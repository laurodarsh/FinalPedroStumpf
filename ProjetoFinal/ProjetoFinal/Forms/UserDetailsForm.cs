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
    public partial class UserDetailForm : Form
    {
        public UserDetailForm()
        {
            InitializeComponent();
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = ProjetoFinal.Properties.Resources.Back;
        }
        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = ProjetoFinal.Properties.Resources.Back___Copy;
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm userAllForm = new UserAllForm();
            userAllForm.Show();
            this.Hide();
        }

        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = ProjetoFinal.Properties.Resources.Save___Copy;
        }
        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = ProjetoFinal.Properties.Resources.Save;
        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.delete___Copy;
        }
        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.delete;
        }
    }
}
