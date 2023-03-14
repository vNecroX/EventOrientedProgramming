using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica6
{
    public partial class frmQSE_Practica6 : Form
    {
        public frmQSE_Practica6()
        {
            InitializeComponent();
        }

        double value, conv;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            value = Double.Parse(txtValue.Text);

            if (rBtnTemp.Checked)
            {
                conv = value - 273.15;
                lblValue.Text = "K = " + conv.ToString() + " C";
            }

            if (rBtnLength.Checked)
            {
                conv = value * 3.281;
                lblValue.Text = "mts = " + conv.ToString() + " pies";
            }

            if(rBtnWeigth.Checked)
            {
                conv = value * 35.274;
                lblValue.Text = "kg = " + conv.ToString() + " oz";
            }
        }
    }
}
