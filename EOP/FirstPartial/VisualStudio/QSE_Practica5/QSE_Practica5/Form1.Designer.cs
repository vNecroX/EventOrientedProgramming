namespace QSE_Practica5
{
    partial class frmQSE_Practica5
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
            this.hsbFirPartial = new System.Windows.Forms.HScrollBar();
            this.hsbSecPartial = new System.Windows.Forms.HScrollBar();
            this.hsbThiPartial = new System.Windows.Forms.HScrollBar();
            this.txtFirPartial = new System.Windows.Forms.TextBox();
            this.txtSecPartial = new System.Windows.Forms.TextBox();
            this.txtThiPartial = new System.Windows.Forms.TextBox();
            this.lblFirPartial = new System.Windows.Forms.Label();
            this.lblSecPartial = new System.Windows.Forms.Label();
            this.lblThiPartial = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsbFirPartial
            // 
            this.hsbFirPartial.LargeChange = 1;
            this.hsbFirPartial.Location = new System.Drawing.Point(30, 56);
            this.hsbFirPartial.Maximum = 10;
            this.hsbFirPartial.Name = "hsbFirPartial";
            this.hsbFirPartial.Size = new System.Drawing.Size(113, 17);
            this.hsbFirPartial.TabIndex = 0;
            this.hsbFirPartial.ValueChanged += new System.EventHandler(this.hsbFirPartial_ValueChanged);
            // 
            // hsbSecPartial
            // 
            this.hsbSecPartial.LargeChange = 1;
            this.hsbSecPartial.Location = new System.Drawing.Point(150, 56);
            this.hsbSecPartial.Maximum = 10;
            this.hsbSecPartial.Name = "hsbSecPartial";
            this.hsbSecPartial.Size = new System.Drawing.Size(113, 17);
            this.hsbSecPartial.TabIndex = 1;
            this.hsbSecPartial.ValueChanged += new System.EventHandler(this.hsbSecPartial_ValueChanged);
            // 
            // hsbThiPartial
            // 
            this.hsbThiPartial.LargeChange = 1;
            this.hsbThiPartial.Location = new System.Drawing.Point(270, 56);
            this.hsbThiPartial.Maximum = 10;
            this.hsbThiPartial.Name = "hsbThiPartial";
            this.hsbThiPartial.Size = new System.Drawing.Size(113, 17);
            this.hsbThiPartial.TabIndex = 2;
            this.hsbThiPartial.ValueChanged += new System.EventHandler(this.hsbThiPartial_ValueChanged);
            // 
            // txtFirPartial
            // 
            this.txtFirPartial.Enabled = false;
            this.txtFirPartial.Location = new System.Drawing.Point(30, 33);
            this.txtFirPartial.Name = "txtFirPartial";
            this.txtFirPartial.Size = new System.Drawing.Size(113, 20);
            this.txtFirPartial.TabIndex = 3;
            // 
            // txtSecPartial
            // 
            this.txtSecPartial.Enabled = false;
            this.txtSecPartial.Location = new System.Drawing.Point(150, 32);
            this.txtSecPartial.Name = "txtSecPartial";
            this.txtSecPartial.Size = new System.Drawing.Size(113, 20);
            this.txtSecPartial.TabIndex = 4;
            // 
            // txtThiPartial
            // 
            this.txtThiPartial.Enabled = false;
            this.txtThiPartial.Location = new System.Drawing.Point(270, 32);
            this.txtThiPartial.Name = "txtThiPartial";
            this.txtThiPartial.Size = new System.Drawing.Size(113, 20);
            this.txtThiPartial.TabIndex = 5;
            // 
            // lblFirPartial
            // 
            this.lblFirPartial.AutoSize = true;
            this.lblFirPartial.Location = new System.Drawing.Point(50, 77);
            this.lblFirPartial.Name = "lblFirPartial";
            this.lblFirPartial.Size = new System.Drawing.Size(80, 13);
            this.lblFirPartial.TabIndex = 6;
            this.lblFirPartial.Text = "Parcial 1 (20%) ";
            // 
            // lblSecPartial
            // 
            this.lblSecPartial.AutoSize = true;
            this.lblSecPartial.Location = new System.Drawing.Point(170, 77);
            this.lblSecPartial.Name = "lblSecPartial";
            this.lblSecPartial.Size = new System.Drawing.Size(80, 13);
            this.lblSecPartial.TabIndex = 7;
            this.lblSecPartial.Text = "Parcial 2 (35%) ";
            // 
            // lblThiPartial
            // 
            this.lblThiPartial.AutoSize = true;
            this.lblThiPartial.Location = new System.Drawing.Point(289, 77);
            this.lblThiPartial.Name = "lblThiPartial";
            this.lblThiPartial.Size = new System.Drawing.Size(80, 13);
            this.lblThiPartial.TabIndex = 8;
            this.lblThiPartial.Text = "Parcial 3 (45%) ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(150, 119);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 40);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmQSE_Practica5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(418, 188);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblThiPartial);
            this.Controls.Add(this.lblSecPartial);
            this.Controls.Add(this.lblFirPartial);
            this.Controls.Add(this.txtThiPartial);
            this.Controls.Add(this.txtSecPartial);
            this.Controls.Add(this.txtFirPartial);
            this.Controls.Add(this.hsbThiPartial);
            this.Controls.Add(this.hsbSecPartial);
            this.Controls.Add(this.hsbFirPartial);
            this.Name = "frmQSE_Practica5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQSE_Practica5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbFirPartial;
        private System.Windows.Forms.HScrollBar hsbSecPartial;
        private System.Windows.Forms.HScrollBar hsbThiPartial;
        private System.Windows.Forms.TextBox txtFirPartial;
        private System.Windows.Forms.TextBox txtSecPartial;
        private System.Windows.Forms.TextBox txtThiPartial;
        private System.Windows.Forms.Label lblFirPartial;
        private System.Windows.Forms.Label lblSecPartial;
        private System.Windows.Forms.Label lblThiPartial;
        private System.Windows.Forms.Button btnCalculate;
    }
}

