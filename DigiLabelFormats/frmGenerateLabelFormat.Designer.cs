namespace DigiLabelFormats
{
    partial class FrmGenerateLabelFormat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.radioTrace = new System.Windows.Forms.RadioButton();
            this.radioKip = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLabelFormatCode = new System.Windows.Forms.TextBox();
            this.cmbTargetFormat = new System.Windows.Forms.ComboBox();
            this.pctWeight = new System.Windows.Forms.PictureBox();
            this.pctPieces = new System.Windows.Forms.PictureBox();
            this.grpVlees = new System.Windows.Forms.GroupBox();
            this.radioGeenVlees = new System.Windows.Forms.RadioButton();
            this.grpBewTemp = new System.Windows.Forms.GroupBox();
            this.radioGeenTemp = new System.Windows.Forms.RadioButton();
            this.radioTempVast = new System.Windows.Forms.RadioButton();
            this.radioTempVar = new System.Windows.Forms.RadioButton();
            this.chkBarcode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOperator = new System.Windows.Forms.CheckBox();
            this.chkPluNumber = new System.Windows.Forms.CheckBox();
            this.chkUVD = new System.Windows.Forms.CheckBox();
            this.chkBewaarAdvies = new System.Windows.Forms.CheckBox();
            this.chkTGT = new System.Windows.Forms.CheckBox();
            this.chkInpakDatum = new System.Windows.Forms.CheckBox();
            this.chkIngredients = new System.Windows.Forms.CheckBox();
            this.chkShopLogo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAfmetingen = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstTypeToestel = new System.Windows.Forms.ListBox();
            this.grpTempQuantity = new System.Windows.Forms.GroupBox();
            this.chkMinMax = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chkShopLarge = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkShopName = new System.Windows.Forms.CheckBox();
            this.chkTotalPrice = new System.Windows.Forms.CheckBox();
            this.chkUnitPrice = new System.Windows.Forms.CheckBox();
            this.chkQuantity = new System.Windows.Forms.CheckBox();
            this.chkWeight = new System.Windows.Forms.CheckBox();
            this.chkArticleName = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkFreezing = new System.Windows.Forms.CheckBox();
            this.chkCooling = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.chkHeating = new System.Windows.Forms.CheckBox();
            this.chkPromo = new System.Windows.Forms.CheckBox();
            this.btnToCreate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkInfoTagVanaf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).BeginInit();
            this.grpVlees.SuspendLayout();
            this.grpBewTemp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpTempQuantity.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // radioTrace
            // 
            this.radioTrace.AutoSize = true;
            this.radioTrace.Location = new System.Drawing.Point(65, 19);
            this.radioTrace.Name = "radioTrace";
            this.radioTrace.Size = new System.Drawing.Size(91, 18);
            this.radioTrace.TabIndex = 3;
            this.radioTrace.TabStop = true;
            this.radioTrace.Text = "Traceability";
            this.radioTrace.UseVisualStyleBackColor = true;
            this.radioTrace.CheckedChanged += new System.EventHandler(this.CheckRadioButton);
            // 
            // radioKip
            // 
            this.radioKip.AutoSize = true;
            this.radioKip.Location = new System.Drawing.Point(156, 19);
            this.radioKip.Name = "radioKip";
            this.radioKip.Size = new System.Drawing.Size(116, 18);
            this.radioKip.TabIndex = 4;
            this.radioKip.TabStop = true;
            this.radioKip.Text = "Chicken warning";
            this.radioKip.UseVisualStyleBackColor = true;
            this.radioKip.CheckedChanged += new System.EventHandler(this.CheckRadioButton);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGreen;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(311, 461);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 50);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLabelFormatCode
            // 
            this.txtLabelFormatCode.Enabled = false;
            this.txtLabelFormatCode.Location = new System.Drawing.Point(6, 14);
            this.txtLabelFormatCode.Name = "txtLabelFormatCode";
            this.txtLabelFormatCode.Size = new System.Drawing.Size(419, 22);
            this.txtLabelFormatCode.TabIndex = 6;
            // 
            // cmbTargetFormat
            // 
            this.cmbTargetFormat.FormattingEnabled = true;
            this.cmbTargetFormat.Location = new System.Drawing.Point(20, 16);
            this.cmbTargetFormat.Name = "cmbTargetFormat";
            this.cmbTargetFormat.Size = new System.Drawing.Size(99, 22);
            this.cmbTargetFormat.TabIndex = 8;
            this.cmbTargetFormat.SelectedIndexChanged += new System.EventHandler(this.cmbTargetFormat_SelectedIndexChanged);
            // 
            // pctWeight
            // 
            this.pctWeight.BackColor = System.Drawing.SystemColors.Control;
            this.pctWeight.Location = new System.Drawing.Point(603, 16);
            this.pctWeight.Name = "pctWeight";
            this.pctWeight.Size = new System.Drawing.Size(336, 483);
            this.pctWeight.TabIndex = 10;
            this.pctWeight.TabStop = false;
            this.pctWeight.Click += new System.EventHandler(this.pctWeight_Click);
            // 
            // pctPieces
            // 
            this.pctPieces.BackColor = System.Drawing.SystemColors.Control;
            this.pctPieces.Location = new System.Drawing.Point(957, 16);
            this.pctPieces.Name = "pctPieces";
            this.pctPieces.Size = new System.Drawing.Size(373, 483);
            this.pctPieces.TabIndex = 11;
            this.pctPieces.TabStop = false;
            // 
            // grpVlees
            // 
            this.grpVlees.Controls.Add(this.radioGeenVlees);
            this.grpVlees.Controls.Add(this.radioTrace);
            this.grpVlees.Controls.Add(this.radioKip);
            this.grpVlees.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVlees.Location = new System.Drawing.Point(158, 151);
            this.grpVlees.Name = "grpVlees";
            this.grpVlees.Size = new System.Drawing.Size(273, 48);
            this.grpVlees.TabIndex = 12;
            this.grpVlees.TabStop = false;
            this.grpVlees.Text = "Meat info";
            // 
            // radioGeenVlees
            // 
            this.radioGeenVlees.AutoSize = true;
            this.radioGeenVlees.Location = new System.Drawing.Point(13, 19);
            this.radioGeenVlees.Name = "radioGeenVlees";
            this.radioGeenVlees.Size = new System.Drawing.Size(52, 18);
            this.radioGeenVlees.TabIndex = 5;
            this.radioGeenVlees.TabStop = true;
            this.radioGeenVlees.Text = "None";
            this.radioGeenVlees.UseVisualStyleBackColor = true;
            this.radioGeenVlees.CheckedChanged += new System.EventHandler(this.CheckRadioButton);
            // 
            // grpBewTemp
            // 
            this.grpBewTemp.Controls.Add(this.radioGeenTemp);
            this.grpBewTemp.Controls.Add(this.radioTempVast);
            this.grpBewTemp.Controls.Add(this.radioTempVar);
            this.grpBewTemp.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBewTemp.Location = new System.Drawing.Point(158, 200);
            this.grpBewTemp.Name = "grpBewTemp";
            this.grpBewTemp.Size = new System.Drawing.Size(251, 48);
            this.grpBewTemp.TabIndex = 13;
            this.grpBewTemp.TabStop = false;
            this.grpBewTemp.Text = "Temperature";
            // 
            // radioGeenTemp
            // 
            this.radioGeenTemp.AutoSize = true;
            this.radioGeenTemp.Location = new System.Drawing.Point(13, 19);
            this.radioGeenTemp.Name = "radioGeenTemp";
            this.radioGeenTemp.Size = new System.Drawing.Size(52, 18);
            this.radioGeenTemp.TabIndex = 6;
            this.radioGeenTemp.TabStop = true;
            this.radioGeenTemp.Text = "None";
            this.radioGeenTemp.UseVisualStyleBackColor = true;
            this.radioGeenTemp.CheckedChanged += new System.EventHandler(this.TempQuantity);
            // 
            // radioTempVast
            // 
            this.radioTempVast.AutoSize = true;
            this.radioTempVast.Location = new System.Drawing.Point(65, 19);
            this.radioTempVast.Name = "radioTempVast";
            this.radioTempVast.Size = new System.Drawing.Size(77, 18);
            this.radioTempVast.TabIndex = 3;
            this.radioTempVast.TabStop = true;
            this.radioTempVast.Text = "Fixed text";
            this.radioTempVast.UseVisualStyleBackColor = true;
            this.radioTempVast.CheckedChanged += new System.EventHandler(this.TempQuantity);
            // 
            // radioTempVar
            // 
            this.radioTempVar.AutoSize = true;
            this.radioTempVar.Location = new System.Drawing.Point(144, 19);
            this.radioTempVar.Name = "radioTempVar";
            this.radioTempVar.Size = new System.Drawing.Size(102, 18);
            this.radioTempVar.TabIndex = 4;
            this.radioTempVar.TabStop = true;
            this.radioTempVar.Text = "Variable (plu)";
            this.radioTempVar.UseVisualStyleBackColor = true;
            this.radioTempVar.CheckedChanged += new System.EventHandler(this.TempQuantity);
            // 
            // chkBarcode
            // 
            this.chkBarcode.AutoSize = true;
            this.chkBarcode.Location = new System.Drawing.Point(13, 19);
            this.chkBarcode.Name = "chkBarcode";
            this.chkBarcode.Size = new System.Drawing.Size(70, 18);
            this.chkBarcode.TabIndex = 16;
            this.chkBarcode.Text = "Barcode";
            this.chkBarcode.UseVisualStyleBackColor = true;
            this.chkBarcode.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOperator);
            this.groupBox1.Controls.Add(this.chkPluNumber);
            this.groupBox1.Controls.Add(this.chkUVD);
            this.groupBox1.Controls.Add(this.chkBewaarAdvies);
            this.groupBox1.Controls.Add(this.chkTGT);
            this.groupBox1.Controls.Add(this.chkInpakDatum);
            this.groupBox1.Controls.Add(this.chkBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(158, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extended fields";
            // 
            // chkOperator
            // 
            this.chkOperator.AutoSize = true;
            this.chkOperator.Location = new System.Drawing.Point(203, 45);
            this.chkOperator.Name = "chkOperator";
            this.chkOperator.Size = new System.Drawing.Size(74, 18);
            this.chkOperator.TabIndex = 24;
            this.chkOperator.Text = "Operator";
            this.chkOperator.UseVisualStyleBackColor = true;
            this.chkOperator.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkPluNumber
            // 
            this.chkPluNumber.AutoSize = true;
            this.chkPluNumber.Location = new System.Drawing.Point(283, 45);
            this.chkPluNumber.Name = "chkPluNumber";
            this.chkPluNumber.Size = new System.Drawing.Size(90, 18);
            this.chkPluNumber.TabIndex = 23;
            this.chkPluNumber.Text = "Plu Number";
            this.chkPluNumber.UseVisualStyleBackColor = true;
            this.chkPluNumber.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkUVD
            // 
            this.chkUVD.AutoSize = true;
            this.chkUVD.Location = new System.Drawing.Point(109, 45);
            this.chkUVD.Name = "chkUVD";
            this.chkUVD.Size = new System.Drawing.Size(90, 18);
            this.chkUVD.TabIndex = 21;
            this.chkUVD.Text = "Sell by Date";
            this.chkUVD.UseVisualStyleBackColor = true;
            this.chkUVD.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkBewaarAdvies
            // 
            this.chkBewaarAdvies.AutoSize = true;
            this.chkBewaarAdvies.Location = new System.Drawing.Point(203, 19);
            this.chkBewaarAdvies.Name = "chkBewaarAdvies";
            this.chkBewaarAdvies.Size = new System.Drawing.Size(114, 18);
            this.chkBewaarAdvies.TabIndex = 20;
            this.chkBewaarAdvies.Text = "Special Message";
            this.chkBewaarAdvies.UseVisualStyleBackColor = true;
            this.chkBewaarAdvies.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkTGT
            // 
            this.chkTGT.AutoSize = true;
            this.chkTGT.Location = new System.Drawing.Point(13, 45);
            this.chkTGT.Name = "chkTGT";
            this.chkTGT.Size = new System.Drawing.Size(89, 18);
            this.chkTGT.TabIndex = 18;
            this.chkTGT.Text = "Use by Date";
            this.chkTGT.UseVisualStyleBackColor = true;
            this.chkTGT.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkInpakDatum
            // 
            this.chkInpakDatum.AutoSize = true;
            this.chkInpakDatum.Location = new System.Drawing.Point(109, 19);
            this.chkInpakDatum.Name = "chkInpakDatum";
            this.chkInpakDatum.Size = new System.Drawing.Size(92, 18);
            this.chkInpakDatum.TabIndex = 17;
            this.chkInpakDatum.Text = "Packed Date";
            this.chkInpakDatum.UseVisualStyleBackColor = true;
            this.chkInpakDatum.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkIngredients
            // 
            this.chkIngredients.AutoSize = true;
            this.chkIngredients.Location = new System.Drawing.Point(203, 45);
            this.chkIngredients.Name = "chkIngredients";
            this.chkIngredients.Size = new System.Drawing.Size(96, 18);
            this.chkIngredients.TabIndex = 25;
            this.chkIngredients.Text = "Ingrediënten";
            this.chkIngredients.UseVisualStyleBackColor = true;
            this.chkIngredients.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkShopLogo
            // 
            this.chkShopLogo.AutoSize = true;
            this.chkShopLogo.Location = new System.Drawing.Point(23, 21);
            this.chkShopLogo.Name = "chkShopLogo";
            this.chkShopLogo.Size = new System.Drawing.Size(57, 18);
            this.chkShopLogo.TabIndex = 22;
            this.chkShopLogo.Text = "Small";
            this.chkShopLogo.UseVisualStyleBackColor = true;
            this.chkShopLogo.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAfmetingen);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 285);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select size";
            // 
            // lstAfmetingen
            // 
            this.lstAfmetingen.FormattingEnabled = true;
            this.lstAfmetingen.ItemHeight = 14;
            this.lstAfmetingen.Location = new System.Drawing.Point(6, 19);
            this.lstAfmetingen.Name = "lstAfmetingen";
            this.lstAfmetingen.Size = new System.Drawing.Size(123, 256);
            this.lstAfmetingen.TabIndex = 0;
            this.lstAfmetingen.SelectedIndexChanged += new System.EventHandler(this.ChangeFormatCode);
            this.lstAfmetingen.DoubleClick += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(164, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 50);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTargetFormat);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 44);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select target format";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabelFormatCode);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(164, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 44);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Format Code";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(12, 461);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(137, 50);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Select from list";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstTypeToestel);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 106);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select device";
            // 
            // lstTypeToestel
            // 
            this.lstTypeToestel.FormattingEnabled = true;
            this.lstTypeToestel.ItemHeight = 14;
            this.lstTypeToestel.Location = new System.Drawing.Point(6, 21);
            this.lstTypeToestel.Name = "lstTypeToestel";
            this.lstTypeToestel.Size = new System.Drawing.Size(123, 74);
            this.lstTypeToestel.TabIndex = 0;
            this.lstTypeToestel.SelectedIndexChanged += new System.EventHandler(this.ChangeDevice);
            // 
            // grpTempQuantity
            // 
            this.grpTempQuantity.Controls.Add(this.chkMinMax);
            this.grpTempQuantity.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempQuantity.Location = new System.Drawing.Point(415, 200);
            this.grpTempQuantity.Name = "grpTempQuantity";
            this.grpTempQuantity.Size = new System.Drawing.Size(104, 48);
            this.grpTempQuantity.TabIndex = 14;
            this.grpTempQuantity.TabStop = false;
            this.grpTempQuantity.Text = "2 temperatures";
            // 
            // chkMinMax
            // 
            this.chkMinMax.AutoSize = true;
            this.chkMinMax.Location = new System.Drawing.Point(6, 19);
            this.chkMinMax.Name = "chkMinMax";
            this.chkMinMax.Size = new System.Drawing.Size(80, 18);
            this.chkMinMax.TabIndex = 23;
            this.chkMinMax.Text = "Min.-max.";
            this.chkMinMax.UseVisualStyleBackColor = true;
            this.chkMinMax.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chkShopLarge);
            this.groupBox9.Controls.Add(this.chkShopLogo);
            this.groupBox9.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(436, 150);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(153, 49);
            this.groupBox9.TabIndex = 28;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Shop Logo";
            // 
            // chkShopLarge
            // 
            this.chkShopLarge.AutoSize = true;
            this.chkShopLarge.Location = new System.Drawing.Point(85, 21);
            this.chkShopLarge.Name = "chkShopLarge";
            this.chkShopLarge.Size = new System.Drawing.Size(57, 18);
            this.chkShopLarge.TabIndex = 19;
            this.chkShopLarge.Text = "Large";
            this.chkShopLarge.UseVisualStyleBackColor = true;
            this.chkShopLarge.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chkIngredients);
            this.groupBox10.Controls.Add(this.chkShopName);
            this.groupBox10.Controls.Add(this.chkTotalPrice);
            this.groupBox10.Controls.Add(this.chkUnitPrice);
            this.groupBox10.Controls.Add(this.chkQuantity);
            this.groupBox10.Controls.Add(this.chkWeight);
            this.groupBox10.Controls.Add(this.chkArticleName);
            this.groupBox10.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(158, 9);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(431, 70);
            this.groupBox10.TabIndex = 29;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Basic fields";
            this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // chkShopName
            // 
            this.chkShopName.AutoSize = true;
            this.chkShopName.Location = new System.Drawing.Point(112, 45);
            this.chkShopName.Name = "chkShopName";
            this.chkShopName.Size = new System.Drawing.Size(85, 18);
            this.chkShopName.TabIndex = 21;
            this.chkShopName.Text = "Shop name";
            this.chkShopName.UseVisualStyleBackColor = true;
            this.chkShopName.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkTotalPrice
            // 
            this.chkTotalPrice.AutoSize = true;
            this.chkTotalPrice.Location = new System.Drawing.Point(13, 45);
            this.chkTotalPrice.Name = "chkTotalPrice";
            this.chkTotalPrice.Size = new System.Drawing.Size(83, 18);
            this.chkTotalPrice.TabIndex = 20;
            this.chkTotalPrice.Text = "Total price";
            this.chkTotalPrice.UseVisualStyleBackColor = true;
            this.chkTotalPrice.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkUnitPrice
            // 
            this.chkUnitPrice.AutoSize = true;
            this.chkUnitPrice.Location = new System.Drawing.Point(283, 20);
            this.chkUnitPrice.Name = "chkUnitPrice";
            this.chkUnitPrice.Size = new System.Drawing.Size(79, 18);
            this.chkUnitPrice.TabIndex = 19;
            this.chkUnitPrice.Text = "Unit price";
            this.chkUnitPrice.UseVisualStyleBackColor = true;
            this.chkUnitPrice.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkQuantity
            // 
            this.chkQuantity.AutoSize = true;
            this.chkQuantity.Location = new System.Drawing.Point(200, 20);
            this.chkQuantity.Name = "chkQuantity";
            this.chkQuantity.Size = new System.Drawing.Size(73, 18);
            this.chkQuantity.TabIndex = 18;
            this.chkQuantity.Text = "Quantity";
            this.chkQuantity.UseVisualStyleBackColor = true;
            this.chkQuantity.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkWeight
            // 
            this.chkWeight.AutoSize = true;
            this.chkWeight.Location = new System.Drawing.Point(112, 21);
            this.chkWeight.Name = "chkWeight";
            this.chkWeight.Size = new System.Drawing.Size(64, 18);
            this.chkWeight.TabIndex = 17;
            this.chkWeight.Text = "Weight";
            this.chkWeight.UseVisualStyleBackColor = true;
            this.chkWeight.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkArticleName
            // 
            this.chkArticleName.AutoSize = true;
            this.chkArticleName.Location = new System.Drawing.Point(13, 21);
            this.chkArticleName.Name = "chkArticleName";
            this.chkArticleName.Size = new System.Drawing.Size(94, 18);
            this.chkArticleName.TabIndex = 16;
            this.chkArticleName.Text = "Article name";
            this.chkArticleName.UseVisualStyleBackColor = true;
            this.chkArticleName.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.chkFreezing);
            this.groupBox6.Controls.Add(this.chkCooling);
            this.groupBox6.Controls.Add(this.chkNuts);
            this.groupBox6.Controls.Add(this.chkBeef);
            this.groupBox6.Controls.Add(this.chkHeating);
            this.groupBox6.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(158, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(439, 99);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Variable text fields";
            // 
            // groupBox7
            // 
            this.groupBox7.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(13, 96);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 48);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temperature";
            // 
            // chkFreezing
            // 
            this.chkFreezing.AutoSize = true;
            this.chkFreezing.Location = new System.Drawing.Point(13, 81);
            this.chkFreezing.Name = "chkFreezing";
            this.chkFreezing.Size = new System.Drawing.Size(277, 18);
            this.chkFreezing.TabIndex = 20;
            this.chkFreezing.Text = "\"Een ontdooid product niet opnieuw invriezen\"";
            this.chkFreezing.UseVisualStyleBackColor = true;
            this.chkFreezing.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkCooling
            // 
            this.chkCooling.AutoSize = true;
            this.chkCooling.Location = new System.Drawing.Point(13, 61);
            this.chkCooling.Name = "chkCooling";
            this.chkCooling.Size = new System.Drawing.Size(150, 18);
            this.chkCooling.TabIndex = 19;
            this.chkCooling.Text = "\"Mits gekoeld bij -18C\"";
            this.chkCooling.UseVisualStyleBackColor = true;
            this.chkCooling.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(13, 41);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(316, 18);
            this.chkNuts.TabIndex = 18;
            this.chkNuts.Text = "\"Dit product kan sporen van noten en sesam bevatten\"";
            this.chkNuts.UseVisualStyleBackColor = true;
            this.chkNuts.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkBeef
            // 
            this.chkBeef.AutoSize = true;
            this.chkBeef.Location = new System.Drawing.Point(177, 21);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(217, 18);
            this.chkBeef.TabIndex = 17;
            this.chkBeef.Text = "\"Kalfsvlees jonger dan 8 maanden\"";
            this.chkBeef.UseVisualStyleBackColor = true;
            this.chkBeef.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkHeating
            // 
            this.chkHeating.AutoSize = true;
            this.chkHeating.Location = new System.Drawing.Point(13, 21);
            this.chkHeating.Name = "chkHeating";
            this.chkHeating.Size = new System.Drawing.Size(159, 18);
            this.chkHeating.TabIndex = 16;
            this.chkHeating.Text = "\"Verhitten tot in de kern\"";
            this.chkHeating.UseVisualStyleBackColor = true;
            this.chkHeating.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // chkPromo
            // 
            this.chkPromo.AutoSize = true;
            this.chkPromo.Location = new System.Drawing.Point(13, 21);
            this.chkPromo.Name = "chkPromo";
            this.chkPromo.Size = new System.Drawing.Size(98, 18);
            this.chkPromo.TabIndex = 21;
            this.chkPromo.Text = "\"Aanbieding\"";
            this.chkPromo.UseVisualStyleBackColor = true;
            this.chkPromo.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // btnToCreate
            // 
            this.btnToCreate.BackColor = System.Drawing.Color.LightGreen;
            this.btnToCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnToCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToCreate.Location = new System.Drawing.Point(460, 461);
            this.btnToCreate.Name = "btnToCreate";
            this.btnToCreate.Size = new System.Drawing.Size(137, 50);
            this.btnToCreate.TabIndex = 31;
            this.btnToCreate.Text = "To Create";
            this.btnToCreate.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(603, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(22, 31);
            this.lblError.TabIndex = 32;
            this.lblError.Text = " ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkInfoTagVanaf);
            this.groupBox8.Controls.Add(this.chkPromo);
            this.groupBox8.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(158, 359);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(431, 48);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Infotag";
            // 
            // chkInfoTagVanaf
            // 
            this.chkInfoTagVanaf.AutoSize = true;
            this.chkInfoTagVanaf.Location = new System.Drawing.Point(117, 21);
            this.chkInfoTagVanaf.Name = "chkInfoTagVanaf";
            this.chkInfoTagVanaf.Size = new System.Drawing.Size(218, 18);
            this.chkInfoTagVanaf.TabIndex = 22;
            this.chkInfoTagVanaf.Text = "Promo tekst \"vanaf ... kg ... euro/kg\"";
            this.chkInfoTagVanaf.UseVisualStyleBackColor = true;
            this.chkInfoTagVanaf.CheckedChanged += new System.EventHandler(this.ChangeFormatCode);
            // 
            // FrmGenerateLabelFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 519);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnToCreate);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.grpTempQuantity);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBewTemp);
            this.Controls.Add(this.grpVlees);
            this.Controls.Add(this.pctPieces);
            this.Controls.Add(this.pctWeight);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Name = "FrmGenerateLabelFormat";
            this.Text = "Select a labelformat";
            this.Load += new System.EventHandler(this.frmGenerateLabelFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPieces)).EndInit();
            this.grpVlees.ResumeLayout(false);
            this.grpVlees.PerformLayout();
            this.grpBewTemp.ResumeLayout(false);
            this.grpBewTemp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.grpTempQuantity.ResumeLayout(false);
            this.grpTempQuantity.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioTrace;
        private System.Windows.Forms.RadioButton radioKip;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLabelFormatCode;
        private System.Windows.Forms.ComboBox cmbTargetFormat;
        private System.Windows.Forms.PictureBox pctWeight;
        private System.Windows.Forms.PictureBox pctPieces;
        private System.Windows.Forms.GroupBox grpVlees;
        private System.Windows.Forms.GroupBox grpBewTemp;
        private System.Windows.Forms.RadioButton radioTempVast;
        private System.Windows.Forms.RadioButton radioTempVar;
        private System.Windows.Forms.RadioButton radioGeenVlees;
        private System.Windows.Forms.RadioButton radioGeenTemp;
        private System.Windows.Forms.CheckBox chkBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBewaarAdvies;
        private System.Windows.Forms.CheckBox chkTGT;
        private System.Windows.Forms.CheckBox chkInpakDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAfmetingen;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstTypeToestel;
        private System.Windows.Forms.GroupBox grpTempQuantity;
        private System.Windows.Forms.CheckBox chkShopLogo;
        private System.Windows.Forms.CheckBox chkUVD;
        private System.Windows.Forms.CheckBox chkMinMax;
        private System.Windows.Forms.CheckBox chkPluNumber;
        private System.Windows.Forms.CheckBox chkOperator;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox chkShopLarge;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox chkArticleName;
        private System.Windows.Forms.CheckBox chkIngredients;
        private System.Windows.Forms.CheckBox chkShopName;
        private System.Windows.Forms.CheckBox chkTotalPrice;
        private System.Windows.Forms.CheckBox chkUnitPrice;
        private System.Windows.Forms.CheckBox chkQuantity;
        private System.Windows.Forms.CheckBox chkWeight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkBeef;
        private System.Windows.Forms.CheckBox chkHeating;
        private System.Windows.Forms.CheckBox chkFreezing;
        private System.Windows.Forms.CheckBox chkCooling;
        private System.Windows.Forms.Button btnToCreate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkPromo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkInfoTagVanaf;
    }
}