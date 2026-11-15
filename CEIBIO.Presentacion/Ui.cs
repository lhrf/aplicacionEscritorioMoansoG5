using System.Drawing.Printing;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion
{
    internal static class Ui
    {
        public static bool Mostrar(Respuesta r)
        {
            MessageBox.Show(r.Mensaje, r.Exito ? "CEIBIO" : "Atención", MessageBoxButtons.OK,
                r.Exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            return r.Exito;
        }

        public static void Aviso(string mensaje) =>
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static void Info(string mensaje) =>
            MessageBox.Show(mensaje, "CEIBIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Error(Exception ex) =>
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static bool Confirmar(string mensaje) =>
            MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        public static void Intentar(Action accion)
        {
            try
            {
                accion();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        public static string Soles(decimal valor) => "S/ " + valor.ToString("0.00");

        public static string Fecha(DateTime? valor) => valor.HasValue ? valor.Value.ToString("dd/MM/yyyy") : "";

        public static string FechaHora(DateTime? valor) => valor.HasValue ? valor.Value.ToString("dd/MM/yyyy HH:mm") : "";

        private static readonly HashSet<DataGridView> cargando = new();

        public static void Llenar<T>(DataGridView grilla, IEnumerable<T> lista, Func<T, object?[]> fila)
        {
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.MultiSelect = false;
            cargando.Add(grilla);
            try
            {
                grilla.Rows.Clear();
                foreach (var item in lista)
                {
                    int i = grilla.Rows.Add(fila(item));
                    grilla.Rows[i].Tag = item;
                }
            }
            finally
            {
                cargando.Remove(grilla);
            }
        }

        public static void AlSeleccionar(DataGridView grilla, Action accion)
        {
            grilla.SelectionChanged += (s, e) =>
            {
                if (cargando.Contains(grilla)) return;
                Intentar(accion);
            };
        }

        public static void AlDobleClic(DataGridView grilla, Action accion)
        {
            grilla.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex < 0 || grilla.Rows[e.RowIndex].Tag == null) return;
                Intentar(accion);
            };
        }

        public static void AlPresionarEnter(Control control, Action accion)
        {
            control.KeyDown += (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.Handled = true;
                e.SuppressKeyPress = true;
                Intentar(accion);
            };
        }

        public static void SoloDigitos(TextBox caja, int largo)
        {
            caja.MaxLength = largo;
            caja.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
            };
        }

        public static void Mayusculas(params TextBox[] cajas)
        {
            foreach (var c in cajas) c.CharacterCasing = CharacterCasing.Upper;
        }

        public static void SoloLectura(params TextBoxBase[] cajas)
        {
            foreach (var c in cajas)
            {
                c.ReadOnly = true;
                c.TabStop = false;
            }
        }

        public static void Lista(params ComboBox[] combos)
        {
            foreach (var c in combos) c.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static bool RangoValido(DateTimePicker inicio, DateTimePicker fin)
        {
            if (fin.Value.Date >= inicio.Value.Date) return true;
            Aviso("La fecha final no puede ser anterior a la fecha inicial.");
            return false;
        }

        public static void Seleccionar<T>(DataGridView grilla, Func<T, bool> condicion) where T : class
        {
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                if (fila.Tag is T item && condicion(item))
                {
                    grilla.ClearSelection();
                    fila.Selected = true;
                    grilla.CurrentCell = fila.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => c.Visible) ?? fila.Cells[0];
                    return;
                }
            }
        }

        public static void Columnas(DataGridView grilla, params string[] titulos)
        {
            if (grilla.Columns.Count > 0) return;
            foreach (var t in titulos)
                grilla.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = t, ReadOnly = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }

        public static T? Seleccionado<T>(DataGridView grilla) where T : class => grilla.CurrentRow?.Tag as T;

        public static void Combo<T>(ComboBox combo, IEnumerable<T> lista, string mostrar, string valor)
        {
            combo.DataSource = null;
            combo.Items.Clear();
            combo.DisplayMember = mostrar;
            combo.ValueMember = valor;
            combo.DataSource = lista.ToList();
            combo.SelectedIndex = -1;
        }

        public static T? ItemCombo<T>(ComboBox combo) where T : class => combo.SelectedItem as T;

        public static void Limpiar(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                switch (c)
                {
                    case TextBox t: t.Clear(); break;
                    case ComboBox cb: cb.SelectedIndex = -1; break;
                    case CheckBox ch: ch.Checked = false; break;
                    case NumericUpDown n: n.Value = Math.Max(n.Minimum, Math.Min(n.Maximum, 0)); break;
                    case DateTimePicker d: d.Value = DateTime.Today < d.MinDate ? d.MinDate : DateTime.Today > d.MaxDate ? d.MaxDate : DateTime.Today; break;
                    case CheckedListBox l:
                        for (int i = 0; i < l.Items.Count; i++) l.SetItemChecked(i, false);
                        break;
                }
                if (c.HasChildren && c is not DataGridView) Limpiar(c);
            }
        }

        public static decimal? Decimal(NumericUpDown control) => string.IsNullOrWhiteSpace(control.Text) ? null : control.Value;

        public static void Decimal(NumericUpDown control, decimal? valor)
        {
            if (valor.HasValue)
                control.Value = Math.Max(control.Minimum, Math.Min(control.Maximum, valor.Value));
            else
                control.Text = "";
        }

        public static string? Pedir(string titulo, string etiqueta)
        {
            using var f = new Form
            {
                Text = titulo,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                ClientSize = new Size(420, 170),
                Font = new Font("Segoe UI", 10F)
            };
            var lbl = new Label { Text = etiqueta, AutoSize = true, Location = new Point(15, 15) };
            var txt = new TextBox { Location = new Point(15, 42), Size = new Size(390, 60), Multiline = true };
            var ok = new Button { Text = "Aceptar", DialogResult = DialogResult.OK, Location = new Point(205, 118), Size = new Size(95, 34) };
            var cancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Location = new Point(310, 118), Size = new Size(95, 34) };
            f.Controls.AddRange(new Control[] { lbl, txt, ok, cancel });
            f.AcceptButton = ok;
            f.CancelButton = cancel;
            return f.ShowDialog(Form.ActiveForm) == DialogResult.OK ? txt.Text.Trim() : null;
        }

        public static T? Elegir<T>(string titulo, IEnumerable<T> lista, Func<T, string> texto) where T : class
        {
            var items = lista.ToList();
            if (items.Count == 0) return null;
            if (items.Count == 1) return items[0];
            using var f = new Form
            {
                Text = titulo,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                ClientSize = new Size(520, 360),
                Font = new Font("Segoe UI", 10F)
            };
            var lst = new ListBox { Location = new Point(15, 15), Size = new Size(490, 280) };
            foreach (var item in items) lst.Items.Add(texto(item));
            lst.SelectedIndex = 0;
            var ok = new Button { Text = "Seleccionar", DialogResult = DialogResult.OK, Location = new Point(300, 310), Size = new Size(100, 34) };
            var cancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Location = new Point(405, 310), Size = new Size(100, 34) };
            lst.DoubleClick += (s, e) => { f.DialogResult = DialogResult.OK; };
            f.Controls.AddRange(new Control[] { lst, ok, cancel });
            f.AcceptButton = ok;
            f.CancelButton = cancel;
            return f.ShowDialog(Form.ActiveForm) == DialogResult.OK && lst.SelectedIndex >= 0 ? items[lst.SelectedIndex] : null;
        }

        public static void Imprimir(string titulo, string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                Aviso("No hay información para imprimir.");
                return;
            }
            var lineas = texto.Replace("\r\n", "\n").Split('\n');
            int indice = 0;
            using var documento = new PrintDocument { DocumentName = titulo };
            using var fuente = new Font("Consolas", 10F);
            documento.PrintPage += (s, e) =>
            {
                float y = e.MarginBounds.Top;
                float alto = fuente.GetHeight(e.Graphics!);
                while (indice < lineas.Length && y + alto <= e.MarginBounds.Bottom)
                {
                    e.Graphics!.DrawString(lineas[indice], fuente, Brushes.Black, e.MarginBounds.Left, y);
                    y += alto;
                    indice++;
                }
                e.HasMorePages = indice < lineas.Length;
            };
            using var vista = new PrintPreviewDialog { Document = documento, Width = 900, Height = 700, Text = titulo };
            vista.ShowDialog();
        }
    }
}
