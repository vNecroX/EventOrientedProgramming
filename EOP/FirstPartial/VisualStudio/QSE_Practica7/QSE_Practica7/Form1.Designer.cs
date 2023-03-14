namespace QSE_Practica7
{
    partial class frmQSE_Practica7
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
            this.grbData = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNetIncome = new System.Windows.Forms.TextBox();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.txtExSalaryH = new System.Windows.Forms.TextBox();
            this.lblExSalH2 = new System.Windows.Forms.Label();
            this.lblExSalH1 = new System.Windows.Forms.Label();
            this.txtSalaryH = new System.Windows.Forms.TextBox();
            this.lblSalH2 = new System.Windows.Forms.Label();
            this.lblSalH1 = new System.Windows.Forms.Label();
            this.txtExtraH = new System.Windows.Forms.TextBox();
            this.lblExtraH = new System.Windows.Forms.Label();
            this.grbData.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.btnCalculate);
            this.grbData.Controls.Add(this.txtHours);
            this.grbData.Controls.Add(this.lblHours);
            this.grbData.Controls.Add(this.txtSalary);
            this.grbData.Controls.Add(this.lblSalary);
            this.grbData.Controls.Add(this.txtName);
            this.grbData.Controls.Add(this.lblName);
            this.grbData.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.Location = new System.Drawing.Point(13, 13);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(403, 106);
            this.grbData.TabIndex = 0;
            this.grbData.TabStop = false;
            this.grbData.Text = "Datos";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(270, 59);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(140, 77);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(78, 23);
            this.txtHours.TabIndex = 5;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(28, 80);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(110, 17);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "N° Horas Trabajadas";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(118, 45);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 23);
            this.txtSalary.TabIndex = 3;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(28, 48);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(87, 17);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Sueldo por Hora";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.btnExit);
            this.grbResult.Controls.Add(this.btnClear);
            this.grbResult.Controls.Add(this.txtNetIncome);
            this.grbResult.Controls.Add(this.lblNetIncome);
            this.grbResult.Controls.Add(this.txtTaxes);
            this.grbResult.Controls.Add(this.lblTaxes);
            this.grbResult.Controls.Add(this.txtExSalaryH);
            this.grbResult.Controls.Add(this.lblExSalH2);
            this.grbResult.Controls.Add(this.lblExSalH1);
            this.grbResult.Controls.Add(this.txtSalaryH);
            this.grbResult.Controls.Add(this.lblSalH2);
            this.grbResult.Controls.Add(this.lblSalH1);
            this.grbResult.Controls.Add(this.txtExtraH);
            this.grbResult.Controls.Add(this.lblExtraH);
            this.grbResult.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold);
            this.grbResult.Location = new System.Drawing.Point(13, 141);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(403, 164);
            this.grbResult.TabIndex = 1;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(213, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNetIncome
            // 
            this.txtNetIncome.Enabled = false;
            this.txtNetIncome.Location = new System.Drawing.Point(108, 127);
            this.txtNetIncome.Name = "txtNetIncome";
            this.txtNetIncome.Size = new System.Drawing.Size(76, 23);
            this.txtNetIncome.TabIndex = 11;
            // 
            // lblNetIncome
            // 
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Location = new System.Drawing.Point(31, 130);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(65, 17);
            this.lblNetIncome.TabIndex = 10;
            this.lblNetIncome.Text = "Sueldo Neto";
            // 
            // txtTaxes
            // 
            this.txtTaxes.Enabled = false;
            this.txtTaxes.Location = new System.Drawing.Point(108, 94);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(76, 23);
            this.txtTaxes.TabIndex = 9;
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(31, 97);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(59, 17);
            this.lblTaxes.TabIndex = 8;
            this.lblTaxes.Text = "Impuestos";
            // 
            // txtExSalaryH
            // 
            this.txtExSalaryH.Enabled = false;
            this.txtExSalaryH.Location = new System.Drawing.Point(286, 59);
            this.txtExSalaryH.Name = "txtExSalaryH";
            this.txtExSalaryH.Size = new System.Drawing.Size(76, 23);
            this.txtExSalaryH.TabIndex = 7;
            // 
            // lblExSalH2
            // 
            this.lblExSalH2.AutoSize = true;
            this.lblExSalH2.Location = new System.Drawing.Point(210, 70);
            this.lblExSalH2.Name = "lblExSalH2";
            this.lblExSalH2.Size = new System.Drawing.Size(38, 17);
            this.lblExSalH2.TabIndex = 6;
            this.lblExSalH2.Text = "Extras";
            // 
            // lblExSalH1
            // 
            this.lblExSalH1.AutoSize = true;
            this.lblExSalH1.Location = new System.Drawing.Point(210, 53);
            this.lblExSalH1.Name = "lblExSalH1";
            this.lblExSalH1.Size = new System.Drawing.Size(73, 17);
            this.lblExSalH1.TabIndex = 5;
            this.lblExSalH1.Text = "Sueldo Horas";
            // 
            // txtSalaryH
            // 
            this.txtSalaryH.Enabled = false;
            this.txtSalaryH.Location = new System.Drawing.Point(108, 59);
            this.txtSalaryH.Name = "txtSalaryH";
            this.txtSalaryH.Size = new System.Drawing.Size(76, 23);
            this.txtSalaryH.TabIndex = 4;
            // 
            // lblSalH2
            // 
            this.lblSalH2.AutoSize = true;
            this.lblSalH2.Location = new System.Drawing.Point(31, 70);
            this.lblSalH2.Name = "lblSalH2";
            this.lblSalH2.Size = new System.Drawing.Size(55, 17);
            this.lblSalH2.TabIndex = 3;
            this.lblSalH2.Text = "Normales";
            // 
            // lblSalH1
            // 
            this.lblSalH1.AutoSize = true;
            this.lblSalH1.Location = new System.Drawing.Point(31, 53);
            this.lblSalH1.Name = "lblSalH1";
            this.lblSalH1.Size = new System.Drawing.Size(73, 17);
            this.lblSalH1.TabIndex = 2;
            this.lblSalH1.Text = "Sueldo Horas";
            // 
            // txtExtraH
            // 
            this.txtExtraH.Enabled = false;
            this.txtExtraH.Location = new System.Drawing.Point(170, 22);
            this.txtExtraH.Name = "txtExtraH";
            this.txtExtraH.Size = new System.Drawing.Size(192, 23);
            this.txtExtraH.TabIndex = 1;
            // 
            // lblExtraH
            // 
            this.lblExtraH.AutoSize = true;
            this.lblExtraH.Location = new System.Drawing.Point(31, 25);
            this.lblExtraH.Name = "lblExtraH";
            this.lblExtraH.Size = new System.Drawing.Size(137, 17);
            this.lblExtraH.TabIndex = 0;
            this.lblExtraH.Text = "N° Horas Extra Trabajadas";
            // 
            // frmQSE_Practica7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(429, 323);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbData);
            this.Name = "frmQSE_Practica7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQSE_Practica7";
            this.grbData.ResumeLayout(false);
            this.grbData.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtExSalaryH;
        private System.Windows.Forms.Label lblExSalH2;
        private System.Windows.Forms.Label lblExSalH1;
        private System.Windows.Forms.TextBox txtSalaryH;
        private System.Windows.Forms.Label lblSalH2;
        private System.Windows.Forms.Label lblSalH1;
        private System.Windows.Forms.TextBox txtExtraH;
        private System.Windows.Forms.Label lblExtraH;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNetIncome;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.Label lblTaxes;
    }
}

