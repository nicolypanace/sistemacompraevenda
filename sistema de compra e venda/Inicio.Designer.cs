namespace sistema_de_compra_e_venda
{
    partial class Inicio
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
            this.btlogin = new System.Windows.Forms.Button();
            this.btcadastro = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(361, 418);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(300, 89);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btcadastro
            // 
            this.btcadastro.Location = new System.Drawing.Point(884, 21);
            this.btcadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.Size = new System.Drawing.Size(153, 42);
            this.btcadastro.TabIndex = 1;
            this.btcadastro.Text = "CADASTRO";
            this.btcadastro.UseVisualStyleBackColor = true;
            this.btcadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(13, 28);
            this.btsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(107, 28);
            this.btsair.TabIndex = 2;
            this.btsair.Text = "SAIR";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.button3_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btcadastro);
            this.Controls.Add(this.btlogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btcadastro;
        private System.Windows.Forms.Button btsair;
    }
}

