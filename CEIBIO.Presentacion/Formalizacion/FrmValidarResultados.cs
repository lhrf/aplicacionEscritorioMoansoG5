using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmValidarResultados : Form
    {
        private readonly ResultadoNegocio negocio = new();
        private readonly bool desdeMenu;
        private int idAtencion;

        public FrmValidarResultados() : this(0)
        {
        }

        public FrmValidarResultados(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            desdeMenu = idAtencion == 0;
            Ui.SoloLectura(txtNumeroAtencion, txtPaciente, txtSexo, txtEdad);
            dgvResultados.ReadOnly = true;
            dgvAnteriores.ReadOnly = true;
            btnValidar.Click += BtnValidar_Click;
            btnRetener.Click += BtnRetener_Click;
            btnCerrar.Click += (s, e) => Close();
            Ui.AlSeleccionar(dgvResultados, MostrarSeleccion);
            Ui.AlDobleClic(dgvResultados, () => BtnValidar_Click(btnValidar, EventArgs.Empty));
            Load += (s, e) => Ui.Intentar(() =>
            {
                if (this.idAtencion == 0) ElegirAtencion();
                Cargar();
            });
        }

        private void ElegirAtencion()
        {
            var pendientes = negocio.ListarPendientesValidacion();
            if (pendientes.Count == 0) { Ui.Info("No hay resultados pendientes de validación."); idAtencion = 0; return; }
            var elegida = Ui.Elegir("Seleccionar atención", pendientes, r => r.NumeroAtencion + " - " + r.NombrePaciente + " (" + r.NombreExamen + ")");
            idAtencion = elegida?.IdAtencion ?? 0;
        }

        private void Cargar()
        {
            var paciente = idAtencion == 0 ? null : negocio.ObtenerPaciente(idAtencion);
            var resultados = idAtencion == 0 ? new List<ResultadoAnalitico>() : negocio.ListarParaValidar(idAtencion);
            txtNumeroAtencion.Text = resultados.FirstOrDefault()?.NumeroAtencion ?? "";
            txtPaciente.Text = paciente?.NombreCompleto ?? "";
            txtSexo.Text = paciente?.Sexo ?? "";
            txtEdad.Text = paciente == null ? "" : paciente.Edad + " años";
            Ui.Llenar(dgvResultados, resultados, r => new object?[]
            {
                r.NombreExamen, r.NombreParametro, r.Valor, r.Unidad, r.IntervaloReferencia, r.FueraDeRangoTexto, r.Estado
            });
            foreach (DataGridViewRow fila in dgvResultados.Rows)
            {
                if (fila.Tag is not ResultadoAnalitico r) continue;
                if (r.Estado != EstadoResultado.PendienteValidacion)
                    fila.DefaultCellStyle.ForeColor = Color.Gray;
                else if (r.FueraDeRango)
                {
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(180, 35, 24);
                    fila.DefaultCellStyle.Font = new Font(dgvResultados.Font, FontStyle.Bold);
                }
            }
            Ui.Seleccionar<ResultadoAnalitico>(dgvResultados, r => r.Estado == EstadoResultado.PendienteValidacion);
            var anteriores = idAtencion == 0 ? new List<ResultadoAnalitico>() : negocio.ListarAnteriores(idAtencion);
            Ui.Llenar(dgvAnteriores, anteriores, r => new object?[] { Ui.Fecha(r.FechaValidacion), r.NombreParametro, r.Valor });
            MostrarSeleccion();
        }

        private int Pendientes() =>
            dgvResultados.Rows.Cast<DataGridViewRow>().Count(f => f.Tag is ResultadoAnalitico r && r.Estado == EstadoResultado.PendienteValidacion);

        private void MostrarSeleccion()
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvResultados);
            bool pendiente = r != null && r.Estado == EstadoResultado.PendienteValidacion;
            btnValidar.Enabled = pendiente;
            btnRetener.Enabled = pendiente;
        }

        private void BtnValidar_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvResultados);
            if (r == null) { Ui.Aviso("Seleccione un resultado."); return; }
            if (r.Estado != EstadoResultado.PendienteValidacion) { Ui.Aviso("El resultado seleccionado no está pendiente de validación."); return; }
            if (r.FueraDeRango && !Ui.Confirmar("El resultado está fuera del intervalo de referencia. ¿Desea validarlo de todos modos?")) return;
            if (!Ui.Mostrar(negocio.Validar(r.IdResultado))) return;
            Ui.Intentar(Cargar);
            Terminar();
        }

        private void BtnRetener_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvResultados);
            if (r == null) { Ui.Aviso("Seleccione un resultado."); return; }
            if (r.Estado != EstadoResultado.PendienteValidacion) { Ui.Aviso("El resultado seleccionado no está pendiente de validación."); return; }
            using var f = new FrmRetenerResultado(r);
            if (f.ShowDialog(this) != DialogResult.OK) return;
            Ui.Intentar(Cargar);
            Terminar();
        }

        private void Terminar()
        {
            if (idAtencion == 0 || Pendientes() > 0) return;
            Ui.Info("La atención " + txtNumeroAtencion.Text + " ya no tiene resultados pendientes de validación.");
            if (!desdeMenu)
            {
                Close();
                return;
            }
            Ui.Intentar(() =>
            {
                ElegirAtencion();
                Cargar();
            });
        }
    }
}
