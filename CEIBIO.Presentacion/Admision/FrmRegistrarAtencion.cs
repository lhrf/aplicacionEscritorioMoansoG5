using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmRegistrarAtencion : Form
    {
        private readonly AtencionNegocio negocio = new();
        private readonly PacienteNegocio pacienteNegocio = new();
        private readonly ExamenNegocio examenNegocio = new();
        private readonly ConvenioNegocio convenioNegocio = new();
        private readonly List<Examen> examenes = new();
        private Paciente? paciente;
        private Atencion? registrada;

        public FrmRegistrarAtencion()
        {
            InitializeComponent();
            txtDni.MaxLength = 8;
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtUsuario.Text = Sesion.NombreUsuario;
            rdbEnSede.Checked = true;
            btnBuscarPaciente.Click += BtnBuscarPaciente_Click;
            btnAgregarExamen.Click += BtnAgregarExamen_Click;
            btnQuitarExamen.Click += BtnQuitarExamen_Click;
            cboConvenio.SelectedIndexChanged += (s, e) => Recalcular();
            btnGuardar.Click += BtnGuardar_Click;
            btnAnular.Click += BtnAnular_Click;
            btnCancelar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(CargarConvenios);
            Nuevo();
        }

        private void CargarConvenios()
        {
            var lista = new List<Convenio> { new Convenio { IdConvenio = 0, Institucion = "(Sin convenio)" } };
            lista.AddRange(convenioNegocio.ListarVigentes());
            Ui.Combo(cboConvenio, lista, "Institucion", "IdConvenio");
            cboConvenio.SelectedIndex = 0;
        }

        private void Nuevo()
        {
            paciente = null;
            registrada = null;
            examenes.Clear();
            txtPaciente.Clear();
            txtNumeroAtencion.Clear();
            txtBuscarExamen.Clear();
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            Refrescar();
        }

        private void BtnBuscarPaciente_Click(object? sender, EventArgs e)
        {
            if (!Validacion.EsDni(txtDni.Text))
            {
                Ui.Aviso("El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            Ui.Intentar(() =>
            {
                paciente = pacienteNegocio.BuscarPorDni(txtDni.Text);
                if (paciente == null)
                {
                    txtPaciente.Clear();
                    if (Ui.Confirmar("El paciente no tiene Ficha clínica histórica. ¿Desea registrarla ahora?"))
                    {
                        using var f = new FrmRegistrarFicha(txtDni.Text.Trim());
                        if (f.ShowDialog(this) == DialogResult.OK) paciente = f.Registrado;
                    }
                }
                txtPaciente.Text = paciente?.NombreCompleto ?? "";
            });
        }

        private void BtnAgregarExamen_Click(object? sender, EventArgs e)
        {
            Ui.Intentar(() =>
            {
                var encontrados = examenNegocio.ListarHabilitados(txtBuscarExamen.Text)
                    .Where(x => !examenes.Any(y => y.IdExamen == x.IdExamen)).ToList();
                if (encontrados.Count == 0)
                {
                    Ui.Aviso("No se encontró ningún examen habilitado con ese texto (o ya está agregado).");
                    return;
                }
                var examen = Ui.Elegir("Seleccionar examen", encontrados, x => x.Codigo + " - " + x.Nombre + "  (" + Ui.Soles(x.Tarifa) + ")");
                if (examen == null) return;
                examenes.Add(examen);
                txtBuscarExamen.Clear();
                Refrescar();
            });
        }

        private void BtnQuitarExamen_Click(object? sender, EventArgs e)
        {
            var examen = Ui.Seleccionado<Examen>(dgvExamenes);
            if (examen == null) return;
            examenes.Remove(examen);
            Refrescar();
        }

        private void Refrescar()
        {
            Ui.Llenar(dgvExamenes, examenes, x => new object?[] { x.Codigo, x.Nombre, x.Tarifa.ToString("0.00") });
            Recalcular();
        }

        private void Recalcular()
        {
            var convenio = Ui.ItemCombo<Convenio>(cboConvenio);
            var costo = negocio.CalcularCosto(examenes, convenio != null && convenio.IdConvenio > 0 ? convenio : null);
            lblSubtotal.Text = "Subtotal: " + Ui.Soles(costo.Subtotal);
            lblDescuento.Text = "Descuento: " + Ui.Soles(costo.Descuento);
            lblCostoTotal.Text = "Costo total: " + Ui.Soles(costo.Total);
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            if (paciente == null)
            {
                Ui.Aviso("Busque primero al paciente por su DNI.");
                return;
            }
            var convenio = Ui.ItemCombo<Convenio>(cboConvenio);
            string modalidad = rdbADomicilio.Checked ? Modalidad.ADomicilio : Modalidad.EnSede;
            var r = negocio.Registrar(paciente.IdPaciente, modalidad, examenes.Select(x => x.IdExamen).ToList(),
                convenio != null && convenio.IdConvenio > 0 ? convenio.IdConvenio : null);
            if (!Ui.Mostrar(r)) return;

            registrada = negocio.ObtenerPorId(r.Id);
            txtNumeroAtencion.Text = r.Dato;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = true;

            if (modalidad == Modalidad.ADomicilio && registrada != null)
            {
                using var f = new FrmProgramarVisita(registrada);
                f.ShowDialog(this);
            }
        }

        private void BtnAnular_Click(object? sender, EventArgs e)
        {
            if (registrada == null) return;
            var motivo = Ui.Pedir("Anular atención", "Motivo de la anulación:");
            if (motivo == null) return;
            if (Ui.Mostrar(negocio.Anular(registrada.IdAtencion, motivo))) Nuevo();
        }
    }
}
