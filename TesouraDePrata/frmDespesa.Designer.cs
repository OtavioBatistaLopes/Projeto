
namespace TesouraDePrata
{
    partial class frmDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObeservacao = new System.Windows.Forms.TextBox();
            this.Periodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.id_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao_Despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.cbPeriodo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtObeservacao);
            this.panel1.Controls.Add(this.Periodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 703);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data de vencimento";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(51, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = global::TesouraDePrata.Properties.Resources.SAM_removebg_preview;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 239);
            this.panel2.TabIndex = 13;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(153, 575);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(51, 604);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(202, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(51, 575);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "A pagar"});
            this.cbPeriodo.Location = new System.Drawing.Point(51, 419);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(202, 24);
            this.cbPeriodo.TabIndex = 9;
            this.cbPeriodo.Text = "Selecione";
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // txtObeservacao
            // 
            this.txtObeservacao.Location = new System.Drawing.Point(51, 482);
            this.txtObeservacao.Multiline = true;
            this.txtObeservacao.Name = "txtObeservacao";
            this.txtObeservacao.Size = new System.Drawing.Size(202, 87);
            this.txtObeservacao.TabIndex = 4;
            // 
            // Periodo
            // 
            this.Periodo.AutoSize = true;
            this.Periodo.Location = new System.Drawing.Point(52, 394);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(57, 17);
            this.Periodo.TabIndex = 6;
            this.Periodo.Text = "Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Despesa";
            // 
            // txtValor
            // 
            this.txtValor.AccessibleName = "";
            this.txtValor.Location = new System.Drawing.Point(51, 310);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(202, 22);
            this.txtValor.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 262);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 22);
            this.txtNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDespesa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Despesa,
            this.nome_Despesa,
            this.valor_Despesa,
            this.observacao_Despesa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDespesa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDespesa.EnableHeadersVisualStyles = false;
            this.dgvDespesa.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgvDespesa.Location = new System.Drawing.Point(306, 0);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.RowHeadersWidth = 51;
            this.dgvDespesa.RowTemplate.Height = 24;
            this.dgvDespesa.Size = new System.Drawing.Size(755, 703);
            this.dgvDespesa.TabIndex = 1;
            // 
            // id_Despesa
            // 
            this.id_Despesa.DataPropertyName = "id_Despesa";
            this.id_Despesa.HeaderText = "ID";
            this.id_Despesa.MinimumWidth = 6;
            this.id_Despesa.Name = "id_Despesa";
            // 
            // nome_Despesa
            // 
            this.nome_Despesa.DataPropertyName = "nome_Despesa";
            this.nome_Despesa.HeaderText = "Despesa";
            this.nome_Despesa.MinimumWidth = 6;
            this.nome_Despesa.Name = "nome_Despesa";
            // 
            // valor_Despesa
            // 
            this.valor_Despesa.DataPropertyName = "valor_Despesa";
            this.valor_Despesa.HeaderText = "Valor";
            this.valor_Despesa.MinimumWidth = 6;
            this.valor_Despesa.Name = "valor_Despesa";
            // 
            // observacao_Despesa
            // 
            this.observacao_Despesa.DataPropertyName = "observacao_Despesa";
            this.observacao_Despesa.HeaderText = "Obeservação";
            this.observacao_Despesa.MinimumWidth = 6;
            this.observacao_Despesa.Name = "observacao_Despesa";
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1061, 703);
            this.Controls.Add(this.dgvDespesa);
            this.Controls.Add(this.panel1);
            this.Name = "frmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObeservacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_Despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao_Despesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}