namespace WinMySQL.Views
{
    partial class frmProfesores
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnAgregar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dgvProfesor = new DataGridView();
            cmsProfesores = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).BeginInit();
            cmsProfesores.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProfesor);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(635, 53);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // dgvProfesor
            // 
            dgvProfesor.AllowUserToAddRows = false;
            dgvProfesor.AllowUserToDeleteRows = false;
            dgvProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesor.ContextMenuStrip = cmsProfesores;
            dgvProfesor.Dock = DockStyle.Fill;
            dgvProfesor.Location = new Point(0, 0);
            dgvProfesor.Name = "dgvProfesor";
            dgvProfesor.ReadOnly = true;
            dgvProfesor.Size = new Size(800, 346);
            dgvProfesor.TabIndex = 0;
            dgvProfesor.CellContentDoubleClick += dgvProfesor_CellContentDoubleClick;
            // 
            // cmsProfesores
            // 
            cmsProfesores.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsProfesores.Name = "cmsProfesores";
            cmsProfesores.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frmProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmProfesores";
            Text = "Profesores";
            Activated += frmProfesores_Activated;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesor).EndInit();
            cmsProfesores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregar;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dgvProfesor;
        private ContextMenuStrip cmsProfesores;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}