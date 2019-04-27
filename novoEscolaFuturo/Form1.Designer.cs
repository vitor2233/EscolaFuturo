namespace novoEscolaFuturo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnScretaria = new System.Windows.Forms.Button();
            this.btnCoordenador = new System.Windows.Forms.Button();
            this.btnDiretor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btnPaginaInicial = new System.Windows.Forms.Button();
            this.userControlBemVindo1 = new novoEscolaFuturo.UserControlBemVindo();
            this.userControlLogin1 = new novoEscolaFuturo.UserControlLogin();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(798, 12);
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
            this.btnFechar.Location = new System.Drawing.Point(842, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 33);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfessor);
            this.panel1.Controls.Add(this.btnScretaria);
            this.panel1.Controls.Add(this.btnCoordenador);
            this.panel1.Controls.Add(this.btnDiretor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlIndicador);
            this.panel1.Controls.Add(this.btnPaginaInicial);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 480);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnProfessor
            // 
            this.btnProfessor.FlatAppearance.BorderSize = 0;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnProfessor.Image")));
            this.btnProfessor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfessor.Location = new System.Drawing.Point(0, 408);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(155, 61);
            this.btnProfessor.TabIndex = 19;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnScretaria
            // 
            this.btnScretaria.FlatAppearance.BorderSize = 0;
            this.btnScretaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScretaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScretaria.ForeColor = System.Drawing.Color.White;
            this.btnScretaria.Image = ((System.Drawing.Image)(resources.GetObject("btnScretaria.Image")));
            this.btnScretaria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScretaria.Location = new System.Drawing.Point(0, 336);
            this.btnScretaria.Name = "btnScretaria";
            this.btnScretaria.Size = new System.Drawing.Size(155, 61);
            this.btnScretaria.TabIndex = 18;
            this.btnScretaria.Text = "Secretária";
            this.btnScretaria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScretaria.UseVisualStyleBackColor = true;
            this.btnScretaria.Click += new System.EventHandler(this.btnScretaria_Click);
            // 
            // btnCoordenador
            // 
            this.btnCoordenador.FlatAppearance.BorderSize = 0;
            this.btnCoordenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoordenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoordenador.ForeColor = System.Drawing.Color.White;
            this.btnCoordenador.Image = ((System.Drawing.Image)(resources.GetObject("btnCoordenador.Image")));
            this.btnCoordenador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCoordenador.Location = new System.Drawing.Point(0, 269);
            this.btnCoordenador.Name = "btnCoordenador";
            this.btnCoordenador.Size = new System.Drawing.Size(155, 61);
            this.btnCoordenador.TabIndex = 17;
            this.btnCoordenador.Text = "Coordenador";
            this.btnCoordenador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoordenador.UseVisualStyleBackColor = true;
            this.btnCoordenador.Click += new System.EventHandler(this.btnCoordenador_Click);
            // 
            // btnDiretor
            // 
            this.btnDiretor.FlatAppearance.BorderSize = 0;
            this.btnDiretor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiretor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiretor.ForeColor = System.Drawing.Color.White;
            this.btnDiretor.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretor.Image")));
            this.btnDiretor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiretor.Location = new System.Drawing.Point(2, 202);
            this.btnDiretor.Name = "btnDiretor";
            this.btnDiretor.Size = new System.Drawing.Size(155, 61);
            this.btnDiretor.TabIndex = 16;
            this.btnDiretor.Text = "Diretor";
            this.btnDiretor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiretor.UseVisualStyleBackColor = true;
            this.btnDiretor.Click += new System.EventHandler(this.btnDiretor_Click);
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
            this.pnlIndicador.Location = new System.Drawing.Point(158, 135);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(20, 61);
            this.pnlIndicador.TabIndex = 14;
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.btnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaInicial.ForeColor = System.Drawing.Color.White;
            this.btnPaginaInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnPaginaInicial.Image")));
            this.btnPaginaInicial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaginaInicial.Location = new System.Drawing.Point(3, 135);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Size = new System.Drawing.Size(155, 61);
            this.btnPaginaInicial.TabIndex = 12;
            this.btnPaginaInicial.Text = "Página inicial";
            this.btnPaginaInicial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaginaInicial.UseVisualStyleBackColor = true;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
            // 
            // userControlBemVindo1
            // 
            this.userControlBemVindo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlBemVindo1.Location = new System.Drawing.Point(184, 52);
            this.userControlBemVindo1.Name = "userControlBemVindo1";
            this.userControlBemVindo1.Size = new System.Drawing.Size(700, 429);
            this.userControlBemVindo1.TabIndex = 11;
            // 
            // userControlLogin1
            // 
            this.userControlLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlLogin1.Location = new System.Drawing.Point(184, 52);
            this.userControlLogin1.Name = "userControlLogin1";
            this.userControlLogin1.Size = new System.Drawing.Size(700, 429);
            this.userControlLogin1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(882, 482);
            this.Controls.Add(this.userControlBemVindo1);
            this.Controls.Add(this.userControlLogin1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiretor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Button btnPaginaInicial;
        private System.Windows.Forms.Button btnCoordenador;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnScretaria;
        private UserControlLogin userControlLogin1;
        private UserControlBemVindo userControlBemVindo1;
    }
}

