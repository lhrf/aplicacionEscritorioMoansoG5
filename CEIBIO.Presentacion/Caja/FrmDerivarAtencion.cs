using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmDerivarAtencion : Form
    {
        private readonly DerivacionNegocio negocio = new();

        public FrmDerivarAtencion()
        {
            InitializeComponent();
            Ui.Lista(cboTecnico);
            Ui.SoloLectura(txtTurno, txtModalidad);
            Ui.AlSeleccionar(dgvAtenciones, MostrarSeleccion);
            Ui.AlDobleClic(dgvAtenciones, () => BtnDerivar_Click(btnDerivar, EventArgs.Empty));
            btnDerivar.Click += BtnDerivar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                Ui.Combo(cboTecnico, negocio.ListarTecnicosItinerantes(), "NombreCompleto", "IdUsuario");
                Cargar();
            });
        }

        private void Cargar()
        {
            Ui.Llenar(dgvAtenciones, negocio.ListarParaDerivar(), a => new object?[]
            {
                a.NumeroAtencion, a.NombrePaciente, a.Modalidad, a.NumeroComprobante
            });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var a = Ui.Seleccionado<Atencion>(dgvAtenciones);
            txtModalidad.Text = a?.Modalidad ?? "";
            bool domicilio = a?.Modalidad == Modalidad.ADomicilio;
            cboTecnico.Enabled = domicilio;
            if (!domicilio) cboTecnico.SelectedIndex = -1;
            else if (cboTecnico.SelectedIndex < 0 && cboTecnico.Items.Count == 1) cboTecnico.SelectedIndex = 0;
            btnDerivar.Enabled = a != null;
        }

        private void BtnDerivar_Click(object? sender, EventArgs e)
        {
            var a = Ui.Seleccionado<Atencion>(dgvAtenciones);
            if (a == null) { Ui.Aviso("Seleccione una atención."); return; }
            var tecnico = Ui.ItemCombo<Usuario>(cboTecnico);
            if (a.Modalidad == Modalidad.ADomicilio && tecnico == null) { Ui.Aviso("Seleccione el Técnico Laboratorista Itinerante que realizará la visita."); return; }
            var r = negocio.Derivar(a.IdAtencion, tecnico?.IdUsuario);
            if (!Ui.Mostrar(r)) return;
            if (a.Modalidad == Modalidad.EnSede && int.TryParse(r.Dato, out int turno))
            {
                txtTurno.Text = turno.ToString("000");
                Ui.Imprimir("Ticket de turno", DerivacionNegocio.TextoTicket(a, turno));
            }
            Ui.Intentar(Cargar);
        }
    }
}
