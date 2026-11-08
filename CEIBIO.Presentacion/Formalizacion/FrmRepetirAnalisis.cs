
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    // Registrar repetición del análisis (CU-48)
    public partial class FrmRepetirAnalisis : Form
    {

        private readonly Color azul =
            Color.FromArgb(11, 61, 110);

        public FrmRepetirAnalisis()
        {
            InitializeComponent();
            this.btnCerrar.Click += (sender, args) => this.Close();

        }


    }
}
