using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Forms
{
    public partial class CategoryAllForm : Form
    {
        public CategoryAllForm()
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
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    
        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = ProjetoFinal.Properties.Resources.Add___Copy;
        }
        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = ProjetoFinal.Properties.Resources.Add;
        }
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryDetailsForm = new CategoryDetailsForm();
            categoryDetailsForm.Show();
            this.Hide();
        }
        
        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {
            pbxEdit.BackgroundImage = ProjetoFinal.Properties.Resources.Edit___Copy;
        }
        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {
            pbxEdit.BackgroundImage = ProjetoFinal.Properties.Resources.Edit;
        }
        private void pbxEdit_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryDetailsForm = new CategoryDetailsForm();
            categoryDetailsForm.Show();
            this.Hide();
        }

        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = ProjetoFinal.Properties.Resources.search___Copy;
        }
        private void pbxSearch_MouseLeave(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = ProjetoFinal.Properties.Resources.search;
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
