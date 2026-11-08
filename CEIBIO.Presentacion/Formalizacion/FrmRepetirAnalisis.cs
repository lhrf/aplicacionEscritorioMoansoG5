using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmRepetirAnalisis : Form
    {
        private readonly ResultadoNegocio negocio = new();

        public FrmRepetirAnalisis()
        {
            InitializeComponent();
            dgvRepeticion.SelectionChanged += (s, e) => MostrarSeleccion();
            btnGuardar.Click += BtnGuardar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvRepeticion, negocio.ListarEnRepeticion(), r => new object?[]
            {
                r.NumeroAtencion, r.NombrePaciente, r.NombreParametro, r.ObservacionMedico
            });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvRepeticion);
            txtResultadoAnterior.Text = r == null ? "" : r.Valor + (Validacion.Vacio(r.Unidad) ? "" : " " + r.Unidad);
            txtNuevoResultado.Clear();
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvRepeticion);
            if (r == null) { Ui.Aviso("Seleccione un resultado en repetición."); return; }
            if (Ui.Mostrar(negocio.RegistrarRepeticion(r.IdResultado, txtNuevoResultado.Text))) Ui.Intentar(Cargar);
        }
    }
}
