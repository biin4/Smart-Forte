namespace SmartForte
{
    partial class PlanoMensal
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
            this.lgPLanoM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lgPLanoM
            // 
            this.lgPLanoM.AutoSize = true;
            this.lgPLanoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgPLanoM.Location = new System.Drawing.Point(232, 9);
            this.lgPLanoM.Name = "lgPLanoM";
            this.lgPLanoM.Size = new System.Drawing.Size(98, 18);
            this.lgPLanoM.TabIndex = 1;
            this.lgPLanoM.Text = "Plano Mensal";
            this.lgPLanoM.Click += new System.EventHandler(this.lgPLanoD_Click);
            // 
            // PlanoMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 259);
            this.ControlBox = false;
            this.Controls.Add(this.lgPLanoM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanoMensal";
            this.Text = "PlanoMensal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgPLanoM;
    }
}