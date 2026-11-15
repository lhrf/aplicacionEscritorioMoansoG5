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
            Ui.SoloDigitos(txtDni, 8);
            Ui.Lista(cboConvenio);
            Ui.SoloLectura(txtPaciente, txtFecha, txtUsuario, txtNumeroAtencion);
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
            Ui.AlPresionarEnter(txtDni, () => BtnBuscarPaciente_Click(btnBuscarPaciente, EventArgs.Empty));
            Ui.AlPresionarEnter(txtBuscarExamen, () => BtnAgregarExamen_Click(btnAgregarExamen, EventArgs.Empty));
            Ui.AlDobleClic(dgvExamenes, () => BtnQuitarExamen_Click(btnQuitarExamen, EventArgs.Empty));
            dgvExamenes.KeyDown += (s, e) => { if (e.KeyCode == Keys.Delete) BtnQuitarExamen_Click(btnQuitarExamen, EventArgs.Empty); };
            txtDni.TextChanged += TxtDni_TextChanged;
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
            Bloquear(false);
            if (cboConvenio.Items.Count > 0) cboConvenio.SelectedIndex = 0;
            Refrescar();
        }

        private void Bloquear(bool bloquear)
        {
            btnBuscarPaciente.Enabled = !bloquear;
            btnAgregarExamen.Enabled = !bloquear;
            btnQuitarExamen.Enabled = !bloquear;
            txtBuscarExamen.Enabled = !bloquear;
            cboConvenio.Enabled = !bloquear;
            rdbEnSede.Enabled = !bloquear;
            rdbADomicilio.Enabled = !bloquear;
        }

        private void TxtDni_TextChanged(object? sender, EventArgs e)
        {
            if (registrada != null)
            {
                Nuevo();
                return;
            }
            if (paciente != null && txtDni.Text.Trim() != paciente.Dni)
            {
                paciente = null;
                txtPaciente.Clear();
            }
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
            if (registrada != null) return;
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
            if (registrada != null) return;
            var examen = Ui.Seleccionado<Examen>(dgvExamenes);
            if (examen == null) { Ui.Aviso("Seleccione el examen que desea quitar."); return; }
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

            Ui.Intentar(() => registrada = negocio.ObtenerPorId(r.Id));
            txtNumeroAtencion.Text = r.Dato;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = registrada != null;
            Bloquear(true);

            if (modalidad == Modalidad.ADomicilio && registrada != null)
            {
                using var f = new FrmProgramarVisita(registrada);
                f.ShowDialog(this);
            }
            Ui.Info("Para registrar otra atención, ingrese un nuevo DNI.");
        }

        private void BtnAnular_Click(object? sender, EventArgs e)
        {
            if (registrada == null) return;
            var motivo = Ui.Pedir("Anular atención", "Motivo de la anulación:");
            if (motivo == null) return;
            if (!Ui.Confirmar("¿Desea anular la atención " + registrada.NumeroAtencion + "?")) return;
            if (Ui.Mostrar(negocio.Anular(registrada.IdAtencion, motivo)))
            {
                txtDni.Clear();
                Nuevo();
            }
        }
    }
}
