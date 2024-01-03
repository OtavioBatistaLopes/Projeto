using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Documents;


namespace DAL
{
    public class Balanco_DAL
    {

        //Incluir Balanco
        public int Incluir_Balanco(Modelo.Modelo_Balanco balanco)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO balanco(total_caixa, caixa_atual, id_periodo)")
              .Append("VALUES (@total_Caixa, @caixa_Atual, @id_Periodo) ")
              .Append("SELECT @@IDENTITY");
              

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@total_Caixa", balanco.total_Caixa);
                    cmd.Parameters.AddWithValue("@caixa_Atual", balanco.caixa_Atual);
                    cmd.Parameters.AddWithValue("@id_Periodo",balanco.Id_Periodo );


                    conn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Carregargird
        public List<Modelo.Modelo_Resultado_Balanco_Periodo> CarregarGrid_Balanco(string strWhere)
        {
            List  <Modelo.Modelo_Resultado_Balanco_Periodo> resultado = new List<Modelo_Resultado_Balanco_Periodo>();
            List  <Modelo.Modelo_Balanco> listabalanco = new List<Modelo.Modelo_Balanco>();
            List  <Modelo.Modelo_Periodo> listaperiodo = new List<Modelo.Modelo_Periodo>();
      
            Modelo.Modelo_Balanco balanco = null;
            Modelo.Modelo_Periodo periodo = null;
            

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("select id_Balanco, Periodo.id_Periodo, total_Caixa , caixa_Atual, data_Inicial , data_Final from Balanco inner join Periodo on balanco.id_Periodo = Periodo.id_Periodo; ")
              .Append(" " + strWhere + " ");


            using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        balanco = new Modelo.Modelo_Balanco();
                        periodo = new Modelo.Modelo_Periodo();

                        if (dr["id_Balanco"] != DBNull.Value)
                            balanco.id_Balanco = Convert.ToInt32(dr["id_Balanco"]);

                        if (dr["total_Caixa"] != DBNull.Value)
                            balanco.total_Caixa = Convert.ToDecimal(dr["total_Caixa"]);

                        if (dr["caixa_Atual"] != DBNull.Value)
                            balanco.caixa_Atual = Convert.ToDecimal(dr["caixa_Atual"]);

                        if (dr["id_Periodo"] != DBNull.Value)
                            periodo.id_Periodo = Convert.ToInt32(dr["id_Periodo"]);

                        if (dr["data_Inicial"] != DBNull.Value)
                            periodo.data_Inicial = Convert.ToDateTime(dr["data_Inicial"]);

                        if (dr["data_Final"] != DBNull.Value)
                            periodo.data_Final = Convert.ToDateTime(dr["data_Final"]);




                        if(listaperiodo == null)
                            listaperiodo = new List<Modelo_Periodo>();

                        if (listabalanco == null)
                            listabalanco = new List<Modelo.Modelo_Balanco>();




                        Modelo.Modelo_Resultado_Balanco_Periodo retorno = new Modelo_Resultado_Balanco_Periodo
                        {
                            id_Periodo = periodo.id_Periodo,
                            id_Balanco = balanco.id_Balanco,
                            Caixa_Atual = balanco.caixa_Atual,
                            Total_Caixa = balanco.total_Caixa,
                            Data_Final = periodo.data_Final,
                            Data_Inicial = periodo.data_Inicial
                        };

                        resultado.Add(retorno);
                    }
                    return resultado; 
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        //Carregargird
        public List<Modelo.Modelo_Balanco> CarregarGrid_Balanco1(string strWhere)
        {
            List<Modelo.Modelo_Balanco> listabalanco = new List<Modelo.Modelo_Balanco>();

            Modelo.Modelo_Balanco balanco = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("select id_Balanco, total_Caixa , caixa_Atual from Balanco; ")
              .Append(" " + strWhere + " ");


            using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        balanco = new Modelo.Modelo_Balanco();

                        if (dr["id_Balanco"] != DBNull.Value)
                            balanco.id_Balanco = Convert.ToInt32(dr["id_Balanco"]);

                        if (dr["total_Caixa"] != DBNull.Value)
                            balanco.total_Caixa = Convert.ToDecimal(dr["total_Caixa"]);

                        if (dr["caixa_Atual"] != DBNull.Value)
                            balanco.caixa_Atual = Convert.ToDecimal(dr["caixa_Atual"]);


                        if (listabalanco == null)
                            listabalanco = new List<Modelo.Modelo_Balanco>();



                        listabalanco.Add(balanco);
                    }
                    return listabalanco;
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        //excluir balanco
        public int Excluir_Balanco(int PW_ID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM [Balanco]")
              .Append("WHERE [id_Balanco] = @id_Balanco");

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_Balanco", PW_ID);

                    conn.Open();

                    return Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //alterar Balanco
        public int Alterar_Balanco(Modelo.Modelo_Balanco id_balanco)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Update balanco set ")
              .Append("total_Caixa = @total_Caixa,")
              .Append("caixa_Atual = @caixa_Atual,")
              .Append("where  id_Balanco= @id_Balanco");
            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_balanco", id_balanco.id_Balanco);
                    cmd.Parameters.AddWithValue("@total_Caixa", id_balanco.total_Caixa);
                    cmd.Parameters.AddWithValue("@caixa_Atual", id_balanco.caixa_Atual);
                    cmd.Parameters.AddWithValue("@id_Periodo", id_balanco.Id_Periodo);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //alterar Balanco
        public int Alterar_Resultado(Modelo.Modelo_Resultado_Balanco_Periodo retorno)
        {
            StringBuilder sb = new StringBuilder();
             sb.Append( "Update Balanco set ")
              .Append("total_Caixa = @total_Caixa, ")
              .Append("caixa_Atual = @caixa_Atual ")
              .Append("Where id_Balanco = @id_Balanco ");

            

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_balanco", retorno.id_Balanco);
                    cmd.Parameters.AddWithValue("@total_Caixa", retorno.Total_Caixa);
                    cmd.Parameters.AddWithValue("@caixa_Atual", retorno.Caixa_Atual);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        
        public int Alterar_Resultado_Periodo(Modelo.Modelo_Resultado_Balanco_Periodo retorno_Periodo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Update Periodo set ")
             .Append("data_Inicial = @data_Inicial, ")
             .Append("data_Final = @data_Final ")
             .Append("Where id_Periodo = @id_Periodo ");



            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_Periodo", retorno_Periodo.id_Periodo);
                    cmd.Parameters.AddWithValue("@data_Inicial", retorno_Periodo.Data_Inicial);
                    cmd.Parameters.AddWithValue("@data_Final", retorno_Periodo.Data_Final);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
