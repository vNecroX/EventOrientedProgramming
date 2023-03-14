using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica1
{
    public partial class frmQSE_Practica1 : Form
    {
        public frmQSE_Practica1()
        {
            InitializeComponent();
        }

        string lblText = "Esteban Quintero Sotomayor.\n 3.\n P.\n Desarrollo de Software.";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lblData.Text = lblText;
            btnExit.Enabled = true;
            btnExit.ForeColor = Color.Honeydew;
        }
    }
}
