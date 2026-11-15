using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Preparacion
{
    public partial class FrmRecepcionMuestra : Form
    {
        private readonly PreparacionMuestraNegocio negocio = new();

        public FrmRecepcionMuestra()
        {
            InitializeComponent();
            Ui.Mayusculas(txtCodigox);
            Ui.AlPresionarEnter(txtCodigox, BuscarCodigo);
            Ui.AlSeleccionar(dgvAcondicionadas, () =>
            {
                btnConfirmar.Enabled = dgvAcondicionadas.CurrentRow != null;
                btnDevolver.Enabled = dgvAcondicionadas.CurrentRow != null;
            });
            btnConfirmar.Click += BtnConfirmar_Click;
            btnDevolver.Click += BtnDevolver_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvAcondicionadas, negocio.ListarAcondicionadas(), m => new object?[]
            {
                m.Codigo, m.NombrePaciente, m.Examenes, m.NombreAcondiciona, Ui.FechaHora(m.FechaAcondicionamiento)
            });
            txtCodigox.Clear();
            btnConfirmar.Enabled = dgvAcondicionadas.CurrentRow != null;
            btnDevolver.Enabled = dgvAcondicionadas.CurrentRow != null;
        }

        private void BuscarCodigo()
        {
            string codigo = txtCodigox.Text.Trim();
            if (codigo.Length == 0) return;
            var m = dgvAcondicionadas.Rows.Cast<DataGridViewRow>().Select(f => f.Tag as Muestra)
                .FirstOrDefault(x => x != null && string.Equals(x.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
            if (m == null) { Ui.Aviso("La muestra " + codigo + " no está en la lista de muestras acondicionadas."); return; }
            Ui.Seleccionar<Muestra>(dgvAcondicionadas, x => x.IdMuestra == m.IdMuestra);
            BtnConfirmar_Click(btnConfirmar, EventArgs.Empty);
        }

        private void BtnConfirmar_Click(object? sender, EventArgs e)
        {
            var m = Ui.Seleccionado<Muestra>(dgvAcondicionadas);
            if (m == null) { Ui.Aviso("Seleccione una muestra acondicionada."); return; }
            if (Ui.Mostrar(negocio.ConfirmarRecepcion(m.IdMuestra, txtCodigox.Text))) Ui.Intentar(Cargar);
        }

        private void BtnDevolver_Click(object? sender, EventArgs e)
        {
            var m = Ui.Seleccionado<Muestra>(dgvAcondicionadas);
            if (m == null) { Ui.Aviso("Seleccione una muestra acondicionada."); return; }
            using var f = new FrmDevolverMuestra(m);
            if (f.ShowDialog(this) == DialogResult.OK) Ui.Intentar(Cargar);
        }
    }
}
