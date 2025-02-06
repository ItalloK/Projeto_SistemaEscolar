namespace Escola
{
    partial class F_GerenciarProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GerenciarProfessores));
            panel_GerenciarProfessores = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonig3 = new CustomControls.Botoes.ButtonIG();
            buttonig2 = new CustomControls.Botoes.ButtonIG();
            textBox1 = new TextBox();
            btn_CadProfessor = new CustomControls.Botoes.ButtonIG();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            panel_CadProfessor = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_CadastrarProfessor = new CustomControls.Botoes.ButtonIG();
            btn_CancelarCadastro = new CustomControls.Botoes.ButtonIG();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tb_NomeProfessorCad = new TextBox();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            cb_nacionalidade = new ComboBox();
            cb_CorProfessorCad = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            tb_NaturalidadeProfessorCad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            mtb_CpfProfessorCad = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            mtb_DataNascCad = new MaskedTextBox();
            cb_SexoProfessorCad = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            tb_EnderecoProfessorCad = new TextBox();
            label10 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            btn_CarregarFoto = new CustomControls.Botoes.ButtonIG();
            pb_FotoProfessor = new PictureBox();
            label2 = new Label();
            panel_GerenciarProfessores.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel_CadProfessor.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FotoProfessor).BeginInit();
            SuspendLayout();
            // 
            // panel_GerenciarProfessores
            // 
            panel_GerenciarProfessores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GerenciarProfessores.Controls.Add(tableLayoutPanel1);
            panel_GerenciarProfessores.Controls.Add(tableLayoutPanel2);
            panel_GerenciarProfessores.Controls.Add(label1);
            panel_GerenciarProfessores.Location = new Point(0, 0);
            panel_GerenciarProfessores.Name = "panel_GerenciarProfessores";
            panel_GerenciarProfessores.Size = new Size(800, 450);
            panel_GerenciarProfessores.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(buttonig3, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonig2, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_CadProfessor, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(795, 32);
            tableLayoutPanel1.TabIndex = 6;
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
            buttonig3.Location = new Point(639, 3);
            buttonig3.Name = "buttonig3";
            buttonig3.Size = new Size(153, 26);
            buttonig3.TabIndex = 6;
            buttonig3.Text = "Deletar Professor";
            buttonig3.TextColor = Color.White;
            buttonig3.UseVisualStyleBackColor = false;
            // 
            // buttonig2
            // 
            buttonig2.BackColor = Color.Gray;
            buttonig2.BackgroundColor = Color.Gray;
            buttonig2.BorderColor = Color.PaleVioletRed;
            buttonig2.BorderRadius = 5;
            buttonig2.BorderSize = 0;
            buttonig2.Dock = DockStyle.Fill;
            buttonig2.FlatAppearance.BorderSize = 0;
            buttonig2.FlatStyle = FlatStyle.Flat;
            buttonig2.Font = new Font("Segoe UI", 9.75F);
            buttonig2.ForeColor = Color.White;
            buttonig2.HoverBackgroundColor = Color.Black;
            buttonig2.Location = new Point(480, 3);
            buttonig2.Name = "buttonig2";
            buttonig2.Size = new Size(153, 26);
            buttonig2.TabIndex = 5;
            buttonig2.Text = "Atualizar Professor";
            buttonig2.TextColor = Color.White;
            buttonig2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 25);
            textBox1.TabIndex = 0;
            // 
            // btn_CadProfessor
            // 
            btn_CadProfessor.BackColor = Color.Gray;
            btn_CadProfessor.BackgroundColor = Color.Gray;
            btn_CadProfessor.BorderColor = Color.PaleVioletRed;
            btn_CadProfessor.BorderRadius = 5;
            btn_CadProfessor.BorderSize = 0;
            btn_CadProfessor.Dock = DockStyle.Fill;
            btn_CadProfessor.FlatAppearance.BorderSize = 0;
            btn_CadProfessor.FlatStyle = FlatStyle.Flat;
            btn_CadProfessor.Font = new Font("Segoe UI", 9.75F);
            btn_CadProfessor.ForeColor = Color.White;
            btn_CadProfessor.HoverBackgroundColor = Color.Black;
            btn_CadProfessor.Location = new Point(321, 3);
            btn_CadProfessor.Name = "btn_CadProfessor";
            btn_CadProfessor.Size = new Size(153, 26);
            btn_CadProfessor.TabIndex = 1;
            btn_CadProfessor.Text = "Cadastrar Professor";
            btn_CadProfessor.TextColor = Color.White;
            btn_CadProfessor.UseVisualStyleBackColor = false;
            btn_CadProfessor.Click += btn_CadProfessor_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(795, 373);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 7;
            label1.Text = "Gerenciar Professores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_CadProfessor
            // 
            panel_CadProfessor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_CadProfessor.Controls.Add(tableLayoutPanel4);
            panel_CadProfessor.Controls.Add(tableLayoutPanel6);
            panel_CadProfessor.Controls.Add(label2);
            panel_CadProfessor.Location = new Point(0, 0);
            panel_CadProfessor.Name = "panel_CadProfessor";
            panel_CadProfessor.Size = new Size(800, 450);
            panel_CadProfessor.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(btn_CadastrarProfessor, 2, 0);
            tableLayoutPanel4.Controls.Add(btn_CancelarCadastro, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 420);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(800, 30);
            tableLayoutPanel4.TabIndex = 10002;
            // 
            // btn_CadastrarProfessor
            // 
            btn_CadastrarProfessor.BackColor = Color.Gray;
            btn_CadastrarProfessor.BackgroundColor = Color.Gray;
            btn_CadastrarProfessor.BorderColor = Color.PaleVioletRed;
            btn_CadastrarProfessor.BorderRadius = 4;
            btn_CadastrarProfessor.BorderSize = 0;
            btn_CadastrarProfessor.Dock = DockStyle.Fill;
            btn_CadastrarProfessor.FlatAppearance.BorderSize = 0;
            btn_CadastrarProfessor.FlatStyle = FlatStyle.Flat;
            btn_CadastrarProfessor.ForeColor = Color.White;
            btn_CadastrarProfessor.HoverBackgroundColor = Color.Black;
            btn_CadastrarProfessor.Location = new Point(643, 3);
            btn_CadastrarProfessor.Name = "btn_CadastrarProfessor";
            btn_CadastrarProfessor.Size = new Size(154, 24);
            btn_CadastrarProfessor.TabIndex = 12;
            btn_CadastrarProfessor.Text = "Cadastrar Professor";
            btn_CadastrarProfessor.TextColor = Color.White;
            btn_CadastrarProfessor.UseVisualStyleBackColor = false;
            btn_CadastrarProfessor.Click += btn_CadastrarAluno_Click;
            // 
            // btn_CancelarCadastro
            // 
            btn_CancelarCadastro.BackColor = Color.Gray;
            btn_CancelarCadastro.BackgroundColor = Color.Gray;
            btn_CancelarCadastro.BorderColor = Color.PaleVioletRed;
            btn_CancelarCadastro.BorderRadius = 4;
            btn_CancelarCadastro.BorderSize = 0;
            btn_CancelarCadastro.Dock = DockStyle.Fill;
            btn_CancelarCadastro.FlatAppearance.BorderSize = 0;
            btn_CancelarCadastro.FlatStyle = FlatStyle.Flat;
            btn_CancelarCadastro.ForeColor = Color.White;
            btn_CancelarCadastro.HoverBackgroundColor = Color.Black;
            btn_CancelarCadastro.Location = new Point(483, 3);
            btn_CancelarCadastro.Name = "btn_CancelarCadastro";
            btn_CancelarCadastro.Size = new Size(154, 24);
            btn_CancelarCadastro.TabIndex = 11;
            btn_CancelarCadastro.Text = "Cancelar Cadastro";
            btn_CancelarCadastro.TextColor = Color.White;
            btn_CancelarCadastro.UseVisualStyleBackColor = false;
            btn_CancelarCadastro.Click += btn_CancelarCadastro_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel6.Location = new Point(6, 37);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(788, 376);
            tableLayoutPanel6.TabIndex = 10001;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 41F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel9.Size = new Size(545, 370);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tb_NomeProfessorCad, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Size = new Size(539, 72);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // tb_NomeProfessorCad
            // 
            tb_NomeProfessorCad.Dock = DockStyle.Fill;
            tb_NomeProfessorCad.Font = new Font("Segoe UI", 9.75F);
            tb_NomeProfessorCad.Location = new Point(3, 31);
            tb_NomeProfessorCad.Name = "tb_NomeProfessorCad";
            tb_NomeProfessorCad.Size = new Size(533, 25);
            tb_NomeProfessorCad.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 9999;
            label3.Text = "Nome Completo:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(cb_nacionalidade, 0, 3);
            tableLayoutPanel5.Controls.Add(cb_CorProfessorCad, 1, 5);
            tableLayoutPanel5.Controls.Add(label9, 1, 4);
            tableLayoutPanel5.Controls.Add(label8, 0, 4);
            tableLayoutPanel5.Controls.Add(tb_NaturalidadeProfessorCad, 1, 3);
            tableLayoutPanel5.Controls.Add(label7, 1, 2);
            tableLayoutPanel5.Controls.Add(label6, 0, 2);
            tableLayoutPanel5.Controls.Add(mtb_CpfProfessorCad, 1, 1);
            tableLayoutPanel5.Controls.Add(label5, 1, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(mtb_DataNascCad, 0, 1);
            tableLayoutPanel5.Controls.Add(cb_SexoProfessorCad, 0, 5);
            tableLayoutPanel5.Location = new Point(3, 81);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(539, 207);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // cb_nacionalidade
            // 
            cb_nacionalidade.Dock = DockStyle.Fill;
            cb_nacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nacionalidade.Font = new Font("Segoe UI", 9.75F);
            cb_nacionalidade.FormattingEnabled = true;
            cb_nacionalidade.Items.AddRange(new object[] { "Brasil", "Argentina", "Uruguai", "Chile", "Venezuela" });
            cb_nacionalidade.Location = new Point(3, 98);
            cb_nacionalidade.Name = "cb_nacionalidade";
            cb_nacionalidade.Size = new Size(263, 25);
            cb_nacionalidade.TabIndex = 3;
            // 
            // cb_CorProfessorCad
            // 
            cb_CorProfessorCad.Dock = DockStyle.Fill;
            cb_CorProfessorCad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_CorProfessorCad.Font = new Font("Segoe UI", 9.75F);
            cb_CorProfessorCad.FormattingEnabled = true;
            cb_CorProfessorCad.Items.AddRange(new object[] { "Branca", "Preta", "Parda", "Amarela", "Indígena", "Prefiro não informar" });
            cb_CorProfessorCad.Location = new Point(272, 166);
            cb_CorProfessorCad.Name = "cb_CorProfessorCad";
            cb_CorProfessorCad.Size = new Size(264, 25);
            cb_CorProfessorCad.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(272, 146);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 9999;
            label9.Text = "Cor/Raça:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 146);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 9999;
            label8.Text = "Sexo:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_NaturalidadeProfessorCad
            // 
            tb_NaturalidadeProfessorCad.Dock = DockStyle.Fill;
            tb_NaturalidadeProfessorCad.Font = new Font("Segoe UI", 9.75F);
            tb_NaturalidadeProfessorCad.Location = new Point(272, 98);
            tb_NaturalidadeProfessorCad.Name = "tb_NaturalidadeProfessorCad";
            tb_NaturalidadeProfessorCad.Size = new Size(264, 25);
            tb_NaturalidadeProfessorCad.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(272, 78);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 9999;
            label7.Text = "Naturalidade:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 78);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 9999;
            label6.Text = "Nacionalidade:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mtb_CpfProfessorCad
            // 
            mtb_CpfProfessorCad.Dock = DockStyle.Fill;
            mtb_CpfProfessorCad.Font = new Font("Segoe UI", 9.75F);
            mtb_CpfProfessorCad.Location = new Point(272, 30);
            mtb_CpfProfessorCad.Mask = "000.000.000-00";
            mtb_CpfProfessorCad.Name = "mtb_CpfProfessorCad";
            mtb_CpfProfessorCad.Size = new Size(264, 25);
            mtb_CpfProfessorCad.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 10);
            label5.Name = "label5";
            label5.Size = new Size(112, 17);
            label5.TabIndex = 9999;
            label5.Text = "CPF do Professor:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 9999;
            label4.Text = "Data de Nascimento:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mtb_DataNascCad
            // 
            mtb_DataNascCad.Dock = DockStyle.Fill;
            mtb_DataNascCad.Font = new Font("Segoe UI", 9.75F);
            mtb_DataNascCad.Location = new Point(3, 30);
            mtb_DataNascCad.Mask = "00/00/0000";
            mtb_DataNascCad.Name = "mtb_DataNascCad";
            mtb_DataNascCad.Size = new Size(263, 25);
            mtb_DataNascCad.TabIndex = 1;
            // 
            // cb_SexoProfessorCad
            // 
            cb_SexoProfessorCad.Dock = DockStyle.Fill;
            cb_SexoProfessorCad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SexoProfessorCad.Font = new Font("Segoe UI", 9.75F);
            cb_SexoProfessorCad.FormattingEnabled = true;
            cb_SexoProfessorCad.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cb_SexoProfessorCad.Location = new Point(3, 166);
            cb_SexoProfessorCad.Name = "cb_SexoProfessorCad";
            cb_SexoProfessorCad.Size = new Size(263, 25);
            cb_SexoProfessorCad.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tb_EnderecoProfessorCad, 0, 1);
            tableLayoutPanel7.Controls.Add(label10, 0, 0);
            tableLayoutPanel7.Location = new Point(3, 294);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(539, 73);
            tableLayoutPanel7.TabIndex = 13;
            // 
            // tb_EnderecoProfessorCad
            // 
            tb_EnderecoProfessorCad.Dock = DockStyle.Fill;
            tb_EnderecoProfessorCad.Font = new Font("Segoe UI", 9.75F);
            tb_EnderecoProfessorCad.Location = new Point(3, 32);
            tb_EnderecoProfessorCad.Name = "tb_EnderecoProfessorCad";
            tb_EnderecoProfessorCad.Size = new Size(533, 25);
            tb_EnderecoProfessorCad.TabIndex = 7;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 12);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 9999;
            label10.Text = "Endereço:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(btn_CarregarFoto, 0, 2);
            tableLayoutPanel8.Controls.Add(pb_FotoProfessor, 0, 1);
            tableLayoutPanel8.Location = new Point(554, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel8.Size = new Size(231, 370);
            tableLayoutPanel8.TabIndex = 16;
            // 
            // btn_CarregarFoto
            // 
            btn_CarregarFoto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_CarregarFoto.BackColor = Color.Gray;
            btn_CarregarFoto.BackgroundColor = Color.Gray;
            btn_CarregarFoto.BorderColor = Color.PaleVioletRed;
            btn_CarregarFoto.BorderRadius = 1;
            btn_CarregarFoto.BorderSize = 0;
            btn_CarregarFoto.FlatAppearance.BorderSize = 0;
            btn_CarregarFoto.FlatStyle = FlatStyle.Flat;
            btn_CarregarFoto.ForeColor = Color.White;
            btn_CarregarFoto.HoverBackgroundColor = Color.Black;
            btn_CarregarFoto.Location = new Point(3, 267);
            btn_CarregarFoto.Name = "btn_CarregarFoto";
            btn_CarregarFoto.Size = new Size(225, 31);
            btn_CarregarFoto.TabIndex = 15;
            btn_CarregarFoto.Text = "Carregar Foto";
            btn_CarregarFoto.TextColor = Color.White;
            btn_CarregarFoto.UseVisualStyleBackColor = false;
            btn_CarregarFoto.Click += btn_CarregarFoto_Click;
            // 
            // pb_FotoProfessor
            // 
            pb_FotoProfessor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_FotoProfessor.BorderStyle = BorderStyle.FixedSingle;
            pb_FotoProfessor.Image = Properties.Resources.person;
            pb_FotoProfessor.Location = new Point(3, 36);
            pb_FotoProfessor.Name = "pb_FotoProfessor";
            pb_FotoProfessor.Size = new Size(225, 225);
            pb_FotoProfessor.SizeMode = PictureBoxSizeMode.Zoom;
            pb_FotoProfessor.TabIndex = 1;
            pb_FotoProfessor.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 10000;
            label2.Text = "Cadastrar Professor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_GerenciarProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_CadProfessor);
            Controls.Add(panel_GerenciarProfessores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "F_GerenciarProfessores";
            Text = "Gerenciar Professores";
            panel_GerenciarProfessores.ResumeLayout(false);
            panel_GerenciarProfessores.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel_CadProfessor.ResumeLayout(false);
            panel_CadProfessor.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_FotoProfessor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_GerenciarProfessores;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.Botoes.ButtonIG buttonig3;
        private CustomControls.Botoes.ButtonIG buttonig2;
        private TextBox textBox1;
        private CustomControls.Botoes.ButtonIG btn_CadProfessor;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel panel_CadProfessor;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tb_NomeProfessorCad;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox cb_nacionalidade;
        private ComboBox cb_CorProfessorCad;
        private Label label9;
        private Label label8;
        private TextBox tb_NaturalidadeProfessorCad;
        private Label label7;
        private Label label6;
        private MaskedTextBox mtb_CpfProfessorCad;
        private Label label5;
        private Label label4;
        private MaskedTextBox mtb_DataNascCad;
        private ComboBox cb_SexoProfessorCad;
        private TableLayoutPanel tableLayoutPanel8;
        private CustomControls.Botoes.ButtonIG btn_CarregarFoto;
        private PictureBox pb_FotoProfessor;
        private TableLayoutPanel tableLayoutPanel4;
        private CustomControls.Botoes.ButtonIG btn_CadastrarProfessor;
        private CustomControls.Botoes.ButtonIG btn_CancelarCadastro;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox tb_EnderecoProfessorCad;
        private Label label10;
    }
}