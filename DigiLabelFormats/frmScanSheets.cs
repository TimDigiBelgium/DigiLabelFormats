using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiLabelFormats
{
    public partial class frmScanSheets : Form
    {
        public string Afmeting
        { get
             {
                    return lstAfmetingen.SelectedItem.ToString();
        }
        
        }

        
        public frmScanSheets()
        {
            InitializeComponent();
        }

        private void frmScanSheets_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lstAfmetingen.Items.Add("40x46");
            lstAfmetingen.Items.Add("40x62");
            lstAfmetingen.Items.Add("60x49");
            lstAfmetingen.Items.Add("60x60");
            lstAfmetingen.Items.Add("60x62");
            lstAfmetingen.Items.Add("60x70");
            lstAfmetingen.Items.Add("60x73");
            lstAfmetingen.Items.Add("60x80");
            lstAfmetingen.Items.Add("60x90");
            lstAfmetingen.Items.Add("60x100");
            lstAfmetingen.Items.Add("60x120");
        }
    }
}
