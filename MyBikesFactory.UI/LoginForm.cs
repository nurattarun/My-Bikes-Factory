using MyBikesFactory.Business;
using MyBikesFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class LoginForm : Form
    {
        private List<User> listOfUsers = UserSequentialData.Load();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool existingUser = false;

            foreach (var user in listOfUsers)
            {
                if (user.Username == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    existingUser = true;
                    break;
                }
            }

            if (existingUser)
            {
                var frmMainForm = new MainForm();
                frmMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
