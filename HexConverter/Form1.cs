using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HexConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Textbox1Clear = true;
        public bool Textbox2Clear = true;
        public bool Textbox3Clear = true;
        public bool Textbox4Clear = true;
        public bool Textbox5Clear = true;
        public bool Textbox6Clear = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Textbox1Clear == true)
            {
                Textbox2Clear = false;
                Textbox3Clear = false;
                Textbox4Clear = false;
                int Text1Length = textBox1.Text.Length;
                int Text2Length = textBox2.Text.Length;
                if (Text1Length > 0)
                {
                    Int64 number = Convert.ToInt64(textBox1.Text, 10);
                    string Bin = Convert.ToString(number, 2);
                    string Oct = Convert.ToString(number, 8);
                    string Hex = Convert.ToString(number, 16);
                    if (Text2Length == 8)
                    {
                        Int32 bytes = Int32.Parse(Hex, NumberStyles.AllowHexSpecifier);
                        float flt = BitConverter.ToSingle(BitConverter.GetBytes(bytes), 0);
                        string flts = Convert.ToString(flt);
                        textBox5.Text = flts;
                    }
                    else
                    {
                        textBox5.Clear();
                    }
                    textBox2.Text = Hex.ToUpper();
                    textBox3.Text = Oct;
                    textBox4.Text = Bin;
                }
                else
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                Textbox2Clear = true;
                Textbox3Clear = true;
                Textbox4Clear = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Textbox2Clear == true)
            {
                Textbox1Clear = false;
                Textbox3Clear = false;
                Textbox4Clear = false;
                int Text2Length = textBox2.Text.Length;
                if (Text2Length > 0)
                {
                    string inbytes = textBox2.Text;
                    Int64 number = Int64.Parse(inbytes, NumberStyles.AllowHexSpecifier);
                    number = Convert.ToInt64(number);
                    string hex = Convert.ToString(number, 16);
                    string dec = Convert.ToString(number, 10);
                    string oct = Convert.ToString(number, 8);
                    string bin = Convert.ToString(number, 2);
                    if (Text2Length == 8)
                    {
                        Int32 bytes = Int32.Parse(hex, NumberStyles.AllowHexSpecifier);
                        float flt = BitConverter.ToSingle(BitConverter.GetBytes(bytes), 0);
                        string flts = Convert.ToString(flt);
                        textBox5.Text = flts;
                    }
                    else
                    {
                        textBox5.Clear();
                    }
                    textBox1.Text = dec;
                    textBox3.Text = oct;
                    textBox4.Text = bin;
                }
                else
                {
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                Textbox1Clear = true;
                Textbox3Clear = true;
                Textbox4Clear = true;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Textbox3Clear == true)
            {
                Textbox1Clear = false;
                Textbox2Clear = false;
                Textbox4Clear = false;
                int Text3Length = textBox3.Text.Length;
                int Text2Length = textBox2.Text.Length;
                if (Text3Length > 0)
                {
                    Int64 number = Convert.ToInt64(textBox3.Text, 8);
                    string Bin = Convert.ToString(number, 2);
                    string dec = Convert.ToString(number, 10);
                    string Hex = Convert.ToString(number, 16);
                    if (Text2Length == 8)
                    {
                        Int32 bytes = Int32.Parse(Hex, NumberStyles.AllowHexSpecifier);
                        float flt = BitConverter.ToSingle(BitConverter.GetBytes(bytes), 0);
                        string flts = Convert.ToString(flt);
                        textBox5.Text = flts;
                    }
                    else
                    {
                        textBox5.Clear();
                    }
                    textBox2.Text = Hex.ToUpper();
                    textBox1.Text = dec;
                    textBox4.Text = Bin;
                }
                else
                {
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                Textbox1Clear = true;
                Textbox2Clear = true;
                Textbox4Clear = true;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Textbox4Clear == true)
            {
                Textbox1Clear = false;
                Textbox2Clear = false;
                Textbox3Clear = false;
                int Text4Length = textBox4.Text.Length;
                int Text2Length = textBox2.Text.Length;
                if (Text4Length > 0)
                {
                    Int64 number = Convert.ToInt64(textBox4.Text, 2);
                    string dec = Convert.ToString(number, 10);
                    string Oct = Convert.ToString(number, 8);
                    string Hex = Convert.ToString(number, 16);
                    if (Text2Length == 8)
                    {
                        Int32 bytes = Int32.Parse(Hex, NumberStyles.AllowHexSpecifier);
                        float flt = BitConverter.ToSingle(BitConverter.GetBytes(bytes), 0);
                        string flts = Convert.ToString(flt);
                        textBox5.Text = flts;
                    }
                    else
                    {
                        textBox5.Clear();
                    }
                    textBox2.Text = Hex.ToUpper();
                    textBox3.Text = Oct;
                    textBox1.Text = dec;
                }
                else
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Clear();
                    textBox5.Clear();
                }
                Textbox2Clear = true;
                Textbox3Clear = true;
                Textbox1Clear = true;
            }
        }
    }
}
