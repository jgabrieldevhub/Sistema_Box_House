namespace Sistema_Box_House
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(393, 210);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(220, 71);
            this.btnVenda.TabIndex = 0;
            this.btnVenda.Text = "NOVA VENDA";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(645, 210);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(231, 71);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "CADASTRAR CLIENTE";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Location = new System.Drawing.Point(393, 329);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(229, 68);
            this.btnEntrega.TabIndex = 2;
            this.btnEntrega.Text = "CONTROLE DE ENTREGAS";
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(645, 329);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(231, 68);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "FECHAR SISTEMA";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 612);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnVenda);
            this.Name = "FormPrincipal";
            this.Text = "Form Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnFechar;
    }
}

