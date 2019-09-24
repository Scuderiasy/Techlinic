using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_chart_plot_fix_axis
{
    public partial class Form1 : Form
    {
        double a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        double[] aa = new double[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            incoming_data_timer.Enabled = true;
            incoming_data_timer.Start();
        }

        private void incoming_data_timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int incoming_data = random.Next(1, 20);
            /*
            a1 = a2;
            a2 = a3;
            a3 = a4;
            a4 = a5;
            a5 = a6;
            a6 = a7;
            a7 = a8;
            a8 = a9;
            a9 = a10;
            a10 = incoming_data;

            this.chart1.Series["Series1"].Points.Clear();

            this.chart1.Series["Series1"].Points.AddXY(1, a1);
            this.chart1.Series["Series1"].Points.AddXY(2, a2);
            this.chart1.Series["Series1"].Points.AddXY(3, a3);
            this.chart1.Series["Series1"].Points.AddXY(4, a4);
            this.chart1.Series["Series1"].Points.AddXY(5, a5);
            this.chart1.Series["Series1"].Points.AddXY(6, a6);
            this.chart1.Series["Series1"].Points.AddXY(7, a7);
            this.chart1.Series["Series1"].Points.AddXY(8, a8);
            this.chart1.Series["Series1"].Points.AddXY(9, a9);
            this.chart1.Series["Series1"].Points.AddXY(10, a10);
            */
            
            /*
            aa[0] = aa[1];
            aa[1] = aa[2];
            aa[2] = aa[3];
            aa[3] = aa[4];
            aa[4] = aa[5];
            aa[5] = aa[6];
            aa[6] = aa[7];
            aa[7] = aa[8];
            aa[8] = aa[9];
            aa[9] = incoming_data;
            */

            
            for (int bb = 0; bb < 9; bb++)
            {
                aa[bb] = aa[bb + 1];
            }

            aa[9] = incoming_data;

            this.chart1.Series["Series1"].Points.Clear();

            for(int cc = 0; cc<=9; cc++)
            {
                this.chart1.Series["Series1"].Points.AddXY(cc + 1, aa[cc]);
            }
        }
    }
}
