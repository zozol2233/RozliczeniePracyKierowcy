using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozliczenieApp
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            introlabel.Parent = pictureBox1;
            introlabel.BackColor = Color.Transparent;
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
          
        }

        
    }
}
