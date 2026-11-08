using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmValidarResultados : Form
    {
        private readonly ResultadoNegocio negocio = new();
        private int idAtencion;

        public FrmValidarResultados() : this(0)
        {
        }

        public FrmValidarResultados(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            btnValidar.Click += BtnValidar_Click;
            btnRetener.Click += BtnRetener_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                if (this.idAtencion == 0) ElegirAtencion();
                Cargar();
            });
        }

        private void ElegirAtencion()
        {
            var pendientes = negocio.ListarPendientesValidacion();
            if (pendientes.Count == 0) { Ui.Info("No hay resultados pendientes de validación."); return; }
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
                if (fila.Tag is ResultadoAnalitico r && r.FueraDeRango)
                {
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(180, 35, 24);
                    fila.DefaultCellStyle.Font = new Font(dgvResultados.Font, FontStyle.Bold);
                }

            var anteriores = idAtencion == 0 ? new List<ResultadoAnalitico>() : negocio.ListarAnteriores(idAtencion);
            Ui.Llenar(dgvAnteriores, anteriores, r => new object?[] { Ui.Fecha(r.FechaValidacion), r.NombreParametro, r.Valor });
        }

        private void BtnValidar_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvResultados);
            if (r == null) { Ui.Aviso("Seleccione un resultado."); return; }
            if (r.FueraDeRango && !Ui.Confirmar("El resultado está fuera del intervalo de referencia. ¿Desea validarlo de todos modos?")) return;
            if (Ui.Mostrar(negocio.Validar(r.IdResultado))) Ui.Intentar(Cargar);
        }

        private void BtnRetener_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvResultados);
            if (r == null) { Ui.Aviso("Seleccione un resultado."); return; }
            using var f = new FrmRetenerResultado(r);
            if (f.ShowDialog(this) == DialogResult.OK) Ui.Intentar(Cargar);
        }
    }
}
