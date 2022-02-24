using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yazili_ortalama_hesaplama_LİSTBOX_ile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);


            int top = 0;
            double ort;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                top = top + Convert.ToInt32(listBox1.Items[i]);
            }

            ort = top / listBox1.Items.Count;

            textBox2.Text = ort.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            int top = 0;
            double ort;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                top = top + Convert.ToInt32(listBox1.Items[i]);
            }

            ort = top / listBox1.Items.Count;

            textBox2.Text = ort.ToString();
            */
        }
    }
}
