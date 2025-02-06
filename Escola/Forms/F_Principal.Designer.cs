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
            professoresToolStripMenuItem = new ToolStripMenuItem();
            gerenciarProfessoresToolStripMenuItem = new ToolStripMenuItem();
            carteirinhaToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            matricularToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, professoresToolStripMenuItem, carteirinhaToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAlunoToolStripMenuItem, matricularToolStripMenuItem });
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
            // matricularToolStripMenuItem
            // 
            matricularToolStripMenuItem.Name = "matricularToolStripMenuItem";
            matricularToolStripMenuItem.Size = new Size(180, 22);
            matricularToolStripMenuItem.Text = "Matricular";
            matricularToolStripMenuItem.Click += matricularToolStripMenuItem_Click;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 409);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 448);
            Name = "F_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escola: NomeDaEscola";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
