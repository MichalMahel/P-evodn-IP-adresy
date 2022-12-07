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
            switch (comboBox3.SelectedIndex)
            {
                case 0:
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
                    break;
                case 1:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            maskedTextBox1.Visible = true;
                            label5.Visible = true;
                            label3.Visible = false;
                            label6.Visible = false;
                            maskedTextBox1.Mask = "000000000000:000000000000:000000000000:000000000000:000000000000:000000000000";
                            break;
                        case 1:
                            maskedTextBox1.Visible = true;
                            label5.Visible = false;
                            label3.Visible = true;
                            label6.Visible = false;
                            maskedTextBox1.Mask = "00000:00000:00000:00000:00000:00000";
                            break;
                        case 2:
                            maskedTextBox1.Visible = true;
                            label5.Visible = false;
                            label3.Visible = false;
                            label6.Visible = true;
                            maskedTextBox1.Mask = "CCCC:CCCC:CCCC:CCCC:CCCC:CCCC";
                            break;
                    }
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
                            textBox2.Text = "";
                            string cislo1 = maskedTextBox1.Text;
                            textBox2.Text = cislo1.ToString();
                            break;
                        
                        case 1:
                            textBox2.Text = "";
                            string cislo2 = maskedTextBox1.Text;
                            List<string> list2 = new List<string>();
                            if (maskedTextBox1.Text.Contains('.'))
                            {
                                string[] pole2 = cislo2.Split('.');
                                foreach (string cis2 in pole2)
                                {
                                    string vys2 = Convert.ToString(Convert.ToInt32(cis2, 2), 10);
                                    list2.Add(vys2.ToString());
                                }
                            }
                            if (maskedTextBox1.Text.Contains(":"))
                            {
                                string[] pole2 = cislo2.Split(':');
                                foreach (string cis2 in pole2)
                                {
                                    string vys2 = Convert.ToString(Convert.ToInt32(cis2, 2), 10);
                                    list2.Add(vys2.ToString());
                                }
                            }
                          
                            int pom2 = 1;
                            foreach (string cis2 in list2)
                            {
                                textBox2.Text += cis2.ToString();
                                if (maskedTextBox1.Text.Contains("."))
                                {
                                    if (pom2 != list2.Count)
                                    {
                                        textBox2.Text += ".";
                                    }
                                }
                                if (maskedTextBox1.Text.Contains(":"))
                                {
                                    if (pom2 != list2.Count)
                                    {
                                        textBox2.Text += ":";
                                    }
                                }
                                pom2++;
                            }
                            break;

                        case 2:
                            textBox2.Text = "";
                            string cislo3 = maskedTextBox1.Text;
                            List<string> list3 = new List<string>();
                            if (maskedTextBox1.Text.Contains("."))
                            {
                                string[] pole3 = cislo3.Split('.');
                                foreach (string cis3 in pole3)
                                {
                                    string vys3 = Convert.ToString(Convert.ToInt32(cis3, 2), 16);
                                    list3.Add(vys3.ToString());
                                }
                            }
                            if (maskedTextBox1.Text.Contains(":"))
                            {
                                string[] pole3 = cislo3.Split(':');
                                foreach (string cis3 in pole3)
                                {
                                    string vys3 = Convert.ToString(Convert.ToInt32(cis3, 2), 16);
                                    list3.Add(vys3.ToString());
                                }
                            }
                            
                            int pom3 = 1;
                            foreach (string cis3 in list3)
                            {
                                textBox2.Text += cis3.ToString();
                                if (maskedTextBox1.Text.Contains("."))
                                {
                                    if (pom3 != list3.Count)
                                    {
                                        textBox2.Text += ".";
                                    }
                                }
                                if (maskedTextBox1.Text.Contains(":"))
                                {
                                    if (pom3 != list3.Count)
                                    {
                                        textBox2.Text += ":";
                                    }
                                }
                                pom3++;
                            }
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            textBox2.Text = "";
                            string cislo1 = maskedTextBox1.Text;
                            List<string> list1 = new List<string>();
                            if (maskedTextBox1.Text.Contains("."))
                            {
                                string[] pole1 = cislo1.Split('.');
                                foreach (string cis1 in pole1)
                                {
                                    string vys1 = Convert.ToString(Convert.ToInt32(cis1, 10), 2);
                                    list1.Add(vys1.ToString());
                                }
                            }
                            if (maskedTextBox1.Text.Contains(":"))
                            {
                                string[] pole1 = cislo1.Split(':');
                                foreach (string cis1 in pole1)
                                {
                                    string vys1 = Convert.ToString(Convert.ToInt32(cis1, 10), 2);
                                    list1.Add(vys1.ToString());
                                }
                            }
                            
                            int pom1 = 1;
                            foreach (string cis1 in list1)
                            {
                                textBox2.Text += cis1.ToString();
                                if (maskedTextBox1.Text.Contains("."))
                                {
                                    if (pom1 != list1.Count)
                                    {
                                        textBox2.Text += ".";
                                    }
                                }
                                if (maskedTextBox1.Text.Contains(":"))
                                {
                                    if (pom1 != list1.Count)
                                    {
                                        textBox2.Text += ":";
                                    }
                                }
                                pom1++;
                            }
                            break;
                        //hotovo
                        case 1:
                            textBox2.Text = "";
                            string cislo2 = maskedTextBox1.Text;
                            textBox2.Text = cislo2.ToString();
                            break;
                        case 2:
                            textBox2.Text = "";
                            string cislo3 = maskedTextBox1.Text;
                            List<string> list3 = new List<string>();
                            if (maskedTextBox1.Text.Contains("."))
                            {
                                string[] pole3 = cislo3.Split('.');
                                foreach (string cis3 in pole3)
                                {
                                    string vys3 = Convert.ToString(Convert.ToInt32(cis3, 10), 16);
                                    list3.Add(vys3.ToString());
                                }
                            }
                            if (maskedTextBox1.Text.Contains(":"))
                            {
                                string[] pole3 = cislo3.Split(':');
                                foreach (string cis3 in pole3)
                                {
                                    string vys3 = Convert.ToString(Convert.ToInt32(cis3, 10), 16);
                                    list3.Add(vys3.ToString());
                                }
                            }
                            
                            int pom3 = 1;
                            foreach (string cis3 in list3)
                            {
                                textBox2.Text += cis3.ToString();
                                if (maskedTextBox1.Text.Contains("."))
                                {
                                    if (pom3 != list3.Count)
                                    {
                                        textBox2.Text += ".";
                                    }
                                }
                                if (maskedTextBox1.Text.Contains(":"))
                                {
                                    if (pom3 != list3.Count)
                                    {
                                        textBox2.Text += ":";
                                    }
                                }
                                pom3++;
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            textBox2.Text = "";
                            string cislo1 = maskedTextBox1.Text;
                            List<string> list1 = new List<string>();
                            if (maskedTextBox1.Text.Contains("."))
                            {
                                string[] pole1 = cislo1.Split('.');
                                foreach (string cis1 in pole1)
                                {
                                    string vys1 = Convert.ToString(Convert.ToInt32(cis1, 16), 2);
                                    list1.Add(vys1.ToString());
                                }
                            }
                            if (maskedTextBox1.Text.Contains(":"))
                            {
                                string[] pole1 = cislo1.Split(':');
                                foreach (string cis1 in pole1)
                                {
                                    string vys1 = Convert.ToString(Convert.ToInt32(cis1, 16), 2);
                                    list1.Add(vys1.ToString());
                                }
                            }
                            
                            int pom1 = 1;
                            foreach (string cis1 in list1)
                            {
                                textBox2.Text += cis1.ToString();
                                if (maskedTextBox1.Text.Contains("."))
                                {
                                    if (pom1 != list1.Count)
                                    {
                                        textBox2.Text += ".";
                                    }
                                }
                                if (maskedTextBox1.Text.Contains(":"))
                                {
                                    if (pom1 != list1.Count)
                                    {
                                        textBox2.Text += ":";
                                    }
                                }
                                pom1++;
                            }
                            break;
                        case 1: break;
                            textBox2.Text = "";
                            string cislo2 = maskedTextBox1.Text;
                            List<string> list2 = new List<string>();
                            if (maskedTextBox1.Text.Contains("."))
                            {
                                string[] pole2 = cislo2.Split('.');
                                foreach (string cis2 in pole2)
                                {
                                    string vys2 = Convert.ToString(Convert.ToInt32(cis2, 16), 10);
                                    list2.Add(vys2.ToString());
                                }
                            }
                            if (maskedTextBox1.Text.Contains(":"))
                            {
                                string[] pole2 = cislo2.Split(':');
                                foreach (string cis2 in pole2)
                                {
                                    string vys2 = Convert.ToString(Convert.ToInt32(cis2, 16), 10);
                                    list2.Add(vys2.ToString());
                                }
                            }
                            
                            int pom2 = 1;
                            foreach (string cis2 in list2)
                            {
                                textBox2.Text += cis2.ToString();
                                if (maskedTextBox1.Text.Contains("."))
                                {
                                    if (pom2 != list2.Count)
                                    {
                                        textBox2.Text += ".";
                                    }
                                }
                                if (maskedTextBox1.Text.Contains(":"))
                                {
                                    if (pom2 != list2.Count)
                                    {
                                        textBox2.Text += ":";
                                    }
                                }
                                pom2++;
                            }
                        case 2:
                            textBox2.Text = "";
                            string cislo3 = maskedTextBox1.Text;
                            textBox2.Text = cislo3.ToString();
                            break;
                    }
                    break;
            }
        }
    }
    
}
