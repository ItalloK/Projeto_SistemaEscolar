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
            panel_CadTurma = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            cb_EscMaxAluno = new ComboBox();
            label7 = new Label();
            cb_EscTurno = new ComboBox();
            label6 = new Label();
            cb_EscTipo = new ComboBox();
            label4 = new Label();
            cb_EscSerie = new ComboBox();
            label5 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_CancelarCadTurma = new CustomControls.Botoes.ButtonIG();
            btn_CadastrarTurma = new CustomControls.Botoes.ButtonIG();
            label3 = new Label();
            panel_GerenciarTurmas.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Dados).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosAluno).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel_CadTurma.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            btn_CadAlunoGerenciador.Click += btn_CadAlunoGerenciador_Click;
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
            // panel_CadTurma
            // 
            panel_CadTurma.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_CadTurma.Controls.Add(tableLayoutPanel5);
            panel_CadTurma.Controls.Add(tableLayoutPanel4);
            panel_CadTurma.Controls.Add(label3);
            panel_CadTurma.Location = new Point(0, 0);
            panel_CadTurma.Name = "panel_CadTurma";
            panel_CadTurma.Size = new Size(800, 450);
            panel_CadTurma.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(cb_EscMaxAluno, 0, 7);
            tableLayoutPanel5.Controls.Add(label7, 0, 6);
            tableLayoutPanel5.Controls.Add(cb_EscTurno, 0, 5);
            tableLayoutPanel5.Controls.Add(label6, 0, 4);
            tableLayoutPanel5.Controls.Add(cb_EscTipo, 0, 3);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(cb_EscSerie, 0, 1);
            tableLayoutPanel5.Controls.Add(label5, 0, 2);
            tableLayoutPanel5.Location = new Point(6, 40);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.Size = new Size(788, 372);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // cb_EscMaxAluno
            // 
            cb_EscMaxAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_EscMaxAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_EscMaxAluno.FormattingEnabled = true;
            cb_EscMaxAluno.Location = new Point(3, 325);
            cb_EscMaxAluno.Name = "cb_EscMaxAluno";
            cb_EscMaxAluno.Size = new Size(308, 29);
            cb_EscMaxAluno.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 301);
            label7.Name = "label7";
            label7.Size = new Size(338, 21);
            label7.TabIndex = 6;
            label7.Text = "Escolha o maximo de Alunos para esta turma:";
            // 
            // cb_EscTurno
            // 
            cb_EscTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_EscTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_EscTurno.FormattingEnabled = true;
            cb_EscTurno.Location = new Point(3, 233);
            cb_EscTurno.Name = "cb_EscTurno";
            cb_EscTurno.Size = new Size(308, 29);
            cb_EscTurno.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 209);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 4;
            label6.Text = "Escolha o Turno:";
            // 
            // cb_EscTipo
            // 
            cb_EscTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_EscTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_EscTipo.FormattingEnabled = true;
            cb_EscTipo.Location = new Point(3, 141);
            cb_EscTipo.Name = "cb_EscTipo";
            cb_EscTipo.Size = new Size(308, 29);
            cb_EscTipo.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 0;
            label4.Text = "Escolha a Serie:";
            // 
            // cb_EscSerie
            // 
            cb_EscSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_EscSerie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_EscSerie.FormattingEnabled = true;
            cb_EscSerie.Location = new Point(3, 49);
            cb_EscSerie.Name = "cb_EscSerie";
            cb_EscSerie.Size = new Size(308, 29);
            cb_EscSerie.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 117);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 2;
            label5.Text = "Escolha o Tipo:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btn_CancelarCadTurma, 1, 0);
            tableLayoutPanel4.Controls.Add(btn_CadastrarTurma, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 418);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(800, 32);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_CancelarCadTurma
            // 
            btn_CancelarCadTurma.BackColor = Color.Gray;
            btn_CancelarCadTurma.BackgroundColor = Color.Gray;
            btn_CancelarCadTurma.BorderColor = Color.PaleVioletRed;
            btn_CancelarCadTurma.BorderRadius = 5;
            btn_CancelarCadTurma.BorderSize = 0;
            btn_CancelarCadTurma.Dock = DockStyle.Fill;
            btn_CancelarCadTurma.FlatAppearance.BorderSize = 0;
            btn_CancelarCadTurma.FlatStyle = FlatStyle.Flat;
            btn_CancelarCadTurma.Font = new Font("Segoe UI", 9.75F);
            btn_CancelarCadTurma.ForeColor = Color.White;
            btn_CancelarCadTurma.HoverBackgroundColor = Color.Black;
            btn_CancelarCadTurma.Location = new Point(403, 3);
            btn_CancelarCadTurma.Name = "btn_CancelarCadTurma";
            btn_CancelarCadTurma.Size = new Size(194, 26);
            btn_CancelarCadTurma.TabIndex = 0;
            btn_CancelarCadTurma.Text = "Cancelar";
            btn_CancelarCadTurma.TextColor = Color.White;
            btn_CancelarCadTurma.UseVisualStyleBackColor = false;
            btn_CancelarCadTurma.Click += btn_CancelarCadTurma_Click;
            // 
            // btn_CadastrarTurma
            // 
            btn_CadastrarTurma.BackColor = Color.Gray;
            btn_CadastrarTurma.BackgroundColor = Color.Gray;
            btn_CadastrarTurma.BorderColor = Color.PaleVioletRed;
            btn_CadastrarTurma.BorderRadius = 5;
            btn_CadastrarTurma.BorderSize = 0;
            btn_CadastrarTurma.Dock = DockStyle.Fill;
            btn_CadastrarTurma.FlatAppearance.BorderSize = 0;
            btn_CadastrarTurma.FlatStyle = FlatStyle.Flat;
            btn_CadastrarTurma.Font = new Font("Segoe UI", 9.75F);
            btn_CadastrarTurma.ForeColor = Color.White;
            btn_CadastrarTurma.HoverBackgroundColor = Color.Black;
            btn_CadastrarTurma.Location = new Point(603, 3);
            btn_CadastrarTurma.Name = "btn_CadastrarTurma";
            btn_CadastrarTurma.Size = new Size(194, 26);
            btn_CadastrarTurma.TabIndex = 1;
            btn_CadastrarTurma.Text = "Cadastrar Turma";
            btn_CadastrarTurma.TextColor = Color.White;
            btn_CadastrarTurma.UseVisualStyleBackColor = false;
            btn_CadastrarTurma.Click += btn_CadastrarTurma_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 0;
            label3.Text = "Cadastrar Turma";
            // 
            // F_GerenciarTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_CadTurma);
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
            panel_CadTurma.ResumeLayout(false);
            panel_CadTurma.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
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
        private Panel panel_CadTurma;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private CustomControls.Botoes.ButtonIG btn_CancelarCadTurma;
        private CustomControls.Botoes.ButtonIG btn_CadastrarTurma;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private ComboBox cb_EscSerie;
        private ComboBox cb_EscMaxAluno;
        private Label label7;
        private ComboBox cb_EscTurno;
        private Label label6;
        private ComboBox cb_EscTipo;
        private Label label5;
    }
}