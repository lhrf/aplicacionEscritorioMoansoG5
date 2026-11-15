using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Analisis
{
    public partial class FrmRegistrarUsoEquipo : Form
    {
        private readonly UsoEquipoNegocio negocio = new();

        public FrmRegistrarUsoEquipo()
        {
            InitializeComponent();
            cboEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            Ui.Mayusculas(txtCodigo);
            Ui.SoloLectura(txtHoraInicio);
            Ui.AlPresionarEnter(txtCodigo, () => BtnRegistrar_Click(btnRegistrar, EventArgs.Empty));
            Ui.AlDobleClic(dgvUsos, () => BtnFalla_Click(btnFalla, EventArgs.Empty));
            btnRegistrar.Click += BtnRegistrar_Click;
            btnFalla.Click += BtnFalla_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                Ui.Combo(cboEquipo, negocio.ListarEquipos(), "Nombre", "IdEquipo");
                Cargar();
            });
        }

        private void Cargar()
        {
            Ui.Llenar(dgvUsos, negocio.ListarUsosDeHoy(), u => new object?[]
            {
                u.HoraInicio.ToString("HH:mm"), u.NombreEquipo, u.CodigoMuestra, u.NombreTecnico
            });
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            var equipo = Ui.ItemCombo<Equipo>(cboEquipo);
            if (equipo == null) { Ui.Aviso("Seleccione el equipo."); return; }
            if (Validacion.Vacio(txtCodigo.Text)) { Ui.Aviso("Ingrese o escanee el código de la muestra."); txtCodigo.Focus(); return; }
            var r = negocio.RegistrarUso(equipo.IdEquipo, txtCodigo.Text);
            if (!Ui.Mostrar(r)) return;
            txtHoraInicio.Text = r.Dato;
            txtCodigo.Clear();
            Ui.Intentar(Cargar);
        }

        private void BtnFalla_Click(object? sender, EventArgs e)
        {
            var uso = Ui.Seleccionado<UsoEquipo>(dgvUsos);
            if (uso == null) { Ui.Aviso("Seleccione en la lista el uso del equipo en el que ocurrió la falla."); return; }
            using var f = new FrmFallaAnalitica(uso);
            if (f.ShowDialog(this) == DialogResult.OK) Ui.Intentar(Cargar);
        }
    }
}
