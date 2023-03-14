using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica9
{
    public partial class frmQSE_Practica9 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        
        Label firstClicked = null;
        Label secondClicked = null; 

        public frmQSE_Practica9()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl14_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void tmr1_Tick(object sender, EventArgs e)
        { 
            tmr1.Stop();
            
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIconsToSquares()
        {

            foreach (Control control in tlp.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        public void lblClick(object sender)
        {
            if (tmr1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                tmr1.Start();
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tlp.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            
            MessageBox.Show("You matched all the icons!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }
    }
}
