namespace Sistema_Box_House
{
    partial class FormClientes
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
            this.gbSecaoCadastro = new System.Windows.Forms.GroupBox();
            this.gbListaCadastro = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNomePet = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientesCadastrados = new System.Windows.Forms.DataGridView();
            this.gbSecaoCadastro.SuspendLayout();
            this.gbListaCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSecaoCadastro
            // 
            this.gbSecaoCadastro.Controls.Add(this.btnBuscar);
            this.gbSecaoCadastro.Controls.Add(this.btnLimpar);
            this.gbSecaoCadastro.Controls.Add(this.btnSalvar);
            this.gbSecaoCadastro.Controls.Add(this.txtTelefone);
            this.gbSecaoCadastro.Controls.Add(this.txtNomePet);
            this.gbSecaoCadastro.Controls.Add(this.cbNome);
            this.gbSecaoCadastro.Controls.Add(this.lbNomePet);
            this.gbSecaoCadastro.Controls.Add(this.lbTelefone);
            this.gbSecaoCadastro.Controls.Add(this.lbNome);
            this.gbSecaoCadastro.Location = new System.Drawing.Point(368, 102);
            this.gbSecaoCadastro.Name = "gbSecaoCadastro";
            this.gbSecaoCadastro.Size = new System.Drawing.Size(576, 197);
            this.gbSecaoCadastro.TabIndex = 0;
            this.gbSecaoCadastro.TabStop = false;
            this.gbSecaoCadastro.Text = "Cadastro de Novos Clientes";
            // 
            // gbListaCadastro
            // 
            this.gbListaCadastro.Controls.Add(this.dgvClientesCadastrados);
            this.gbListaCadastro.Location = new System.Drawing.Point(368, 315);
            this.gbListaCadastro.Name = "gbListaCadastro";
            this.gbListaCadastro.Size = new System.Drawing.Size(576, 189);
            this.gbListaCadastro.TabIndex = 1;
            this.gbListaCadastro.TabStop = false;
            this.gbListaCadastro.Text = "Lista de Clientes Cadastrados";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(6, 37);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(6, 66);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 3;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbNomePet
            // 
            this.lbNomePet.AutoSize = true;
            this.lbNomePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePet.Location = new System.Drawing.Point(6, 99);
            this.lbNomePet.Name = "lbNomePet";
            this.lbNomePet.Size = new System.Drawing.Size(69, 13);
            this.lbNomePet.TabIndex = 2;
            this.lbNomePet.Text = "Nome do Pet";
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(103, 34);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(467, 21);
            this.cbNome.TabIndex = 4;
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(103, 99);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(467, 20);
            this.txtNomePet.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(103, 66);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(167, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 151);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(178, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar Cliente";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(193, 151);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(184, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(383, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(187, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar por Nome";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvClientesCadastrados
            // 
            this.dgvClientesCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCadastrados.Location = new System.Drawing.Point(9, 19);
            this.dgvClientesCadastrados.Name = "dgvClientesCadastrados";
            this.dgvClientesCadastrados.Size = new System.Drawing.Size(561, 164);
            this.dgvClientesCadastrados.TabIndex = 0;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 745);
            this.Controls.Add(this.gbListaCadastro);
            this.Controls.Add(this.gbSecaoCadastro);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.gbSecaoCadastro.ResumeLayout(false);
            this.gbSecaoCadastro.PerformLayout();
            this.gbListaCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSecaoCadastro;
        private System.Windows.Forms.GroupBox gbListaCadastro;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNomePet;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvClientesCadastrados;
    }
}