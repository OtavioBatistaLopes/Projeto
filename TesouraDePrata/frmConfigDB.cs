using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesouraDePrata
{
    public partial class frmConfigDB : Form
    {
        public frmConfigDB()
        {
            InitializeComponent();
        }

        //Grid da Conexão de Banco de Dados
        private void dgvInstancia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtInstancia.Text = Convert.ToString(dgvInstancia.Rows[e.RowIndex].Cells[0].Value + "\\" + dgvInstancia.Rows[e.RowIndex].Cells[1].Value);

        }

        //Carregar Grid no inicio
        private void frmConfigDB_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBancoDados.txt");
                txtInstancia.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "Erro ao se conectar no banco de dados\n" + "Acesse as configurações do banco de dados e informe os parâmetros da conexão");
            }

            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        //Conectar ao Banco
        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=" + txtInstancia.Text + ";Initial Catalog=" + txtBanco.Text + ";User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text + "";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Conexão Aberta!");
                cnn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
            }
        }

        //Gravar Instancia
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstancia.Text) || (string.IsNullOrWhiteSpace(txtBanco.Text) || (string.IsNullOrWhiteSpace(txtUsuario.Text) || (string.IsNullOrWhiteSpace(txtSenha.Text)))))
            {
                MessageBox.Show("Campo em branco");
            }
            else
            {


                try
                {
                    StreamWriter arquivo = new StreamWriter("ConfiguracaoBancoDados.txt", false);
                    arquivo.WriteLine(txtInstancia.Text);
                    arquivo.WriteLine(txtBanco.Text);
                    arquivo.WriteLine(txtUsuario.Text);
                    arquivo.WriteLine(txtSenha.Text);
                    arquivo.Close();
                    MessageBox.Show("Arquivo atualizado com sucesso!!!");
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }
            }
        }


        //Buscar Instancias
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblInstancia.Text = "Buscando instâncias, aguarde...";
            dgvInstancia.DataSource = null;
            SqlDataSourceEnumerator sqls = SqlDataSourceEnumerator.Instance;
            Refresh();
            dgvInstancia.DataSource = sqls.GetDataSources();
            if (dgvInstancia.Rows.Count == 0)
            {
                lblInstancia.Text = "Não consegui encontrar nenhuma instância. Por favor avisar o TI";
            }
            else
            {
                lblInstancia.Text = "Busca Concluida";
            }
        }
    }
}
