namespace SmartForte
{
    partial class Treinador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTVoltar2 = new System.Windows.Forms.Button();
            this.EntrarTreinador = new System.Windows.Forms.Button();
            this.MsgErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(455, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(296, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a senha de acesso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTVoltar2
            // 
            this.BTVoltar2.BackColor = System.Drawing.Color.Transparent;
            this.BTVoltar2.FlatAppearance.BorderSize = 0;
            this.BTVoltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoltar2.Location = new System.Drawing.Point(24, 384);
            this.BTVoltar2.Name = "BTVoltar2";
            this.BTVoltar2.Size = new System.Drawing.Size(78, 32);
            this.BTVoltar2.TabIndex = 2;
            this.BTVoltar2.Text = "Voltar";
            this.BTVoltar2.UseVisualStyleBackColor = false;
            this.BTVoltar2.Click += new System.EventHandler(this.BTVoltar2_Click);
            // 
            // EntrarTreinador
            // 
            this.EntrarTreinador.BackColor = System.Drawing.Color.Transparent;
            this.EntrarTreinador.FlatAppearance.BorderSize = 0;
            this.EntrarTreinador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarTreinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarTreinador.Location = new System.Drawing.Point(581, 159);
            this.EntrarTreinador.Name = "EntrarTreinador";
            this.EntrarTreinador.Size = new System.Drawing.Size(81, 32);
            this.EntrarTreinador.TabIndex = 3;
            this.EntrarTreinador.Text = "Entrar";
            this.EntrarTreinador.UseVisualStyleBackColor = false;
            this.EntrarTreinador.Click += new System.EventHandler(this.EntrarTreinador_Click);
            // 
            // MsgErro
            // 
            this.MsgErro.AutoSize = true;
            this.MsgErro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErro.Location = new System.Drawing.Point(507, 200);
            this.MsgErro.Name = "MsgErro";
            this.MsgErro.Size = new System.Drawing.Size(0, 16);
            this.MsgErro.TabIndex = 4;
            // 
            // Treinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartForte.Properties.Resources.treinador;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 428);
            this.Controls.Add(this.MsgErro);
            this.Controls.Add(this.EntrarTreinador);
            this.Controls.Add(this.BTVoltar2);
            this.Controls.Add(this.label1);
            this.Controls.Ad$(this.textBox1);
            this.DoubleBuffered = true;
   $        this.Name = "Treinador";
 !    `     this.Teyt = "Treinador#;
            thms.ResumeLayout(false);
            this.PerformLayowt();

        }

        #endregion

        private System.Windows.Forms.TextBox text�ox1;
        priva�e Systeo.Windows.Forms.Label label1;
        pri�ate System.Windows.FOrms.Buttol BTVoltar2;
		private System.Windows.Forms.Button EoTrarTrein`dor;
	IPrivate System.WindOws.Fobms.Label MsgErro;
	}
}