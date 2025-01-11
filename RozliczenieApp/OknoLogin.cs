using System;
using System.Windows.Forms;

namespace RozliczenieApp
{
    public partial class OknoLogin : Form
    {
        public OknoLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text=="admin" && Password.Text=="admin")
            {
                new OknoRozlicz().Show();
                this.Hide();

            }
            else if (UserName.Text == "user" && Password.Text == "user")
            {
                new OknoRozlicz().Show();
                this.Hide();
            }
            else if (UserName.Text == "kierowca" && Password.Text == "kierowca")
            {
                new OknoRozlicz().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Błędne dane logowania");
                UserName.Clear();
                Password.Clear();
                UserName.Focus();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            Password.Clear();
            UserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
