using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica4
{
    public partial class frmQSE_Practica4 : Form
    {
        public frmQSE_Practica4()
        {
            InitializeComponent();
        }

        bool isSecName = false;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string lastName1 = "", lastName2 = "", secName = "", firName = "", day = "", month = "", year = "", genre = "", entity= "", curp = "";
            
            lastName1 = txtLastName1.Text.Substring(0, 2);

            try
            {
                if (txtLastName2.Text != null)
                {
                    lastName2 = txtLastName2.Text.Substring(0, 1);
                }
            }
            catch { }

            try
            {
                if (txtSecName.Text != null)
                {
                    isSecName = true;
                    secName = txtSecName.Text.Substring(0, 1);
                }
            }
            catch
            {
                isSecName = false;
            }
            
            firName = txtFirName.Text.Substring(0, 1);

            day = txtDay.Text;
            month = txtMonth.Text;
            year = txtYear.Text;

            genre = txtGenre.Text.Substring(0, 1);

            entity = txtEntity.Text.Substring(0, 1);

            curp = lastName1 + lastName2;

            if(isSecName)
                curp += secName;
            else
                curp += firName;

            curp += year + month + day + genre + entity;

            lblCURP.Text = curp;
            Font lblFormat = new Font("Arial", 25);
            lblCURP.Font = lblFormat;
            lblCURP.ForeColor = Color.DarkSlateGray;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFirName.Text = null;

            if(isSecName)
                txtSecName.Text = null;

            txtLastName1.Text = null;
            txtLastName2.Text = null;
            txtDay.Text = null;
            txtMonth.Text = null;
            txtYear.Text = null;
            txtGenre.Text = null;
            txtEntity.Text = null;

            lblCURP.Text = null;
        }
    }
}
