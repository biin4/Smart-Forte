namespace SmartForte
{
    partial class Form1
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
            this.BTCadastro = new System.Windows.Forms.Button();
            this.BTAluno = new System.Windows.Forms.Button();
            this.BTTreinadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTCadastro
            // 
            this.BTCadastro.BackColor = System.Drawing.Color.Transparent;
            this.BTCadastro.FlatAppearance.BorderSize = 0;
            this.BTCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCadastro.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTCadastro.Location = new System.Drawing.Point(334, 233);
            this.BTCadastro.Name = "BTCadastro";
            this.BTCadastro.Size = new System.Drawing.Size(131, 54);
            this.BTCadastro.TabIndex = 0;
            this.BTCadastro.Text = "Cadastro";
            this.BTCadastro.UseVisualStyleBackColor = false;
            this.BTCadastro.Click += new System.EventHandler(this.BTCadastro_Click);
            // 
            // BTAluno
            // 
            this.BTAluno.BackColor = System.Drawing.Color.Transparent;
            this.BTAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTAluno.FlatAppearance.BorderSize = 0;
            this.BTAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAluno.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.BTAluno.Location = new System.Drawing.Point(334, 293);
            this.BTAluno.Name = "BTAluno";
            this.BTAluno.Size = new System.Drawing.Size(131, 49);
            this.BTAluno.TabIndex = 1;
            this.BTAluno.Text = "Área do Aluno";
            this.BTAluno.UseVisualStyleBackColor = false;
            this.BTAluno.Click += new System.EventHandler(this.BTAluno_Click);
            // 
            // BTTreinadores
            // 
            this.BTTreinadores.BackColor = System.Drawing.Color.Transparent;
            this.BTTreinadores.FlatAppearance.BorderSize = 0;
            this.BTTreinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTreinadores.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTreinadores.Location = new System.Drawing.Point(334, 360);
            this.BTTreinadores.Name = "BTTreinadores";
            this.BTTreinadores.Size = new System.Drawing.Size(131, 44);
            this.BTTreinadores.TabIndex = 2;
            this.BTTreinadores.Text = "Acesso Treinadores";
            this.BTTreinadores.UseVisualStyleBackColor = false;
            this.BTTreinadores.Click += new System.EventHandler(this.BTTreinadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartForte.Properties.Resources.pag_inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTTreinadores);
            this.Controls.Add(this.BTAluno);
            this.Controls.Add(this.BTCadastro);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTCadastro;
        private System.Windows.Forms.Button BTAluno;
        private System.Windows.Forms.Button BTTreinadores;
    }
}

