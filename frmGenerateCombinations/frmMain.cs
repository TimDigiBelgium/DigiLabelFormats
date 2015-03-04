using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGenerateCombinations
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            MessageBox.Show(GenerateFormat());
        }

        public bool random()
        {
            Random rand = new Random();
            return rand.Next(0,2)==0;
        }

        public string GenerateFormat()
        {
            string FormatCode;
            FormatCode = "";

            bool rnd = random();
            if (rnd)
            {
                FormatCode = "Bc";
            }
            rnd = random();
            if (rnd)
            {
                FormatCode = FormatCode + "Pd";
            }
            rnd = random();
            if (rnd)
            {
                FormatCode = FormatCode + "Sm";
            }


            return FormatCode;
                
        }
    }
}
