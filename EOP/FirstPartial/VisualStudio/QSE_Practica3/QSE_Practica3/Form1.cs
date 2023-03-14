using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica3
{
    public partial class frmQSE_Practica3 : Form
    {
        public frmQSE_Practica3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int mValue, eValue, sValue;
            bool mFlag, eFlag, sFlag;
            string subject;

            double average;

            mValue = Int32.Parse(txtMath.Text);
            eValue = Int32.Parse(txtEnglish.Text);
            sValue = Int32.Parse(txtSpanish.Text);

            if ((mValue < 0) || (mValue > 100))
            {
                subject = "Matemáticas";
                txtMsgValidation(subject);
                txtMath.Text = null;
                mFlag = false;
            }
            else
                mFlag = true;

            if ((eValue < 0) || (eValue > 100))
            {
                subject = "Inglés";
                txtMsgValidation(subject);
                txtEnglish.Text = null;
                eFlag = false;
            }
            else
                eFlag = true;

            if ((sValue < 0) || (sValue > 100))
            {
                subject = "Español";
                txtMsgValidation(subject);
                txtSpanish.Text = null;
                sFlag = false;
            }
            else
                sFlag = true;

            if(mFlag && eFlag && sFlag)
            {
                average = mValue + eValue + sValue;
                average /= 3;
                MessageBox.Show("El promedio del alumno/a es de " + average.ToString(), "Promedio!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void txtMsgValidation(string s)
        {
            MessageBox.Show("La calificación de " + s + " esta fuera de rango, favor de ingresarla nuevamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
