using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica5
{
    public partial class frmQSE_Practica5 : Form
    {
        public frmQSE_Practica5()
        {
            InitializeComponent();
        }

        double valueFirPartial, valueSecPartial, valueThiPartial, average;
        string msg;

        private void hsbFirPartial_ValueChanged(object sender, EventArgs e)
        {
            txtFirPartial.Text = hsbFirPartial.Value.ToString();
        }

        private void hsbSecPartial_ValueChanged(object sender, EventArgs e)
        {
            txtSecPartial.Text = hsbSecPartial.Value.ToString();
        }

        private void hsbThiPartial_ValueChanged(object sender, EventArgs e)
        {
            txtThiPartial.Text = hsbThiPartial.Value.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            valueFirPartial = Double.Parse(txtFirPartial.Text);
            valueSecPartial = Double.Parse(txtSecPartial.Text);
            valueThiPartial = Double.Parse(txtThiPartial.Text);

            valueFirPartial *= .02;
            valueSecPartial *= .035;
            valueThiPartial *= .045;

            average = valueFirPartial + valueSecPartial + valueThiPartial;
            average /= .1;

            if (average > 6.9)
                msg = "Aprobado!";
            else
                msg = "Reprobado!";

            averageMsg(average, msg);
        }

        void averageMsg(double d, string s)
        {
            MessageBox.Show("Promedio final: " + d.ToString(), msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
