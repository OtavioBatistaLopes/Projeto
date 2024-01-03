using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Despesa_BLL
    {
        //Incluir Despesa
        public int Incluir_Despesa(Modelo.Modelo_Despesas despesas)
        {

            try
            {
                return new DAL.Despesa_DAL().Incluir_Despesa(despesas);
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

        //Excluir Despesa
        public int Excluir_Despesa(int PW_ID)
        {
            try
            {
                return new DAL.Despesa_DAL().Excluir_Despesa(PW_ID);
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

        //Carregar grid Despesa
        public List<Modelo.Modelo_Despesas> CarregarGrid_Despesa(string strWhere)
        {
            try
            {
                return new DAL.Despesa_DAL().CarregarGrid_Despesa(strWhere);

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

        //Alterar Despesa
        public int Alterar_Despesa(Modelo.Modelo_Despesas despesa)

        {
            try
            {
                return new DAL.Despesa_DAL().Alterar_Despesa(despesa);
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


        //Carrega ComboBox
        public class CarregaPeriodo
        {
            public List<Modelo.Modelo_Periodo> CarregaComboBox()
            {
                try
                {
                    return new DAL.Despesa_DAL().CarregaComboBox();
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
}
