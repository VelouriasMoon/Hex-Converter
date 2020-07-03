using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexConverter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Clear();
            if (textBox2.Text.Length > 0)
                textBox2.Clear();
            if (textBox3.Text.Length > 0)
                textBox3.Clear();
            if (textBox4.Text.Length > 0)
                textBox4.Clear();
            if (textBox5.Text.Length > 0)
                textBox5.Clear();
            if (textBox6.Text.Length > 0)
                textBox6.Clear();
            if (textBox7.Text.Length > 0)
                textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Input1 = textBox1.Text;      //hour textbox
            string Input2 = textBox2.Text;      //minute textbox
            string Input3 = textBox3.Text;      //second textbox
            float num1;     //hours
            float num2;     //minutes
            float num3;     //seconds
            float num7;
            int tempnum = 0;
            try
            {
                if (textBox1.Text.Length > 0)
                    num1 = float.Parse(Input1);
                else
                    num1 = 0;
                if (textBox2.Text.Length > 0)
                    num2 = float.Parse(Input2);
                else
                    num2 = 0;
                if (textBox3.Text.Length > 0)
                    num3 = float.Parse(Input3);
                else
                    num3 = 0;
            }
            catch (FormatException)
            {
                return;
            }
            //seconds output
            float num6 = ((num1 * 60) + num2) * 60 + num3;
            string secout = num6.ToString();
            textBox5.Text = secout;
            //minute output
            float num5 = (num1 * 60) + (num3 / 60) + num2;
            string minout = num5.ToString();
            textBox6.Text = minout;
            //hour output
            float num4 = ((num3 / 60) + num2) / 60 + num1;
            string houout = num4.ToString();
            textBox7.Text = houout;
            //total output
            if (num3 >= 59)
            {
                tempnum = (int)Math.Floor(num3/60);
                tempnum = tempnum * 60;
                num7 = num3 - tempnum;
                textBox9.Text = num7.ToString();
                
            }
            else
            {
                textBox9.Text = num3.ToString();
            }
            tempnum = tempnum / 60;
            num2 = num2 + tempnum;
            if (num2 >= 59)
            {
                tempnum = (int)Math.Floor(num2 / 60);
                tempnum = tempnum * 60;
                num7 = num2 - tempnum;
                textBox8.Text = num7.ToString();
            }
            else
            {
                textBox8.Text = num2.ToString();
            }
            tempnum = tempnum / 60;
            num1 = num1 + tempnum;
            textBox4.Text = num1.ToString();
        }
    }
}
