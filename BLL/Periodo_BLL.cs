using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Periodo_BLL
    {
        //Adicionar Periodo
        public int Incluir_Periodo(Modelo.Modelo_Periodo periodo)
        {
            try
            {
                return new DAL.Periodo_DAL().Incluir_Periodo(periodo);
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

        //Carregargrid
        public List<Modelo.Modelo_Periodo> CarregarGrid_Periodo(string strWhere)
        {
            try
            {
                return new DAL.Periodo_DAL().CarregarGrid_Periodo(strWhere);
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

        //Excluir Periodo
        public int Excluir_Perido(int PW_ID)
        {
            try
            {
                return new DAL.Periodo_DAL().Excluir_Periodo(PW_ID);
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

        //Alterar Periodo
        public int Alterar_Periodo(Modelo.Modelo_Periodo id_periodo)

        {
            try
            {
                return new DAL.Periodo_DAL().Alterar_Periodo(id_periodo);
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
