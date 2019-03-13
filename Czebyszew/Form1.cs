using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Czebyszew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            richTextBox4.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s;
            double xl, xp;
            s = System.Convert.ToInt32(richTextBox1.Text);
            xl = System.Convert.ToDouble(richTextBox2.Text);
            xp = System.Convert.ToDouble(richTextBox3.Text);

            double Tn(double a, int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                else if (n == 1)
                {
                    return a;
                }
                else
                {
                    return 2 * a * Tn(a, n - 1) - Tn(a, n - 2);
                }
            }
            richTextBox4.Text += "---------St_wlmn: " + System.Convert.ToString(s) + "----------" + "\r\n";
            richTextBox4.Text += "x" + " " + "y" + "\r\n";

            for (double x = xl; x <= xp; x = x + 0.01)
        {       
                chart1.Series["Series1"].Points.AddXY(x, Tn(x, s));

                richTextBox4.Text += System.Convert.ToString(x) + " " + System.Convert.ToString(Tn(x, s)) + "\r\n";
        }

        }
        //pobiera stopien wielomianu
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //pobiera xl
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //pobiera xp
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
