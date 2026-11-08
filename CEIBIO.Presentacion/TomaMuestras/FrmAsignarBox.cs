using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.TomaMuestras
{
    public partial class FrmAsignarBox : Form
    {
        private readonly TomaMuestraNegocio negocio = new();

        public FrmAsignarBox()
        {
            InitializeComponent();
            cboBox.Format += (s, e) => { if (e.ListItem is Box b) e.Value = b.ToString(); };
            btnAsignar.Click += BtnAsignar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvEspera, negocio.ListarEnEspera(), a => new object?[]
            {
                a.NumeroTurno?.ToString("000"), a.NumeroAtencion, a.NombrePaciente, a.Examenes
            });
            Ui.Combo(cboBox, negocio.ListarBoxesLibres(), "Numero", "IdBox");
            if (cboBox.Items.Count == 0 && dgvEspera.Rows.Count > 0) Ui.Info("No hay boxes libres en este momento.");
        }

        private void BtnAsignar_Click(object? sender, EventArgs e)
        {
            var a = Ui.Seleccionado<Atencion>(dgvEspera);
            var box = Ui.ItemCombo<Box>(cboBox);
            if (a == null) { Ui.Aviso("Seleccione un paciente en espera."); return; }
            if (box == null) { Ui.Aviso("Seleccione un box libre."); return; }
            if (Ui.Mostrar(negocio.AsignarBox(a.IdAtencion, box.IdBox))) Ui.Intentar(Cargar);
        }
    }
}
