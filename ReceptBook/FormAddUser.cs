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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var surname = textBoxSurname.Text;
            var name = textBoxName.Text;
            var idrole = textBoxIdRole.Text;
            var email = textBoxEmail.Text;
            var password = textBoxPassword.Text;
            

            if (DBConnect.AddUser(textBoxSurname.Text, textBoxName.Text, Convert.ToInt32(textBoxIdRole.Text), textBoxEmail.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Створено нового користувача!");
            }
            else
            {
                MessageBox.Show("Такий користувач вже існує.");
            }
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            DBConnect.getAllRoles(ref dataGridViewRoles);
        }
    }
}
