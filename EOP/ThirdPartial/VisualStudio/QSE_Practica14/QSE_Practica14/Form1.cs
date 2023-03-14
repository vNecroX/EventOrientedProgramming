using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica14
{
    public partial class frmQSE_Practica14 : Form
    {
        public frmQSE_Practica14()
        {
            InitializeComponent();
            serialPortArduino.PortName = "COM3";
            serialPortArduino.BaudRate = 9600;
            serialPortArduino.Open();
        }

        int secsGR, auxSecsGR;
        int flagGR = 1;
        int secsY, auxsecsY;

        private void frmQSE_Practica14_Load(object sender, EventArgs e)
        {
            tmr1.Enabled = false;
            tmr2.Enabled = false;

            tmr1.Interval = 1000;
            tmr2.Interval = 1000;

            picSemaphore.Image = Properties.Resources.Off;

            lblMsg.Text = "SEMÁFORO APAGADO";

            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            picSemaphore.Image = Properties.Resources.Green;
            serialPortArduino.Write("1");

            secsGR = (int)nudGreenRed.Value;
            secsGR *= 60;
            auxSecsGR = secsGR;

            secsY = (int)nudYellow.Value;
            auxsecsY = secsY;

            nudGreenRed.Enabled = false;
            nudYellow.Enabled = false;

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            tmr1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            tmr2.Stop();

            lblMsg.Text = "SEMAFORO APAGADO";

            nudGreenRed.Enabled = true;
            nudYellow.Enabled = true;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            picSemaphore.Image = Properties.Resources.Off;
            serialPortArduino.Write("4");
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            secsGR--;
            lblMsg.Text = secsGR.ToString();

            if (secsGR == 0)
            {
                if(flagGR == 0)
                {
                    flagGR++;

                    picSemaphore.Image = Properties.Resources.Green;
                    serialPortArduino.Write("1");
                    secsGR = auxSecsGR;

                    tmr1.Stop();
                    tmr1.Start();

                }
                else
                {
                    picSemaphore.Image = Properties.Resources.Yellow;
                    serialPortArduino.Write("2");
                    secsY = auxsecsY;

                    tmr1.Stop();
                    tmr2.Start();
                }
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            secsY--;
            lblMsg.Text = secsY.ToString();

            if (secsY == 0)
            {
                flagGR--;

                picSemaphore.Image = Properties.Resources.Red;
                serialPortArduino.Write("0");
                secsGR = auxSecsGR;

                tmr2.Stop();
                tmr1.Start();
            }
        }

        private void frmQSE_Practica14_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortArduino.IsOpen)
                serialPortArduino.Close();
        }
    }
}
