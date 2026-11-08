using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Analisis
{
    public partial class FrmRegistrarResultados : Form
    {
        private readonly ResultadoNegocio negocio = new();
        private Muestra? muestra;

        public FrmRegistrarResultados()
        {
            InitializeComponent();
            txtPaciente.ReadOnly = true;
            cboExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvParametros.ReadOnly = false;
            colParametro.ReadOnly = true;
            colUnidad.ReadOnly = true;
            colValor.ReadOnly = false;
            AcceptButton = btnBuscar;
            btnBuscar.Click += (s, e) => Buscar();
            cboExamen.SelectedIndexChanged += (s, e) => Ui.Intentar(MostrarExamen);
            btnGuardar.Click += (s, e) => Guardar(true);
            btnEnviar.Click += BtnEnviar_Click;
            btnCerrar.Click += (s, e) => Close();
            Mostrar(null);
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                var m = negocio.BuscarMuestra(txtCodigo.Text, out string mensaje);
                if (m == null) Ui.Aviso(mensaje);
                Mostrar(m);
            });
        }

        private void Mostrar(Muestra? m)
        {
            muestra = m;
            txtPaciente.Text = m?.NombrePaciente ?? "";
            var examenes = m == null ? new List<AtencionExamen>() : negocio.ListarExamenes(m.IdAtencion);
            Ui.Combo(cboExamen, examenes, "NombreExamen", "IdExamen");
            if (examenes.Count > 0) cboExamen.SelectedIndex = 0;
            MostrarExamen();
        }

        private AtencionExamen? Examen => Ui.ItemCombo<AtencionExamen>(cboExamen);

        private void MostrarExamen()
        {
            var ex = Examen;
            txtProcedimiento.Text = ex?.Procedimiento ?? "";
            txtObservaciones.Text = ex?.ObservacionesMicroscopicas ?? "";
            txtObservaciones.Enabled = ex?.Procedimiento == "Microscópico";
            var parametros = muestra == null || ex == null ? new List<ResultadoAnalitico>() : negocio.ListarParametros(muestra.IdAtencion, ex.IdExamen);
            Ui.Llenar(dgvParametros, parametros, p => new object?[] { p.NombreParametro, p.Valor, p.Unidad });
            foreach (DataGridViewRow fila in dgvParametros.Rows)
                if (fila.Tag is ResultadoAnalitico r && r.IdResultado > 0 && r.Estado != EstadoResultado.Registrado)
                    fila.Cells[colValor.Index].ReadOnly = true;
            btnGuardar.Enabled = ex != null;
            btnEnviar.Enabled = ex != null;
        }

        private bool Guardar(bool mostrar)
        {
            if (muestra == null || Examen == null) { Ui.Aviso("Busque la muestra y seleccione el examen."); return false; }
            dgvParametros.EndEdit();
            var valores = dgvParametros.Rows.Cast<DataGridViewRow>()
                .Where(f => f.Tag is ResultadoAnalitico)
                .Select(f => new ResultadoAnalitico
                {
                    IdParametro = ((ResultadoAnalitico)f.Tag!).IdParametro,
                    Valor = Convert.ToString(f.Cells[colValor.Index].Value)
                }).ToList();
            string? observaciones = txtObservaciones.Enabled ? txtObservaciones.Text : null;
            var r = negocio.GuardarResultados(muestra.IdAtencion, Examen.IdExamen, valores, observaciones);
            if (mostrar || !r.Exito) Ui.Mostrar(r);
            return r.Exito;
        }

        private void BtnEnviar_Click(object? sender, EventArgs e)
        {
            if (muestra == null || Examen == null) return;
            if (!Guardar(false)) return;
            if (Ui.Mostrar(negocio.EnviarAValidacion(muestra.IdAtencion, Examen.IdExamen))) Ui.Intentar(MostrarExamen);
        }
    }
}
