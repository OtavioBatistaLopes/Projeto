using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class Despesa_DAL
    {

        //Adicionar Despesa
        public int Incluir_Despesa(Modelo.Modelo_Despesas despesas)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO Despesas(nome_Despesa, valor_Despesa, observacao_Despesa)")
              .Append("VALUES (@nome_Despesa, @valor_Despesa, @observacao_Despesa) ")
              .Append("SELECT @@IDENTITY");

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@nome_Despesa", despesas.nome_Despesa);
                    cmd.Parameters.AddWithValue("@valor_Despesa", despesas.valor_Despesa);
                    cmd.Parameters.AddWithValue("@observacao_Despesa", despesas.observacao_Despesa);

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

       

        //excluir Despesa
        public int Excluir_Despesa(int PW_ID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM [Despesas]")
              .Append("WHERE [id_Despesa] = @id_Despesa");

            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_Despesa", PW_ID);

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

        //Carregargird Desepsa
        public List<Modelo.Modelo_Despesas> CarregarGrid_Despesa(string strWhere)
        {
            List<Modelo.Modelo_Despesas> listadespesa = new List<Modelo.Modelo_Despesas>();

            Modelo.Modelo_Despesas despesa = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("select id_Despesa, nome_Despesa , valor_Despesa, observacao_Despesa from Despesas; ")
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
                        despesa = new Modelo.Modelo_Despesas();

                        if (dr["id_Despesa"] != DBNull.Value)
                            despesa.id_Despesa = Convert.ToInt32(dr["id_Despesa"]);

                        if (dr["nome_Despesa"] != DBNull.Value)
                            despesa.nome_Despesa = (dr["nome_Despesa"].ToString());

                        if (dr["valor_Despesa"] != DBNull.Value)
                            despesa.valor_Despesa = Convert.ToDecimal(dr["valor_Despesa"]);

                        if (dr["observacao_Despesa"] != DBNull.Value)
                            despesa.observacao_Despesa = (dr["observacao_Despesa"].ToString());


                        if (listadespesa == null)
                            listadespesa = new List<Modelo.Modelo_Despesas>();



                        listadespesa.Add(despesa);
                    }
                    return listadespesa;
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

        //alterar Despesa
        public int Alterar_Despesa(Modelo.Modelo_Despesas despesa)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Update Despesas set ")
              .Append("nome_Despesa = @nome_despesa, ")
              .Append("valor_Despesa = @valor_Despesa, ")
              .Append("observacao_Despesa = @observacao_Despesa ")
              .Append("where  id_Despesa = @id_Despesa");
            try
            {
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@id_Despesa", despesa.id_Despesa);
                    cmd.Parameters.AddWithValue("@nome_Despesa", despesa.nome_Despesa);
                    cmd.Parameters.AddWithValue("@valor_Despesa", despesa.valor_Despesa);
                    cmd.Parameters.AddWithValue("@observacao_Despesa", despesa.observacao_Despesa);

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

        //ComboBox
        public List<Modelo.Modelo_Periodo> CarregaComboBox()
        {
            List<Modelo.Modelo_Periodo> listaPeriodos = null;
            //  nome da classe Objeto
            Modelo.Modelo_Periodo objListaPeriodo = null;

            // vamos montrar o Select do BD
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Periodo ")
              .Append("ORDER BY id_Periodo");

            try
            {
                // SqlConnection fica dentro da classe System.Data.SqlClient
                using (SqlConnection conn = new SqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                    // abre conexão BD
                    conn.Open();

                    // dr = data reader
                    // vai no BD e executa o commando Select ...
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (listaPeriodos == null)
                        {
                            listaPeriodos = new List<Modelo.Modelo_Periodo>();
                        }

                        // para cada item que vem do banco tem que ter um new para criar o objeto
                        objListaPeriodo = new Modelo.Modelo_Periodo();
                        objListaPeriodo = new Modelo.Modelo_Periodo();

                        if (dr["id_Periodo"] != DBNull.Value)
                            // .cncID da classe entities  o que esta dentro do dr é do BD
                            objListaPeriodo.id_Periodo = Convert.ToInt32(dr["id_Periodo"]);

                        // .cncID da classe entities  o que esta dentro do dr é do BD
                        if (dr["data_Inicial"] != DBNull.Value)
                            objListaPeriodo.data_Inicial = Convert.ToDateTime(dr["data_Inicial"]);

                        if (dr["data_Final"] != DBNull.Value)
                            objListaPeriodo.data_Final = Convert.ToDateTime(dr["data_Final"]);

                        
                        // adicionar o objeto objComonosconheceu na lista
                        listaPeriodos.Add(objListaPeriodo);
                    }
                }

                if (listaPeriodos != null)
                {
                    // Adiciono no combo a opção Selecione que não esta cadastrado na tabela
                    listaPeriodos.Insert(0, new Modelo.Modelo_Periodo { id_Periodo = -1});
                }

                return listaPeriodos;
               


            }
            catch (SqlException) // Erro BD
            {
                throw;
            }

            catch (Exception) // Erro Genérico
            {
                throw;
            }
        }
    }
}
