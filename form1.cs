using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 15;
        }

        string CalTotal;
        double num1;
        double num2;
        String option;
        double result;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBox1.Text.Replace("'", "");
            string[] parts = currentText.Split('.');
            string firstPart = "";
            for (int i = 0; i < parts[0].Length; i++)
            {
                if (i > 0 && i % 3 == 0)
                {
                    firstPart += "'";
                }
                firstPart += parts[0][i];
            }
            if (parts.Length > 1)
            {
                textBox1.Text = firstPart + "." + parts[1];
            }
            else
            {
                textBox1.Text = firstPart;
            }
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {


                if (option.Equals("+"))

                    result = num1 + double.Parse(textBox1.Text);

                if (option.Equals("-"))
                    result = num1 - double.Parse(textBox1.Text);

                if (option.Equals("*"))
                    result = num1 * double.Parse(textBox1.Text);

                if (option.Equals("/"))
                {
                    if (textBox1.Text == "0")
                    {

                        MessageBox.Show("Dont divide by 0!");
                    }
                    else
                    {
                        result = num1 / double.Parse(textBox1.Text);


                    }

                }


                textBox1.Text = result + "";
            }
        }

        
        private void bt_minus_Click(object sender, EventArgs e)
        {
            setoperator1();
            option = "-";
            textBox1.Clear();        }
        private void bt_multiply_Click(object sender, EventArgs e)
        {
            setoperator1();
            option = "*";
            textBox1.Clear();
        }

        private void bt_divide_Click(object sender, EventArgs e)
        {
            setoperator1();
            option = "/";

            textBox1.Clear();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            setoperator1();
            option = "+";

            textBox1.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void setoperator1()
        {
          if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            num1 = double.Parse(textBox1.Text);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

          
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
