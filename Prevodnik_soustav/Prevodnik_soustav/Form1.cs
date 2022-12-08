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
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            label5.Visible = true;
                            label3.Visible = false;
                            label6.Visible = false;
                            maskedTextBox1.Mask = "00000000.00000000.00000000.00000000";
                            break;
                        case 1:
                            label5.Visible = false;
                            label3.Visible = true;
                            label6.Visible = false;
                            maskedTextBox1.Mask = "000.000.000.000";
                            break;
                        case 2:
                            label5.Visible = false;
                            label3.Visible = false;
                            label6.Visible = true;
                            maskedTextBox1.Mask = "CC.CC.CC.CC";
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            label5.Visible = true;
                            label3.Visible = false;
                            label6.Visible = false;
                            maskedTextBox1.Mask = "000000000000:000000000000:000000000000:000000000000:000000000000:000000000000";
                            break;
                        case 1:
                            label5.Visible = false;
                            label3.Visible = true;
                            label6.Visible = false;
                            maskedTextBox1.Mask = "00000:00000:00000:00000:00000:00000";
                            break;
                        case 2:
                            label5.Visible = false;
                            label3.Visible = false;
                            label6.Visible = true;
                            maskedTextBox1.Mask = "CCCC:CCCC:CCCC:CCCC:CCCC:CCCC";
                            break;
                    }
                    break;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int Z = 0;
            int DO = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Z = 2;
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            DO = 2;break;
                        case 1:
                            DO = 10;break;
                        case 2:
                            DO = 16;break;
                    }
                    break;
                case 1:
                    Z = 10;
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            DO = 2; break;
                        case 1:
                            DO = 10; break;
                        case 2:
                            DO = 16; break;
                    }
                    break;
                case 2:
                    Z = 16;
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            DO = 2; break;
                        case 1:
                            DO = 10; break;
                        case 2:
                            DO = 16; break;
                    }
                    break;
            }
            string cislo = maskedTextBox1.Text;
            int Pomocna_promena_pro_osetreni_cisel = 0;
            List<string> list = new List<string>();
            if (maskedTextBox1.Text.Contains(","))
            {
                string[] pole = cislo.Split(',');
                foreach (string cis in pole)
                {
                    string vys = Convert.ToString(Convert.ToInt32(cis, Z), DO);
                    list.Add(vys.ToString());
                }

                // Nefunguje mi to a nevim proč
                //foreach (string cis in list)
                //{
                //    int vys = Convert.ToInt32(cis, Z);
                //    if (vys > 255 || vys < 0)
                //    {
                //        Pomocna_promena_pro_osetreni_cisel++;
                //    }
                //}
            }
            if (maskedTextBox1.Text.Contains(":"))
            {
                string[] pole = cislo.Split(':');
                foreach (string cis in pole)
                {
                    string vys = Convert.ToString(Convert.ToInt32(cis, Z), DO);
                    list.Add(vys.ToString());
                }

                // Nefunguje mi to a nevim proč
                //foreach (string cis in list)
                //{
                //    int vys = Convert.ToInt32(cis, Z);
                //    if (vys > 65535 || vys < 0)
                //    {
                //        Pomocna_promena_pro_osetreni_cisel++;
                //    }
                //}
            }

            if (Pomocna_promena_pro_osetreni_cisel == 0)
            {
                int pom = 1;
                foreach (string cis in list)
                {
                    textBox2.Text += cis.ToString();
                    if (maskedTextBox1.Text.Contains(","))
                    {
                        if (pom != list.Count)
                        {
                            textBox2.Text += ".";
                        }
                    }
                    if (maskedTextBox1.Text.Contains(":"))
                    {
                        if (pom != list.Count)
                        {
                            textBox2.Text += ":";
                        }
                    }
                    pom++;
                }
            }
            else
            {
                MessageBox.Show("Zadal jsi špatně prvotní IP adresu! Zkus to znovu.");
            }

        }
    }
    
}
