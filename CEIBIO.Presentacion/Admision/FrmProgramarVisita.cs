using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmProgramarVisita : Form
    {
        private readonly VisitaNegocio negocio = new();
        private readonly AtencionNegocio atencionNegocio = new();
        private Atencion? atencion;
        private VisitaDomiciliaria? visita;

        public FrmProgramarVisita()
        {
            InitializeComponent();
            Configurar();
            Load += (s, e) => Ui.Intentar(ElegirAtencion);
        }

        public FrmProgramarVisita(Atencion atencion)
        {
            InitializeComponent();
            Configurar();
            Load += (s, e) => Ui.Intentar(() => Mostrar(atencion));
        }

        private void Configurar()
        {
            Ui.SoloDigitos(txtTelefono, 9);
            Ui.SoloLectura(txtNumeroAtencion, txtPaciente);
            btnGuardar.Enabled = false;
            btnReprogramar.Enabled = false;
            btnCancelarVisita.Enabled = false;
            dtpFechaProgramada.MinDate = DateTime.Today;
            btnGuardar.Click += BtnGuardar_Click;
            btnReprogramar.Click += BtnReprogramar_Click;
            btnCancelarVisita.Click += BtnCancelarVisita_Click;
            btnCerrar.Click += (s, e) => Close();
        }

        private void ElegirAtencion()
        {
            var candidatas = atencionNegocio.Consultar(DateTime.Today.AddDays(-90), DateTime.Today, null)
                .Where(a => a.Modalidad == Modalidad.ADomicilio && a.Estado != EstadoAtencion.Anulada && a.Estado != EstadoAtencion.Culminada)
                .ToList();
            if (candidatas.Count == 0)
            {
                Ui.Aviso("No hay atenciones a domicilio pendientes.");
                return;
            }
            var elegida = Ui.Elegir("Seleccionar atención a domicilio", candidatas, a => a.NumeroAtencion + " - " + a.NombrePaciente + " (" + a.Estado + ")");
            if (elegida != null) Mostrar(elegida);
        }

        private void Mostrar(Atencion a)
        {
            atencion = a;
            txtNumeroAtencion.Text = a.NumeroAtencion;
            txtPaciente.Text = a.NombrePaciente;
            visita = negocio.ObtenerPorAtencion(a.IdAtencion);
            if (visita != null)
            {
                txtDireccion.Text = visita.Direccion;
                txtReferencia.Text = visita.Referencia ?? "";
                txtTelefono.Text = visita.Telefono;
                if (visita.FechaProgramada.Date >= DateTime.Today) dtpFechaProgramada.Value = visita.FechaProgramada;
                txtMotivo.Text = visita.Motivo ?? "";
            }
            else
            {
                var paciente = new PacienteNegocio().ObtenerPorId(a.IdPaciente);
                txtDireccion.Text = paciente?.Direccion ?? "";
                txtTelefono.Text = paciente?.Telefono ?? "";
            }
            bool activa = visita != null && visita.Estado != EstadoVisita.Cancelada && visita.Estado != EstadoVisita.Realizada;
            btnGuardar.Enabled = visita == null;
            btnReprogramar.Enabled = activa || visita?.Estado == EstadoVisita.NoRealizada;
            btnCancelarVisita.Enabled = activa;
        }

        private VisitaDomiciliaria Leer() => new VisitaDomiciliaria
        {
            IdAtencion = atencion?.IdAtencion ?? 0,
            Direccion = txtDireccion.Text,
            Referencia = txtReferencia.Text,
            Telefono = txtTelefono.Text,
            FechaProgramada = dtpFechaProgramada.Value.Date,
            Motivo = txtMotivo.Text
        };

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            if (atencion == null) { Ui.Aviso("Seleccione una atención."); return; }
            if (Ui.Mostrar(negocio.Programar(Leer()))) Mostrar(atencion);
        }

        private void BtnReprogramar_Click(object? sender, EventArgs e)
        {
            if (atencion == null) return;
            if (Ui.Mostrar(negocio.Reprogramar(Leer()))) Mostrar(atencion);
        }

        private void BtnCancelarVisita_Click(object? sender, EventArgs e)
        {
            if (atencion == null) return;
            if (!Ui.Confirmar("¿Desea cancelar la visita domiciliaria?")) return;
            if (Ui.Mostrar(negocio.Cancelar(atencion.IdAtencion, txtMotivo.Text))) Mostrar(atencion);
        }
    }
}
