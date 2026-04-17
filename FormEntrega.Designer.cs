namespace Sistema_Box_House
{
    partial class FormEntrega
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
            this.gbGerenciarEntregas = new System.Windows.Forms.GroupBox();
            this.gbListaEntregas = new System.Windows.Forms.GroupBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbGerenciarEntregas.SuspendLayout();
            this.gbListaEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGerenciarEntregas
            // 
            this.gbGerenciarEntregas.Controls.Add(this.btnAtualizar);
            this.gbGerenciarEntregas.Controls.Add(this.cbCliente);
            this.gbGerenciarEntregas.Controls.Add(this.btnAdicionar);
            this.gbGerenciarEntregas.Controls.Add(this.btnLimpar);
            this.gbGerenciarEntregas.Controls.Add(this.txtEntrega);
            this.gbGerenciarEntregas.Controls.Add(this.cbStatus);
            this.gbGerenciarEntregas.Controls.Add(this.lbStatus);
            this.gbGerenciarEntregas.Controls.Add(this.lbEndereco);
            this.gbGerenciarEntregas.Controls.Add(this.lbCliente);
            this.gbGerenciarEntregas.Location = new System.Drawing.Point(378, 138);
            this.gbGerenciarEntregas.Name = "gbGerenciarEntregas";
            this.gbGerenciarEntregas.Size = new System.Drawing.Size(552, 176);
            this.gbGerenciarEntregas.TabIndex = 0;
            this.gbGerenciarEntregas.TabStop = false;
            this.gbGerenciarEntregas.Text = "Gerenciar Entregas de Pedidos";
            // 
            // gbListaEntregas
            // 
            this.gbListaEntregas.Controls.Add(this.dataGridView1);
            this.gbListaEntregas.Location = new System.Drawing.Point(378, 320);
            this.gbListaEntregas.Name = "gbListaEntregas";
            this.gbListaEntregas.Size = new System.Drawing.Size(552, 206);
            this.gbListaEntregas.TabIndex = 1;
            this.gbListaEntregas.TabStop = false;
            this.gbListaEntregas.Text = "Lista de Entregas Cadastrados";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(6, 34);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(95, 13);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.Text = "Selecionar Cliente:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(6, 66);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(111, 13);
            this.lbEndereco.TabIndex = 1;
            this.lbEndereco.Text = "Endereço de Entrega:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(6, 101);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(64, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status Atual";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(134, 31);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(412, 21);
            this.cbCliente.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(134, 98);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(412, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Location = new System.Drawing.Point(134, 66);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(412, 20);
            this.txtEntrega.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(9, 141);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(175, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar Entrega";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(190, 141);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(372, 141);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(174, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar Status Selecionados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 786);
            this.Controls.Add(this.gbListaEntregas);
            this.Controls.Add(this.gbGerenciarEntregas);
            this.Name = "FormEntrega";
            this.Text = "FormEntrega";
            this.gbGerenciarEntregas.ResumeLayout(false);
            this.gbGerenciarEntregas.PerformLayout();
            this.gbListaEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGerenciarEntregas;
        private System.Windows.Forms.GroupBox gbListaEntregas;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}