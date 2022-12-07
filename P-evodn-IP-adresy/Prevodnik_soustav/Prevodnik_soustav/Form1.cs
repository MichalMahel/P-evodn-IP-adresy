using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prevodnik_soustav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    maskedTextBox1.Visible = true;
                    label5.Visible = true;     
                    label3.Visible = false;
                    label6.Visible = false;
                    maskedTextBox1.Mask = "00000000.00000000.00000000.00000000";
                    break;
                case 1:
                    maskedTextBox1.Visible = true;
                    label5.Visible = false;                
                    label3.Visible = true;
                    label6.Visible = false;
                    maskedTextBox1.Mask = "000.000.000.000";
                    break;
                case 2:
                    maskedTextBox1.Visible = true;
                    label5.Visible = false;
                    label3.Visible = false;
                    label6.Visible = true;
                    maskedTextBox1.Mask = "CC.CC.CC.CC";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    switch (comboBox2.SelectedIndex)
                    {
                        //hotovo
                        case 0:
                            string cislo1 = maskedTextBox1.Text;
                            textBox2.Text = cislo1.ToString();
                            break;
                        
                        case 1:
                            string cislo2 = maskedTextBox1.Text;
                            int Vysledne_cislo = 0;
                            double delka = cislo2.Length;
                            double mocnina = 0;
                            foreach (char c in cislo2)
                            {
                                if (c == '1')
                                {
                                    mocnina = Math.Pow(2, delka - 1);
                                    Vysledne_cislo += (int)mocnina;
                                    mocnina = 0;
                                    delka--;
                                }
                                else
                                {
                                    delka--;
                                }
                            }
                        //string cislo2 = textBox1.Text;
                        //string Vysledne_cislo = Convert.ToString(Convert.ToInt32(cislo2, 2), 10);
                        //textBox2.Text = Vysledne_cislo.ToString();
                        break;

                        case 2:
                            string cislo3 = maskedTextBox1.Text;
                            string hex = Convert.ToString(Convert.ToInt32(cislo3, 2), 16);
                            textBox2.Text = hex.ToString();
                            break;
                    }
                   ; break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        
                        case 0:
                            //string cislo3 = textBox1.Text;
                            //string Vysledne_cislo = Convert.ToString(Convert.ToInt32(cislo3, 10), 2);
                            //textBox2.Text = Vysledne_cislo.ToString(); break;
                            textBox2.Text = "";
                            int cislo1 = Convert.ToInt32(maskedTextBox1.Text);
                            List<int> list1 = new List<int>();
                            int vysledek = 0;

                            while (cislo1 >= 1)
                            {
                                vysledek = cislo1 % 2;
                                cislo1 = cislo1 / 2;
                                list1.Add(vysledek);
                            }
                            while (list1.Count % 4 != 0)
                            {
                                list1.Add(0);
                            }
                            list1.Reverse();
                            foreach (int s in list1)
                            {
                                textBox2.Text += s.ToString();
                            }
                            break;
                        //hotovo
                        case 1:
                            string cislo2 = maskedTextBox1.Text;
                            textBox2.Text = cislo2.ToString(); break;
                        case 2:; break;
                    }
                   ; break;
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            //string bc = Convert.ToString(Convert.ToInt32(hc, 16), 2);


                            break;
                        case 1:; break;
                        case 2:; break;
                    }
                   ; break;
            }
        }

        
    }
    
}
