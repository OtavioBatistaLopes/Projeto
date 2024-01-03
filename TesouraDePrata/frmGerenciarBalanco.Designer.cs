
namespace TesouraDePrata
{
    partial class frmGerenciarBalanco
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
            this.dgvBalanco1 = new System.Windows.Forms.DataGridView();
            this.id_Balanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanco1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBalanco1
            // 
            this.dgvBalanco1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalanco1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBalanco1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalanco1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Balanco,
            this.total_Caixa,
            this.caixa_Atual});
            this.dgvBalanco1.Location = new System.Drawing.Point(12, 12);
            this.dgvBalanco1.Name = "dgvBalanco1";
            this.dgvBalanco1.RowHeadersWidth = 51;
            this.dgvBalanco1.RowTemplate.Height = 24;
            this.dgvBalanco1.Size = new System.Drawing.Size(776, 384);
            this.dgvBalanco1.TabIndex = 0;
            // 
            // id_Balanco
            // 
            this.id_Balanco.DataPropertyName = "id_Balanco";
            this.id_Balanco.HeaderText = "ID";
            this.id_Balanco.MinimumWidth = 6;
            this.id_Balanco.Name = "id_Balanco";
            // 
            // total_Caixa
            // 
            this.total_Caixa.DataPropertyName = "total_Caixa";
            this.total_Caixa.HeaderText = "Total Caixa";
            this.total_Caixa.MinimumWidth = 6;
            this.total_Caixa.Name = "total_Caixa";
            // 
            // caixa_Atual
            // 
            this.caixa_Atual.DataPropertyName = "caixa_Atual";
            this.caixa_Atual.HeaderText = "Caixa Atual";
            this.caixa_Atual.MinimumWidth = 6;
            this.caixa_Atual.Name = "caixa_Atual";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(50, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(131, 415);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmGerenciarBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvBalanco1);
            this.Name = "frmGerenciarBalanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanco1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBalanco1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Balanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_Atual;
    }
}