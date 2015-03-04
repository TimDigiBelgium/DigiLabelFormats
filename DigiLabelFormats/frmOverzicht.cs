using System;
using System.Windows.Forms;

namespace DigiLabelFormats
{
    public partial class FrmOverzicht : Form
    {

        public FrmOverzicht(string overzicht)
        {
            InitializeComponent();
            CenterToScreen();
            txtOverzicht.Text = overzicht;
        }

        private void frmOverzicht_Load(object sender, EventArgs e)
        {

        }
    }
}
