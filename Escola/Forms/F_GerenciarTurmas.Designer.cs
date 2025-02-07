namespace Escola.Forms
{
    partial class F_GerenciarTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GerenciarTurmas));
            panel_GerenciarTurmas = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgv_Dados = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgv_DadosAluno = new DataGridView();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonig4 = new CustomControls.Botoes.ButtonIG();
            buttonig3 = new CustomControls.Botoes.ButtonIG();
            textBox1 = new TextBox();
            btn_CadAlunoGerenciador = new CustomControls.Botoes.ButtonIG();
            label1 = new Label();
            panel_GerenciarTurmas.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Dados).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosAluno).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_GerenciarTurmas
            // 
            panel_GerenciarTurmas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GerenciarTurmas.Controls.Add(tableLayoutPanel2);
            panel_GerenciarTurmas.Controls.Add(tableLayoutPanel1);
            panel_GerenciarTurmas.Controls.Add(label1);
            panel_GerenciarTurmas.Location = new Point(0, 0);
            panel_GerenciarTurmas.Name = "panel_GerenciarTurmas";
            panel_GerenciarTurmas.Size = new Size(800, 450);
            panel_GerenciarTurmas.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgv_Dados, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 374);
            tableLayoutPanel2.TabIndex = 7;
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
            dgv_Dados.Size = new Size(794, 187);
            dgv_Dados.TabIndex = 0;
            dgv_Dados.SelectionChanged += dgv_Dados_SelectionChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dgv_DadosAluno, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 187);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.Size = new Size(794, 187);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dgv_DadosAluno
            // 
            dgv_DadosAluno.AllowUserToAddRows = false;
            dgv_DadosAluno.AllowUserToDeleteRows = false;
            dgv_DadosAluno.AllowUserToResizeColumns = false;
            dgv_DadosAluno.AllowUserToResizeRows = false;
            dgv_DadosAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DadosAluno.BackgroundColor = Color.White;
            dgv_DadosAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_DadosAluno.Dock = DockStyle.Fill;
            dgv_DadosAluno.Location = new Point(0, 28);
            dgv_DadosAluno.Margin = new Padding(0);
            dgv_DadosAluno.MultiSelect = false;
            dgv_DadosAluno.Name = "dgv_DadosAluno";
            dgv_DadosAluno.ReadOnly = true;
            dgv_DadosAluno.RowHeadersVisible = false;
            dgv_DadosAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DadosAluno.Size = new Size(794, 159);
            dgv_DadosAluno.TabIndex = 2;
            dgv_DadosAluno.CellFormatting += dgv_DadosAluno_CellFormatting;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 1);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 0;
            label2.Text = "Alunos:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(buttonig4, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonig3, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_CadAlunoGerenciador, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(794, 32);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonig4
            // 
            buttonig4.BackColor = Color.Gray;
            buttonig4.BackgroundColor = Color.Gray;
            buttonig4.BorderColor = Color.PaleVioletRed;
            buttonig4.BorderRadius = 5;
            buttonig4.BorderSize = 0;
            buttonig4.Dock = DockStyle.Fill;
            buttonig4.FlatAppearance.BorderSize = 0;
            buttonig4.FlatStyle = FlatStyle.Flat;
            buttonig4.Font = new Font("Segoe UI", 9.75F);
            buttonig4.ForeColor = Color.White;
            buttonig4.HoverBackgroundColor = Color.Black;
            buttonig4.Location = new Point(636, 3);
            buttonig4.Name = "buttonig4";
            buttonig4.Size = new Size(155, 26);
            buttonig4.TabIndex = 6;
            buttonig4.Text = "Deletar Turma";
            buttonig4.TextColor = Color.White;
            buttonig4.UseVisualStyleBackColor = false;
            // 
            // buttonig3
            // 
            buttonig3.BackColor = Color.Gray;
            buttonig3.BackgroundColor = Color.Gray;
            buttonig3.BorderColor = Color.PaleVioletRed;
            buttonig3.BorderRadius = 5;
            buttonig3.BorderSize = 0;
            buttonig3.Dock = DockStyle.Fill;
            buttonig3.FlatAppearance.BorderSize = 0;
            buttonig3.FlatStyle = FlatStyle.Flat;
            buttonig3.Font = new Font("Segoe UI", 9.75F);
            buttonig3.ForeColor = Color.White;
            buttonig3.HoverBackgroundColor = Color.Black;
            buttonig3.Location = new Point(478, 3);
            buttonig3.Name = "buttonig3";
            buttonig3.Size = new Size(152, 26);
            buttonig3.TabIndex = 5;
            buttonig3.Text = "Atualizar Turma";
            buttonig3.TextColor = Color.White;
            buttonig3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 25);
            textBox1.TabIndex = 0;
            // 
            // btn_CadAlunoGerenciador
            // 
            btn_CadAlunoGerenciador.BackColor = Color.Gray;
            btn_CadAlunoGerenciador.BackgroundColor = Color.Gray;
            btn_CadAlunoGerenciador.BorderColor = Color.PaleVioletRed;
            btn_CadAlunoGerenciador.BorderRadius = 5;
            btn_CadAlunoGerenciador.BorderSize = 0;
            btn_CadAlunoGerenciador.Dock = DockStyle.Fill;
            btn_CadAlunoGerenciador.FlatAppearance.BorderSize = 0;
            btn_CadAlunoGerenciador.FlatStyle = FlatStyle.Flat;
            btn_CadAlunoGerenciador.Font = new Font("Segoe UI", 9.75F);
            btn_CadAlunoGerenciador.ForeColor = Color.White;
            btn_CadAlunoGerenciador.HoverBackgroundColor = Color.Black;
            btn_CadAlunoGerenciador.Location = new Point(320, 3);
            btn_CadAlunoGerenciador.Name = "btn_CadAlunoGerenciador";
            btn_CadAlunoGerenciador.Size = new Size(152, 26);
            btn_CadAlunoGerenciador.TabIndex = 1;
            btn_CadAlunoGerenciador.Text = "Cadastrar Turma";
            btn_CadAlunoGerenciador.TextColor = Color.White;
            btn_CadAlunoGerenciador.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 5;
            label1.Text = "Gerenciar Turmas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_GerenciarTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_GerenciarTurmas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_GerenciarTurmas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Turmas";
            Load += F_GerenciarTurmas_Load;
            panel_GerenciarTurmas.ResumeLayout(false);
            panel_GerenciarTurmas.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Dados).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosAluno).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GerenciarTurmas;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private CustomControls.Botoes.ButtonIG btn_CadAlunoGerenciador;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private DataGridView dgv_Dados;
        private DataGridView dgv_DadosAluno;
        private CustomControls.Botoes.ButtonIG buttonig4;
        private CustomControls.Botoes.ButtonIG buttonig3;
    }
}