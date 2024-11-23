namespace Escola
{
    partial class GerenciarProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarProfessores));
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            buttonig1 = new CustomControls.Botoes.ButtonIG();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            buttonig2 = new CustomControls.Botoes.ButtonIG();
            buttonig3 = new CustomControls.Botoes.ButtonIG();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(buttonig1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(795, 32);
            tableLayoutPanel1.TabIndex = 3;
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
            // buttonig1
            // 
            buttonig1.BackColor = Color.Gray;
            buttonig1.BackgroundColor = Color.Gray;
            buttonig1.BorderColor = Color.PaleVioletRed;
            buttonig1.BorderRadius = 5;
            buttonig1.BorderSize = 0;
            buttonig1.Dock = DockStyle.Fill;
            buttonig1.FlatAppearance.BorderSize = 0;
            buttonig1.FlatStyle = FlatStyle.Flat;
            buttonig1.Font = new Font("Segoe UI", 9.75F);
            buttonig1.ForeColor = Color.White;
            buttonig1.HoverBackgroundColor = Color.Black;
            buttonig1.Location = new Point(321, 3);
            buttonig1.Name = "buttonig1";
            buttonig1.Size = new Size(153, 26);
            buttonig1.TabIndex = 1;
            buttonig1.Text = "Cadastrar Professor";
            buttonig1.TextColor = Color.White;
            buttonig1.UseVisualStyleBackColor = false;
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
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 4;
            label1.Text = "Gerenciar Professores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // GerenciarProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "GerenciarProfessores";
            Text = "Gerenciar Professores";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private CustomControls.Botoes.ButtonIG buttonig1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private CustomControls.Botoes.ButtonIG buttonig3;
        private CustomControls.Botoes.ButtonIG buttonig2;
    }
}