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
    public partial class LogForm : Form
    {
        public LogForm()
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

        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = ProjetoFinal.Properties.Resources.search___Copy;
        }
        private void pbxSearch_MouseLeave(object sender, EventArgs e)
        {
            pbxSearch.BackgroundImage = ProjetoFinal.Properties.Resources.search;
        }
    }
}
