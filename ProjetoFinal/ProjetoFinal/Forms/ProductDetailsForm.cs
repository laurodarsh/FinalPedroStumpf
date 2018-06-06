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
    public partial class ProductDetailsForm : Form
    {

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        string name = "" ;
        float price = 0 ;
        string category = "" ;
        bool active = false;

        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            category = cmbCategory.Text; 

            if (cbxActive.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }
        }
        void CleanData()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
            cmbCategory.SelectedIndex = 0;
            cbxActive.Checked = false;
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
            ProductAllForm productallForm = new ProductAllForm();
            productallForm.Show();
            this.Hide();
        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.delete___Copy;
        }
        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.delete;
        }
        private void pbxDelete_Click(object sender, EventArgs e)
        {

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

        }
    }
}
