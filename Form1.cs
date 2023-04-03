using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;
            
            

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure you wish to auit ?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure you wish to auit ?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            panel3.Height = button11.Height;
            panel3.Top = button11.Top;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Height = button12.Height;
            panel3.Top = button12.Top;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Height = button13.Height;
            panel3.Top = button13.Top;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel3.Height = button14.Height;
            panel3.Top = button14.Top;
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }
    }
}
