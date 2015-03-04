using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiLabelFormats
{
    public partial class FrmDoelformaatWijzigen : Form
    {
        public string DoelFormaat
        {
            get
            {
                return cmbTargetFormat.SelectedItem.ToString();
            }

        }
        
        
        
        public FrmDoelformaatWijzigen(IEnumerable<string> doelformaten)
        {
            InitializeComponent();
            foreach (string item in doelformaten)
            {
                cmbTargetFormat.Items.Add(item);
            }
            cmbTargetFormat.SelectedIndex = 0;
        }

        private void frmDoelformaatWijzigen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
