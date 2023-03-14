namespace QSE_Practica6
{
    partial class frmQSE_Practica6
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
            this.grbForm = new System.Windows.Forms.GroupBox();
            this.rBtnTemp = new System.Windows.Forms.RadioButton();
            this.rBtnLength = new System.Windows.Forms.RadioButton();
            this.rBtnWeigth = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbForm
            // 
            this.grbForm.Controls.Add(this.lblValue);
            this.grbForm.Controls.Add(this.btnConvert);
            this.grbForm.Controls.Add(this.rBtnWeigth);
            this.grbForm.Controls.Add(this.rBtnLength);
            this.grbForm.Controls.Add(this.txtValue);
            this.grbForm.Controls.Add(this.rBtnTemp);
            this.grbForm.Location = new System.Drawing.Point(13, 13);
            this.grbForm.Name = "grbForm";
            this.grbForm.Size = new System.Drawing.Size(272, 126);
            this.grbForm.TabIndex = 0;
            this.grbForm.TabStop = false;
            this.grbForm.Text = "Conversiones de Medidas.";
            // 
            // rBtnTemp
            // 
            this.rBtnTemp.AutoSize = true;
            this.rBtnTemp.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnTemp.ForeColor = System.Drawing.Color.Gold;
            this.rBtnTemp.Location = new System.Drawing.Point(7, 20);
            this.rBtnTemp.Name = "rBtnTemp";
            this.rBtnTemp.Size = new System.Drawing.Size(133, 22);
            this.rBtnTemp.TabIndex = 0;
            this.rBtnTemp.TabStop = true;
            this.rBtnTemp.Text = "Temperatura (K a C).";
            this.rBtnTemp.UseVisualStyleBackColor = true;
            // 
            // rBtnLength
            // 
            this.rBtnLength.AutoSize = true;
            this.rBtnLength.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnLength.ForeColor = System.Drawing.Color.DarkKhaki;
            this.rBtnLength.Location = new System.Drawing.Point(7, 44);
            this.rBtnLength.Name = "rBtnLength";
            this.rBtnLength.Size = new System.Drawing.Size(135, 22);
            this.rBtnLength.TabIndex = 1;
            this.rBtnLength.TabStop = true;
            this.rBtnLength.Text = "Longitud (mts a pies).";
            this.rBtnLength.UseVisualStyleBackColor = true;
            // 
            // rBtnWeigth
            // 
            this.rBtnWeigth.AutoSize = true;
            this.rBtnWeigth.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnWeigth.ForeColor = System.Drawing.Color.Olive;
            this.rBtnWeigth.Location = new System.Drawing.Point(7, 68);
            this.rBtnWeigth.Name = "rBtnWeigth";
            this.rBtnWeigth.Size = new System.Drawing.Size(103, 22);
            this.rBtnWeigth.TabIndex = 2;
            this.rBtnWeigth.TabStop = true;
            this.rBtnWeigth.Text = "Peso (kg a oz).";
            this.rBtnWeigth.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(6, 91);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(112, 91);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 18);
            this.lblValue.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Thistle;
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(191, 14);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmQSE_Practica6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(300, 154);
            this.Controls.Add(this.grbForm);
            this.Name = "frmQSE_Practica6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQSE_Practica6";
            this.grbForm.ResumeLayout(false);
            this.grbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbForm;
        private System.Windows.Forms.RadioButton rBtnWeigth;
        private System.Windows.Forms.RadioButton rBtnLength;
        private System.Windows.Forms.RadioButton rBtnTemp;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnConvert;
    }
}

