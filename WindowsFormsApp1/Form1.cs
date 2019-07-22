using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        double reqem, reqem2, netice;
        string emeliyyat;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void reqemyaz()
        {
            if(textBox1.Text !="")
            {
                reqem = Convert.ToDouble(textBox1.Text);
                label1.Text = reqem.ToString() + emeliyyat.ToString();
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "Zehmet olmasa reqem daxil edin";
            }
         
        }
        void reqemyaz2()
        {
            label1.Text = reqem.ToString() + emeliyyat.ToString() + reqem2.ToString() + "=" + netice.ToString();
            textBox1.Text = "";

        }

    

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";

            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";

            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "1";

            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";

            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";

            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";

            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";

            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";

            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";

            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";

            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            emeliyyat = "+";
            reqemyaz();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            emeliyyat = "x";
            reqemyaz();


        }

        private void Button15_Click(object sender, EventArgs e)
        {
            emeliyyat = "-";
            reqemyaz();


        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if( button16.Text == "Show History")
            {
                groupBox1.Visible = true;
                this.Size = new Size(517, 370);
                button16.Text = "Hide History";
            }
            else
            {
                groupBox1.Visible = false;
                this.Size = new Size(271, 370);
                button16.Text = "Show History";

            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Writing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) >0);
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1) ;
                 if (textBox1.Text.Length == 0) ;
                {
                    textBox1.Text = "0";

                }
                
            }
        

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            emeliyyat = "/";
            reqemyaz();

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") reqem2 = Convert.ToDouble(textBox1.Text);
            else label1.Text = "Reqem yazmadiniz";
            switch (emeliyyat)
            { case "+":

                    netice = reqem + reqem2;
                    reqemyaz2();
                    break;
                case "-":
                    netice = reqem - reqem2;
                    reqemyaz2();
                    break;
                case "/":
                    netice = reqem / reqem2;
                    reqemyaz2();
                    break;
                case "x":
                    netice = reqem * reqem2;
                    reqemyaz2();
                    break;
            
            }
            Writing.Items.Add(label1.Text);
        }
    }
}
