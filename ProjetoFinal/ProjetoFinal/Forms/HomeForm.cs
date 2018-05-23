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
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.GreenYellow;
            lblProduct.Visible = true;
        }

        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Transparent;
            lblProduct.Visible = false;
        }

        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.GreenYellow;
            lblCategory.Visible = true;
        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Transparent;
            lblCategory.Visible = false;
        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.GreenYellow;
            lblUser.Visible = true;
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Transparent;
            lblUser.Visible = false;
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.GreenYellow;
            lblUserProfile.Visible = true;
        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.Transparent;
            lblUserProfile.Visible = false;
        }

        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.GreenYellow;
            lblLog.Visible = true;
        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Transparent;
            lblLog.Visible = false;
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm productallForm = new ProductAllForm();
            productallForm.Show();
            this.Hide();
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm categoryallForm = new CategoryAllForm();
            categoryallForm.Show();
            this.Hide();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm userallForm = new UserAllForm();
            userallForm.Show();
            this.Hide();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userprofileallForm = new UserProfileAllForm();
            userprofileallForm.Show();
            this.Hide();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            logForm.Show();
            this.Hide();
        }
    }
}
