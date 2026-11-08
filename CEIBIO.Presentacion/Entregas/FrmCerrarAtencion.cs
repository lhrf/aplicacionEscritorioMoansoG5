using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Entregas
{
    public partial class FrmCerrarAtencion : Form
    {
        private readonly EntregaNegocio negocio = new();

        public FrmCerrarAtencion()
        {
            InitializeComponent();
            btnCerrarAtencion.Click += BtnCerrarAtencion_Click;
            btnSalir.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvEntregadas, negocio.ListarEntregadas(), x => new object?[]
            {
                x.NumeroAtencion, x.NombrePaciente, x.NombreRecibe, Ui.FechaHora(x.FechaEntrega)
            });
        }

        private void BtnCerrarAtencion_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Entrega>(dgvEntregadas);
            if (x == null) { Ui.Aviso("Seleccione una atención entregada."); return; }
            if (Ui.Mostrar(negocio.CerrarAtencion(x.IdAtencion))) Ui.Intentar(Cargar);
        }
    }
}
