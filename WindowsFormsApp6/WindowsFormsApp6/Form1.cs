using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Erzurum");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Avukat");
            listBox1.Items.Add("Memur");
            listBox1.Items.Add("Savcı");
            listBox1.Items.Add("Gazeteci");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text+" "+textBox4.Text+" "+textBox2.Text+" "+textBox1.Text);
        }
    }
}
