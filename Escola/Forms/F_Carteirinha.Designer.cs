namespace Escola
{
    partial class F_Carteirinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Carteirinha));
            label1 = new Label();
            btn_Buscar = new Button();
            panel_Fundo = new Panel();
            pb_QrCode = new PictureBox();
            lbl_Serie = new Label();
            lbl_TextSerie = new Label();
            lbl_Turma = new Label();
            lbl_TextTurma = new Label();
            lbl_Codigo = new Label();
            lbl_TextCodigo = new Label();
            lbl_Sexo = new Label();
            lbl_TextSexo = new Label();
            lbl_DataNasc = new Label();
            lbl_TextDataNasc = new Label();
            lbl_Nome = new Label();
            lbl_TextNome = new Label();
            pb_FotoPerfil = new PictureBox();
            pb_FundoCarteirinha = new PictureBox();
            cb_Tipo = new ComboBox();
            mtb_CpfBuscar = new MaskedTextBox();
            panel_Fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QrCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_FotoPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_FundoCarteirinha).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 1;
            label1.Text = "Digite o CPF:";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Buscar.BackgroundImage = Properties.Resources.lupa;
            btn_Buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Buscar.Location = new Point(415, 29);
            btn_Buscar.Margin = new Padding(0);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(25, 25);
            btn_Buscar.TabIndex = 15;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // panel_Fundo
            // 
            panel_Fundo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Fundo.BackColor = Color.Transparent;
            panel_Fundo.BorderStyle = BorderStyle.FixedSingle;
            panel_Fundo.Controls.Add(pb_QrCode);
            panel_Fundo.Controls.Add(lbl_Serie);
            panel_Fundo.Controls.Add(lbl_TextSerie);
            panel_Fundo.Controls.Add(lbl_Turma);
            panel_Fundo.Controls.Add(lbl_TextTurma);
            panel_Fundo.Controls.Add(lbl_Codigo);
            panel_Fundo.Controls.Add(lbl_TextCodigo);
            panel_Fundo.Controls.Add(lbl_Sexo);
            panel_Fundo.Controls.Add(lbl_TextSexo);
            panel_Fundo.Controls.Add(lbl_DataNasc);
            panel_Fundo.Controls.Add(lbl_TextDataNasc);
            panel_Fundo.Controls.Add(lbl_Nome);
            panel_Fundo.Controls.Add(lbl_TextNome);
            panel_Fundo.Controls.Add(pb_FotoPerfil);
            panel_Fundo.Controls.Add(pb_FundoCarteirinha);
            panel_Fundo.Location = new Point(12, 63);
            panel_Fundo.Margin = new Padding(0);
            panel_Fundo.Name = "panel_Fundo";
            panel_Fundo.Size = new Size(550, 230);
            panel_Fundo.TabIndex = 16;
            // 
            // pb_QrCode
            // 
            pb_QrCode.BackColor = Color.Transparent;
            pb_QrCode.Location = new Point(495, 176);
            pb_QrCode.Name = "pb_QrCode";
            pb_QrCode.Size = new Size(50, 50);
            pb_QrCode.SizeMode = PictureBoxSizeMode.Zoom;
            pb_QrCode.TabIndex = 13;
            pb_QrCode.TabStop = false;
            // 
            // lbl_Serie
            // 
            lbl_Serie.AutoSize = true;
            lbl_Serie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Serie.Location = new Point(402, 141);
            lbl_Serie.Name = "lbl_Serie";
            lbl_Serie.Size = new Size(0, 21);
            lbl_Serie.TabIndex = 12;
            lbl_Serie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextSerie
            // 
            lbl_TextSerie.AutoSize = true;
            lbl_TextSerie.BackColor = Color.Transparent;
            lbl_TextSerie.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_TextSerie.Location = new Point(402, 124);
            lbl_TextSerie.Name = "lbl_TextSerie";
            lbl_TextSerie.Size = new Size(40, 17);
            lbl_TextSerie.TabIndex = 11;
            lbl_TextSerie.Text = "Serie:";
            lbl_TextSerie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Turma
            // 
            lbl_Turma.AutoSize = true;
            lbl_Turma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Turma.Location = new Point(169, 141);
            lbl_Turma.Name = "lbl_Turma";
            lbl_Turma.Size = new Size(0, 21);
            lbl_Turma.TabIndex = 10;
            lbl_Turma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextTurma
            // 
            lbl_TextTurma.AutoSize = true;
            lbl_TextTurma.BackColor = Color.Transparent;
            lbl_TextTurma.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_TextTurma.Location = new Point(169, 124);
            lbl_TextTurma.Name = "lbl_TextTurma";
            lbl_TextTurma.Size = new Size(49, 17);
            lbl_TextTurma.TabIndex = 9;
            lbl_TextTurma.Text = "Turma:";
            lbl_TextTurma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Codigo.Location = new Point(13, 189);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(0, 21);
            lbl_Codigo.TabIndex = 8;
            lbl_Codigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextCodigo
            // 
            lbl_TextCodigo.AutoSize = true;
            lbl_TextCodigo.BackColor = Color.Transparent;
            lbl_TextCodigo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_TextCodigo.Location = new Point(13, 172);
            lbl_TextCodigo.Name = "lbl_TextCodigo";
            lbl_TextCodigo.Size = new Size(54, 17);
            lbl_TextCodigo.TabIndex = 7;
            lbl_TextCodigo.Text = "Código:";
            lbl_TextCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Sexo
            // 
            lbl_Sexo.AutoSize = true;
            lbl_Sexo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Sexo.Location = new Point(402, 86);
            lbl_Sexo.Name = "lbl_Sexo";
            lbl_Sexo.Size = new Size(0, 21);
            lbl_Sexo.TabIndex = 6;
            lbl_Sexo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextSexo
            // 
            lbl_TextSexo.AutoSize = true;
            lbl_TextSexo.BackColor = Color.Transparent;
            lbl_TextSexo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_TextSexo.Location = new Point(402, 69);
            lbl_TextSexo.Name = "lbl_TextSexo";
            lbl_TextSexo.Size = new Size(40, 17);
            lbl_TextSexo.TabIndex = 5;
            lbl_TextSexo.Text = "Sexo:";
            lbl_TextSexo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_DataNasc
            // 
            lbl_DataNasc.AutoSize = true;
            lbl_DataNasc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_DataNasc.Location = new Point(169, 86);
            lbl_DataNasc.Name = "lbl_DataNasc";
            lbl_DataNasc.Size = new Size(0, 21);
            lbl_DataNasc.TabIndex = 4;
            lbl_DataNasc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextDataNasc
            // 
            lbl_TextDataNasc.AutoSize = true;
            lbl_TextDataNasc.BackColor = Color.Transparent;
            lbl_TextDataNasc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_TextDataNasc.Location = new Point(169, 69);
            lbl_TextDataNasc.Name = "lbl_TextDataNasc";
            lbl_TextDataNasc.Size = new Size(134, 17);
            lbl_TextDataNasc.TabIndex = 3;
            lbl_TextDataNasc.Text = "Data de Nascimento:";
            lbl_TextDataNasc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Nome.Location = new Point(169, 30);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(0, 21);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextNome
            // 
            lbl_TextNome.AutoSize = true;
            lbl_TextNome.BackColor = Color.Transparent;
            lbl_TextNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_TextNome.Location = new Point(169, 13);
            lbl_TextNome.Name = "lbl_TextNome";
            lbl_TextNome.Size = new Size(48, 17);
            lbl_TextNome.TabIndex = 1;
            lbl_TextNome.Text = "Nome:";
            lbl_TextNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb_FotoPerfil
            // 
            pb_FotoPerfil.BackColor = Color.White;
            pb_FotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            pb_FotoPerfil.Location = new Point(13, 13);
            pb_FotoPerfil.Name = "pb_FotoPerfil";
            pb_FotoPerfil.Size = new Size(150, 150);
            pb_FotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pb_FotoPerfil.TabIndex = 0;
            pb_FotoPerfil.TabStop = false;
            // 
            // pb_FundoCarteirinha
            // 
            pb_FundoCarteirinha.Dock = DockStyle.Fill;
            pb_FundoCarteirinha.Location = new Point(0, 0);
            pb_FundoCarteirinha.Name = "pb_FundoCarteirinha";
            pb_FundoCarteirinha.Size = new Size(548, 228);
            pb_FundoCarteirinha.TabIndex = 14;
            pb_FundoCarteirinha.TabStop = false;
            // 
            // cb_Tipo
            // 
            cb_Tipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Tipo.Font = new Font("Segoe UI", 9.75F);
            cb_Tipo.FormattingEnabled = true;
            cb_Tipo.Items.AddRange(new object[] { "Aluno", "Professor" });
            cb_Tipo.Location = new Point(443, 29);
            cb_Tipo.Name = "cb_Tipo";
            cb_Tipo.Size = new Size(119, 25);
            cb_Tipo.TabIndex = 18;
            // 
            // mtb_CpfBuscar
            // 
            mtb_CpfBuscar.Culture = new System.Globalization.CultureInfo("");
            mtb_CpfBuscar.Font = new Font("Segoe UI", 9.75F);
            mtb_CpfBuscar.Location = new Point(12, 29);
            mtb_CpfBuscar.Mask = "000.000.000-00";
            mtb_CpfBuscar.Name = "mtb_CpfBuscar";
            mtb_CpfBuscar.Size = new Size(400, 25);
            mtb_CpfBuscar.TabIndex = 19;
            // 
            // F_Carteirinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(574, 302);
            Controls.Add(mtb_CpfBuscar);
            Controls.Add(cb_Tipo);
            Controls.Add(panel_Fundo);
            Controls.Add(btn_Buscar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Carteirinha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carteirinha";
            FormClosing += F_Carteirinha_FormClosing;
            Load += F_Carteirinha_Load;
            panel_Fundo.ResumeLayout(false);
            panel_Fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QrCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_FotoPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_FundoCarteirinha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_Buscar;
        private Panel panel_Fundo;
        private ComboBox cb_Tipo;
        private MaskedTextBox mtb_CpfBuscar;
        private PictureBox pb_FotoPerfil;
        private Label lbl_TextNome;
        private Label lbl_Nome;
        private Label lbl_TextDataNasc;
        private Label lbl_DataNasc;
        private Label lbl_Sexo;
        private Label lbl_TextSexo;
        private Label lbl_Codigo;
        private Label lbl_TextCodigo;
        private Label lbl_Turma;
        private Label lbl_TextTurma;
        private Label lbl_Serie;
        private Label lbl_TextSerie;
        private PictureBox pb_QrCode;
        private PictureBox pb_FundoCarteirinha;
    }
}