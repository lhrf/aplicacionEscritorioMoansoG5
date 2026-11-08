using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmVisitasAsignadas : Form
    {
        private readonly VisitaNegocio negocio = new();

        public FrmVisitasAsignadas()
        {
            InitializeComponent();
            dgvVisitas.SelectionChanged += (s, e) => MostrarSeleccion();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            var lista = negocio.ListarMisVisitas();
            Ui.Llenar(dgvVisitas, lista, v => new object?[]
            {
                v.NombrePaciente, v.Direccion, v.Telefono, v.Examenes, v.NumeroComprobante
            });
            MostrarSeleccion();
            if (lista.Count == 0) Ui.Info("No tiene visitas domiciliarias asignadas.");
        }

        private void MostrarSeleccion()
        {
            var v = Ui.Seleccionado<VisitaDomiciliaria>(dgvVisitas);
            txtPaciente.Text = v?.NombrePaciente ?? "";
            txtDireccion.Text = v?.Direccion ?? "";
            txtReferencia.Text = v?.Referencia ?? "";
            txtTelefono.Text = v?.Telefono ?? "";
        }
    }
}
