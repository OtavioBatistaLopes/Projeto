using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Periodo_DAL
    {
        //Adicionar Periodo
        public int Incluir_Periodo(Modelo.Modelo_Periodo periodo)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO periodo(data_Inicial, data_Final)")
              .Append("VALUES (@data_Inicial, @data_Final) ")
              .Append("SELECT @@IDENTITY");

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@data_Inicial",periodo.data_Inicial );
                    cmd.Parameters.AddWithValue("@data_Final",periodo.data_Final );


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
        public List<Modelo.Modelo_Periodo> CarregarGrid_Periodo(string strWhere)
        {
            List<Modelo.Modelo_Periodo> listaperiodo = new List<Modelo.Modelo_Periodo>();
            Modelo.Modelo_Periodo periodo= null;

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT id_Periodo, data_Inicial, data_Final FROM Periodo ")
              .Append("" + strWhere + " ")
              .Append("ORDER BY id_Periodo");

            using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        periodo = new Modelo.Modelo_Periodo();

                        if (dr["id_Periodo"] != DBNull.Value)
                            periodo.id_Periodo = Convert.ToInt32(dr["id_Periodo"]);

                        if (dr["data_Inicial"] != DBNull.Value)
                            periodo.data_Inicial = Convert.ToDateTime(dr["data_Inicial"]);

                        if (dr["data_Final"] != DBNull.Value)
                            periodo.data_Final = Convert.ToDateTime(dr["data_Final"]);

                        if (listaperiodo == null)
                            listaperiodo = new List<Modelo.Modelo_Periodo>();

                        listaperiodo.Add(periodo);
                    }

                    return listaperiodo;
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

        //Excluir Periodo
        public int Excluir_Periodo(int PW_ID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM [Periodo]")
              .Append("WHERE [id_Periodo] = @id_Periodo");

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_Periodo", PW_ID);

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

        //Alterar Periodo
        public int Alterar_Periodo(Modelo.Modelo_Periodo id_periodo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Update periodo set ")
              .Append("data_Inicial = @data_Inicial, ")
              .Append("data_Final = @data_Final, ")
              .Append("where id_Periodo = @id_Periodo");
            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_Periodo", id_periodo.id_Periodo);
                    cmd.Parameters.AddWithValue("@data_Inicial", id_periodo.data_Inicial);
                    cmd.Parameters.AddWithValue("@data_Final", id_periodo.data_Final);

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
