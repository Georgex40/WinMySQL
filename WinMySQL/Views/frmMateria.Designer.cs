namespace WinMySQL.Views
{
    partial class frmMateria
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
            label1 = new Label();
            label2 = new Label();
            txtMateria = new TextBox();
            txtCveOficial = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "CVE Oficial";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(36, 43);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(288, 23);
            txtMateria.TabIndex = 2;
            // 
            // txtCveOficial
            // 
            txtCveOficial.Location = new Point(36, 100);
            txtCveOficial.Name = "txtCveOficial";
            txtCveOficial.Size = new Size(149, 23);
            txtCveOficial.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(218, 89);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(106, 43);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 171);
            Controls.Add(btnAceptar);
            Controls.Add(txtCveOficial);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMateria";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMateria;
        private TextBox txtCveOficial;
        private Button btnAceptar;
    }
}