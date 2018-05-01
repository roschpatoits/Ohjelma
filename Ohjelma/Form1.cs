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
   /*         int Peta = 15;
            int Tera = 12;
            int Giga = 9;
            int Mega = 6;
            int kilo = 3;
            int hehto = 2;
            int deka = 1;
            int desi = -1;
            int sentti = -2;
            int milli = -3;
            int mikro = -6;
            int nano = -9;
            int piko = -12;
            int femto = -15;
    */        

        }


        private void Valikko_SelectedIndexChanged(object sender, EventArgs e)
        {
            VastausLaatikko.Text = Valikko.Text;
        }


        private void Laatikko_TextChanged(object sender, EventArgs e)
        {
            if(Muunnos.Modified == true)
            {
                Refresh();
            }


            int[] potenssi = new int[14];
            Taulukoi(potenssi);
            string[] merkit = new string[14];
            Merkitse(merkit);

            double arvo = double.Parse(Laatikko.Text);

            int a = 0;

            for(int i = 0; i < potenssi.Length; i++)
            {
                if (EtuValikkoVastaus.Text.Equals(merkit[i]))
                {
                    a = potenssi[i];
                    break;
                }
            }

            double arvoMetri = arvo * Math.Pow(10, (-1 * a));

            Muunnos.Text = arvoMetri + "";


        }


        private void Taulukoi(int[] taulukko)
        {
            int i = 0;
            taulukko[i] = 15; i++;
            taulukko[i] = 12; i++;
            taulukko[i] = 9; i++;
            taulukko[i] = 6; i++;
            taulukko[i] = 3; i++;
            taulukko[i] = 2; i++;
            taulukko[i] = 1; i++;
            taulukko[i] = -1; i++;
            taulukko[i] = -2; i++;
            taulukko[i] = -3; i++;
            taulukko[i] = -6; i++;
            taulukko[i] = -9; i++;
            taulukko[i] = -12; i++;
            taulukko[i] = -15;
            return;
        }


        private void Merkitse(string[] merkit)
        {
            int i = 0;
            merkit[i] = "Peta"; i++;
            merkit[i] = "Tera"; i++;
            merkit[i] = "Giga"; i++;
            merkit[i] = "Mega"; i++;
            merkit[i] = "kilo"; i++;
            merkit[i] = "hehto"; i++;
            merkit[i] = "deka"; i++;
            merkit[i] = "desi"; i++;
            merkit[i] = "sentti"; i++;
            merkit[i] = "milli"; i++;
            merkit[i] = "mikro"; i++;
            merkit[i] = "nano"; i++;
            merkit[i] = "piko"; i++;
            merkit[i] = "femto";
            return;
        }


    }
}
