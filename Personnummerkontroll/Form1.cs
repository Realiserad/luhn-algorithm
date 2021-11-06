using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personnummerkontroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;                    // Hämta inmatning
                int len = text.Length;                          // Beräkna strängens längd
                if (len == 12)                                  // Personnummret har rätt längd
                {
                    string personnummer = text.Substring(2, 10);// Extrahera tiosiffrigt personnummer

                    if (DateExists(personnummer))               // Datumet existerar
                    {
                        if (Validate(personnummer))             // Giltig kontrollsiffra
                        {
                            label1.Text = "Personnumret är giltigt.";

                            if (Man(personnummer))              // Kontrollera om personen är en man
                            {
                                label2.Text = "Personen är en man.";
                            }
                            else                                // Kvinna
                            {
                                label2.Text = "Personen är en kvinna.";
                            }

                            label3.Text = "Född en " + Day(text) + ".";

                            pictureBox1.Visible = true;
                        }
                        else
                        {
                            label1.Text = "Ogiltig kontrollsiffra.";
                            label2.Text = "";
                            label3.Text = "";
                            pictureBox2.Visible = true;
                        }
                    }
                    else                                        // Datumet existerar inte 
                    {
                        label1.Text = "Ogiltigt datum.";
                        label2.Text = "";
                        label3.Text = "";
                        pictureBox2.Visible = true;
                    }
                }
                else
                {
                    label1.Text = "";                           // Användaren har inte skrivit in hela personnumret
                    label2.Text = "";
                    label3.Text = "";
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                }
            }
            catch
            {
                
            }
        }
        bool Validate(string digits)                            // Kontrollera om kontrollsiffran är korrekt
        {
                                                                // Plocka ut varje siffra i strängen och lägg i en heltalsvariabel
            int x1 = Convert.ToInt16(digits[0].ToString());
            int x2 = Convert.ToInt16(digits[1].ToString());
            int x3 = Convert.ToInt16(digits[2].ToString());
            int x4 = Convert.ToInt16(digits[3].ToString());
            int x5 = Convert.ToInt16(digits[4].ToString());
            int x6 = Convert.ToInt16(digits[5].ToString());
            int x7 = Convert.ToInt16(digits[6].ToString());
            int x8 = Convert.ToInt16(digits[7].ToString());
            int x9 = Convert.ToInt16(digits[8].ToString());
            int x10 = Convert.ToInt16(digits[9].ToString());

                                                                // Multiplicera varannan siffra med 2, om talet
                                                                // blir större än 9 addera siffersumman
            x1 = x1 * 2;
            if (x1 > 9)
            {
                x1 = x1 - 9;
            }
            x3 = x3 * 2;
            if (x3 > 9)
            {
                x3 = x3 - 9;
            }
            x5 = x5 * 2;
            if (x5 > 9)
            {
                x5 = x5 - 9;
            }
            x7 = x7 * 2;
            if (x7 > 9)
            {
                x7 = x7 - 9;
            }
            x9 = x9 * 2;
            if (x9 > 9)
            {
                x9 = x9 - 9;
            }

                                                                // Skapa checksumma genom att addera alla siffror
            int checksum = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10;

                                                                // Om checksumman är jämnt delbar med tio är personnumret korrekt
            int rest = checksum % 10;
            if (rest == 0)                                      // Giltig kontrollsiffra
            {
                return true;
            }
            else // Ogiltig kontrollsiffra
            {
                return false;
            }
        }
        bool DateExists(string personnummer)                    // Kontrollera om datumet är korrekt
        {
            try
            {
                personnummer = personnummer.Substring(0, 6);
                string format = "yyMMdd";
                DateTime dt = DateTime.ParseExact(personnummer, format, null);
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool Man(string p)                                      // Kontrollera om personen är en man
        {
            if ((Convert.ToInt16(p[8]) % 2) == 0) return false;
            else return true;
        }
        string Day(string p)                                    // Räkna ut vilken dag personen är född
        {
            p = p.Substring(0, 8);
            string format = "yyyyMMdd";
            DateTime dt = DateTime.ParseExact(p, format, null);
            int d = (int)dt.DayOfWeek;
            if (d == 1) return "måndag";
            else if (d == 2) return "tisdag";
            else if (d == 3) return "onsdag";
            else if (d == 4) return "torsdag";
            else if (d == 5) return "fredag";
            else if (d == 6) return "lördag";
            else if (d == 7) return "söndag";
            else return "error";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  // Acceptera ej bokstäver
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
        private void textBox1_Click(object sender, EventArgs e) // Skapa tooltip
        {
            ToolTip format = new ToolTip();
            format.IsBalloon = true;
            format.AutoPopDelay = 5000;
            format.ReshowDelay = 5000;
            format.ShowAlways = false;
            format.ToolTipTitle = "Format";
            format.UseFading = false;
            format.SetToolTip(textBox1, "ÅÅÅÅMMDDXXXX");
        }
    }
}
