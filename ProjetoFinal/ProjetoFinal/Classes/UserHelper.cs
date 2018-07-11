﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Classes
{
    public static class UserHelper
    {


        public static string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        public static User SelectByName(string name)
        {

            string connectionString = "workstation id=StockControlData.mssql.somee.com;packet size=4096;user id=luacademy_SQLLogin_1;pwd=msctq6gvt3;data source=StockControlData.mssql.somee.com;persist security info=False;initial catalog=StockControlData";

            SqlConnection sqlConnect = new SqlConnection(connectionString);
            User user = new User();

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE NAME = @name", sqlConnect);
                cmd.Parameters.Add(new SqlParameter("@name", name));//-----

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Id = Int32.Parse(reader["ID"].ToString());
                        user.Name = reader["NAME"].ToString();
                        user.Password = reader["PASSWORD"].ToString();
                        user.Email = reader["EMAIL"].ToString();
                        user.Active = bool.Parse(reader["ACTIVE"].ToString());
                        user.UserProfile = new UserProfile
                        {
                            Id = Int32.Parse(reader["FK_USERPROFILE"].ToString())
                        };
                    }
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnect.Close();
            }

            return user;
        }
    }
}
