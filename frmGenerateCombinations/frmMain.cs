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
            txtCombinations.Text=GenerateFormat();
        }

      

        public string GenerateFormat()
        {
            string FormatCode;
            FormatCode = "";


            Utility truefalse = new Utility();
            bool newbool = truefalse.GetRandomBoolean();
            

            if (newbool)
            {
                FormatCode = "Bc";
            }

            truefalse = new Utility();
            newbool = truefalse.GetRandomBoolean();

            if (newbool)
            {
                FormatCode = FormatCode + "Pd";
            }

            truefalse = new Utility();
            newbool = truefalse.GetRandomBoolean();
            if (newbool)
            {
                FormatCode = FormatCode + "Sm";
            }


            return FormatCode;
                
        }
    }
   
    public class Utility
    {
        /// <summary>
        /// Returns a random Boolean value.
        /// </summary>
        /// 
        public bool GenerateBool { get; set; }

        public Utility()
        {
            this.GenerateBool = GetRandomBoolean();
        }

        public bool GetRandomBoolean()
        {
            return new Random().Next(100) % 2 == 0;
        }
    }
}

