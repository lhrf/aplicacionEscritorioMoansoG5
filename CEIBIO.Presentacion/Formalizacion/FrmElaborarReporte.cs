using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmElaborarReporte : Form
    {
        private readonly ReporteNegocio negocio = new();
        private ReporteClinico? reporte;

        public FrmElaborarReporte()
        {
            InitializeComponent();
            rtbVistaPrevia.ReadOnly = true;
            rtbVistaPrevia.Font = new Font("Consolas", 10F);
            dgvAtenciones.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            btnGenerar.Click += BtnGenerar_Click;
            btnImprimirBorrador.Click += (s, e) => Imprimir();
            btnEnviarRevision.Click += (s, e) => Ejecutar(id => negocio.EnviarARevision(id));
            btnGuardarDefinitivo.Click += (s, e) => Ejecutar(id => negocio.GuardarDefinitivo(id));
            btnImprimirDefinitivo.Click += (s, e) => Imprimir();
            btnEnviarAutorizacion.Click += (s, e) => Ejecutar(id => negocio.EnviarAAutorizacion(id));
            btnEnviarEntrega.Click += (s, e) => Ejecutar(id => negocio.EnviarAEntrega(id));
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            int? seleccion = Ui.Seleccionado<Atencion>(dgvAtenciones)?.IdAtencion;
            var lista = negocio.ListarParaElaborar();
            Ui.Llenar(dgvAtenciones, lista, a => new object?[] { a.NumeroAtencion, a.NombrePaciente, a.EstadoReporte });
            if (seleccion.HasValue)
                foreach (DataGridViewRow fila in dgvAtenciones.Rows)
                    if (fila.Tag is Atencion a && a.IdAtencion == seleccion.Value) { fila.Selected = true; dgvAtenciones.CurrentCell = fila.Cells[0]; }
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var a = Ui.Seleccionado<Atencion>(dgvAtenciones);
            reporte = a == null ? null : negocio.ObtenerPorAtencion(a.IdAtencion);
            rtbVistaPrevia.Text = reporte == null ? "" : ReporteNegocio.TextoImpresion(reporte);
            txtEstado.Text = reporte?.EstadoVersion ?? (a == null ? "" : "Sin reporte");

            string estado = reporte?.Estado ?? "";
            btnGenerar.Enabled = a != null && (reporte == null || estado == EstadoReporte.Borrador || estado == EstadoReporte.Observado || estado == EstadoReporte.DevueltoMedico);
            btnImprimirBorrador.Enabled = reporte != null && !reporte.Definitivo;
            btnEnviarRevision.Enabled = estado == EstadoReporte.Borrador;
            btnGuardarDefinitivo.Enabled = estado == EstadoReporte.Revisado && reporte?.Definitivo == false;
            btnImprimirDefinitivo.Enabled = reporte?.Definitivo == true;
            btnEnviarAutorizacion.Enabled = estado == EstadoReporte.Revisado && reporte?.Definitivo == true;
            btnEnviarEntrega.Enabled = estado == EstadoReporte.Autorizado;
        }

        private void BtnGenerar_Click(object? sender, EventArgs e)
        {
            var a = Ui.Seleccionado<Atencion>(dgvAtenciones);
            if (a == null) { Ui.Aviso("Seleccione una atención."); return; }
            if (Ui.Mostrar(negocio.Generar(a.IdAtencion))) Ui.Intentar(Cargar);
        }

        private void Ejecutar(Func<int, Respuesta> accion)
        {
            if (reporte == null) { Ui.Aviso("Primero genere el reporte."); return; }
            if (Ui.Mostrar(accion(reporte.IdReporte))) Ui.Intentar(Cargar);
        }

        private void Imprimir()
        {
            if (reporte == null) return;
            Ui.Imprimir("Reporte clínico " + reporte.NumeroAtencion, ReporteNegocio.TextoImpresion(reporte));
        }
    }
}
