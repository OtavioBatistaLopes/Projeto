using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Balanco_BLL
    {
        //Adicionar Balanco
        public int Incluir_Balanco(Modelo.Modelo_Balanco balanco)
        {
            try
            {
                return new DAL.Balanco_DAL().Incluir_Balanco(balanco);
               
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);
            }
        }


        //Carregargrid periodo e Balanco
        public List<Modelo.Modelo_Resultado_Balanco_Periodo> CarregarGrid_Balanco(string strWhere)
        {
            try
            {
                return new DAL.Balanco_DAL().CarregarGrid_Balanco(strWhere);
 
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);
            }
        }

        //Carregar grid balanco
        public List<Modelo.Modelo_Balanco> CarregarGrid_Balanco1(string strWhere)
        {
            try
            {
                return new DAL.Balanco_DAL().CarregarGrid_Balanco1(strWhere);

            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);
            }
        }


        //Excluir Balanco
        public int Excluir_Balanco(int PW_ID)
        {
            try
            {
                return new DAL.Balanco_DAL().Excluir_Balanco(PW_ID);
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);
            }
        }


        //Alterar Balanco
        public int Alterar_Balanco(Modelo.Modelo_Balanco id_balanco)

        {
            try
            {
                return new DAL.Balanco_DAL().Alterar_Balanco(id_balanco);
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);

            }
        }

        //Alterar Balanco 
        public int Alterar_Resultado(Modelo.Modelo_Resultado_Balanco_Periodo retorno)

        {
            try
            {
                return new DAL.Balanco_DAL().Alterar_Resultado(retorno);
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);

            }
        }

        //Alterar  Periodo
        public int Alterar_Resultado_Periodo(Modelo.Modelo_Resultado_Balanco_Periodo retorno_Periodo)

        {
            try
            {
                return new DAL.Balanco_DAL().Alterar_Resultado_Periodo(retorno_Periodo);
            }
            catch (SqlException sqlEx)
            {
                string msg = Funcoes.Mensagens.RetornaMsgSQLException(sqlEx);
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                string msg = Funcoes.Mensagens.RetornaMsgException(ex);
                throw new Exception(msg);

            }
        }

       
    }
}
