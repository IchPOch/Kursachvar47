using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursachvar47
{
    public partial class Form1 : Form
    {
        int bit;
        public Form1()
        {
            InitializeComponent();
            bit = 2;
        }
        //0 = 48
        //1 = 49
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxVivod.Text = "";
            string s = textBoxVvod.Text;
            s = s.Replace(" ", "");
            int[,] A = new int[s.Length/8,8];
            int c = 0;
            for(int i = 0; i < s.Length / 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (s[c] == 48) A[i, j] = 0;
                    else A[i, j] = 1;
                    
                    c++;
                }
            }
            if (s.Length % bit == 0)
            {
                int[,] B = new int[s.Length / bit, bit];
                c = 0;
                for (int i = 0; i < (s.Length / bit); i++)
                {
                    for (int j = 0; j < bit; j++)
                    {
                        if (s[c] == 48) B[i, j] = 0;
                        else B[i, j] = 1;
                        c++;
                    }
                }
                for (int i = 0; i < s.Length / bit; i++)
                {
                    textBoxVivod.Text += " ";
                    for (int j = 0; j < bit; j++)
                    {
                        textBoxVivod.Text += "" + B[i, j];
                    }
                }
            }
            else
            {
                int[,] B = new int[s.Length / bit + 1, bit];
                c = 0;
                for (int i = 0; i < (s.Length / bit); i++)
                {
                    for (int j = 0; j < bit; j++)
                    {
                        if (s[c] == 48) B[i, j] = 0;
                        else B[i, j] = 1;
                        c++;
                    }
                }
                //if (s.Length % bit == 0)
                //{
                //    for (int i = (s.Length / bit) - 1; i < s.Length / bit; i++)
                //    {
                //        for (int j = 0; j < bit; j++)
                //        {
                //            if (s[c] == 48) B[i, j] = 0;
                //            else B[i, j] = 1;
                //            c++;
                //        }
                //    }
                //}
                int ost = bit - (s.Length % bit);
                    for (int j = 0; j < bit; j++)
                    {
                        if (ost > j)
                        {
                            B[(s.Length / bit), j] = 0;
                        }
                        else
                        {
                        if (s[c] == 48) { B[(s.Length / bit), j] = 0; }
                        else { B[(s.Length / bit), j] = 1; }
                            c++;
                        }
                    }
                
                for (int i = 0; i < s.Length / bit + 1; i++)
                {
                    textBoxVivod.Text += " ";
                    for (int j = 0; j < bit; j++)
                    {
                        textBoxVivod.Text += "" + B[i, j];
                    }
                }
            }
        }

        private void radioButton2bit_Click(object sender, EventArgs e)
        {
            bit = 2;
        }

        private void radioButton4bit_Click(object sender, EventArgs e)
        {
            bit = 4;
        }

        private void radioButton6bit_Click(object sender, EventArgs e)
        {
            bit = 6;
        }
    }
}
