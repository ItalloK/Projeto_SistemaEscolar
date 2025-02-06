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
            panel1 = new Panel();
            lbl_Serie = new Label();
            lbl_TextSerie = new Label();
            lbl_Turma = new Label();
            lbl_TextTurma = new Label();
            lbl_Codigo = new Label();
            label9 = new Label();
            lbl_Sexo = new Label();
            label7 = new Label();
            lbl_DataNasc = new Label();
            label4 = new Label();
            lbl_Nome = new Label();
            label2 = new Label();
            pb_FotoPerfil = new PictureBox();
            cb_Tipo = new ComboBox();
            mtb_CpfBuscar = new MaskedTextBox();
            pb_QrCode = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FotoPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_QrCode).BeginInit();
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pb_QrCode);
            panel1.Controls.Add(lbl_Serie);
            panel1.Controls.Add(lbl_TextSerie);
            panel1.Controls.Add(lbl_Turma);
            panel1.Controls.Add(lbl_TextTurma);
            panel1.Controls.Add(lbl_Codigo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lbl_Sexo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lbl_DataNasc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbl_Nome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pb_FotoPerfil);
            panel1.Location = new Point(12, 63);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 230);
            panel1.TabIndex = 16;
            // 
            // lbl_Serie
            // 
            lbl_Serie.AutoSize = true;
            lbl_Serie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Serie.Location = new Point(402, 141);
            lbl_Serie.Name = "lbl_Serie";
            lbl_Serie.Size = new Size(65, 21);
            lbl_Serie.TabIndex = 12;
            lbl_Serie.Text = "8º ANO";
            lbl_Serie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextSerie
            // 
            lbl_TextSerie.AutoSize = true;
            lbl_TextSerie.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lbl_Turma.Size = new Size(33, 21);
            lbl_Turma.TabIndex = 10;
            lbl_Turma.Text = "101";
            lbl_Turma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextTurma
            // 
            lbl_TextTurma.AutoSize = true;
            lbl_TextTurma.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TextTurma.Location = new Point(169, 124);
            lbl_TextTurma.Name = "lbl_TextTurma";
            lbl_TextTurma.Size = new Size(48, 17);
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
            lbl_Codigo.Size = new Size(64, 21);
            lbl_Codigo.TabIndex = 8;
            lbl_Codigo.Text = "000000";
            lbl_Codigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 172);
            label9.Name = "label9";
            label9.Size = new Size(54, 17);
            label9.TabIndex = 7;
            label9.Text = "Código:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Sexo
            // 
            lbl_Sexo.AutoSize = true;
            lbl_Sexo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Sexo.Location = new Point(402, 86);
            lbl_Sexo.Name = "lbl_Sexo";
            lbl_Sexo.Size = new Size(86, 21);
            lbl_Sexo.TabIndex = 6;
            lbl_Sexo.Text = "FEMININO";
            lbl_Sexo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(402, 69);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 5;
            label7.Text = "Sexo:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_DataNasc
            // 
            lbl_DataNasc.AutoSize = true;
            lbl_DataNasc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_DataNasc.Location = new Point(169, 86);
            lbl_DataNasc.Name = "lbl_DataNasc";
            lbl_DataNasc.Size = new Size(96, 21);
            lbl_DataNasc.TabIndex = 4;
            lbl_DataNasc.Text = "00/00/0000";
            lbl_DataNasc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 69);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Nome.Location = new Point(169, 30);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(144, 21);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "NOME DA PESSOA";
            lbl_Nome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 13);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            mtb_CpfBuscar.Font = new Font("Segoe UI", 9.75F);
            mtb_CpfBuscar.Location = new Point(12, 29);
            mtb_CpfBuscar.Mask = "000.000.000-00";
            mtb_CpfBuscar.Name = "mtb_CpfBuscar";
            mtb_CpfBuscar.Size = new Size(400, 25);
            mtb_CpfBuscar.TabIndex = 19;
            // 
            // pb_QrCode
            // 
            pb_QrCode.BackColor = Color.White;
            pb_QrCode.Location = new Point(495, 176);
            pb_QrCode.Name = "pb_QrCode";
            pb_QrCode.Size = new Size(50, 50);
            pb_QrCode.SizeMode = PictureBoxSizeMode.Zoom;
            pb_QrCode.TabIndex = 13;
            pb_QrCode.TabStop = false;
            // 
            // F_Carteirinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(574, 302);
            Controls.Add(mtb_CpfBuscar);
            Controls.Add(cb_Tipo);
            Controls.Add(panel1);
            Controls.Add(btn_Buscar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Carteirinha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carteirinha";
            Load += F_Carteirinha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FotoPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_QrCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_Buscar;
        private Panel panel1;
        private ComboBox cb_Tipo;
        private MaskedTextBox mtb_CpfBuscar;
        private PictureBox pb_FotoPerfil;
        private Label label2;
        private Label lbl_Nome;
        private Label label4;
        private Label lbl_DataNasc;
        private Label lbl_Sexo;
        private Label label7;
        private Label lbl_Codigo;
        private Label label9;
        private Label lbl_Turma;
        private Label lbl_TextTurma;
        private Label lbl_Serie;
        private Label lbl_TextSerie;
        private PictureBox pb_QrCode;
    }
}