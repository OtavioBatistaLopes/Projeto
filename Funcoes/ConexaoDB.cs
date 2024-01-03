using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    public class ConexaoBD
    {
        public static string RetornaConexaoBD()
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBancoDados.txt");
                StringBuilder sb = new StringBuilder();
                sb.Append("Data Source=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Initial Catalog=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("User ID=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Password=").Append(arquivo.ReadLine());
                arquivo.Close();
                return sb.ToString();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}