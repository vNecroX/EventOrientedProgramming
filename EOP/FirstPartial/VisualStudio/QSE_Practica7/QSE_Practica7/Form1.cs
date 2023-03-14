using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSE_Practica7
{
    public partial class frmQSE_Practica7 : Form
    {
        public frmQSE_Practica7()
        {
            InitializeComponent();
        }

        double salary, salaryH, exSalaryH, totalSalary, taxes, netIncome;

        int hWorked, extraHoursW;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            salary = Double.Parse(txtSalary.Text);
            hWorked = Int32.Parse(txtHours.Text);

            extraHoursW = hWorked - 40;
            if (extraHoursW > 0)
            {
                txtExtraH.Text = extraHoursW.ToString();

                salaryH = 40 * salary;
                txtSalaryH.Text = salaryH.ToString();

                exSalaryH = extraHoursW * salary * 2;
                txtExSalaryH.Text = exSalaryH.ToString();

                totalSalary = salaryH + exSalaryH;
                taxes = totalSalary * .1;
                txtTaxes.Text = taxes.ToString();

                netIncome = totalSalary - taxes;
                txtNetIncome.Text = netIncome.ToString();
            }
            else if (extraHoursW <= 0)
            {
                extraHoursW = 0;
                txtExtraH.Text = "0";

                salaryH = salary * hWorked;
                txtSalaryH.Text = salaryH.ToString();

                txtExSalaryH.Text = "0";

                taxes = salaryH * .1;
                txtTaxes.Text = taxes.ToString();

                netIncome = salaryH - taxes;
                txtNetIncome.Text = netIncome.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtSalary.Text = null;
            txtHours.Text = null;
            txtExtraH.Text = null;
            txtSalaryH.Text = null;
            txtExSalaryH.Text = null;
            txtTaxes.Text = null;
            txtNetIncome.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
