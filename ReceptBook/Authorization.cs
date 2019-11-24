using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptBook
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //char login;
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            if (DBConnect.SignIn(loginTextBox.Text, passwordTextBox.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                errMessageLabel.Text = "Неправильний логін або пароль";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
