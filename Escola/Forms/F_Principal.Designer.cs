namespace Escola
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            menuStrip1 = new MenuStrip();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarAlunoToolStripMenuItem = new ToolStripMenuItem();
            matricularToolStripMenuItem = new ToolStripMenuItem();
            responsavelToolStripMenuItem = new ToolStripMenuItem();
            gerenciarResponsaveisToolStripMenuItem = new ToolStripMenuItem();
            professoresToolStripMenuItem = new ToolStripMenuItem();
            gerenciarProfessoresToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            gerenciarTurmasToolStripMenuItem = new ToolStripMenuItem();
            carteirinhaToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            pb_Principal = new PictureBox();
            toolStripSeparator1 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Principal).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, professoresToolStripMenuItem, turmasToolStripMenuItem, carteirinhaToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAlunoToolStripMenuItem, matricularToolStripMenuItem, toolStripSeparator1, responsavelToolStripMenuItem });
            alunosToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            alunosToolStripMenuItem.Image = Properties.Resources.estudantes;
            alunosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(75, 21);
            alunosToolStripMenuItem.Text = "Alunos";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            cadastrarAlunoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarAlunoToolStripMenuItem.Text = "Gerenciar Aluno";
            cadastrarAlunoToolStripMenuItem.Click += cadastrarAlunoToolStripMenuItem_Click;
            // 
            // matricularToolStripMenuItem
            // 
            matricularToolStripMenuItem.Name = "matricularToolStripMenuItem";
            matricularToolStripMenuItem.Size = new Size(180, 22);
            matricularToolStripMenuItem.Text = "Matricular";
            matricularToolStripMenuItem.Click += matricularToolStripMenuItem_Click;
            // 
            // responsavelToolStripMenuItem
            // 
            responsavelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarResponsaveisToolStripMenuItem });
            responsavelToolStripMenuItem.Image = Properties.Resources.responsavel;
            responsavelToolStripMenuItem.Name = "responsavelToolStripMenuItem";
            responsavelToolStripMenuItem.Size = new Size(180, 22);
            responsavelToolStripMenuItem.Text = "Responsavel";
            // 
            // gerenciarResponsaveisToolStripMenuItem
            // 
            gerenciarResponsaveisToolStripMenuItem.Name = "gerenciarResponsaveisToolStripMenuItem";
            gerenciarResponsaveisToolStripMenuItem.Size = new Size(215, 22);
            gerenciarResponsaveisToolStripMenuItem.Text = "Gerenciar Responsaveis";
            gerenciarResponsaveisToolStripMenuItem.Click += gerenciarResponsaveisToolStripMenuItem_Click;
            // 
            // professoresToolStripMenuItem
            // 
            professoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarProfessoresToolStripMenuItem });
            professoresToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            professoresToolStripMenuItem.Image = Properties.Resources.professores;
            professoresToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            professoresToolStripMenuItem.Size = new Size(105, 21);
            professoresToolStripMenuItem.Text = "Professores";
            // 
            // gerenciarProfessoresToolStripMenuItem
            // 
            gerenciarProfessoresToolStripMenuItem.Name = "gerenciarProfessoresToolStripMenuItem";
            gerenciarProfessoresToolStripMenuItem.Size = new Size(205, 22);
            gerenciarProfessoresToolStripMenuItem.Text = "Gerenciar Professores";
            gerenciarProfessoresToolStripMenuItem.Click += gerenciarProfessoresToolStripMenuItem_Click;
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarTurmasToolStripMenuItem });
            turmasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            turmasToolStripMenuItem.Image = Properties.Resources.turmas;
            turmasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(79, 21);
            turmasToolStripMenuItem.Text = "Turmas";
            // 
            // gerenciarTurmasToolStripMenuItem
            // 
            gerenciarTurmasToolStripMenuItem.Name = "gerenciarTurmasToolStripMenuItem";
            gerenciarTurmasToolStripMenuItem.Size = new Size(179, 22);
            gerenciarTurmasToolStripMenuItem.Text = "Gerenciar Turmas";
            gerenciarTurmasToolStripMenuItem.Click += gerenciarTurmasToolStripMenuItem_Click;
            // 
            // carteirinhaToolStripMenuItem
            // 
            carteirinhaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            carteirinhaToolStripMenuItem.Image = Properties.Resources.carteirinha;
            carteirinhaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            carteirinhaToolStripMenuItem.Name = "carteirinhaToolStripMenuItem";
            carteirinhaToolStripMenuItem.Size = new Size(99, 21);
            carteirinhaToolStripMenuItem.Text = "Carteirinha";
            carteirinhaToolStripMenuItem.Click += carteirinhaToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            configuraçõesToolStripMenuItem.Image = Properties.Resources.configuracoes;
            configuraçõesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(120, 21);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // pb_Principal
            // 
            pb_Principal.Dock = DockStyle.Fill;
            pb_Principal.Location = new Point(0, 25);
            pb_Principal.Name = "pb_Principal";
            pb_Principal.Size = new Size(800, 400);
            pb_Principal.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Principal.TabIndex = 1;
            pb_Principal.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 425);
            Controls.Add(pb_Principal);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 448);
            Name = "F_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escola: NomeDaEscola";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Principal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private ToolStripMenuItem gerenciarProfessoresToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem carteirinhaToolStripMenuItem;
        private ToolStripMenuItem matricularToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
        private ToolStripMenuItem gerenciarTurmasToolStripMenuItem;
        private PictureBox pb_Principal;
        private ToolStripMenuItem responsavelToolStripMenuItem;
        private ToolStripMenuItem gerenciarResponsaveisToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}
