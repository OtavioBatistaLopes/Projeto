using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesouraDePrata
{
    public partial class frmDespesa : Form
    {
        public frmDespesa()
        {
            InitializeComponent();
            CarregarGrid_Despesa();
        }

        //Carregar Grid
        private void CarregarGrid_Despesa()
        {
            string strWhere = "";
            List<Modelo.Modelo_Despesas> despesa = new BLL.Despesa_BLL().CarregarGrid_Despesa(strWhere);
            dgvDespesa.AutoGenerateColumns = false;
            dgvDespesa.DataSource = despesa;
            dgvDespesa.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDespesa.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        //Adicinar Despesa
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Modelo.Modelo_Despesas despesa = new Modelo.Modelo_Despesas();

            try
            {
                despesa.nome_Despesa = (txtNome.Text);
                despesa.valor_Despesa = Convert.ToDecimal(txtValor.Text);
                despesa.status_Despesa = (cbPeriodo.Text);
                despesa.observacao_Despesa = (txtObeservacao.Text);
                string despesas = new BLL.Despesa_BLL().Incluir_Despesa(despesa).ToString();
                MessageBox.Show("Despesa cadastrada com sucesso!");
                CarregarGrid_Despesa();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Excluir Despesa
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esta despesa?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modelo.Modelo_Despesas despesas = new Modelo.Modelo_Despesas();
                despesas.id_Despesa = int.Parse(dgvDespesa.CurrentRow.Cells[0].Value.ToString());
                new BLL.Despesa_BLL().Excluir_Despesa(Convert.ToInt32(despesas.id_Despesa));
                CarregarGrid_Despesa();
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Não Foi possivel excluir");
            }
        }

        //Alterar Despesa
        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Modelo.Modelo_Despesas despesa = new Modelo.Modelo_Despesas();

            if (MessageBox.Show("Tem certeza que deseja alterar?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                despesa.id_Despesa = int.Parse(dgvDespesa.CurrentRow.Cells[0].Value.ToString());
                despesa.nome_Despesa = (dgvDespesa.CurrentRow.Cells[1].Value.ToString());
                despesa.valor_Despesa = decimal.Parse(dgvDespesa.CurrentRow.Cells[2].Value.ToString());
                despesa.observacao_Despesa = (dgvDespesa.CurrentRow.Cells[3].Value.ToString());
                new BLL.Despesa_BLL().Alterar_Despesa((despesa));
                CarregarGrid_Despesa();
                
            }
            else
            {
                CarregarGrid_Despesa();
            };
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            List<Modelo.Modelo_Periodo> CarregaPeriodo = new BLL.Despesa_BLL.CarregaPeriodo().CarregaComboBox();
            cbPeriodo.ValueMember = "id_Periodo";
            cbPeriodo.DisplayMember = "data_Inicial";
            cbPeriodo.DataSource = CarregaPeriodo;
        }
    }
}
