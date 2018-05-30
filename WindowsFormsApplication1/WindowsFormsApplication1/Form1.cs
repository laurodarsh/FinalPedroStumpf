using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
               

                //Conectar
                sqlConnect.Open();
                string sql = "INSERT INTO PRODUCT(NAME, ACTIVE, PRICE) VALUES (@name, @active, @price)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", "Limpeza"));
                cmd.Parameters.Add(new SqlParameter("@active", true));
                cmd.Parameters.Add(new SqlParameter("@price", 10));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");


            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);

            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }
    }
}
