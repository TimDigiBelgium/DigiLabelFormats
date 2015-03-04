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
    public partial class frmSelectDevice : Form
    {

        public bool Sm5500 
        { get;
            private set; }


        public frmSelectDevice(List<string> devices)
        {
            InitializeComponent();
            Sm5500 = true;
            foreach (string device in devices)
            {
                lstDevice.Items.Add(device);
            }
           
        }

        private void frmSelectDevice_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void lstDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstDevice.SelectedIndex)
            {
                case 0 :
                    Sm5500 = true;
                    break;
                case 1 :
                    Sm5500 = false;
                    break;
                default:
                    break;
            }
        }
    }
}
