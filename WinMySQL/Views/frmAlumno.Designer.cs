namespace WinMySQL.Views
{
    partial class frmAlumno
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
            txtTelefono = new TextBox();
            txtAppat = new TextBox();
            txtNoCtrl = new TextBox();
            txtNombre = new TextBox();
            txtApmat = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(263, 166);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 1;
            label1.Text = "No_Control";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 2;
            label2.Text = "ApPat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(207, 14);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(207, 82);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 4;
            label4.Text = "ApMat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 142);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 5;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(24, 166);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(160, 29);
            txtTelefono.TabIndex = 6;
            // 
            // txtAppat
            // 
            txtAppat.Font = new Font("Segoe UI", 12F);
            txtAppat.Location = new Point(24, 106);
            txtAppat.Name = "txtAppat";
            txtAppat.Size = new Size(160, 29);
            txtAppat.TabIndex = 7;
            // 
            // txtNoCtrl
            // 
            txtNoCtrl.Font = new Font("Segoe UI", 12F);
            txtNoCtrl.Location = new Point(24, 38);
            txtNoCtrl.Name = "txtNoCtrl";
            txtNoCtrl.Size = new Size(160, 29);
            txtNoCtrl.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(207, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 29);
            txtNombre.TabIndex = 9;
            // 
            // txtApmat
            // 
            txtApmat.Font = new Font("Segoe UI", 12F);
            txtApmat.Location = new Point(207, 106);
            txtApmat.Name = "txtApmat";
            txtApmat.Size = new Size(168, 29);
            txtApmat.TabIndex = 10;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 236);
            Controls.Add(txtApmat);
            Controls.Add(txtNombre);
            Controls.Add(txtNoCtrl);
            Controls.Add(txtAppat);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "frmAlumno";
            Text = "Alumno";
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
        private TextBox txtTelefono;
        private TextBox txtAppat;
        private TextBox txtNoCtrl;
        private TextBox txtNombre;
        private TextBox txtApmat;
    }
}