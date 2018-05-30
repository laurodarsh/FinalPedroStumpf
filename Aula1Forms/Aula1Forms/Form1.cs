using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1Forms
{
    public partial class Form1 : Form
    {

        string nome = "";
        int idade = 0;
        float nota = 0;

        public Form1()
        {
            InitializeComponent();           
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.Magenta;
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.ForeColor = Color.Black;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ObterDados();

            if (idade > 17)
            {
                MessageBox.Show(nome.ToUpper() + " é maior de idade.");
            }
            else
            {
                MessageBox.Show(nome.ToUpper() + " é menor de idade.");
            }

            MessageBox.Show("Passou: " + VerificarAprovado(nota));

            LimparDados();
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.Black;
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.ForeColor = Color.White;
        }
        
        bool VerificarAprovado(float a)
        {
            bool resultado = false;

            if(a>= 5)
            {
                resultado = true;
            }

            return resultado;
        }

        void ObterDados()
        {
            nome = tbxNome.Text;
            idade = Int32.Parse(tbxIdade.Text);
            nota = float.Parse(tbxNota.Text);
        }

        void LimparDados()
        {
            tbxNome.Text = "";
            tbxIdade.Text = "";
            tbxNota.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(tbxNum1.Text);
            int n2 = Int32.Parse(tbxNum2.Text);

            int total = Somar(n1, n2);

            lblResultado.Text = total.ToString();

        }

        int Somar(int n2, int n1)
        {
            int resultado = 0;

            resultado = n1 + n2;

            return resultado;
        }

    }
}
