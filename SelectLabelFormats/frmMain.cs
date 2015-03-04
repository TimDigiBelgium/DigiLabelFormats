using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SelectLabelFormats
{
    public partial class frmMain : Form
    {

        public string ServerDrive { get; set; }

        public frmMain()
        {
            if (Directory.Exists(@"Y:\Production\Converters\Production Tools\"))
            {
                ServerDrive = @"Y:\Production\Converters\Production Tools\";
            }
            else
            {
                ServerDrive = @"C:\Production\Converters\Production Tools\";
            }
            InitializeComponent();
            this.lstDevices.Enabled = false;
            this.lstSizes.Enabled = false;
            this.lstLabelFormats.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            initThemes();
            this.CenterToScreen();
        }

        public void initFolders(string searchFolder)
        {
            lstMain.Items.Clear();
            foreach (string folder in Directory.GetDirectories(@searchFolder))
            {
                lstMain.Items.Add(Path.GetFileName(folder));
            }
            
        }

        public void initThemes()
        {
            lstTheme.Items.Add("ExcelConverters");
            lstTheme.Items.Add("LabelFormats");
            lstTheme.Items.Add("Documentatie");
            lstTheme.SelectedIndex = 0;


        }

        private void ShowLabelFormats(object sender, EventArgs e)
        {
           
        }

        private void openInLabelDesigner()
        {
            if (lstLabelFormats.SelectedIndex != -1)
            {
                //freeformats.dat kopieren
                string file = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString() + @"\" + @lstSizes.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() + @"\freeformats.dat";
                File.Copy(file, @"C:\DEC\Digidrv\Data\freeformats.dat", true);

                //code om labeldesigner te openen
                string labelDesignerPath = @"c:\dec\label designer\label designer.exe";
                if (File.Exists(labelDesignerPath))
                {
                    Process.Start(labelDesignerPath);
                }
                else
                {
                    MessageBox.Show(labelDesignerPath + " niet gevonden.");
                }
            }
            else
            {
                MessageBox.Show("Selecteer een formaat");
            }
           
        
        
        
        }


        private void btnOpenInLabelDesigner_Click(object sender, EventArgs e)
        {
            switch (lstTheme.SelectedIndex)
            {
                case 0:
                    SaveExcelConverter();
                    break;
                case 1:
                    openInLabelDesigner();
                    break;
                case 2:
                    openWordDocument();
                    break;
                default:
                    break;
            }
          
        }

        private void SaveExcelConverter()
        {
            if (lstLabelFormats.SelectedIndex != -1)
            {


                //saveAsBackOffice.Filter = "dat bestanden | *.dat";
                saveConverter.Title = "Bewaar de converter";
                saveConverter.FileName = @lstLabelFormats.SelectedItem.ToString() + @".xlsm";
                saveConverter.InitialDirectory = @"C:\XLConverter";

                DialogResult result = saveConverter.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() + @".xlsm";


                    File.Copy(file, saveConverter.FileName, true);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een ExcelConverter");
            }
        }

        private void openWordDocument()
        { 
        string file = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString() + @"\" + @lstSizes.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() +  @"\" + @lstLabelFormats.SelectedItem.ToString() + @".docx";

        Process.Start(file);
        
        
        }

        private void btnSaveAsWindigi_Click(object sender, EventArgs e)
        {
            if (lstLabelFormats.SelectedIndex != -1)
            {


                saveAsBackOffice.Filter = "dat bestanden | *.dat";
                saveAsBackOffice.Title = "Bewaar de file om in windigi in te lezen";
                saveAsBackOffice.FileName = "freeformats.dat";
                saveAsBackOffice.InitialDirectory = @"C:\XLConverter";

                DialogResult result = saveAsBackOffice.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString() + @"\" + @lstSizes.SelectedItem.ToString() + @"\" + @lstLabelFormats.SelectedItem.ToString() + @"\freeformats.dat";


                    File.Copy(file, saveAsBackOffice.FileName, true);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een formaat");
            }
        }

        private void lstLabelFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSizes.Items.Clear();
            lstLabelFormats.Items.Clear();
            this.lstSizes.Enabled = true;
            this.lstLabelFormats.Enabled = false;
           
            string SearchFolder = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString();
            

            foreach (string folder in Directory.GetDirectories(SearchFolder))
                lstSizes.Items.Add(Path.GetFileName(folder));
        }

        private void lstSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSizes.SelectedIndex!=-1)
            {
                this.lstLabelFormats.Enabled = true;
                lstLabelFormats.Items.Clear();
                List<string> folderNames = new List<string>();
                string SearchFolder = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString() + @"\" + @lstDevices.SelectedItem.ToString() + @"\" + @lstSizes.SelectedItem.ToString();


                foreach (string folder in Directory.GetDirectories(SearchFolder))
                    lstLabelFormats.Items.Add(Path.GetFileName(folder));
            }
            }
           

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SearchFolder;
            switch (lstTheme.SelectedIndex)
            {
                case 0:
    
                    break;
                default:
                      lstDevices.Items.Clear();
            lstSizes.Items.Clear();
            lstLabelFormats.Items.Clear();
            this.lstDevices.Enabled = true;
            this.lstSizes.Enabled = false;
            this.lstLabelFormats.Enabled = false;

            SearchFolder = @ServerDrive + @lstTheme.SelectedItem.ToString() + @"\" + @lstMain.SelectedItem.ToString();


            foreach (string folder in Directory.GetDirectories(SearchFolder))
                lstDevices.Items.Add(Path.GetFileName(folder));
            


                    break;
            }
           
          
        }

        private void lstTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SearchFolder;
            lstDevices.Items.Clear();
            lstMain.Items.Clear();
            lstSizes.Items.Clear();
            lstLabelFormats.Items.Clear();
            switch (lstTheme.SelectedIndex)
            {
                case 0:
                    lblSubject.Text = "";
                    lblDeviceType.Text = "";
                    lblSelectItem.Text = "Select Converter:";
                    lblFolder.Text = "";
                    lstMain.Visible = false;
                    lstSizes.Visible = false;
                    lstDevices.Visible = false;
                    btnSaveAsWindigi.Visible = false;
                    btnOpenInLabelDesigner.Text = "Save Converter";
                          this.lstLabelFormats.Enabled = true;
                lstLabelFormats.Items.Clear();
                List<string> folderNames = new List<string>();
                SearchFolder = @ServerDrive + @lstTheme.SelectedItem.ToString();


                foreach (string folder in Directory.GetDirectories(SearchFolder))
                    lstLabelFormats.Items.Add(Path.GetFileName(folder));


                    break;
                
                
                
                
                case 1:
                    lstSizes.Visible = true;
                    lstDevices.Visible = true;
                    lstMain.Visible = true;
                    lblFolder.Text = "Select Folder:";
                    lblSubject.Text = "Label Size:";
                    lblDeviceType.Text = "Device Type:";
                    lblSelectItem.Text = "Select LabelFormat:";
                    btnSaveAsWindigi.Visible = true;
                    btnOpenInLabelDesigner.Text = "Open in LabelDesigner";
                    initFolders(@ServerDrive + @lstTheme.SelectedItem.ToString());
                    break;
                case 2:
                    lstSizes.Visible = true;
                    lstDevices.Visible = true;
                    lstMain.Visible = true;
                    lblFolder.Text = "Select Folder:";
                    lblSubject.Text = "Subject:";
                    lblDeviceType.Text = "Device Type:";
                    lblSelectItem.Text = "Select Document:";
                    initFolders(@ServerDrive + @lstTheme.SelectedItem.ToString());
                    btnSaveAsWindigi.Visible = false;
                    btnOpenInLabelDesigner.Text = "Open in Word";
                    break;
                default:
                    break;
            }
        }

      
    }
      
        

    
}
