using System;
using System.Windows.Forms;

namespace Hospital.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin")
                if (txtPassword.Text == "admin")
                {
                    var f = new Form1();
                    f.Show();
                    this.Hide();
                }
        }
    }
}
