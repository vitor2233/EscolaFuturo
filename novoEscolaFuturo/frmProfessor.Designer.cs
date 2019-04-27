namespace novoEscolaFuturo
{
    partial class frmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFreqAluno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btnPlanoAula = new System.Windows.Forms.Button();
            this.btnPontuacao = new System.Windows.Forms.Button();
            this.userControlPontuacao1 = new novoEscolaFuturo.UserControlPontuacao();
            this.userControlFreqAluno1 = new novoEscolaFuturo.UserControlFreqAluno();
            this.userControlCadPlanoProf1 = new novoEscolaFuturo.UserControlCadPlanoProf();
            this.userControlBemVindo1 = new novoEscolaFuturo.UserControlBemVindo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(800, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 33);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(844, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 33);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFreqAluno);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlIndicador);
            this.panel1.Controls.Add(this.btnPlanoAula);
            this.panel1.Controls.Add(this.btnPontuacao);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 480);
            this.panel1.TabIndex = 12;
            // 
            // btnFreqAluno
            // 
            this.btnFreqAluno.FlatAppearance.BorderSize = 0;
            this.btnFreqAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreqAluno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreqAluno.ForeColor = System.Drawing.Color.White;
            this.btnFreqAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnFreqAluno.Image")));
            this.btnFreqAluno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFreqAluno.Location = new System.Drawing.Point(1, 284);
            this.btnFreqAluno.Name = "btnFreqAluno";
            this.btnFreqAluno.Size = new System.Drawing.Size(155, 58);
            this.btnFreqAluno.TabIndex = 21;
            this.btnFreqAluno.Text = "Frequência do Aluno";
            this.btnFreqAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFreqAluno.UseVisualStyleBackColor = true;
            this.btnFreqAluno.Click += new System.EventHandler(this.btnFreqAluno_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 109);
            this.panel2.TabIndex = 20;
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.White;
            this.pnlIndicador.Location = new System.Drawing.Point(157, 170);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(20, 58);
            this.pnlIndicador.TabIndex = 19;
            // 
            // btnPlanoAula
            // 
            this.btnPlanoAula.FlatAppearance.BorderSize = 0;
            this.btnPlanoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanoAula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanoAula.ForeColor = System.Drawing.Color.White;
            this.btnPlanoAula.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanoAula.Image")));
            this.btnPlanoAula.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlanoAula.Location = new System.Drawing.Point(1, 401);
            this.btnPlanoAula.Name = "btnPlanoAula";
            this.btnPlanoAula.Size = new System.Drawing.Size(155, 58);
            this.btnPlanoAula.TabIndex = 18;
            this.btnPlanoAula.Text = "Plano de aula";
            this.btnPlanoAula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlanoAula.UseVisualStyleBackColor = true;
            this.btnPlanoAula.Click += new System.EventHandler(this.btnPlanoAula_Click);
            // 
            // btnPontuacao
            // 
            this.btnPontuacao.FlatAppearance.BorderSize = 0;
            this.btnPontuacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPontuacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontuacao.ForeColor = System.Drawing.Color.White;
            this.btnPontuacao.Image = ((System.Drawing.Image)(resources.GetObject("btnPontuacao.Image")));
            this.btnPontuacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPontuacao.Location = new System.Drawing.Point(1, 170);
            this.btnPontuacao.Name = "btnPontuacao";
            this.btnPontuacao.Size = new System.Drawing.Size(155, 58);
            this.btnPontuacao.TabIndex = 17;
            this.btnPontuacao.Text = "Distribuir pontuação";
            this.btnPontuacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPontuacao.UseVisualStyleBackColor = true;
            this.btnPontuacao.Click += new System.EventHandler(this.btnPontuacao_Click);
            // 
            // userControlPontuacao1
            // 
            this.userControlPontuacao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlPontuacao1.Location = new System.Drawing.Point(182, 52);
            this.userControlPontuacao1.Name = "userControlPontuacao1";
            this.userControlPontuacao1.Size = new System.Drawing.Size(700, 429);
            this.userControlPontuacao1.TabIndex = 13;
            // 
            // userControlFreqAluno1
            // 
            this.userControlFreqAluno1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlFreqAluno1.Location = new System.Drawing.Point(182, 52);
            this.userControlFreqAluno1.Name = "userControlFreqAluno1";
            this.userControlFreqAluno1.Size = new System.Drawing.Size(700, 429);
            this.userControlFreqAluno1.TabIndex = 14;
            // 
            // userControlCadPlanoProf1
            // 
            this.userControlCadPlanoProf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadPlanoProf1.Location = new System.Drawing.Point(182, 52);
            this.userControlCadPlanoProf1.Name = "userControlCadPlanoProf1";
            this.userControlCadPlanoProf1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadPlanoProf1.TabIndex = 15;
            // 
            // userControlBemVindo1
            // 
            this.userControlBemVindo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlBemVindo1.Location = new System.Drawing.Point(182, 51);
            this.userControlBemVindo1.Name = "userControlBemVindo1";
            this.userControlBemVindo1.Size = new System.Drawing.Size(700, 429);
            this.userControlBemVindo1.TabIndex = 16;
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(882, 482);
            this.Controls.Add(this.userControlBemVindo1);
            this.Controls.Add(this.userControlCadPlanoProf1);
            this.Controls.Add(this.userControlFreqAluno1);
            this.Controls.Add(this.userControlPontuacao1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfessor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFreqAluno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Button btnPlanoAula;
        private System.Windows.Forms.Button btnPontuacao;
        private UserControlPontuacao userControlPontuacao1;
        private UserControlFreqAluno userControlFreqAluno1;
        private UserControlCadPlanoProf userControlCadPlanoProf1;
        private UserControlBemVindo userControlBemVindo1;
    }
}