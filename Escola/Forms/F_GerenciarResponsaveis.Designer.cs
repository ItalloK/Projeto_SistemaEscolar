namespace Escola.Forms
{
    partial class F_GerenciarResponsaveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GerenciarResponsaveis));
            panel_GerenciarResponsaveis = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_BuscarProfessorG = new Button();
            btn_CadResponsavel = new CustomControls.Botoes.ButtonIG();
            btn_AttProfessorG = new CustomControls.Botoes.ButtonIG();
            btn_DeletarProfessor = new CustomControls.Botoes.ButtonIG();
            tb_BuscarProfessorG = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgv_DadosAlunos = new DataGridView();
            dgv_Dados = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel_CadastrarResponsavel = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_CadResponsavelP = new CustomControls.Botoes.ButtonIG();
            btn_CancelarCadResponsavelP = new CustomControls.Botoes.ButtonIG();
            label3 = new Label();
            panel_GerenciarResponsaveis.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Dados).BeginInit();
            panel_CadastrarResponsavel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel_GerenciarResponsaveis
            // 
            panel_GerenciarResponsaveis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GerenciarResponsaveis.Controls.Add(tableLayoutPanel1);
            panel_GerenciarResponsaveis.Controls.Add(tableLayoutPanel2);
            panel_GerenciarResponsaveis.Controls.Add(label1);
            panel_GerenciarResponsaveis.Location = new Point(0, 0);
            panel_GerenciarResponsaveis.Name = "panel_GerenciarResponsaveis";
            panel_GerenciarResponsaveis.Size = new Size(800, 450);
            panel_GerenciarResponsaveis.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btn_BuscarProfessorG, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_CadResponsavel, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_AttProfessorG, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_DeletarProfessor, 4, 0);
            tableLayoutPanel1.Controls.Add(tb_BuscarProfessorG, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(794, 32);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // btn_BuscarProfessorG
            // 
            btn_BuscarProfessorG.Anchor = AnchorStyles.Left;
            btn_BuscarProfessorG.BackgroundImage = Properties.Resources.lupa;
            btn_BuscarProfessorG.BackgroundImageLayout = ImageLayout.Zoom;
            btn_BuscarProfessorG.Location = new Point(285, 1);
            btn_BuscarProfessorG.Margin = new Padding(0);
            btn_BuscarProfessorG.Name = "btn_BuscarProfessorG";
            btn_BuscarProfessorG.Size = new Size(29, 29);
            btn_BuscarProfessorG.TabIndex = 18;
            btn_BuscarProfessorG.UseVisualStyleBackColor = true;
            // 
            // btn_CadResponsavel
            // 
            btn_CadResponsavel.BackColor = Color.Gray;
            btn_CadResponsavel.BackgroundColor = Color.Gray;
            btn_CadResponsavel.BorderColor = Color.PaleVioletRed;
            btn_CadResponsavel.BorderRadius = 5;
            btn_CadResponsavel.BorderSize = 0;
            btn_CadResponsavel.Dock = DockStyle.Fill;
            btn_CadResponsavel.FlatAppearance.BorderSize = 0;
            btn_CadResponsavel.FlatStyle = FlatStyle.Flat;
            btn_CadResponsavel.Font = new Font("Segoe UI", 9.75F);
            btn_CadResponsavel.ForeColor = Color.White;
            btn_CadResponsavel.HoverBackgroundColor = Color.Black;
            btn_CadResponsavel.Location = new Point(319, 3);
            btn_CadResponsavel.Name = "btn_CadResponsavel";
            btn_CadResponsavel.Size = new Size(152, 26);
            btn_CadResponsavel.TabIndex = 15;
            btn_CadResponsavel.Text = "Cadastrar Responsavel";
            btn_CadResponsavel.TextColor = Color.White;
            btn_CadResponsavel.UseVisualStyleBackColor = false;
            btn_CadResponsavel.Click += btn_CadResponsavel_Click;
            // 
            // btn_AttProfessorG
            // 
            btn_AttProfessorG.BackColor = Color.Gray;
            btn_AttProfessorG.BackgroundColor = Color.Gray;
            btn_AttProfessorG.BorderColor = Color.PaleVioletRed;
            btn_AttProfessorG.BorderRadius = 5;
            btn_AttProfessorG.BorderSize = 0;
            btn_AttProfessorG.Dock = DockStyle.Fill;
            btn_AttProfessorG.FlatAppearance.BorderSize = 0;
            btn_AttProfessorG.FlatStyle = FlatStyle.Flat;
            btn_AttProfessorG.Font = new Font("Segoe UI", 9.75F);
            btn_AttProfessorG.ForeColor = Color.White;
            btn_AttProfessorG.HoverBackgroundColor = Color.Black;
            btn_AttProfessorG.Location = new Point(477, 3);
            btn_AttProfessorG.Name = "btn_AttProfessorG";
            btn_AttProfessorG.Size = new Size(152, 26);
            btn_AttProfessorG.TabIndex = 13;
            btn_AttProfessorG.Text = "Atualizar Responsavel";
            btn_AttProfessorG.TextColor = Color.White;
            btn_AttProfessorG.UseVisualStyleBackColor = false;
            // 
            // btn_DeletarProfessor
            // 
            btn_DeletarProfessor.BackColor = Color.Gray;
            btn_DeletarProfessor.BackgroundColor = Color.Gray;
            btn_DeletarProfessor.BorderColor = Color.PaleVioletRed;
            btn_DeletarProfessor.BorderRadius = 5;
            btn_DeletarProfessor.BorderSize = 0;
            btn_DeletarProfessor.Dock = DockStyle.Fill;
            btn_DeletarProfessor.FlatAppearance.BorderSize = 0;
            btn_DeletarProfessor.FlatStyle = FlatStyle.Flat;
            btn_DeletarProfessor.Font = new Font("Segoe UI", 9.75F);
            btn_DeletarProfessor.ForeColor = Color.White;
            btn_DeletarProfessor.HoverBackgroundColor = Color.Black;
            btn_DeletarProfessor.Location = new Point(635, 3);
            btn_DeletarProfessor.Name = "btn_DeletarProfessor";
            btn_DeletarProfessor.Size = new Size(156, 26);
            btn_DeletarProfessor.TabIndex = 11;
            btn_DeletarProfessor.Text = "Deletar Responsavel";
            btn_DeletarProfessor.TextColor = Color.White;
            btn_DeletarProfessor.UseVisualStyleBackColor = false;
            // 
            // tb_BuscarProfessorG
            // 
            tb_BuscarProfessorG.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_BuscarProfessorG.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_BuscarProfessorG.Location = new Point(3, 3);
            tb_BuscarProfessorG.Name = "tb_BuscarProfessorG";
            tb_BuscarProfessorG.Size = new Size(279, 25);
            tb_BuscarProfessorG.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgv_DadosAlunos, 0, 2);
            tableLayoutPanel2.Controls.Add(dgv_Dados, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(794, 374);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // dgv_DadosAlunos
            // 
            dgv_DadosAlunos.AllowUserToAddRows = false;
            dgv_DadosAlunos.AllowUserToDeleteRows = false;
            dgv_DadosAlunos.AllowUserToResizeColumns = false;
            dgv_DadosAlunos.AllowUserToResizeRows = false;
            dgv_DadosAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DadosAlunos.BackgroundColor = Color.White;
            dgv_DadosAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_DadosAlunos.Dock = DockStyle.Fill;
            dgv_DadosAlunos.Location = new Point(0, 261);
            dgv_DadosAlunos.Margin = new Padding(0);
            dgv_DadosAlunos.MultiSelect = false;
            dgv_DadosAlunos.Name = "dgv_DadosAlunos";
            dgv_DadosAlunos.ReadOnly = true;
            dgv_DadosAlunos.RowHeadersVisible = false;
            dgv_DadosAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DadosAlunos.Size = new Size(794, 113);
            dgv_DadosAlunos.TabIndex = 4;
            // 
            // dgv_Dados
            // 
            dgv_Dados.AllowUserToAddRows = false;
            dgv_Dados.AllowUserToDeleteRows = false;
            dgv_Dados.AllowUserToResizeColumns = false;
            dgv_Dados.AllowUserToResizeRows = false;
            dgv_Dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Dados.BackgroundColor = Color.White;
            dgv_Dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_Dados.Dock = DockStyle.Fill;
            dgv_Dados.Location = new Point(0, 0);
            dgv_Dados.Margin = new Padding(0);
            dgv_Dados.MultiSelect = false;
            dgv_Dados.Name = "dgv_Dados";
            dgv_Dados.ReadOnly = true;
            dgv_Dados.RowHeadersVisible = false;
            dgv_Dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Dados.Size = new Size(794, 235);
            dgv_Dados.TabIndex = 2;
            dgv_Dados.SelectionChanged += dgv_Dados_SelectionChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 235);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 3;
            label2.Text = "Alunos:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 7;
            label1.Text = "Gerenciar Responsaveis";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_CadastrarResponsavel
            // 
            panel_CadastrarResponsavel.Controls.Add(tableLayoutPanel3);
            panel_CadastrarResponsavel.Controls.Add(label3);
            panel_CadastrarResponsavel.Location = new Point(0, 0);
            panel_CadastrarResponsavel.Name = "panel_CadastrarResponsavel";
            panel_CadastrarResponsavel.Size = new Size(800, 450);
            panel_CadastrarResponsavel.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btn_CadResponsavelP, 2, 0);
            tableLayoutPanel3.Controls.Add(btn_CancelarCadResponsavelP, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 419);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(800, 31);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // btn_CadResponsavelP
            // 
            btn_CadResponsavelP.BackColor = Color.Gray;
            btn_CadResponsavelP.BackgroundColor = Color.Gray;
            btn_CadResponsavelP.BorderColor = Color.PaleVioletRed;
            btn_CadResponsavelP.BorderRadius = 5;
            btn_CadResponsavelP.BorderSize = 0;
            btn_CadResponsavelP.Dock = DockStyle.Fill;
            btn_CadResponsavelP.FlatAppearance.BorderSize = 0;
            btn_CadResponsavelP.FlatStyle = FlatStyle.Flat;
            btn_CadResponsavelP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_CadResponsavelP.ForeColor = Color.White;
            btn_CadResponsavelP.HoverBackgroundColor = Color.Black;
            btn_CadResponsavelP.Location = new Point(603, 3);
            btn_CadResponsavelP.Name = "btn_CadResponsavelP";
            btn_CadResponsavelP.Size = new Size(194, 25);
            btn_CadResponsavelP.TabIndex = 2;
            btn_CadResponsavelP.Text = "Cadastrar Responsavel";
            btn_CadResponsavelP.TextColor = Color.White;
            btn_CadResponsavelP.UseVisualStyleBackColor = false;
            // 
            // btn_CancelarCadResponsavelP
            // 
            btn_CancelarCadResponsavelP.BackColor = Color.Gray;
            btn_CancelarCadResponsavelP.BackgroundColor = Color.Gray;
            btn_CancelarCadResponsavelP.BorderColor = Color.PaleVioletRed;
            btn_CancelarCadResponsavelP.BorderRadius = 5;
            btn_CancelarCadResponsavelP.BorderSize = 0;
            btn_CancelarCadResponsavelP.Dock = DockStyle.Fill;
            btn_CancelarCadResponsavelP.FlatAppearance.BorderSize = 0;
            btn_CancelarCadResponsavelP.FlatStyle = FlatStyle.Flat;
            btn_CancelarCadResponsavelP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_CancelarCadResponsavelP.ForeColor = Color.White;
            btn_CancelarCadResponsavelP.HoverBackgroundColor = Color.Black;
            btn_CancelarCadResponsavelP.Location = new Point(403, 3);
            btn_CancelarCadResponsavelP.Name = "btn_CancelarCadResponsavelP";
            btn_CancelarCadResponsavelP.Size = new Size(194, 25);
            btn_CancelarCadResponsavelP.TabIndex = 0;
            btn_CancelarCadResponsavelP.Text = "Cancelar Cadastro";
            btn_CancelarCadResponsavelP.TextColor = Color.White;
            btn_CancelarCadResponsavelP.UseVisualStyleBackColor = false;
            btn_CancelarCadResponsavelP.Click += btn_CancelarCadResponsavelP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(219, 25);
            label3.TabIndex = 8;
            label3.Text = "Cadastrar Responsaveis";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_GerenciarResponsaveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_GerenciarResponsaveis);
            Controls.Add(panel_CadastrarResponsavel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_GerenciarResponsaveis";
            Text = "Gerenciar Responsaveis";
            Load += F_GerenciarResponsaveis_Load;
            panel_GerenciarResponsaveis.ResumeLayout(false);
            panel_GerenciarResponsaveis.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Dados).EndInit();
            panel_CadastrarResponsavel.ResumeLayout(false);
            panel_CadastrarResponsavel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GerenciarResponsaveis;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_BuscarProfessorG;
        private CustomControls.Botoes.ButtonIG btn_CadResponsavel;
        private CustomControls.Botoes.ButtonIG btn_AttProfessorG;
        private CustomControls.Botoes.ButtonIG btn_DeletarProfessor;
        private TextBox tb_BuscarProfessorG;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgv_Dados;
        private Label label1;
        private Panel panel_CadastrarResponsavel;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.Botoes.ButtonIG btn_CadResponsavelP;
        private CustomControls.Botoes.ButtonIG btn_CancelarCadResponsavelP;
        private Label label2;
        private DataGridView dgv_DadosAlunos;
    }
}