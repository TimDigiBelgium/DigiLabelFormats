using ClassLibraryLabelFormats;
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

namespace DigidriverSend
{
    public partial class frmDigidriverSend : Form
    {
        public string SendFileUrl { get; set; }

        public frmDigidriverSend()
        {

            Folders.rootMap = Directory.GetCurrentDirectory();

          

            Folders.StartDatServer = Folders.rootMap + @"\DataFiles\Start.dat";

          

            Folders.DigiDriver = @"C:\DEC\DIGIDRV\DIGIDRV.EXE";
            Folders.DigiDriverConfiguration = @"C:\DEC\DIGIDRV\DigiDriverConfiguration.EXE";
            Folders.SendDat = @"C:\DEC\Digidrv\In\send.dat";
            Folders.StartDat = @"C:\DEC\Digidrv\In\start.dat";

         
        
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConfigureDigiDriver.Enabled = false ;
            btnSendWithDigiDriver.Enabled = false;
            this.CenterToScreen();

        }

        private void btnConfigureDigiDriver_Click(object sender, EventArgs e)
        {
            //code om digidriver te starten
         
            //code om digidriver te starten
            if (File.Exists(Folders.DigiDriverConfiguration))
            {
                Process.Start(Folders.DigiDriverConfiguration);
            }
            else
            {
                MessageBox.Show("Error: " + Folders.DigiDriverConfiguration + " not found !");
            }
        }

        private void btnSendWithDigiDriver_Click(object sender, EventArgs e)
        {


            if (!File.Exists(Folders.DigiDriver))
            {
                MessageBox.Show("Error : Digidriver not found in " + Folders.DigiDriver + " !");
            }
            else
            {
                File.Copy(SendFileUrl, Folders.SendDat, true);

                 File.Copy(Folders.StartDatServer, Folders.StartDat, true);
                Process.Start(Folders.DigiDriver);
               // Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult result = openSendFile.ShowDialog();
             if (result == DialogResult.OK) // Test result.
             {
                 SendFileUrl = openSendFile.FileName;
                 btnConfigureDigiDriver.Enabled = true;
                 btnSendWithDigiDriver.Enabled = true;
             }
            
               
        }
    }
}
