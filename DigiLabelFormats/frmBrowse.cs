using System;
using System.Windows.Forms;
using ClassLibraryLabelFormats;

namespace DigiLabelFormats
{
    public partial class FrmBrowse : Form
    {
        public string SearchFolder { get; set; }

        public bool Totaal { get; set; }

        public string NewFormat
        {
            get
            {
                return lstBrowse.SelectedItem.ToString();


            }
        }
        public FrmBrowse(string searchFolder,bool totaal)
        {
            InitializeComponent();
            SearchFolder = searchFolder;
            btnOk.Enabled = false;
            Totaal = totaal;
            CenterToScreen();
        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {
            var folderNames = StaticMethods.GetExistingLabelFormats(SearchFolder,Totaal);

            foreach (var item in folderNames)
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
            
            LabelFormat lbl =(LabelFormat)lstBrowse.SelectedItem;

            pctExample.Image = lbl.LabelImageKg;
            this.lblSummary.Text = lbl.Omschrijving;
        }

        private void ShowExample()
        { 
        
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void doubleclick(object sender, EventArgs e)
        {
            btnOk.PerformClick();
        }

    }
}
