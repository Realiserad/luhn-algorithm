using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Miniräknare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Random GenerateDigits = new Random();
            if (year.Text == "")
            {  
                year.Text = Convert.ToString(GenerateDigits.Next(1900, 2012));
            }
            if (month.Text == "")
            {
                int monthDigit = GenerateDigits.Next(1,13);
                if (monthDigit >= 10)
                {
                    month.Text = Convert.ToString(monthDigit);
                }
                else
                {
                    month.Text = "0" + Convert.ToString(monthDigit);
                }

            }
            if (day.Text == "")
            {
                int dayDigit = GenerateDigits.Next(1,29);
                if (dayDigit >= 10)
                {
                    day.Text = Convert.ToString(dayDigit);
                }
                else
                {
                    day.Text = "0" + Convert.ToString(dayDigit);
                }
            }
            if (province.Text == "")
            {
                int provinceDigit = GenerateDigits.Next(1, 26);
                if (provinceDigit >= 10)
                {
                    province.Text = Convert.ToString(provinceDigit);
                }
                else
                {
                    province.Text = "0" + Convert.ToString(provinceDigit);
                }
            }
            if (gender.Text == "")
            {
                gender.Text = Convert.ToString("1");
            }
            //Räkna ut kontrollsiffra med Luhnalgoritmen
            string digits = year.Text + month.Text + day.Text + province.Text + gender.Text;
            int x1 = Convert.ToInt16(digits[0].ToString());
            int x2 = Convert.ToInt16(digits[1].ToString());
            int x3 = Convert.ToInt16(digits[2].ToString());
            int x4 = Convert.ToInt16(digits[3].ToString());
            int x5 = Convert.ToInt16(digits[4].ToString());
            int x6 = Convert.ToInt16(digits[5].ToString());
            int x7 = Convert.ToInt16(digits[6].ToString());
            int x8 = Convert.ToInt16(digits[7].ToString());
            int x9 = Convert.ToInt16(digits[8].ToString());
            x1 = x1 * 2;
            if (x1 > 9)
            {
                x1 = x1 - 9;
            }
            x2 = x2 * 1;
            if (x2 > 9)
            {
                x2 = x2 - 9;
            }
            x3 = x3 * 2;
            if (x3 > 9)
            {
                x3 = x3 - 9;
            }
            x4 = x4 * 1;
            if (x4 > 9)
            {
                x4 = x4 - 9;
            }
            x5 = x5 * 2;
            if (x5 > 9)
            {
                x5 = x5 - 9;
            }
            x6 = x6 * 1;
            if (x6 > 9)
            {
                x6 = x6 - 9;
            }
            x7 = x7 * 2;
            if (x7 > 9)
            {
                x7 = x7 - 9;
            }
            x8 = x8 * 1;
            if (x8 > 9)
            {
                x8 = x8 - 9;
            }
            x9 = x9 * 2;
            if (x9 > 9)
            {
                x9 = x9 - 9;
            }
            int checksum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9;
            string two_digits = Convert.ToString(checksum);
            int last_digit = Convert.ToInt16(two_digits[1].ToString());
            int x10 = 10 - last_digit;
            if (last_digit == 0)
            {
                x10 = 0;
            }
            check_digit.Text = Convert.ToString(x10);
            // Skapa färdigt personnummer
            string personnummer = year.Text + month.Text + day.Text + province.Text + gender.Text + Convert.ToString(x10);
            // Kopiera till klippbordet
            Clipboard.SetText(personnummer);
        }
        private void about_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Byggd i Microsoft Visual C# av Bastian.");
        }

        private void title_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kazaaa! Kazaaa!");
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            gender.Text = Convert.ToString("1");
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            gender.Text = Convert.ToString("2");
        }

        private void man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void empty_MouseClick(object sender, MouseEventArgs e)
        {
            // Töm fält
            year.Text = "";
            month.Text = "";
            day.Text = "";
            province.Text = "";
            gender.Text = "";
            check_digit.Text = "";
        }

        private void day_label_Click(object sender, EventArgs e)
        {

        }

        private void empty_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void s(object sender, EventArgs e)
        {

        }
    }
}
