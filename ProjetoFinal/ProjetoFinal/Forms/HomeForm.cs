using ProjetoFinal.Classes;
using ProjetoFinal.Forms;
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
    public partial class HomeForm : Form
    {
        User aux = new User();

        public HomeForm(User user)
        {
            InitializeComponent();
            if (user.UserProfile.Name != "Gerente")
            {
                pbxLog.Visible = false;
                pbxUser.Visible = false;
                pbxUserProfile.Visible = false;
            }
            aux = user;
        }

        public HomeForm()
        {
            InitializeComponent();
            if (aux.UserProfile.Name != "Gerente")
            {
                pbxLog.Visible = false;
                pbxUser.Visible = false;
                pbxUserProfile.Visible = false;
            }

        }


        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackgroundImage = ProjetoFinal.Properties.Resources.ProductBrown;
            lblProduct.Visible = true;
        }
        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackgroundImage = ProjetoFinal.Properties.Resources.Product;
            lblProduct.Visible = false;
        }
        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm productallForm = new ProductAllForm();
            productallForm.Show();
            this.Hide();
        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackgroundImage = ProjetoFinal.Properties.Resources.User_Profile___Copy;
            lblUser.Visible = true;
        }
        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackgroundImage = ProjetoFinal.Properties.Resources.User_Profile;
            lblUser.Visible = false;
        }
        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm userallForm = new UserAllForm();
            userallForm.Show();
            this.Hide();
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxUserProfile.BackgroundImage = ProjetoFinal.Properties.Resources.User___Copy1;
            lblUserProfile.Visible = true;
        }
        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxUserProfile.BackgroundImage = ProjetoFinal.Properties.Resources.User;
            lblUserProfile.Visible = false;
        }
        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userprofileallForm = new UserProfileAllForm();
            userprofileallForm.Show();
            this.Hide();
        }

        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackgroundImage = ProjetoFinal.Properties.Resources.CategoryBlue;
            lblCategory.Visible = true;
        }
        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackgroundImage = ProjetoFinal.Properties.Resources.Category;
            lblCategory.Visible = false;
        }
        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm categoryallForm = new CategoryAllForm();
            categoryallForm.Show();
            this.Hide();
        }

        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbxLog.BackgroundImage = ProjetoFinal.Properties.Resources.LogBlue;
            lblLog.Visible = true;
        }
        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackgroundImage = ProjetoFinal.Properties.Resources.Log;
            lblLog.Visible = false;
        }
        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            logForm.Show();
            this.Hide();
        }
    }
}
