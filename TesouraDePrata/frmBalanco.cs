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

namespace TesouraDePrata
{
    public partial class frmBalanco : Form
    {
        public frmBalanco()
        {
            InitializeComponent();
            CarregarGrid_Balanco();
            
        }


        //Carregar Grid
        private void CarregarGrid_Periodo()
        {
            string strWhere = "";
            List<Modelo.Modelo_Periodo> listaperiodo = new BLL.Periodo_BLL().CarregarGrid_Periodo(strWhere);
            dgvBalanco.AutoGenerateColumns = false;
            dgvBalanco.DataSource = listaperiodo;
            dgvBalanco.RowsDefaultCellStyle.BackColor = Color.White;
            dgvBalanco.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        //Carregar Grid
        private void CarregarGrid_Balanco()
        {
            string strWhere = "";
            List<Modelo.Modelo_Resultado_Balanco_Periodo> resultado = new BLL.Balanco_BLL().CarregarGrid_Balanco(strWhere);
            dgvBalanco.AutoGenerateColumns = false;
            dgvBalanco.DataSource = resultado;
            dgvBalanco.RowsDefaultCellStyle.BackColor = Color.White;
            dgvBalanco.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }


        //adicionar Balanço
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                Modelo.Modelo_Periodo periodo = new Modelo.Modelo_Periodo();
                periodo.data_Inicial = Convert.ToDateTime(txtPeriodoInicio.Text);
                periodo.data_Final = Convert.ToDateTime(txtPeriodoFim.Text);

                string periodos =  new BLL.Periodo_BLL().Incluir_Periodo(periodo).ToString();
        
                Modelo.Modelo_Balanco balanco = new Modelo.Modelo_Balanco();
                balanco.Id_Periodo = Convert.ToInt32(periodos);
                balanco.total_Caixa = Convert.ToDecimal(txtCaixa.Text); 
                balanco.caixa_Atual = balanco.total_Caixa;

                string balancos = new BLL.Balanco_BLL().Incluir_Balanco(balanco).ToString();

                MessageBox.Show("Balanço cadastrado com sucesso!");
                CarregarGrid_Balanco();
            }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
          
        }


        //Excluir Balanco
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este balanço?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modelo.Modelo_Balanco balanco = new Modelo.Modelo_Balanco();
                balanco.id_Balanco = int.Parse(dgvBalanco.CurrentRow.Cells[0].Value.ToString());
                new BLL.Balanco_BLL().Excluir_Balanco(Convert.ToInt32(balanco.id_Balanco));
                CarregarGrid_Balanco();
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {

            }
        }



        //Alterar Balanco 
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Modelo.Modelo_Resultado_Balanco_Periodo retorno = new Modelo.Modelo_Resultado_Balanco_Periodo();
            Modelo.Modelo_Resultado_Balanco_Periodo retorno_Periodo = new Modelo.Modelo_Resultado_Balanco_Periodo();

            if (MessageBox.Show("Tem certeza que deseja alterar?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                retorno.id_Balanco = int.Parse(dgvBalanco.CurrentRow.Cells[0].Value.ToString());
                retorno.Total_Caixa = decimal.Parse(dgvBalanco.CurrentRow.Cells[1].Value.ToString());
                retorno.Caixa_Atual = decimal.Parse(dgvBalanco.CurrentRow.Cells[2].Value.ToString());
                new BLL.Balanco_BLL().Alterar_Resultado((retorno));
                retorno_Periodo.id_Periodo = int.Parse(dgvBalanco.CurrentRow.Cells[3].Value.ToString());
                retorno_Periodo.Data_Inicial = DateTime.Parse(dgvBalanco.CurrentRow.Cells[4].Value.ToString());
                retorno_Periodo.Data_Final = DateTime.Parse(dgvBalanco.CurrentRow.Cells[5].Value.ToString());
                new BLL.Balanco_BLL().Alterar_Resultado_Periodo((retorno_Periodo));
                CarregarGrid_Balanco();
            }
            else {
                CarregarGrid_Balanco();
            };

        }
    }
}

