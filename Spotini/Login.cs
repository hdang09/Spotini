using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotini
{
    public partial class Login : Form
    {
        AccountRepository accountRepository;
        public Login()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void login(object sender, EventArgs e)
        {

        }

        private void handleLogin(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var list = accountRepository.GetAll();
            foreach (var item in list)
            {
                if (item.Username.Equals(username) && item.Password.Equals(password))
                {
                    this.Hide();

                    if (item.Role == "ADMIN")
                    {
                        AdminAccount admin = new AdminAccount();
                        admin.Show();
                    }
                    else
                    {
                        Home home = new Home();
                        home.Show();
                    }

                }
            }
        }

        private void redirectRegister(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.Show();
        }
    }
}
