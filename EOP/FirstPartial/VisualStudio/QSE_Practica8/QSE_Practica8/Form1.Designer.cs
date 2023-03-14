namespace QSE_Practica8
{
    partial class frmQSE_Practica8
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
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grbSelec = new System.Windows.Forms.GroupBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.btnOp = new System.Windows.Forms.Button();
            this.cmbNum2 = new System.Windows.Forms.ComboBox();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.cmbNum1 = new System.Windows.Forms.ComboBox();
            this.grbNumbers = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.rBtnI = new System.Windows.Forms.RadioButton();
            this.rBtnP = new System.Windows.Forms.RadioButton();
            this.grbRange = new System.Windows.Forms.GroupBox();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.grbResult.SuspendLayout();
            this.grbSelec.SuspendLayout();
            this.grbNumbers.SuspendLayout();
            this.grbType.SuspendLayout();
            this.grbRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.btnClear);
            this.grbResult.Controls.Add(this.txtResult);
            this.grbResult.Location = new System.Drawing.Point(12, 287);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(428, 74);
            this.grbResult.TabIndex = 5;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultado";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(321, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(7, 30);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(260, 20);
            this.txtResult.TabIndex = 0;
            // 
            // grbSelec
            // 
            this.grbSelec.Controls.Add(this.lblOp);
            this.grbSelec.Controls.Add(this.cmbOp);
            this.grbSelec.Controls.Add(this.btnOp);
            this.grbSelec.Controls.Add(this.cmbNum2);
            this.grbSelec.Controls.Add(this.lblDiv);
            this.grbSelec.Controls.Add(this.lblTimes);
            this.grbSelec.Controls.Add(this.lblNum2);
            this.grbSelec.Controls.Add(this.lblNum1);
            this.grbSelec.Controls.Add(this.cmbNum1);
            this.grbSelec.Location = new System.Drawing.Point(12, 148);
            this.grbSelec.Name = "grbSelec";
            this.grbSelec.Size = new System.Drawing.Size(428, 133);
            this.grbSelec.TabIndex = 4;
            this.grbSelec.TabStop = false;
            this.grbSelec.Text = "Seleccionar";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(159, 16);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(56, 13);
            this.lblOp.TabIndex = 9;
            this.lblOp.Text = "Operación";
            // 
            // cmbOp
            // 
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Location = new System.Drawing.Point(159, 33);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(108, 21);
            this.cmbOp.TabIndex = 8;
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.SystemColors.Control;
            this.btnOp.Location = new System.Drawing.Point(108, 70);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(212, 45);
            this.btnOp.TabIndex = 7;
            this.btnOp.Text = "Resolver operación";
            this.btnOp.UseVisualStyleBackColor = false;
            this.btnOp.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // cmbNum2
            // 
            this.cmbNum2.FormattingEnabled = true;
            this.cmbNum2.Location = new System.Drawing.Point(304, 33);
            this.cmbNum2.Name = "cmbNum2";
            this.cmbNum2.Size = new System.Drawing.Size(108, 21);
            this.cmbNum2.TabIndex = 5;
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Location = new System.Drawing.Point(105, 28);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(0, 13);
            this.lblDiv.TabIndex = 4;
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(95, 42);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(0, 13);
            this.lblTimes.TabIndex = 3;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(301, 17);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(40, 13);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Valor 2";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(14, 17);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(40, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Valor 1";
            // 
            // cmbNum1
            // 
            this.cmbNum1.FormattingEnabled = true;
            this.cmbNum1.Location = new System.Drawing.Point(16, 33);
            this.cmbNum1.Name = "cmbNum1";
            this.cmbNum1.Size = new System.Drawing.Size(108, 21);
            this.cmbNum1.TabIndex = 0;
            // 
            // grbNumbers
            // 
            this.grbNumbers.Controls.Add(this.btnAccept);
            this.grbNumbers.Controls.Add(this.grbType);
            this.grbNumbers.Controls.Add(this.grbRange);
            this.grbNumbers.Location = new System.Drawing.Point(12, 12);
            this.grbNumbers.Name = "grbNumbers";
            this.grbNumbers.Size = new System.Drawing.Size(428, 129);
            this.grbNumbers.TabIndex = 3;
            this.grbNumbers.TabStop = false;
            this.grbNumbers.Text = "Números";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccept.Location = new System.Drawing.Point(321, 76);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 37);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.rBtnI);
            this.grbType.Controls.Add(this.rBtnP);
            this.grbType.Location = new System.Drawing.Point(182, 19);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(121, 94);
            this.grbType.TabIndex = 1;
            this.grbType.TabStop = false;
            this.grbType.Text = "Tipo";
            // 
            // rBtnI
            // 
            this.rBtnI.AutoSize = true;
            this.rBtnI.Location = new System.Drawing.Point(7, 56);
            this.rBtnI.Name = "rBtnI";
            this.rBtnI.Size = new System.Drawing.Size(51, 17);
            this.rBtnI.TabIndex = 1;
            this.rBtnI.TabStop = true;
            this.rBtnI.Text = "Impar";
            this.rBtnI.UseVisualStyleBackColor = true;
            // 
            // rBtnP
            // 
            this.rBtnP.AutoSize = true;
            this.rBtnP.Location = new System.Drawing.Point(7, 29);
            this.rBtnP.Name = "rBtnP";
            this.rBtnP.Size = new System.Drawing.Size(41, 17);
            this.rBtnP.TabIndex = 0;
            this.rBtnP.TabStop = true;
            this.rBtnP.Text = "Par";
            this.rBtnP.UseVisualStyleBackColor = true;
            // 
            // grbRange
            // 
            this.grbRange.Controls.Add(this.txtUp);
            this.grbRange.Controls.Add(this.txtLow);
            this.grbRange.Controls.Add(this.lblUp);
            this.grbRange.Controls.Add(this.lblLow);
            this.grbRange.Location = new System.Drawing.Point(7, 20);
            this.grbRange.Name = "grbRange";
            this.grbRange.Size = new System.Drawing.Size(149, 94);
            this.grbRange.TabIndex = 0;
            this.grbRange.TabStop = false;
            this.grbRange.Text = "Rango";
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(46, 56);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(90, 20);
            this.txtUp.TabIndex = 3;
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(46, 29);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(90, 20);
            this.txtLow.TabIndex = 2;
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(6, 56);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(21, 13);
            this.lblUp.TabIndex = 1;
            this.lblUp.Text = "Fin";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(7, 29);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(32, 13);
            this.lblLow.TabIndex = 0;
            this.lblLow.Text = "Inicio";
            // 
            // frmQSE_Practica8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(452, 376);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbSelec);
            this.Controls.Add(this.grbNumbers);
            this.Name = "frmQSE_Practica8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQSE_Practica8";
            this.Load += new System.EventHandler(this.frmQSE_Practica8_Load);
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.grbSelec.ResumeLayout(false);
            this.grbSelec.PerformLayout();
            this.grbNumbers.ResumeLayout(false);
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbRange.ResumeLayout(false);
            this.grbRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox grbSelec;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.ComboBox cmbNum2;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.ComboBox cmbNum1;
        private System.Windows.Forms.GroupBox grbNumbers;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.RadioButton rBtnI;
        private System.Windows.Forms.RadioButton rBtnP;
        private System.Windows.Forms.GroupBox grbRange;
        private System.Windows.Forms.TextBox txtUp;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.ComboBox cmbOp;
    }
}

