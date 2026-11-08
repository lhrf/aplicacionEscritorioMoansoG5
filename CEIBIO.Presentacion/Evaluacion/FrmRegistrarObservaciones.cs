using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Evaluacion
{
    public partial class FrmRegistrarObservaciones : Form
    {
        private readonly EvaluacionNegocio negocio = new();

        public FrmRegistrarObservaciones()
        {
            InitializeComponent();
            nudHorasAyuno.Minimum = 0;
            nudHorasAyuno.Maximum = 72;
            dgvPendientes.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            btnGuardar.Click += BtnGuardar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvPendientes, negocio.ListarPendientes(), a => new object?[] { a.NumeroAtencion, a.NombrePaciente, a.Examenes });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var a = Ui.Seleccionado<Atencion>(dgvPendientes);
            var condiciones = a == null ? new List<CondicionPreanalitica>() : negocio.ListarCondiciones(a.IdAtencion);
            Ui.Llenar(dgvCondiciones, condiciones, c => new object?[]
            {
                c.NombreExamen, c.HorasAyuno, c.MuestraQueDebeTraer ?? c.RestriccionMedicamentos ?? ""
            });
            bool requiere = a != null && negocio.RequiereMuestraEntregada(a.IdAtencion);
            foreach (var chk in new[] { chkRotulado, chkHermetico, chkVolumen, chkConservacion })
            {
                chk.Enabled = requiere;
                chk.Checked = false;
            }
            nudHorasAyuno.Value = 0;
            txtMedicamentos.Clear();
            txtObservaciones.Clear();
            btnGuardar.Enabled = a != null;
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var a = Ui.Seleccionado<Atencion>(dgvPendientes);
            if (a == null) { Ui.Aviso("Seleccione una atención pendiente."); return; }
            var ev = new EvaluacionPreanalitica
            {
                IdAtencion = a.IdAtencion,
                HorasAyuno = (int)nudHorasAyuno.Value,
                Medicamentos = txtMedicamentos.Text,
                Observaciones = txtObservaciones.Text,
                RotuladoCorrecto = chkRotulado.Enabled ? chkRotulado.Checked : null,
                RecipienteHermetico = chkHermetico.Enabled ? chkHermetico.Checked : null,
                VolumenSuficiente = chkVolumen.Enabled ? chkVolumen.Checked : null,
                ConservacionAdecuada = chkConservacion.Enabled ? chkConservacion.Checked : null
            };
            if (!Ui.Mostrar(negocio.GuardarObservaciones(ev))) return;

            if (Ui.Confirmar("¿Desea registrar ahora el resultado de la evaluación?"))
            {
                using var f = new FrmResultadoEvaluacion(a);
                f.ShowDialog(this);
            }
            Ui.Intentar(Cargar);
        }
    }
}
