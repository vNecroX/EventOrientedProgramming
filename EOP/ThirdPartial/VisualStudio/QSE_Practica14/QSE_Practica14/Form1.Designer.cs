namespace QSE_Practica14
{
    partial class frmQSE_Practica14
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
            this.components = new System.ComponentModel.Container();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picSemaphore = new System.Windows.Forms.PictureBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudYellow = new System.Windows.Forms.NumericUpDown();
            this.nudGreenRed = new System.Windows.Forms.NumericUpDown();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaphore)).BeginInit();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenRed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(20, 150);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(70, 25);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "label1";
            // 
            // picSemaphore
            // 
            this.picSemaphore.Image = global::QSE_Practica14.Properties.Resources.Off;
            this.picSemaphore.InitialImage = null;
            this.picSemaphore.Location = new System.Drawing.Point(341, 29);
            this.picSemaphore.Name = "picSemaphore";
            this.picSemaphore.Size = new System.Drawing.Size(219, 318);
            this.picSemaphore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaphore.TabIndex = 4;
            this.picSemaphore.TabStop = false;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.lblMsg);
            this.grpControls.Controls.Add(this.lblRed);
            this.grpControls.Controls.Add(this.lblYellow);
            this.grpControls.Controls.Add(this.lblGreen);
            this.grpControls.Controls.Add(this.lblSeconds);
            this.grpControls.Controls.Add(this.lblMinutes);
            this.grpControls.Controls.Add(this.btnStop);
            this.grpControls.Controls.Add(this.btnStart);
            this.grpControls.Controls.Add(this.nudYellow);
            this.grpControls.Controls.Add(this.nudGreenRed);
            this.grpControls.Location = new System.Drawing.Point(11, 29);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(309, 318);
            this.grpControls.TabIndex = 3;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controles";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(22, 66);
            this.lblRed.MinimumSize = new System.Drawing.Size(35, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(35, 17);
            this.lblRed.TabIndex = 7;
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.BackColor = System.Drawing.Color.Gold;
            this.lblYellow.Location = new System.Drawing.Point(22, 96);
            this.lblYellow.MinimumSize = new System.Drawing.Size(35, 0);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(35, 17);
            this.lblYellow.TabIndex = 6;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.lblGreen.Location = new System.Drawing.Point(22, 49);
            this.lblGreen.MinimumSize = new System.Drawing.Size(35, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(35, 17);
            this.lblGreen.TabIndex = 5;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(211, 96);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(72, 17);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "Segundos";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(211, 49);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(57, 17);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Minutos";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(68, 264);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Finalizar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(68, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudYellow
            // 
            this.nudYellow.Location = new System.Drawing.Point(74, 94);
            this.nudYellow.Name = "nudYellow";
            this.nudYellow.Size = new System.Drawing.Size(120, 22);
            this.nudYellow.TabIndex = 1;
            // 
            // nudGreenRed
            // 
            this.nudGreenRed.Location = new System.Drawing.Point(74, 47);
            this.nudGreenRed.Name = "nudGreenRed";
            this.nudGreenRed.Size = new System.Drawing.Size(120, 22);
            this.nudGreenRed.TabIndex = 0;
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // tmr2
            // 
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.PortName = "COM3";
            // 
            // frmQSE_Practica14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 357);
            this.Controls.Add(this.picSemaphore);
            this.Controls.Add(this.grpControls);
            this.Name = "frmQSE_Practica14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQSE_Practica14";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQSE_Practica14_FormClosing);
            this.Load += new System.EventHandler(this.frmQSE_Practica14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaphore)).EndInit();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picSemaphore;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudYellow;
        private System.Windows.Forms.NumericUpDown nudGreenRed;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr2;
        private System.IO.Ports.SerialPort serialPortArduino;
    }
}

