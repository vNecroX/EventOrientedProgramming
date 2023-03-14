using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica10
{
    public partial class frmQSE_Practica10 : Form
    {
        int mins, secs, flag;

        public frmQSE_Practica10()
        {
            InitializeComponent();
        }

        private void frmQSE_Practica10_Load(object sender, EventArgs e)
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
            flag = 1;

            picSemaphore.Image = Properties.Resources.Green;

            mins = (int)nudGreenRed.Value;
            secs = (int)nudYellow.Value;

            mins *= 60;

            tmr1.Start();

            nudGreenRed.Enabled = false;
            nudYellow.Enabled = false;

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            lblGreen.Visible = true;
            lblRed.Visible = true;
            lblYellow.Visible = true;
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

            lblGreen.Visible = false;
            lblRed.Visible = false;
            lblYellow.Visible = false;

            picSemaphore.Image = Properties.Resources.Off;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            mins--;
            lblMsg.Text = mins.ToString();

            if(mins == 0)
            {
                flag++;
                if(flag == 1)
                {
                    picSemaphore.Image = Properties.Resources.Green;

                    mins = (int)nudGreenRed.Value;
                    mins *= 60;

                    tmr2.Start();
                }

                if (flag == 2)
                { 
                    picSemaphore.Image = Properties.Resources.Yellow;

                    tmr2.Start();
                    tmr1.Stop();
                }
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            secs--;
            lblMsg.Text = secs.ToString();

            if(secs == 0)
            {
                flag++;
                if(flag == 3)
                {
                    picSemaphore.Image = Properties.Resources.Red;
                
                    mins = (int)nudGreenRed.Value;
                    mins *= 60;

                    flag = 1;

                    tmr1.Start();
                }

                tmr2.Stop();
                secs = (int)nudYellow.Value;
            }
        }
    }
}
