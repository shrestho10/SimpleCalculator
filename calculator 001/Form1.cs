﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_001
{
    public partial class Form1 : Form
    {
        Decimal FirstNum;
        Decimal SecondNum;
        int Operator;
        Boolean OperatorSeletor = false;








        public Form1()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            FirstNum = System.Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            OperatorSeletor = true;
            Operator = 1;//+

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
            {
               textBox1.Text += "1";
            }

            else
            {
                textBox1.Text = "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "2";
            }

            else
            {
                textBox1.Text = "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "3";
            }

            else
            {
                textBox1.Text = "3";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "4";
            }

            else
            {
                textBox1.Text = "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "5";
            }

            else
            {
                textBox1.Text = "5";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "6";
            }

            else
            {
                textBox1.Text = "6";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "7";
            }

            else
            {
                textBox1.Text = "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "8";
            }

            else
            {
                textBox1.Text = "8";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "9";
            }

            else
            {
                textBox1.Text = "9";
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }

            else
            {
                textBox1.Text = "0";
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text .Contains ("."))
            {
                textBox1.Text += ".";
            }

           
        }

        private void Button11_Click(object sender, EventArgs e)
        {
           
            FirstNum = System.Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            OperatorSeletor = true;
            Operator = 2;//-

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            FirstNum = System.Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            OperatorSeletor = true;
            Operator = 3;//x

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            FirstNum = System.Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            OperatorSeletor = true;
            Operator = 4;// /

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if(OperatorSeletor==true)
            {
                SecondNum = System.Convert.ToDecimal(textBox1.Text);
                if (Operator==1)
                {
                    textBox1.Text = System.Convert.ToString(FirstNum + SecondNum);
                    OperatorSeletor = false;
                }

                else if (Operator == 2)
                {
                    textBox1.Text = System.Convert.ToString(FirstNum - SecondNum);
                }

               else  if (Operator == 3)
                {
                    textBox1.Text = System.Convert.ToString(FirstNum * SecondNum);
                }
                else if (Operator == 4)
                {
                    if(SecondNum==0)
                    {
                        textBox1.Text = "Error";
                    }
                    else
                    textBox1.Text = System.Convert.ToString(FirstNum / SecondNum);
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
