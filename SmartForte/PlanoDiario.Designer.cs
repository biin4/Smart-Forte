namespace SmartForte
{
    partial class PlanoDiario
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
            this.lgPLanoD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lgPLanoD
            // 
            this.lgPLanoD.AutoSize = true;
            this.lgPLanoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgPLanoD.Location = new System.Drawing.Point(257, 121);
            this.lgPLanoD.Name = "lgPLanoD";
            this.lgPLanoD.Size = new System.Drawing.Size(89, 18);
            this.lgPLanoD.TabIndex = 0;
            this.lgPLanoD.Text = "Plano Diário";
            this.lgPLanoD.Click += new System.EventHandler(this.lgPlanos_Click);
            // 
            // PlanoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(613, 298);
            this.Controls.Add(this.lgPLanoD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanoDiario";
            this.Text = "PlanoDiario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgPLanoD;
    }
}