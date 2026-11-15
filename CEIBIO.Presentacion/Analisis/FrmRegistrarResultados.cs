using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Analisis
{
    public partial class FrmRegistrarResultados : Form
    {
        private readonly ResultadoNegocio negocio = new();
        private Muestra? muestra;
        private AtencionExamen? actual;
        private bool cambios;
        private bool cargando;

        public FrmRegistrarResultados()
        {
            InitializeComponent();
            txtPaciente.ReadOnly = true;
            cboExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvParametros.ReadOnly = false;
            colParametro.ReadOnly = true;
            colUnidad.ReadOnly = true;
            colValor.ReadOnly = false;
            Ui.Mayusculas(txtCodigo);
            Ui.SoloLectura(txtProcedimiento);
            Ui.AlPresionarEnter(txtCodigo, Buscar);
            dgvParametros.CellEndEdit += (s, e) => { if (e.RowIndex >= 0) cambios = true; };
            txtObservaciones.TextChanged += (s, e) => { if (!cargando && txtObservaciones.Enabled) cambios = true; };
            FormClosing += FrmRegistrarResultados_FormClosing;
            btnBuscar.Click += (s, e) => Buscar();
            cboExamen.SelectionChangeCommitted += (s, e) => CambiarExamen();
            btnGuardar.Click += (s, e) => Guardar(true);
            btnEnviar.Click += BtnEnviar_Click;
            btnCerrar.Click += (s, e) => Close();
            Mostrar(null);
        }

        private bool ConfirmarCambios()
        {
            if (!cambios) return true;
            var respuesta = MessageBox.Show("Hay resultados sin guardar de " + (actual?.NombreExamen ?? "el examen actual") + ". ¿Desea guardarlos?",
                "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Cancel) return false;
            if (respuesta == DialogResult.Yes) return Guardar(true);
            cambios = false;
            return true;
        }

        private void Buscar()
        {
            if (Validacion.Vacio(txtCodigo.Text)) { Ui.Aviso("Ingrese o escanee el código de la muestra."); txtCodigo.Focus(); return; }
            if (!ConfirmarCambios()) return;
            Ui.Intentar(() =>
            {
                var m = negocio.BuscarMuestra(txtCodigo.Text, out string mensaje);
                if (m == null) Ui.Aviso(mensaje);
                Mostrar(m);
            });
        }

        private void CambiarExamen()
        {
            var nuevo = Ui.ItemCombo<AtencionExamen>(cboExamen);
            if (actual != null && nuevo != null && nuevo.IdExamen == actual.IdExamen) return;
            if (!ConfirmarCambios())
            {
                if (actual != null) cboExamen.SelectedValue = actual.IdExamen;
                return;
            }
            Ui.Intentar(MostrarExamen);
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

        private void MostrarExamen()
        {
            cargando = true;
            actual = Ui.ItemCombo<AtencionExamen>(cboExamen);
            txtProcedimiento.Text = actual?.Procedimiento ?? "";
            txtObservaciones.Text = actual?.ObservacionesMicroscopicas ?? "";
            txtObservaciones.Enabled = actual?.Procedimiento == "Microscópico";
            var parametros = muestra == null || actual == null ? new List<ResultadoAnalitico>() : negocio.ListarParametros(muestra.IdAtencion, actual.IdExamen);
            Ui.Llenar(dgvParametros, parametros, p => new object?[] { p.NombreParametro, p.Valor, p.Unidad });
            foreach (DataGridViewRow fila in dgvParametros.Rows)
                if (fila.Tag is ResultadoAnalitico r && r.IdResultado > 0 && r.Estado != EstadoResultado.Registrado)
                    fila.Cells[colValor.Index].ReadOnly = true;
            bool editable = dgvParametros.Rows.Cast<DataGridViewRow>().Any(f => !f.Cells[colValor.Index].ReadOnly);
            btnGuardar.Enabled = actual != null && editable;
            btnEnviar.Enabled = actual != null && editable;
            if (actual != null && parametros.Count > 0 && !editable)
                Ui.Info("Los resultados de " + actual.NombreExamen + " ya fueron enviados a validación.");
            cambios = false;
            cargando = false;
        }

        private void FrmRegistrarResultados_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!ConfirmarCambios()) e.Cancel = true;
        }

        private bool Guardar(bool mostrar)
        {
            if (muestra == null || actual == null) { Ui.Aviso("Busque la muestra y seleccione el examen."); return false; }
            dgvParametros.EndEdit();
            var valores = dgvParametros.Rows.Cast<DataGridViewRow>()
                .Where(f => f.Tag is ResultadoAnalitico)
                .Select(f => new ResultadoAnalitico
                {
                    IdParametro = ((ResultadoAnalitico)f.Tag!).IdParametro,
                    Valor = Convert.ToString(f.Cells[colValor.Index].Value)
                }).ToList();
            string? observaciones = txtObservaciones.Enabled ? txtObservaciones.Text : null;
            if (valores.All(v => Validacion.Vacio(v.Valor)) && Validacion.Vacio(observaciones))
            {
                Ui.Aviso("Ingrese al menos un resultado.");
                return false;
            }
            var r = negocio.GuardarResultados(muestra.IdAtencion, actual.IdExamen, valores, observaciones);
            if (mostrar || !r.Exito) Ui.Mostrar(r);
            if (r.Exito) cambios = false;
            return r.Exito;
        }

        private void BtnEnviar_Click(object? sender, EventArgs e)
        {
            if (muestra == null || actual == null) return;
            if (!Ui.Confirmar("Una vez enviados a validación, los resultados de " + actual.NombreExamen + " ya no se podrán modificar. ¿Desea continuar?")) return;
            if (!Guardar(false)) return;
            if (Ui.Mostrar(negocio.EnviarAValidacion(muestra.IdAtencion, actual.IdExamen))) Ui.Intentar(MostrarExamen);
        }
    }
}
