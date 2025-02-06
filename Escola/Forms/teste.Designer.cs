namespace Escola.Forms
{
    partial class teste
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
            buttonig1 = new CustomControls.Botoes.ButtonIG();
            SuspendLayout();
            // 
            // buttonig1
            // 
            buttonig1.BackColor = Color.MediumSlateBlue;
            buttonig1.BackgroundColor = Color.MediumSlateBlue;
            buttonig1.BorderColor = Color.PaleVioletRed;
            buttonig1.BorderRadius = 0;
            buttonig1.BorderSize = 0;
            buttonig1.FlatAppearance.BorderSize = 0;
            buttonig1.FlatStyle = FlatStyle.Flat;
            buttonig1.ForeColor = Color.White;
            buttonig1.HoverBackgroundColor = Color.LightBlue;
            buttonig1.Location = new Point(373, 49);
            buttonig1.Name = "buttonig1";
            buttonig1.Size = new Size(150, 40);
            buttonig1.TabIndex = 0;
            buttonig1.Text = "buttonig1";
            buttonig1.TextColor = Color.White;
            buttonig1.UseVisualStyleBackColor = false;
            // 
            // teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonig1);
            Name = "teste";
            Text = "teste";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.Botoes.ButtonIG buttonig1;
    }
}