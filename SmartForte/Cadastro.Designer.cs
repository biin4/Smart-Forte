namespace SmartForte
{
    partial class Cadastro
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
            this.BTVoltar3 = new System.Windows.Forms.Button();
            this.DocumentoCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaPlanos = new System.Windows.Forms.ComboBox();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.PanelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTVoltar3
            // 
            this.BTVoltar3.BackColor = System.Drawing.Color.Transparent;
            this.BTVoltar3.FlatAppearance.BorderSize = 0;
            this.BTVoltar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTVoltar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoltar3.Location = new System.Drawing.Point(25, 402);
            this.BTVoltar3.Name = "BTVoltar3";
            this.BTVoltar3.Size = new System.Drawing.Size(81, 36);
            this.BTVoltar3.TabIndex = 0;
            this.BTVoltar3.Text = "Voltar";
            this.BTVoltar3.UseVisualStyleBackColor = false;
            this.BTVoltar3.Click += new System.EventHandler(this.BTVoltar3_Click);
            // 
            // DocumentoCadastro
            // 
            this.DocumentoCadastro.AutoSize = true;
            this.DocumentoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.DocumentoCadastro.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentoCadastro.Location = new System.Drawing.Point(302, 106);
            this.DocumentoCadastro.Name = "DocumentoCadastro";
            this.DocumentoCadastro.Size = new System.Drawing.Size(190, 24);
            this.DocumentoCadastro.TabIndex = 1;
            this.DocumentoCadastro.Text = "Planos Disponiveis";
            this.DocumentoCadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // ListaPlanos
            // 
            this.ListaPlanos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListaPlanos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaPlanos.FormattingEnabled = true;
            this.ListaPlanos.Items.AddRange(new object[] {
            "Plano Diario",
            "Plano Mensal",
            "Plano Anual",
            "Plano Vip",
            "Plano Premium"});
            this.ListaPlanos.Location = new System.Drawing.Point(498, 106);
            this.ListaPlanos.Name = "ListaPlanos";
            this.ListaPlanos.Size = new System.Drawing.Size(204, 28);
            this.ListaPlanos.TabIndex = 3;
            this.ListaPlanos.SelectedIndexChanged += new System.EventHandler(this.ListaPlanos_SelectedIndexChanged);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.Transparent;
            this.PanelCentral.Controls.Add(this.label1);
            this.PanelCentral.Location = new System.Drawing.Point(185, 149);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(613, 298);
            this.PanelCentral.TabIndex = 4;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(708, 107);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 28);
            this.Btn_Load.TabIndex = 5;
            this.Btn_Load.Text = "Carregar";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartForte.Properties.Resources.planos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.ListaPlanos);
            this.Controls.Add(this.DocumentoCadastro);
            this.Controls.Add(this.BTVoltar3);
            this.DoubleBuffered = true;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.PanelCentral.ResumeLayout(false);
            this.PanelCentral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTVoltar3;
        private System.Windows.Forms.Label DocumentoCadastro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ListaPlanos;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Button Btn_Load;
    }
}