﻿using ProjetoFinal.Classes;
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

namespace ProjetoFinal.Forms
{
    public partial class UserProfileDetailsForm : Form
    {
        public UserProfileDetailsForm()
        {
            InitializeComponent();
        }

        public UserProfileDetailsForm(int idUserProfile)
        {

            InitializeComponent();

            lblId.Text = idUserProfile.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUserProfile));

                    UserProfile userProfile = new UserProfile(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            userProfile.Id = Int32.Parse(reader["ID"].ToString());
                            userProfile.Name = reader["NAME"].ToString();
                            userProfile.Active = bool.Parse(reader["ACTIVE"].ToString());
                        }
                    }

                    tbxName.Text = userProfile.Name;
                    cbxActive.Checked = userProfile.Active;
                }
                catch (Exception EX)
                {
                    //Tratar exce??es
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }


        string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";
        string name = "";
        bool active = false;

        void GetData()
        {
            name = tbxName.Text;
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
            cbxActive.Checked = false;
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
            UserProfileAllForm userProfileAllForm = new UserProfileAllForm();
            userProfileAllForm.Show();
            this.Hide();
        }

        private void pbxSave_MouseEnter(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = ProjetoFinal.Properties.Resources.SaveGrey;
        }
        private void pbxSave_MouseLeave(object sender, EventArgs e)
        {
            pbxSave.BackgroundImage = ProjetoFinal.Properties.Resources.Save;
        }

        private void pbxDelete_MouseEnter(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.deleteRed;
        }
        private void pbxDelete_MouseLeave(object sender, EventArgs e)
        {
            pbxDelete.BackgroundImage = ProjetoFinal.Properties.Resources.delete;
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                GetData();

                sqlConnect.Open();
                string sql = "INSERT INTO USER_PROFILE(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@active", active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");

                CleanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar perfil!" + ex.Message);
                CleanData();
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text)) //-----
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE USER_PROFILE SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", Int32.Parse(lblId.Text)));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Perfil inativo!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este Perfil!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
                }
        }
    }
}
