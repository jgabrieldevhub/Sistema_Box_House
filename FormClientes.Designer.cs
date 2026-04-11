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
            this.SuspendLayout();
            // 
            // gbSecaoCadastro
            // 
            this.gbSecaoCadastro.Location = new System.Drawing.Point(368, 102);
            this.gbSecaoCadastro.Name = "gbSecaoCadastro";
            this.gbSecaoCadastro.Size = new System.Drawing.Size(576, 136);
            this.gbSecaoCadastro.TabIndex = 0;
            this.gbSecaoCadastro.TabStop = false;
            this.gbSecaoCadastro.Text = "Cadastro de Novos Clientes";
            // 
            // gbListaCadastro
            // 
            this.gbListaCadastro.Location = new System.Drawing.Point(368, 272);
            this.gbListaCadastro.Name = "gbListaCadastro";
            this.gbListaCadastro.Size = new System.Drawing.Size(576, 141);
            this.gbListaCadastro.TabIndex = 1;
            this.gbListaCadastro.TabStop = false;
            this.gbListaCadastro.Text = "Lista de Clientes Cadastrados";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 607);
            this.Controls.Add(this.gbListaCadastro);
            this.Controls.Add(this.gbSecaoCadastro);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSecaoCadastro;
        private System.Windows.Forms.GroupBox gbListaCadastro;
    }
}