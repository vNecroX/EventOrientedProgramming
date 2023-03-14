using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QSE_Practica11
{
    public partial class frmQSE_Practica11 : Form
    {
        public frmQSE_Practica11()
        {
            InitializeComponent();
        }

        string[] names = { "Esteban", "Ama", "Gisel", "Montse" };
        int[] age = { 21, 15, 21, 20 };

        private void frmQSE_Practica11_Load(object sender, EventArgs e)
        {
            chart1.Palette = ChartColorPalette.Light;
            chart1.Titles.Add("Edades.");

            for(int x=0; x<names.Length; x++)
            {
                Series serie = chart1.Series.Add(names[x]);
                serie.ChartType = SeriesChartType.Column;
                serie.Points.Add(age[x]);
                serie.Label = age[x].ToString();
            }
        }
    }
}
