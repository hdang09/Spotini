using Data;
using Data.Models;

namespace Spotini
{
    public partial class Register : Form
    {
        AccountRepository accountRepository;

        public Register()
        {
            accountRepository = new AccountRepository();
            InitializeComponent();
        }

        private void createAccount(object sender, EventArgs e)
        {
            String fullName = tbFullname.Text;
            String username = tbUsername.Text;
            String password = tbPassword.Text;
            String rePassword = tbRePassword.Text;

            if (password != rePassword)
            {

            }

            Account account = new Account()
            {
                FullName = fullName,
                Username = username,
                Password = password,
                Role = "USER",
                Status = "active",
            };
            accountRepository.Create(account);

            this.Hide();

            Login login = new Login();
            login.Show();
        }
    }
}
