using ProjetoFinal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class LoginForm : Form
    {
        User aux = new User();
        string login;
        string password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            GetData();

            if (CheckLogin(password, login))
            {
               
                    HomeForm homeForm = new HomeForm(aux);
                    homeForm.Show();
                    this.Hide();
               
            }
            else

            {
                CleanData();
                MessageBox.Show("usuário ou senha incorretos!");
            }

        }

        void GetData()
        {
            login = tbxName.Text;
            password = tbxPassword.Text;
        }
        void CleanData()
        {
            tbxName.Text = "";
            tbxPassword.Text = "";
        }
        private bool CheckLogin(string password, string name)
        {
            User user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                    aux = user;
                    return true;
                }
            }
            return false;
        }
    }
}
