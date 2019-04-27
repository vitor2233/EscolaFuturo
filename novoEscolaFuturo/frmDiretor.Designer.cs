namespace novoEscolaFuturo
{
    partial class frmDiretor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiretor));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadSecretaria = new System.Windows.Forms.Button();
            this.btnCadCoor = new System.Windows.Forms.Button();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btEmitirRelatorio = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.userControlCadCurso1 = new novoEscolaFuturo.UserControlCadCurso();
            this.userControlCadFuncionario1 = new novoEscolaFuturo.UserControlCadFuncionario();
            this.userControlCadCoordenador1 = new novoEscolaFuturo.UserControlCadCoordenador();
            this.userControlCadSecretaria1 = new novoEscolaFuturo.UserControlCadSecretaria();
            this.userControlFreqFuncionario1 = new novoEscolaFuturo.UserControlFreqFuncionario();
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
            this.btnMinimizar.Location = new System.Drawing.Point(802, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 33);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(846, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 33);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadSecretaria);
            this.panel1.Controls.Add(this.btnCadCoor);
            this.panel1.Controls.Add(this.btnCadFuncionario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlIndicador);
            this.panel1.Controls.Add(this.btEmitirRelatorio);
            this.panel1.Controls.Add(this.btnCadastrarCurso);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 480);
            this.panel1.TabIndex = 7;
            // 
            // btnCadSecretaria
            // 
            this.btnCadSecretaria.FlatAppearance.BorderSize = 0;
            this.btnCadSecretaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSecretaria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSecretaria.ForeColor = System.Drawing.Color.White;
            this.btnCadSecretaria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadSecretaria.Image")));
            this.btnCadSecretaria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadSecretaria.Location = new System.Drawing.Point(3, 336);
            this.btnCadSecretaria.Name = "btnCadSecretaria";
            this.btnCadSecretaria.Size = new System.Drawing.Size(152, 54);
            this.btnCadSecretaria.TabIndex = 18;
            this.btnCadSecretaria.Text = "Cadastrar Secretária";
            this.btnCadSecretaria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadSecretaria.UseVisualStyleBackColor = true;
            this.btnCadSecretaria.Click += new System.EventHandler(this.btnCadSecretaria_Click);
            // 
            // btnCadCoor
            // 
            this.btnCadCoor.FlatAppearance.BorderSize = 0;
            this.btnCadCoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCoor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCoor.ForeColor = System.Drawing.Color.White;
            this.btnCadCoor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCoor.Image")));
            this.btnCadCoor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadCoor.Location = new System.Drawing.Point(3, 263);
            this.btnCadCoor.Name = "btnCadCoor";
            this.btnCadCoor.Size = new System.Drawing.Size(155, 67);
            this.btnCadCoor.TabIndex = 17;
            this.btnCadCoor.Text = "Cadastrar Coordenador";
            this.btnCadCoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadCoor.UseVisualStyleBackColor = true;
            this.btnCadCoor.Click += new System.EventHandler(this.btnCadCoor_Click);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFuncionario.Image")));
            this.btnCadFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadFuncionario.Location = new System.Drawing.Point(3, 190);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(155, 67);
            this.btnCadFuncionario.TabIndex = 16;
            this.btnCadFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(17, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 109);
            this.panel2.TabIndex = 15;
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.White;
            this.pnlIndicador.Location = new System.Drawing.Point(156, 117);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(20, 67);
            this.pnlIndicador.TabIndex = 14;
            // 
            // btEmitirRelatorio
            // 
            this.btEmitirRelatorio.FlatAppearance.BorderSize = 0;
            this.btEmitirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmitirRelatorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmitirRelatorio.ForeColor = System.Drawing.Color.White;
            this.btEmitirRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btEmitirRelatorio.Image")));
            this.btEmitirRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEmitirRelatorio.Location = new System.Drawing.Point(0, 396);
            this.btEmitirRelatorio.Name = "btEmitirRelatorio";
            this.btEmitirRelatorio.Size = new System.Drawing.Size(155, 84);
            this.btEmitirRelatorio.TabIndex = 13;
            this.btEmitirRelatorio.Text = "Emitir relatório de frequência do funcionário";
            this.btEmitirRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmitirRelatorio.UseVisualStyleBackColor = true;
            this.btEmitirRelatorio.Click += new System.EventHandler(this.btEmitirRelatorio_Click);
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCurso.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCurso.Image")));
            this.btnCadastrarCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarCurso.Location = new System.Drawing.Point(3, 117);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(155, 67);
            this.btnCadastrarCurso.TabIndex = 12;
            this.btnCadastrarCurso.Text = "Cadastrar curso";
            this.btnCadastrarCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarCurso.UseVisualStyleBackColor = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // userControlCadCurso1
            // 
            this.userControlCadCurso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadCurso1.Location = new System.Drawing.Point(184, 51);
            this.userControlCadCurso1.Name = "userControlCadCurso1";
            this.userControlCadCurso1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadCurso1.TabIndex = 8;
            // 
            // userControlCadFuncionario1
            // 
            this.userControlCadFuncionario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadFuncionario1.Location = new System.Drawing.Point(184, 51);
            this.userControlCadFuncionario1.Name = "userControlCadFuncionario1";
            this.userControlCadFuncionario1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadFuncionario1.TabIndex = 9;
            // 
            // userControlCadCoordenador1
            // 
            this.userControlCadCoordenador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadCoordenador1.Location = new System.Drawing.Point(184, 51);
            this.userControlCadCoordenador1.Name = "userControlCadCoordenador1";
            this.userControlCadCoordenador1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadCoordenador1.TabIndex = 10;
            // 
            // userControlCadSecretaria1
            // 
            this.userControlCadSecretaria1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadSecretaria1.Location = new System.Drawing.Point(184, 51);
            this.userControlCadSecretaria1.Name = "userControlCadSecretaria1";
            this.userControlCadSecretaria1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadSecretaria1.TabIndex = 11;
            // 
            // userControlFreqFuncionario1
            // 
            this.userControlFreqFuncionario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlFreqFuncionario1.Location = new System.Drawing.Point(184, 51);
            this.userControlFreqFuncionario1.Name = "userControlFreqFuncionario1";
            this.userControlFreqFuncionario1.Size = new System.Drawing.Size(700, 429);
            this.userControlFreqFuncionario1.TabIndex = 12;
            // 
            // userControlBemVindo1
            // 
            this.userControlBemVindo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlBemVindo1.Location = new System.Drawing.Point(184, 60);
            this.userControlBemVindo1.Name = "userControlBemVindo1";
            this.userControlBemVindo1.Size = new System.Drawing.Size(700, 429);
            this.userControlBemVindo1.TabIndex = 13;
            // 
            // frmDiretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(882, 482);
            this.Controls.Add(this.userControlBemVindo1);
            this.Controls.Add(this.userControlFreqFuncionario1);
            this.Controls.Add(this.userControlCadSecretaria1);
            this.Controls.Add(this.userControlCadCoordenador1);
            this.Controls.Add(this.userControlCadFuncionario1);
            this.Controls.Add(this.userControlCadCurso1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiretor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiretor";
            this.Load += new System.EventHandler(this.frmDiretor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Button btEmitirRelatorio;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.Button btnCadCoor;
        private System.Windows.Forms.Button btnCadSecretaria;
        private UserControlCadCurso userControlCadCurso1;
        private UserControlCadFuncionario userControlCadFuncionario1;
        private UserControlCadCoordenador userControlCadCoordenador1;
        private UserControlCadSecretaria userControlCadSecretaria1;
        private UserControlFreqFuncionario userControlFreqFuncionario1;
        private UserControlBemVindo userControlBemVindo1;
    }
}