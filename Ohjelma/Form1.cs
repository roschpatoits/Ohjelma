using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelma
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ///pöö
            /////pöö
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int lisa = 23;
            if (bar1.Value + lisa > 100)
            {
                bar1.Value = 0;
            }
            else bar1.Value += lisa;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int lisa = 12;
            int lisa1 = 2;
            int lisa2 = 5;

            if (bar1.Value + lisa > 100)
            {
                bar1.Value = 0;
            }
            else bar1.Value += lisa;

            if (bar2.Value + lisa1 > 100)
            {
                bar2.Value = 0;
            }
            else bar2.Value += lisa1;

            if (bar3.Value + lisa2 > 100)
            {
                bar3.Value = 0;
            }
            else bar3.Value += lisa2;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int lisa = 10;
            int lisa1 = 6;
            int lisa2 = 3;
            int lisa3 = 6;

            if (bar4.Value + lisa > 100)
            {
                bar4.Value = 0;
            }
            else bar4.Value += lisa;

            if (bar3.Value + lisa1 > 100)
            {
                bar3.Value = 0;
            }
            else bar3.Value += lisa1;

            if (bar5.Value + lisa2 > 100)
            {
                bar5.Value = 0;
            }
            else bar5.Value += lisa2;

            if (bar2.Value + lisa3 > 100)
            {
                bar2.Value = 0;
            }
            else bar2.Value += lisa3;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int lisa = 2;
            int lisa1 = 1;
            int lisa2 = 10;

            if (bar1.Value + lisa > 100)
            {
                bar1.Value = 0;
            }
            else bar1.Value += lisa;

            if (bar3.Value + lisa1 > 100)
            {
                bar3.Value = 0;
            }
            else bar3.Value += lisa1;

            if (bar5.Value + lisa2 > 100)
            {
                bar5.Value = 0;
            }
            else bar5.Value += lisa2;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int lisa = 4;
            int lisa1 = 12;

            if (bar3.Value + lisa > 100)
            {
                bar3.Value = 0;
            }
            else bar3.Value += lisa;

            if (bar6.Value + lisa1 > 100)
            {
                bar6.Value = 0;
            }
            else bar6.Value += lisa1;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            int lisa = 14;
            int lisa1 = 7;
            int lisa2 = 8;

            if (bar3.Value + lisa > 100)
            {
                bar3.Value = 0;
            }
            else bar3.Value += lisa;

            if (bar4.Value + lisa1 > 100)
            {
                bar4.Value = 0;
            }
            else bar4.Value += lisa1;

            if (bar6.Value + lisa2 > 100)
            {
                bar6.Value = 0;
            }
            else bar6.Value += lisa2;
        }


        private void LaatikkoF_TextChanged(object sender, EventArgs e)
        {

            double F = double.Parse(LaatikkoF.Text);
            double C = (F - 32) / 1.8;
            if (F != null)
            {
                LaatikkoC.Text = Math.Round(C, 2) + "";
            }
            else C.Equals(null);
            if (C < -273)
            {
                LaatikkoVirheF.Text = "Arvo alittaa absoluuttisen nollapisteen";
            }
            else LaatikkoVirheF.Text = "";
        }


        private void LaatikkoM_TextChanged(object sender, EventArgs e)
        {
            double M = double.Parse(LaatikkoM.Text);
            double mm = M * Math.Pow(10, 3);

            LaatikkoMM.Text = mm + "";
        }


        private void LaatikkoMM2_TextChanged(object sender, EventArgs e)
        {
            double mm = double.Parse(LaatikkoMM2.Text);
            double M = mm * Math.Pow(10, -3);

            LaatikkoM2.Text = M + "";
        }


        private void EtuValikko_SelectedIndexChanged(object sender, EventArgs e)
        {
            int P = 15;
            int T = 12;
            int G = 9;
            int M = 6;
            int k = 3;
            int h = 2;
            int da = 1;
            int d = -1;
            int c = -2;
            int m = -3;
            int μ = -6;
            int n = -9;
            int p = -12;
            int f = -15;
            


        }


        private void Valikko_SelectedIndexChanged(object sender, EventArgs e)
        {
            VastausLaatikko.Text = Valikko.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int P = 15;
            int T = 12;
            int G = 9;
            int M = 6;
            int k = 3;
            int h = 2;
            int da = 1;
            int d = -1;
            int c = -2;
            int m = -3;
            int μ = -6;
            int n = -9;
            int p = -12;
            int f = -15;

            double arvo = double.Parse(textBox2.Text);

            int i = 0;

            double arvoMuutettu = Math.Pow(10, i);


            //      double M = EtuValikko.Text;

            //   double arvoM = Math.Pow(10, M);


            Muunnos.Text = arvoMuutettu + "";

        }


    }
}
