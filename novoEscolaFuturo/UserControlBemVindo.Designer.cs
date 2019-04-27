namespace novoEscolaFuturo
{
    partial class UserControlBemVindo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBemVindo));
            this.pnlSeta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblEscolaFuturo = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeta
            // 
            this.pnlSeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSeta.BackgroundImage")));
            this.pnlSeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSeta.Location = new System.Drawing.Point(307, 348);
            this.pnlSeta.Name = "pnlSeta";
            this.pnlSeta.Size = new System.Drawing.Size(87, 74);
            this.pnlSeta.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escolha uma opção ao lado";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Location = new System.Drawing.Point(266, 270);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(169, 33);
            this.lblBemVindo.TabIndex = 9;
            this.lblBemVindo.Text = "Bem Vindo!";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.lblEscolaFuturo);
            this.pnlLogo.Location = new System.Drawing.Point(210, 13);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(288, 216);
            this.pnlLogo.TabIndex = 8;
            // 
            // lblEscolaFuturo
            // 
            this.lblEscolaFuturo.AutoSize = true;
            this.lblEscolaFuturo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolaFuturo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEscolaFuturo.Location = new System.Drawing.Point(57, 186);
            this.lblEscolaFuturo.Name = "lblEscolaFuturo";
            this.lblEscolaFuturo.Size = new System.Drawing.Size(170, 30);
            this.lblEscolaFuturo.TabIndex = 1;
            this.lblEscolaFuturo.Text = "Escola Futuro";
            // 
            // UserControlBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.pnlSeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pnlLogo);
            this.Name = "UserControlBemVindo";
            this.Size = new System.Drawing.Size(700, 429);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblEscolaFuturo;
    }
}
