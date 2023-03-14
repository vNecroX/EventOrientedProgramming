using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica8
{
    public partial class frmQSE_Practica8 : Form
    {
        public frmQSE_Practica8()
        {
            InitializeComponent();
        }

        int low, up, index;
        int numOne, numTwo, result;
        double divResult;

        string op;

        private void frmQSE_Practica8_Load(object sender, EventArgs e)
        {
            cmbOp.DataSource = new[]
            {
                "+",
                "-",
                "*",
                "/"
            };
            cmbOp.Text = null;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            low = Int32.Parse(txtLow.Text);
            up = Int32.Parse(txtUp.Text);

            index = low;
            if (rBtnP.Checked)
            {
                if ((low % 2) != 0)
                    index++;

                fillNumCmb(index, up);
            }
            else if (rBtnI.Checked)
            {
                if ((low % 2) == 0)
                    index++;

                fillNumCmb(index, up);
            }
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            double auxNumOne, auxNumTwo;
            numOne = Int32.Parse(cmbNum1.Text);
            numTwo = Int32.Parse(cmbNum2.Text);

            txtResult.BackColor = Color.Gold;

            op = cmbOp.Text;
            if (op == "+")
            {
                result = numOne + numTwo;
                txtResult.Text = "La suma de " + numOne.ToString() + " + " + numTwo.ToString() + " = " + result.ToString();
            }
            else if (op == "-")
            {
                result = numOne - numTwo;
                txtResult.Text = "La resta de " + numOne.ToString() + " - " + numTwo.ToString() + " = " + result.ToString();
            }
            else if (op == "*")
            {
                result = numOne * numTwo;
                txtResult.Text = "La multiplicación de " + numOne.ToString() + " * " + numTwo.ToString() + " = " + result.ToString();
            }
            else if (op == "/")
            {
                auxNumOne = Convert.ToDouble(numOne);
                auxNumTwo = Convert.ToDouble(numTwo);

                divResult = auxNumOne / auxNumTwo;
                txtResult.Text = "La división de " + numOne.ToString() + " / " + numTwo.ToString() + " = " + divResult.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLow.Text = null;
            txtUp.Text = null;

            rBtnP.Checked = false;
            rBtnI.Checked = false;

            cmbNum1.Items.Clear();
            cmbNum1.Text = null;
            //cmbOp.Items.Clear();
            cmbOp.Text = null;
            cmbNum2.Items.Clear();
            cmbNum2.Text = null;

            txtResult.BackColor = SystemColors.Window;
            txtResult.Text = null;
            
        }

        void fillNumCmb(int i, int u)
        {
            for (; i <= u;)
            {
                cmbNum1.Items.Add(i);
                cmbNum2.Items.Add(i);
                i += 2;
            }
        } 
    }
}
