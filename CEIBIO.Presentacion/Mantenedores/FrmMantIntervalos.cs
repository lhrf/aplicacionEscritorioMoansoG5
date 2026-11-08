using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantIntervalos : Form
    {
        private readonly IntervaloNegocio negocio = new();
        private readonly ParametroNegocio parametros = new();
        private readonly Mantenedor m;
        private bool cargando;

        public FrmMantIntervalos()
        {
            InitializeComponent();
            cboExamen.Items.Clear();
            cboParametro.Items.Clear();
            cboSexo.Items.Clear();
            cboSexo.Items.AddRange(IntervaloNegocio.Sexos);
            nudMinimo.Minimum = -1000000;
            nudMaximo.Minimum = -1000000;
            nudEdadMinima.Minimum = 0;
            nudEdadMinima.Maximum = 120;
            nudEdadMaxima.Minimum = 0;
            nudEdadMaxima.Maximum = 120;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar);
            cboExamen.SelectedIndexChanged += (s, e) => CargarParametros();
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => Nuevo();
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                cargando = true;
                Ui.Combo(cboExamen, new ExamenNegocio().ListarHabilitados(), "Nombre", "IdExamen");
                cargando = false;
                Buscar();
            });
        }

        private void CargarParametros()
        {
            if (cargando) return;
            var ex = Ui.ItemCombo<Examen>(cboExamen);
            if (ex == null) { cboParametro.DataSource = null; cboParametro.Items.Clear(); return; }
            Ui.Intentar(() => Ui.Combo(cboParametro, parametros.ListarPorExamen(ex.IdExamen), "Nombre", "IdParametro"));
        }

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.NombreParametro, x.ValorMinimo?.ToString("0.##"), x.ValorMaximo?.ToString("0.##"),
                x.Sexo, x.EdadTexto, x.ReferenciaTexto, x.EstadoTexto
            }));
        }

        private void Nuevo()
        {
            m.Nuevo();
            Ui.Decimal(nudMinimo, null);
            Ui.Decimal(nudMaximo, null);
            cboSexo.SelectedItem = "Ambos";
            nudEdadMinima.Value = 0;
            nudEdadMaxima.Value = 120;
            cboExamen.Focus();
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<IntervaloReferencia>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdIntervalo);
            cboExamen.SelectedValue = x.IdExamen;
            cboParametro.SelectedValue = x.IdParametro;
            Ui.Decimal(nudMinimo, x.ValorMinimo);
            Ui.Decimal(nudMaximo, x.ValorMaximo);
            cboSexo.SelectedItem = x.Sexo;
            nudEdadMinima.Value = Math.Clamp(x.EdadMinima, 0, 120);
            nudEdadMaxima.Value = Math.Clamp(x.EdadMaxima, 0, 120);
            txtReferenciaTexto.Text = x.ReferenciaTexto ?? "";
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new IntervaloReferencia
            {
                IdIntervalo = m.Id,
                IdParametro = Ui.ItemCombo<Parametro>(cboParametro)?.IdParametro ?? 0,
                ValorMinimo = Ui.Decimal(nudMinimo),
                ValorMaximo = Ui.Decimal(nudMaximo),
                Sexo = cboSexo.Text,
                EdadMinima = (int)nudEdadMinima.Value,
                EdadMaxima = (int)nudEdadMaxima.Value,
                ReferenciaTexto = txtReferenciaTexto.Text
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<IntervaloReferencia>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar el intervalo de " + x.NombreParametro + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdIntervalo))) Buscar();
        }
    }
}
