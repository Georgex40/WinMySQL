namespace WinMySQL.Views
{
    partial class frmProfesor
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
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCvePro = new TextBox();
            txtNombre = new TextBox();
            txtAppat = new TextBox();
            txtApmat = new TextBox();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(316, 202);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 38);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(51, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "Cve_Profesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(280, 33);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(51, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 3;
            label3.Text = "Appat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(280, 106);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 4;
            label4.Text = "Apmat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(51, 182);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 5;
            label5.Text = "Telefono";
            // 
            // txtCvePro
            // 
            txtCvePro.Font = new Font("Segoe UI", 12F);
            txtCvePro.Location = new Point(51, 57);
            txtCvePro.Name = "txtCvePro";
            txtCvePro.Size = new Size(200, 29);
            txtCvePro.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(280, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtAppat
            // 
            txtAppat.Font = new Font("Segoe UI", 12F);
            txtAppat.Location = new Point(51, 130);
            txtAppat.Name = "txtAppat";
            txtAppat.Size = new Size(200, 29);
            txtAppat.TabIndex = 8;
            // 
            // txtApmat
            // 
            txtApmat.Font = new Font("Segoe UI", 12F);
            txtApmat.Location = new Point(280, 130);
            txtApmat.Name = "txtApmat";
            txtApmat.Size = new Size(211, 29);
            txtApmat.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(51, 206);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 29);
            txtTelefono.TabIndex = 10;
            // 
            // frmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 263);
            Controls.Add(txtTelefono);
            Controls.Add(txtApmat);
            Controls.Add(txtAppat);
            Controls.Add(txtNombre);
            Controls.Add(txtCvePro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "frmProfesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCvePro;
        private TextBox txtNombre;
        private TextBox txtAppat;
        private TextBox txtApmat;
        private TextBox txtTelefono;
    }
}