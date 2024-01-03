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
    public partial class frmGerenciarBalanco : Form
    {
        public frmGerenciarBalanco()
        {
            InitializeComponent();
            CarregarGrid_Balanco1();
        }


        //Carregar Grid
        private void CarregarGrid_Balanco1()
        {
            string strWhere = "";
            List<Modelo.Modelo_Balanco> resultado = new BLL.Balanco_BLL().CarregarGrid_Balanco1(strWhere);
            dgvBalanco1.AutoGenerateColumns = false;
            dgvBalanco1.DataSource = resultado;
            dgvBalanco1.RowsDefaultCellStyle.BackColor = Color.White;
            dgvBalanco1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir um usuário?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modelo.Modelo_Balanco balanco = new Modelo.Modelo_Balanco();
                balanco.id_Balanco = int.Parse(dgvBalanco1.CurrentRow.Cells[0].Value.ToString());
                new BLL.Balanco_BLL().Excluir_Balanco(Convert.ToInt32(balanco.id_Balanco));
                CarregarGrid_Balanco1();
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Modelo.Modelo_Balanco balanco = new Modelo.Modelo_Balanco();

            if (MessageBox.Show("Tem certeza que deseja alterar?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                balanco.id_Balanco = int.Parse(dgvBalanco1.CurrentRow.Cells[0].Value.ToString());
                balanco.total_Caixa = decimal.Parse(dgvBalanco1.CurrentRow.Cells[1].Value.ToString());
                balanco.caixa_Atual = decimal.Parse(dgvBalanco1.CurrentRow.Cells[2].Value.ToString());
                balanco.Id_Periodo = int.Parse(dgvBalanco1.CurrentRow.Cells[3].Value.ToString());
                new BLL.Balanco_BLL().Alterar_Balanco((balanco));
                MessageBox.Show("Alteração efetuada com sucesso!");
                CarregarGrid_Balanco1();
            }
        }
    }
}
