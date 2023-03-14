namespace QSE_Practica2
{
    partial class frmQSE_Practica2
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
            this.lblIndicator = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Location = new System.Drawing.Point(226, 67);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(0, 17);
            this.lblIndicator.TabIndex = 0;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(16, 34);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(186, 22);
            this.txtWord.TabIndex = 1;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(256, 39);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(0, 17);
            this.lblFormat.TabIndex = 2;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(16, 82);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(118, 34);
            this.btnFormat.TabIndex = 3;
            this.btnFormat.Text = "Apply Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // frmQSE_Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(606, 147);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblIndicator);
            this.Name = "frmQSE_Practica2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQSE_Practica2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnFormat;
    }
}

