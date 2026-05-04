using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtPassword.Text == "1234")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Ошибка входа");
            }
        }
    }
}
