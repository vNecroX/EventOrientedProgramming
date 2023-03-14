using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica12
{
    public partial class frmQSE_Practica12 : Form
    {
        public frmQSE_Practica12()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int[,] matrix = new int[3, 3];

        int i, j;
        int x, y;
        int a, b;

        Label[,] labels = new Label[3, 3];
        int range;

        int rCount = 0, yCount = 0, gCount = 0, bCount = 0; 
        char[,] state = new char[3, 3];

        private void frmQSE_Practica12_Load(object sender, EventArgs e)
        {
            labels[0, 0] = this.lbl0;
            labels[0, 1] = this.lbl1;
            labels[0, 2] = this.lbl2;
            labels[1, 0] = this.lbl3;
            labels[1, 1] = this.lbl4;
            labels[1, 2] = this.lbl5;
            labels[2, 0] = this.lbl6;
            labels[2, 1] = this.lbl7;
            labels[2, 2] = this.lbl8;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    matrix[i, j] = random.Next(-1, 101);
                }
            }
            assignColor();
            timer1.Start();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Refrigeration has been stopped!", "Advice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRefrigerate_Click(object sender, EventArgs e)
        {
            for(x=0; x<3; x++)
            {
                for(y=0; y<3; y++)
                {
                    if (rCount != 0 && state[x, y] == 'R')
                    {
                        matrix[x, y] -= 15;
                        rCount--;
                    }
                    else
                    {
                        if (yCount != 0 && state[x, y] == 'Y')
                        {
                            matrix[x, y] -= 10;

                            if (matrix[x, y] <= 69)
                                yCount--;
                        }
                        else
                        {
                            if (gCount != 0 && state[x, y] == 'G')
                            {
                                matrix[x, y] -= 5;

                                if (matrix[x, y] < 50)
                                    gCount--;
                            }
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            assignColor();
        }

        public void assignColor()
        {
            frozen();

            if (bCount == 9)
                btnRefrigerate.Enabled = false;
            else
                btnRefrigerate.Enabled = true;

            for(i=0; i<3; i++)
            {
                for(j=0; j<3; j++)
                {
                    range = matrix[i, j];
                    
                    if (range < 50)
                    {
                        range += 20;
                        labels[i, j].ForeColor = Color.Black;

                        if (range < 0)
                            range = 0;

                        state[i, j] = 'B';
                    }
                    else if (range >= 50 && range <= 69)
                    {
                        range += 10;
                        labels[i, j].ForeColor = Color.Green;

                        state[i, j] = 'G';
                        gCount++;
                    }
                    else if (range >= 70 && range <= 89)
                    {
                        range += 5;
                        labels[i, j].ForeColor = Color.DarkGoldenrod;

                        state[i, j] = 'Y';
                        yCount++;
                    }
                    else if (range >= 90)
                    {
                        range += 1;
                        labels[i, j].ForeColor = Color.Red;

                        if (range == 101)
                            range--;

                        state[i, j] = 'R';
                        rCount++;
                    }
                    labels[i, j].Text = range.ToString();
                    matrix[i, j] = range;
                }
            }
        }

        public void frozen()
        {
            for(a=0; a<3; a++)
            {
                for(b=0; b<3; b++)
                {
                    if (state[a, b] == 'B')
                        bCount++;
                }
            }
        }
    }
}
