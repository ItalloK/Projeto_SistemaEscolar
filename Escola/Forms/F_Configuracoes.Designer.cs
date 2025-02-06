namespace Escola
{
    partial class F_Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Configuracoes));
            label1 = new Label();
            tb_NomeEscola = new TextBox();
            label2 = new Label();
            btn_ConfirmAlteracoes = new CustomControls.Botoes.ButtonIG();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 8);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Configurações:";
            // 
            // tb_NomeEscola
            // 
            tb_NomeEscola.Font = new Font("Segoe UI", 9.75F);
            tb_NomeEscola.Location = new Point(12, 65);
            tb_NomeEscola.Name = "tb_NomeEscola";
            tb_NomeEscola.Size = new Size(434, 25);
            tb_NomeEscola.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome da Escola:";
            // 
            // btn_ConfirmAlteracoes
            // 
            btn_ConfirmAlteracoes.BackColor = Color.Gray;
            btn_ConfirmAlteracoes.BackgroundColor = Color.Gray;
            btn_ConfirmAlteracoes.BorderColor = Color.PaleVioletRed;
            btn_ConfirmAlteracoes.BorderRadius = 5;
            btn_ConfirmAlteracoes.BorderSize = 0;
            btn_ConfirmAlteracoes.FlatAppearance.BorderSize = 0;
            btn_ConfirmAlteracoes.FlatStyle = FlatStyle.Flat;
            btn_ConfirmAlteracoes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ConfirmAlteracoes.ForeColor = Color.White;
            btn_ConfirmAlteracoes.HoverBackgroundColor = Color.Black;
            btn_ConfirmAlteracoes.Location = new Point(12, 325);
            btn_ConfirmAlteracoes.Name = "btn_ConfirmAlteracoes";
            btn_ConfirmAlteracoes.Size = new Size(434, 40);
            btn_ConfirmAlteracoes.TabIndex = 3;
            btn_ConfirmAlteracoes.Text = "Confirmar Configurações";
            btn_ConfirmAlteracoes.TextColor = Color.White;
            btn_ConfirmAlteracoes.UseVisualStyleBackColor = false;
            btn_ConfirmAlteracoes.Click += btn_ConfirmAlteracoes_Click;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 377);
            Controls.Add(btn_ConfirmAlteracoes);
            Controls.Add(label2);
            Controls.Add(tb_NomeEscola);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Configuracoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_NomeEscola;
        private Label label2;
        private CustomControls.Botoes.ButtonIG btn_ConfirmAlteracoes;
    }
}