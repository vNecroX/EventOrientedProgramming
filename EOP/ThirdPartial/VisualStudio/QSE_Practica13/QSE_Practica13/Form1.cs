using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica13
{
    public partial class frmQSE_Practica13 : Form
    {
        public frmQSE_Practica13()
        {
            InitializeComponent();
            serialPortArduino.PortName = "COM3";
            serialPortArduino.BaudRate = 9600;
            serialPortArduino.Open();
        }

        string status;

        private void btnOn_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = false;
            btnOff.Enabled = true;

            serialPortArduino.Write("1");
            status = "ON!";
            ledStatus(status);
            pictureBox1.Image = Properties.Resources.purple_led_on;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOff.Enabled = false;
            btnOn.Enabled = true;

            serialPortArduino.Write("0");
            status = "OFF!";
            ledStatus(status);
            pictureBox1.Image = Properties.Resources.purple_led_off;
        }

        private void frmQSE_Practica13_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortArduino.IsOpen)
                serialPortArduino.Close();
        }

        public void ledStatus(string s)
        {
            txtStatus.Text = "Led is " + s;
        }
    }
}
