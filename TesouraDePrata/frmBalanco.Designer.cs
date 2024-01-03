
namespace TesouraDePrata
{
    partial class frmBalanco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodoFim = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodoInicio = new System.Windows.Forms.TextBox();
            this.txtCaixa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBalanco = new System.Windows.Forms.DataGridView();
            this.id_Balanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPeriodoFim);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPeriodoInicio);
            this.panel1.Controls.Add(this.txtCaixa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 545);
            this.panel1.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(125, 350);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar ";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(39, 379);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(173, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(39, 350);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periodo Fim";
            // 
            // txtPeriodoFim
            // 
            this.txtPeriodoFim.Location = new System.Drawing.Point(39, 321);
            this.txtPeriodoFim.Name = "txtPeriodoFim";
            this.txtPeriodoFim.Size = new System.Drawing.Size(173, 22);
            this.txtPeriodoFim.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TesouraDePrata.Properties.Resources.SAM_removebg_preview;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 197);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo Inicio";
            // 
            // txtPeriodoInicio
            // 
            this.txtPeriodoInicio.Location = new System.Drawing.Point(39, 263);
            this.txtPeriodoInicio.Name = "txtPeriodoInicio";
            this.txtPeriodoInicio.Size = new System.Drawing.Size(173, 22);
            this.txtPeriodoInicio.TabIndex = 1;
            // 
            // txtCaixa
            // 
            this.txtCaixa.Location = new System.Drawing.Point(39, 206);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.Size = new System.Drawing.Size(173, 22);
            this.txtCaixa.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 0);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(251, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 10);
            this.panel4.TabIndex = 4;
            // 
            // dgvBalanco
            // 
            this.dgvBalanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalanco.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBalanco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvBalanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Balanco,
            this.caixa_Total,
            this.caixa_Atual,
            this.id_Periodo,
            this.data_Inicial,
            this.data_Final});
            this.dgvBalanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalanco.Location = new System.Drawing.Point(251, 10);
            this.dgvBalanco.Name = "dgvBalanco";
            this.dgvBalanco.RowHeadersWidth = 51;
            this.dgvBalanco.RowTemplate.Height = 24;
            this.dgvBalanco.Size = new System.Drawing.Size(859, 535);
            this.dgvBalanco.TabIndex = 5;
            // 
            // id_Balanco
            // 
            this.id_Balanco.DataPropertyName = "id_Balanco";
            this.id_Balanco.HeaderText = "Código Balanço";
            this.id_Balanco.MinimumWidth = 6;
            this.id_Balanco.Name = "id_Balanco";
            this.id_Balanco.Visible = false;
            // 
            // caixa_Total
            // 
            this.caixa_Total.DataPropertyName = "total_Caixa";
            this.caixa_Total.HeaderText = "Caixa Inicial";
            this.caixa_Total.MinimumWidth = 6;
            this.caixa_Total.Name = "caixa_Total";
            // 
            // caixa_Atual
            // 
            this.caixa_Atual.DataPropertyName = "caixa_Atual";
            this.caixa_Atual.HeaderText = "Caixa Atual";
            this.caixa_Atual.MinimumWidth = 6;
            this.caixa_Atual.Name = "caixa_Atual";
            // 
            // id_Periodo
            // 
            this.id_Periodo.DataPropertyName = "id_Periodo";
            this.id_Periodo.HeaderText = "id_Periodo";
            this.id_Periodo.MinimumWidth = 6;
            this.id_Periodo.Name = "id_Periodo";
            this.id_Periodo.Visible = false;
            // 
            // data_Inicial
            // 
            this.data_Inicial.DataPropertyName = "data_Inicial";
            this.data_Inicial.HeaderText = "Periodo Início";
            this.data_Inicial.MinimumWidth = 6;
            this.data_Inicial.Name = "data_Inicial";
            // 
            // data_Final
            // 
            this.data_Final.DataPropertyName = "data_Final";
            this.data_Final.HeaderText = "Periodo Fim";
            this.data_Final.MinimumWidth = 6;
            this.data_Final.Name = "data_Final";
            // 
            // frmBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1110, 545);
            this.Controls.Add(this.dgvBalanco);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBalanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanço";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPeriodoInicio;
        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeriodoFim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvBalanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Balanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_Atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_Final;
    }
}