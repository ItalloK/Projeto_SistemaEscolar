namespace Escola.Forms
{
    partial class F_Matricular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Matricular));
            label1 = new Label();
            mtb_CpfBuscar = new MaskedTextBox();
            btn_Buscar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_NomeAluno = new Label();
            lbl_DataNascAluno = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_SexoAluno = new Label();
            label5 = new Label();
            lbl_Turma = new Label();
            label9 = new Label();
            lbl_Serie = new Label();
            label11 = new Label();
            lbl_Turno = new Label();
            label13 = new Label();
            lbl_Tipo = new Label();
            label15 = new Label();
            lbl_QntAlunos = new Label();
            label6 = new Label();
            lbl_MaxAlunos = new Label();
            label14 = new Label();
            btn_Cancelar = new CustomControls.Botoes.ButtonIG();
            btn_Matricular = new CustomControls.Botoes.ButtonIG();
            cb_Turmas = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Matricular Aluno:";
            // 
            // mtb_CpfBuscar
            // 
            mtb_CpfBuscar.Culture = new System.Globalization.CultureInfo("");
            mtb_CpfBuscar.Font = new Font("Segoe UI", 9.75F);
            mtb_CpfBuscar.Location = new Point(12, 65);
            mtb_CpfBuscar.Mask = "000.000.000-00";
            mtb_CpfBuscar.Name = "mtb_CpfBuscar";
            mtb_CpfBuscar.Size = new Size(403, 25);
            mtb_CpfBuscar.TabIndex = 22;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Buscar.BackgroundImage = Properties.Resources.lupa;
            btn_Buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Buscar.Location = new Point(418, 65);
            btn_Buscar.Margin = new Padding(0);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(25, 25);
            btn_Buscar.TabIndex = 21;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 20;
            label2.Text = "Digite o CPF do Aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 23;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 24;
            label4.Text = "Dados do Aluno:";
            // 
            // lbl_NomeAluno
            // 
            lbl_NomeAluno.AutoSize = true;
            lbl_NomeAluno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_NomeAluno.Location = new Point(62, 130);
            lbl_NomeAluno.Name = "lbl_NomeAluno";
            lbl_NomeAluno.Size = new Size(127, 19);
            lbl_NomeAluno.TabIndex = 25;
            lbl_NomeAluno.Text = "NOME DO ALUNO";
            // 
            // lbl_DataNascAluno
            // 
            lbl_DataNascAluno.AutoSize = true;
            lbl_DataNascAluno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_DataNascAluno.Location = new Point(155, 158);
            lbl_DataNascAluno.Name = "lbl_DataNascAluno";
            lbl_DataNascAluno.Size = new Size(85, 19);
            lbl_DataNascAluno.TabIndex = 27;
            lbl_DataNascAluno.Text = "00/00/0000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(12, 156);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 26;
            label7.Text = "Data de Nascimento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(289, 156);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 28;
            label8.Text = "Sexo:";
            // 
            // lbl_SexoAluno
            // 
            lbl_SexoAluno.AutoSize = true;
            lbl_SexoAluno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_SexoAluno.Location = new Point(328, 158);
            lbl_SexoAluno.Name = "lbl_SexoAluno";
            lbl_SexoAluno.Size = new Size(76, 19);
            lbl_SexoAluno.TabIndex = 29;
            lbl_SexoAluno.Text = "FEMININO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 30;
            label5.Text = "Dados da Turma:";
            // 
            // lbl_Turma
            // 
            lbl_Turma.AutoSize = true;
            lbl_Turma.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_Turma.Location = new Point(62, 253);
            lbl_Turma.Name = "lbl_Turma";
            lbl_Turma.Size = new Size(57, 19);
            lbl_Turma.TabIndex = 32;
            lbl_Turma.Text = "TURMA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(12, 251);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 31;
            label9.Text = "Turma:";
            // 
            // lbl_Serie
            // 
            lbl_Serie.AutoSize = true;
            lbl_Serie.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_Serie.Location = new Point(329, 253);
            lbl_Serie.Name = "lbl_Serie";
            lbl_Serie.Size = new Size(58, 19);
            lbl_Serie.TabIndex = 34;
            lbl_Serie.Text = "8º ANO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(289, 251);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 33;
            label11.Text = "Serie:";
            // 
            // lbl_Turno
            // 
            lbl_Turno.AutoSize = true;
            lbl_Turno.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_Turno.Location = new Point(59, 284);
            lbl_Turno.Name = "lbl_Turno";
            lbl_Turno.Size = new Size(82, 19);
            lbl_Turno.TabIndex = 36;
            lbl_Turno.Text = "MATUTINO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(12, 283);
            label13.Name = "label13";
            label13.Size = new Size(50, 20);
            label13.TabIndex = 35;
            label13.Text = "Turno:";
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_Tipo.Location = new Point(328, 284);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(110, 19);
            lbl_Tipo.TabIndex = 38;
            lbl_Tipo.Text = "FUNDAMENTAL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F);
            label15.Location = new Point(289, 282);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 37;
            label15.Text = "Tipo:";
            // 
            // lbl_QntAlunos
            // 
            lbl_QntAlunos.AutoSize = true;
            lbl_QntAlunos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_QntAlunos.Location = new Point(92, 319);
            lbl_QntAlunos.Name = "lbl_QntAlunos";
            lbl_QntAlunos.Size = new Size(24, 19);
            lbl_QntAlunos.TabIndex = 40;
            lbl_QntAlunos.Text = "20";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(12, 317);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 39;
            label6.Text = "Qnt Alunos:";
            // 
            // lbl_MaxAlunos
            // 
            lbl_MaxAlunos.AutoSize = true;
            lbl_MaxAlunos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_MaxAlunos.Location = new Point(373, 319);
            lbl_MaxAlunos.Name = "lbl_MaxAlunos";
            lbl_MaxAlunos.Size = new Size(24, 19);
            lbl_MaxAlunos.TabIndex = 42;
            lbl_MaxAlunos.Text = "50";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(289, 317);
            label14.Name = "label14";
            label14.Size = new Size(89, 20);
            label14.TabIndex = 41;
            label14.Text = "Max Alunos:";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Gray;
            btn_Cancelar.BackgroundColor = Color.Gray;
            btn_Cancelar.BorderColor = Color.PaleVioletRed;
            btn_Cancelar.BorderRadius = 5;
            btn_Cancelar.BorderSize = 0;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.HoverBackgroundColor = Color.Black;
            btn_Cancelar.Location = new Point(12, 352);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(204, 40);
            btn_Cancelar.TabIndex = 43;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.TextColor = Color.White;
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_Matricular
            // 
            btn_Matricular.BackColor = Color.Gray;
            btn_Matricular.BackgroundColor = Color.Gray;
            btn_Matricular.BorderColor = Color.PaleVioletRed;
            btn_Matricular.BorderRadius = 5;
            btn_Matricular.BorderSize = 0;
            btn_Matricular.FlatAppearance.BorderSize = 0;
            btn_Matricular.FlatStyle = FlatStyle.Flat;
            btn_Matricular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Matricular.ForeColor = Color.White;
            btn_Matricular.HoverBackgroundColor = Color.Black;
            btn_Matricular.Location = new Point(234, 352);
            btn_Matricular.Name = "btn_Matricular";
            btn_Matricular.Size = new Size(204, 40);
            btn_Matricular.TabIndex = 44;
            btn_Matricular.Text = "Matricular";
            btn_Matricular.TextColor = Color.White;
            btn_Matricular.UseVisualStyleBackColor = false;
            btn_Matricular.Click += btn_Matricular_Click;
            // 
            // cb_Turmas
            // 
            cb_Turmas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Turmas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Turmas.FormattingEnabled = true;
            cb_Turmas.Location = new Point(12, 195);
            cb_Turmas.Name = "cb_Turmas";
            cb_Turmas.Size = new Size(431, 25);
            cb_Turmas.TabIndex = 45;
            cb_Turmas.SelectedIndexChanged += cb_Turmas_SelectedIndexChanged;
            // 
            // F_Matricular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 404);
            Controls.Add(cb_Turmas);
            Controls.Add(btn_Matricular);
            Controls.Add(btn_Cancelar);
            Controls.Add(lbl_MaxAlunos);
            Controls.Add(label14);
            Controls.Add(lbl_QntAlunos);
            Controls.Add(label6);
            Controls.Add(lbl_Tipo);
            Controls.Add(label15);
            Controls.Add(lbl_Turno);
            Controls.Add(label13);
            Controls.Add(lbl_Serie);
            Controls.Add(label11);
            Controls.Add(lbl_Turma);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(lbl_SexoAluno);
            Controls.Add(label8);
            Controls.Add(lbl_DataNascAluno);
            Controls.Add(label7);
            Controls.Add(lbl_NomeAluno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mtb_CpfBuscar);
            Controls.Add(btn_Buscar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Matricular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matricular";
            Load += F_Matricular_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mtb_CpfBuscar;
        private Button btn_Buscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_NomeAluno;
        private Label lbl_DataNascAluno;
        private Label label7;
        private Label label8;
        private Label lbl_SexoAluno;
        private Label label5;
        private Label lbl_Turma;
        private Label label9;
        private Label lbl_Serie;
        private Label label11;
        private Label lbl_Turno;
        private Label label13;
        private Label lbl_Tipo;
        private Label label15;
        private Label lbl_QntAlunos;
        private Label label6;
        private Label lbl_MaxAlunos;
        private Label label14;
        private CustomControls.Botoes.ButtonIG btn_Cancelar;
        private CustomControls.Botoes.ButtonIG btn_Matricular;
        private ComboBox cb_Turmas;
    }
}