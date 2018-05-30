using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploEstatico
{
    public partial class Form1 : Form
    {
        string nome = "";
        string email = "";
        bool fumante = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ObterDados();
            string resArroba = EmailHelper.VerificarEmailComArroba(email);
            string resEspaco = EmailHelper.VerificarEmailComEspaco(email);

            if (resArroba == "Correto")
            {
                if(resEspaco == "Correto")
                {
                    Pessoa p = new Pessoa(nome, email, fumante);
                    MessageBox.Show(p.Nome + " cadastrado com sucesso!");
                    LimparDados();
                }
                else
                {
                    MessageBox.Show(resEspaco);
                }
            }
            else
            {
                MessageBox.Show(resArroba);
            }
        }

        void ObterDados()
        {
            nome = tbxNome.Text;
            email = tbxEmail.Text;

            if(cbxFumante.Checked)
            {
                fumante = true;
            }
        }

        void LimparDados()
        {
            tbxEmail.Text = "";
            tbxNome.Text = "";
            cbxFumante.Checked = false;
            fumante = false;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FormResultado f = new FormResultado();
            f.Show();
            this.Hide();
        }
    }
}
