using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstatico
{
    public static class EmailHelper
    {
        public static string VerificarEmailComArroba(string email)
        {
            string result = "Correto";

            int pos = email.IndexOf("@");

            if (pos == -1)
            {
                result = "O e-mail deve possuir @";
            }

            return result;
        }

        public static string VerificarEmailComEspaco(string email)
        {
            string result = "Correto";
            int i = email.IndexOf(" ");

            if (i != -1)
            {
                result = "O e-mail não deve possuir espaços em branco";
            }

            return result;
        }


    }
}
