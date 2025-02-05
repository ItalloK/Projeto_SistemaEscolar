namespace Escola
{
    partial class GerenciarAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarAlunos));
            Panel_CadAluno = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tb_NomeAlunoCad = new TextBox();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            cb_nacionalidade = new ComboBox();
            cb_CorAlunoCad = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            tb_NaturalidadeAlunoCad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            mtb_CpfAlunoCad = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            mtb_DataNascCad = new MaskedTextBox();
            cb_SexoAlunoCad = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            tb_EnderecoAlunoCad = new TextBox();
            label10 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            label11 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label12 = new Label();
            tb_NomeResponsavel = new TextBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            mtb_TelResponsavel = new MaskedTextBox();
            label14 = new Label();
            label13 = new Label();
            mtb_CpfResponsavel = new MaskedTextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            btn_CarregarFoto = new CustomControls.Botoes.ButtonIG();
            pb_FotoAluno = new PictureBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            label15 = new Label();
            btn_BuscarResponsavel = new Button();
            mtb_BuscarCPFResp = new MaskedTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_CadastrarAluno = new CustomControls.Botoes.ButtonIG();
            btn_CancelarCadastro = new CustomControls.Botoes.ButtonIG();
            label2 = new Label();
            Panel_Gerenciar = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonig4 = new CustomControls.Botoes.ButtonIG();
            buttonig3 = new CustomControls.Botoes.ButtonIG();
            buttonig2 = new CustomControls.Botoes.ButtonIG();
            textBox1 = new TextBox();
            btn_CadAlunoGerenciador = new CustomControls.Botoes.ButtonIG();
            Panel_CadAluno.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FotoAluno).BeginInit();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            Panel_Gerenciar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_CadAluno
            // 
            Panel_CadAluno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_CadAluno.Controls.Add(tableLayoutPanel6);
            Panel_CadAluno.Controls.Add(tableLayoutPanel4);
            Panel_CadAluno.Controls.Add(label2);
            Panel_CadAluno.Location = new Point(0, 0);
            Panel_CadAluno.Name = "Panel_CadAluno";
            Panel_CadAluno.Size = new Size(800, 450);
            Panel_CadAluno.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel6.Location = new Point(6, 38);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(788, 376);
            tableLayoutPanel6.TabIndex = 10000;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 3);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 41F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 29F));
            tableLayoutPanel9.Size = new Size(545, 370);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tb_NomeAlunoCad, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Size = new Size(539, 49);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // tb_NomeAlunoCad
            // 
            tb_NomeAlunoCad.Dock = DockStyle.Fill;
            tb_NomeAlunoCad.Font = new Font("Segoe UI", 9.75F);
            tb_NomeAlunoCad.Location = new Point(3, 22);
            tb_NomeAlunoCad.Name = "tb_NomeAlunoCad";
            tb_NomeAlunoCad.Size = new Size(533, 25);
            tb_NomeAlunoCad.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 2);
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
            tableLayoutPanel5.Controls.Add(cb_CorAlunoCad, 1, 5);
            tableLayoutPanel5.Controls.Add(label9, 1, 4);
            tableLayoutPanel5.Controls.Add(label8, 0, 4);
            tableLayoutPanel5.Controls.Add(tb_NaturalidadeAlunoCad, 1, 3);
            tableLayoutPanel5.Controls.Add(label7, 1, 2);
            tableLayoutPanel5.Controls.Add(label6, 0, 2);
            tableLayoutPanel5.Controls.Add(mtb_CpfAlunoCad, 1, 1);
            tableLayoutPanel5.Controls.Add(label5, 1, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(mtb_DataNascCad, 0, 1);
            tableLayoutPanel5.Controls.Add(cb_SexoAlunoCad, 0, 5);
            tableLayoutPanel5.Location = new Point(3, 58);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(539, 145);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // cb_nacionalidade
            // 
            cb_nacionalidade.Dock = DockStyle.Fill;
            cb_nacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nacionalidade.Font = new Font("Segoe UI", 9.75F);
            cb_nacionalidade.FormattingEnabled = true;
            cb_nacionalidade.Items.AddRange(new object[] { "Brasil", "Argentina", "Uruguai", "Chile", "Venezuela" });
            cb_nacionalidade.Location = new Point(3, 70);
            cb_nacionalidade.Name = "cb_nacionalidade";
            cb_nacionalidade.Size = new Size(263, 25);
            cb_nacionalidade.TabIndex = 3;
            // 
            // cb_CorAlunoCad
            // 
            cb_CorAlunoCad.Dock = DockStyle.Fill;
            cb_CorAlunoCad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_CorAlunoCad.Font = new Font("Segoe UI", 9.75F);
            cb_CorAlunoCad.FormattingEnabled = true;
            cb_CorAlunoCad.Items.AddRange(new object[] { "Branca", "Preta", "Parda", "Amarela", "Indígena", "Prefiro não informar" });
            cb_CorAlunoCad.Location = new Point(272, 118);
            cb_CorAlunoCad.Name = "cb_CorAlunoCad";
            cb_CorAlunoCad.Size = new Size(264, 25);
            cb_CorAlunoCad.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(272, 98);
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
            label8.Location = new Point(3, 98);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 9999;
            label8.Text = "Sexo:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_NaturalidadeAlunoCad
            // 
            tb_NaturalidadeAlunoCad.Dock = DockStyle.Fill;
            tb_NaturalidadeAlunoCad.Font = new Font("Segoe UI", 9.75F);
            tb_NaturalidadeAlunoCad.Location = new Point(272, 70);
            tb_NaturalidadeAlunoCad.Name = "tb_NaturalidadeAlunoCad";
            tb_NaturalidadeAlunoCad.Size = new Size(264, 25);
            tb_NaturalidadeAlunoCad.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(272, 50);
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
            label6.Location = new Point(3, 50);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 9999;
            label6.Text = "Nacionalidade:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mtb_CpfAlunoCad
            // 
            mtb_CpfAlunoCad.Dock = DockStyle.Fill;
            mtb_CpfAlunoCad.Font = new Font("Segoe UI", 9.75F);
            mtb_CpfAlunoCad.Location = new Point(272, 22);
            mtb_CpfAlunoCad.Mask = "000.000.000-00";
            mtb_CpfAlunoCad.Name = "mtb_CpfAlunoCad";
            mtb_CpfAlunoCad.Size = new Size(264, 25);
            mtb_CpfAlunoCad.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 2);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 9999;
            label5.Text = "CPF do Aluno:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 2);
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
            mtb_DataNascCad.Location = new Point(3, 22);
            mtb_DataNascCad.Mask = "00/00/0000";
            mtb_DataNascCad.Name = "mtb_DataNascCad";
            mtb_DataNascCad.Size = new Size(263, 25);
            mtb_DataNascCad.TabIndex = 1;
            // 
            // cb_SexoAlunoCad
            // 
            cb_SexoAlunoCad.Dock = DockStyle.Fill;
            cb_SexoAlunoCad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SexoAlunoCad.Font = new Font("Segoe UI", 9.75F);
            cb_SexoAlunoCad.FormattingEnabled = true;
            cb_SexoAlunoCad.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cb_SexoAlunoCad.Location = new Point(3, 118);
            cb_SexoAlunoCad.Name = "cb_SexoAlunoCad";
            cb_SexoAlunoCad.Size = new Size(263, 25);
            cb_SexoAlunoCad.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tb_EnderecoAlunoCad, 0, 1);
            tableLayoutPanel7.Controls.Add(label10, 0, 0);
            tableLayoutPanel7.Location = new Point(3, 209);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(539, 49);
            tableLayoutPanel7.TabIndex = 13;
            // 
            // tb_EnderecoAlunoCad
            // 
            tb_EnderecoAlunoCad.Dock = DockStyle.Fill;
            tb_EnderecoAlunoCad.Font = new Font("Segoe UI", 9.75F);
            tb_EnderecoAlunoCad.Location = new Point(3, 22);
            tb_EnderecoAlunoCad.Name = "tb_EnderecoAlunoCad";
            tb_EnderecoAlunoCad.Size = new Size(533, 25);
            tb_EnderecoAlunoCad.TabIndex = 7;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 2);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 9999;
            label10.Text = "Endereço:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(label11, 0, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 261);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel10.Size = new Size(545, 109);
            tableLayoutPanel10.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 10000;
            label11.Text = "Responsavel:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 21);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(545, 88);
            tableLayoutPanel11.TabIndex = 10001;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(label12, 0, 0);
            tableLayoutPanel12.Controls.Add(tb_NomeResponsavel, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel12.Size = new Size(545, 44);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(43, 14);
            label12.TabIndex = 0;
            label12.Text = "Nome:";
            // 
            // tb_NomeResponsavel
            // 
            tb_NomeResponsavel.Dock = DockStyle.Fill;
            tb_NomeResponsavel.Font = new Font("Segoe UI", 9.75F);
            tb_NomeResponsavel.Location = new Point(3, 17);
            tb_NomeResponsavel.Name = "tb_NomeResponsavel";
            tb_NomeResponsavel.Size = new Size(539, 25);
            tb_NomeResponsavel.TabIndex = 8;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(mtb_TelResponsavel, 1, 1);
            tableLayoutPanel13.Controls.Add(label14, 1, 0);
            tableLayoutPanel13.Controls.Add(label13, 0, 0);
            tableLayoutPanel13.Controls.Add(mtb_CpfResponsavel, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 44);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel13.Size = new Size(545, 44);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // mtb_TelResponsavel
            // 
            mtb_TelResponsavel.Dock = DockStyle.Fill;
            mtb_TelResponsavel.Font = new Font("Segoe UI", 9.75F);
            mtb_TelResponsavel.Location = new Point(275, 17);
            mtb_TelResponsavel.Mask = "(00) 0 0000-0000";
            mtb_TelResponsavel.Name = "mtb_TelResponsavel";
            mtb_TelResponsavel.Size = new Size(267, 25);
            mtb_TelResponsavel.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(275, 0);
            label14.Name = "label14";
            label14.Size = new Size(54, 14);
            label14.TabIndex = 2;
            label14.Text = "Telefone:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 14);
            label13.TabIndex = 1;
            label13.Text = "CPF:";
            // 
            // mtb_CpfResponsavel
            // 
            mtb_CpfResponsavel.Dock = DockStyle.Fill;
            mtb_CpfResponsavel.Font = new Font("Segoe UI", 9.75F);
            mtb_CpfResponsavel.Location = new Point(3, 17);
            mtb_CpfResponsavel.Mask = "000.000.000-00";
            mtb_CpfResponsavel.Name = "mtb_CpfResponsavel";
            mtb_CpfResponsavel.Size = new Size(266, 25);
            mtb_CpfResponsavel.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(btn_CarregarFoto, 0, 2);
            tableLayoutPanel8.Controls.Add(pb_FotoAluno, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel14, 0, 3);
            tableLayoutPanel8.Location = new Point(554, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
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
            btn_CarregarFoto.Location = new Point(3, 256);
            btn_CarregarFoto.Name = "btn_CarregarFoto";
            btn_CarregarFoto.Size = new Size(225, 31);
            btn_CarregarFoto.TabIndex = 15;
            btn_CarregarFoto.Text = "Carregar Foto";
            btn_CarregarFoto.TextColor = Color.White;
            btn_CarregarFoto.UseVisualStyleBackColor = false;
            btn_CarregarFoto.Click += btn_CarregarFoto_Click;
            // 
            // pb_FotoAluno
            // 
            pb_FotoAluno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_FotoAluno.BorderStyle = BorderStyle.FixedSingle;
            pb_FotoAluno.Image = Properties.Resources.person;
            pb_FotoAluno.Location = new Point(3, 25);
            pb_FotoAluno.Name = "pb_FotoAluno";
            pb_FotoAluno.Size = new Size(225, 225);
            pb_FotoAluno.SizeMode = PictureBoxSizeMode.Zoom;
            pb_FotoAluno.TabIndex = 1;
            pb_FotoAluno.TabStop = false;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel14.Controls.Add(label15, 0, 0);
            tableLayoutPanel14.Controls.Add(btn_BuscarResponsavel, 1, 1);
            tableLayoutPanel14.Controls.Add(mtb_BuscarCPFResp, 0, 1);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 295);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel14.Size = new Size(231, 75);
            tableLayoutPanel14.TabIndex = 12;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 30);
            label15.Name = "label15";
            label15.Size = new Size(110, 15);
            label15.TabIndex = 0;
            label15.Text = "Buscar Responsavel";
            // 
            // btn_BuscarResponsavel
            // 
            btn_BuscarResponsavel.BackgroundImage = Properties.Resources.lupa;
            btn_BuscarResponsavel.BackgroundImageLayout = ImageLayout.Zoom;
            btn_BuscarResponsavel.Location = new Point(199, 48);
            btn_BuscarResponsavel.Name = "btn_BuscarResponsavel";
            btn_BuscarResponsavel.Size = new Size(29, 24);
            btn_BuscarResponsavel.TabIndex = 14;
            btn_BuscarResponsavel.UseVisualStyleBackColor = true;
            btn_BuscarResponsavel.Click += btn_BuscarResponsavel_Click;
            // 
            // mtb_BuscarCPFResp
            // 
            mtb_BuscarCPFResp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtb_BuscarCPFResp.Font = new Font("Segoe UI", 9.75F);
            mtb_BuscarCPFResp.Location = new Point(3, 48);
            mtb_BuscarCPFResp.Mask = "000.000.000-00";
            mtb_BuscarCPFResp.Name = "mtb_BuscarCPFResp";
            mtb_BuscarCPFResp.Size = new Size(190, 25);
            mtb_BuscarCPFResp.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(btn_CadastrarAluno, 2, 0);
            tableLayoutPanel4.Controls.Add(btn_CancelarCadastro, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 420);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(800, 30);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // btn_CadastrarAluno
            // 
            btn_CadastrarAluno.BackColor = Color.Gray;
            btn_CadastrarAluno.BackgroundColor = Color.Gray;
            btn_CadastrarAluno.BorderColor = Color.PaleVioletRed;
            btn_CadastrarAluno.BorderRadius = 4;
            btn_CadastrarAluno.BorderSize = 0;
            btn_CadastrarAluno.Dock = DockStyle.Fill;
            btn_CadastrarAluno.FlatAppearance.BorderSize = 0;
            btn_CadastrarAluno.FlatStyle = FlatStyle.Flat;
            btn_CadastrarAluno.ForeColor = Color.White;
            btn_CadastrarAluno.HoverBackgroundColor = Color.Black;
            btn_CadastrarAluno.Location = new Point(643, 3);
            btn_CadastrarAluno.Name = "btn_CadastrarAluno";
            btn_CadastrarAluno.Size = new Size(154, 24);
            btn_CadastrarAluno.TabIndex = 12;
            btn_CadastrarAluno.Text = "Cadastrar Aluno";
            btn_CadastrarAluno.TextColor = Color.White;
            btn_CadastrarAluno.UseVisualStyleBackColor = false;
            btn_CadastrarAluno.Click += btn_CadastrarAluno_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 9999;
            label2.Text = "Cadastrar Aluno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Gerenciar
            // 
            Panel_Gerenciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Gerenciar.Controls.Add(tableLayoutPanel2);
            Panel_Gerenciar.Controls.Add(label1);
            Panel_Gerenciar.Controls.Add(tableLayoutPanel1);
            Panel_Gerenciar.Location = new Point(0, 0);
            Panel_Gerenciar.Name = "Panel_Gerenciar";
            Panel_Gerenciar.Size = new Size(800, 450);
            Panel_Gerenciar.TabIndex = 4;
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
            tableLayoutPanel2.Size = new Size(794, 374);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 4;
            label1.Text = "Gerenciar Alunos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(buttonig4, 4, 0);
            tableLayoutPanel1.Controls.Add(buttonig3, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonig2, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_CadAlunoGerenciador, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(794, 32);
            tableLayoutPanel1.TabIndex = 3;
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
            buttonig4.Location = new Point(663, 3);
            buttonig4.Name = "buttonig4";
            buttonig4.Size = new Size(128, 26);
            buttonig4.TabIndex = 4;
            buttonig4.Text = "Deletar Aluno";
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
            buttonig3.Location = new Point(531, 3);
            buttonig3.Name = "buttonig3";
            buttonig3.Size = new Size(126, 26);
            buttonig3.TabIndex = 3;
            buttonig3.Text = "Atualizar Aluno";
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
            buttonig2.Location = new Point(399, 3);
            buttonig2.Name = "buttonig2";
            buttonig2.Size = new Size(126, 26);
            buttonig2.TabIndex = 2;
            buttonig2.Text = "Ver Responsáveis";
            buttonig2.TextColor = Color.White;
            buttonig2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 25);
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
            btn_CadAlunoGerenciador.Location = new Point(267, 3);
            btn_CadAlunoGerenciador.Name = "btn_CadAlunoGerenciador";
            btn_CadAlunoGerenciador.Size = new Size(126, 26);
            btn_CadAlunoGerenciador.TabIndex = 1;
            btn_CadAlunoGerenciador.Text = "Cadastrar Aluno";
            btn_CadAlunoGerenciador.TextColor = Color.White;
            btn_CadAlunoGerenciador.UseVisualStyleBackColor = false;
            btn_CadAlunoGerenciador.Click += btn_CadAlunoGerenciador_Click;
            // 
            // GerenciarAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel_CadAluno);
            Controls.Add(Panel_Gerenciar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "GerenciarAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Alunos";
            Panel_CadAluno.ResumeLayout(false);
            Panel_CadAluno.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_FotoAluno).EndInit();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            Panel_Gerenciar.ResumeLayout(false);
            Panel_Gerenciar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Panel_CadAluno;
        private Label label2;
        private CustomControls.Botoes.ButtonIG btn_CancelarCadastro;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tb_NomeAlunoCad;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private CustomControls.Botoes.ButtonIG btn_CadastrarAluno;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private MaskedTextBox mtb_DataNascCad;
        private Label label7;
        private Label label6;
        private MaskedTextBox mtb_CpfAlunoCad;
        private Label label5;
        private TextBox tb_NaturalidadeAlunoCad;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label9;
        private Label label8;
        private ComboBox cb_CorAlunoCad;
        private ComboBox cb_SexoAlunoCad;
        private TextBox tb_EnderecoAlunoCad;
        private Label label10;
        private Panel Panel_Gerenciar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.Botoes.ButtonIG buttonig4;
        private CustomControls.Botoes.ButtonIG buttonig3;
        private CustomControls.Botoes.ButtonIG buttonig2;
        private TextBox textBox1;
        private CustomControls.Botoes.ButtonIG btn_CadAlunoGerenciador;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pb_FotoAluno;
        private ComboBox cb_nacionalidade;
        private CustomControls.Botoes.ButtonIG btn_CarregarFoto;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label12;
        private TextBox tb_NomeResponsavel;
        private TableLayoutPanel tableLayoutPanel13;
        private MaskedTextBox mtb_TelResponsavel;
        private Label label14;
        private Label label13;
        private MaskedTextBox mtb_CpfResponsavel;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label15;
        private Button btn_BuscarResponsavel;
        private MaskedTextBox mtb_BuscarCPFResp;
    }
}