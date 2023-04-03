using System;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "kero" && password.Text == "123456")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect");
                username.Clear();
                password.Clear();
                username.Focus();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
