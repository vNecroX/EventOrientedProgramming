using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica2
{
    public partial class frmQSE_Practica2 : Form
    {
        public frmQSE_Practica2()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (txtWord.Text == "")
                MessageBox.Show("El campo de texto no puede estar vacio!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lblIndicator.Text = "->";
                lblFormat.Text = txtWord.Text;
                Font auxLblFormat = new Font("Verdana", 28);
                lblFormat.Font = auxLblFormat;
                lblFormat.ForeColor = Color.DarkCyan;
            }
        }
    }
}
