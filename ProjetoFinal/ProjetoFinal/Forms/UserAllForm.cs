﻿using System;
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
    public partial class UserAllForm : Form
    {
        public UserAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_MouseEnter(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = ProjetoFinal.Properties.Resources.BackRed;
        }
        private void pbxBack_MouseLeave(object sender, EventArgs e)
        {
            pbxBack.BackgroundImage = ProjetoFinal.Properties.Resources.Back;
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void pbxAdd_MouseEnter(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = ProjetoFinal.Properties.Resources.AddGreen;
        }
        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.BackgroundImage = ProjetoFinal.Properties.Resources.Add;
        }
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm();
            userDetailForm.Show();
            this.Hide();
        }

        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = ProjetoFinal.Properties.Resources.searchGrey;
        }
        private void pbxSearch_MouseLeave(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = ProjetoFinal.Properties.Resources.search;
        }

        private void pbxEdit_MouseEnter(object sender, EventArgs e)
        {
            pbxEdit.BackgroundImage = ProjetoFinal.Properties.Resources.EditGreen;
        }
        private void pbxEdit_MouseLeave(object sender, EventArgs e)
        {
            pbxEdit.BackgroundImage = ProjetoFinal.Properties.Resources.Edit;
        }
        private void pbxEdit_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm();
            userDetailForm.Show();
            this.Hide();
        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.deleteRed;
        }
        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.delete;
        }
    }
}
