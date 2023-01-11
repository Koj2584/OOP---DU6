using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___Skola_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pacient p;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Pacient(textBox1.Text, textBox2.Text, short.Parse(textBox3.Text), float.Parse(textBox4.Text), float.Parse(textBox5.Text));
                panel1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Špatný formát!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BMI: " + p.BMI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ABSI: " + p.ABSI());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.ToString());
        }
    }
}
