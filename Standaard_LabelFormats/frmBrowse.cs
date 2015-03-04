using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiLabelFormats
{
    public partial class frmBrowse : Form
    {
        public string SearchFolder { get; set; }


        public string newFormat
        {
            get
            {
                return lstBrowse.SelectedItem.ToString();


            }
        }
        public frmBrowse(string searchFolder)
        {
            InitializeComponent();
            this.SearchFolder = searchFolder;
            btnOk.Enabled = false;
            this.CenterToScreen();
        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {

            List<string> folderNames = new List<string>();
            folderNames = StaticMethods.GetExistingFormats(SearchFolder);

            foreach (string item in folderNames)
            {
                lstBrowse.Items.Add(item);
            }
            
        }

        
        private void lstBrowse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBrowse.SelectedItem!=null)
            {
                btnOk.Enabled = true;
            }
        }

    }
}
