namespace Sistema_Box_House
{
    partial class FormVendas
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
            this.cbSelecaoProdutos = new System.Windows.Forms.ComboBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.gbSecaoProduto = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvExibirItens = new System.Windows.Forms.DataGridView();
            this.gbItensPedido = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.gbSecaoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibirItens)).BeginInit();
            this.gbItensPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelecaoProdutos
            // 
            this.cbSelecaoProdutos.FormattingEnabled = true;
            this.cbSelecaoProdutos.Location = new System.Drawing.Point(98, 34);
            this.cbSelecaoProdutos.Name = "cbSelecaoProdutos";
            this.cbSelecaoProdutos.Size = new System.Drawing.Size(397, 21);
            this.cbSelecaoProdutos.TabIndex = 0;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(98, 72);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numQuantidade.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(538, 91);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(189, 443);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(157, 20);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "TOTAL DO PEDIDO:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(7, 34);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(47, 13);
            this.lbProduto.TabIndex = 5;
            this.lbProduto.Text = "Produto:";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(7, 74);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 6;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // gbSecaoProduto
            // 
            this.gbSecaoProduto.Controls.Add(this.btnAdicionar);
            this.gbSecaoProduto.Controls.Add(this.lbProduto);
            this.gbSecaoProduto.Controls.Add(this.lbQuantidade);
            this.gbSecaoProduto.Controls.Add(this.numQuantidade);
            this.gbSecaoProduto.Controls.Add(this.cbSelecaoProdutos);
            this.gbSecaoProduto.Location = new System.Drawing.Point(183, 107);
            this.gbSecaoProduto.Name = "gbSecaoProduto";
            this.gbSecaoProduto.Size = new System.Drawing.Size(644, 122);
            this.gbSecaoProduto.TabIndex = 7;
            this.gbSecaoProduto.TabStop = false;
            this.gbSecaoProduto.Text = "Seleção de Produto";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(724, 443);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(97, 23);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // dgvExibirItens
            // 
            this.dgvExibirItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibirItens.Location = new System.Drawing.Point(6, 19);
            this.dgvExibirItens.Name = "dgvExibirItens";
            this.dgvExibirItens.Size = new System.Drawing.Size(632, 150);
            this.dgvExibirItens.TabIndex = 3;
            // 
            // gbItensPedido
            // 
            this.gbItensPedido.Controls.Add(this.dgvExibirItens);
            this.gbItensPedido.Location = new System.Drawing.Point(183, 247);
            this.gbItensPedido.Name = "gbItensPedido";
            this.gbItensPedido.Size = new System.Drawing.Size(644, 180);
            this.gbItensPedido.TabIndex = 8;
            this.gbItensPedido.TabStop = false;
            this.gbItensPedido.Text = "Itens do Pedido";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 594);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gbItensPedido);
            this.Controls.Add(this.gbSecaoProduto);
            this.Controls.Add(this.lbResultado);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.gbSecaoProduto.ResumeLayout(false);
            this.gbSecaoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibirItens)).EndInit();
            this.gbItensPedido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelecaoProdutos;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.GroupBox gbSecaoProduto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvExibirItens;
        private System.Windows.Forms.GroupBox gbItensPedido;
    }
}