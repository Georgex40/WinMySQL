using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmProfesores : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmProfesores()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProfesor profesor = new frmProfesor();
            profesor.ShowDialog();
        }

        private void frmProfesores_Activated(object sender, EventArgs e)
        {
            try
            {

                ds = datos.ejecutar("SELECT * from Profesores");
                if (ds != null)
                {
                    dgvProfesor.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            { }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string No_Control = dgvProfesor.CurrentRow.Cells[0].Value.ToString();
            string nombre = dgvProfesor.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el Registro del Profesor con el numero de control: " + No_Control + " ?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"DELETE FROM Profesores WHERE nombre='{nombre}'");
                if (f)
                {
                    MessageBox.Show("Registro del Profesor Eliminado Correctamente", "Sistema");

                }
                else
                {
                    MessageBox.Show("Error al eliminar el Registro", "Sistema");
                }
            }
        }

        private void dgvProfesor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProfesor Profesor = new frmProfesor(
      dgvProfesor.CurrentRow.Cells[0].Value.ToString(),
      dgvProfesor.CurrentRow.Cells[1].Value.ToString(),
      dgvProfesor.CurrentRow.Cells[2].Value.ToString(),
     dgvProfesor.CurrentRow.Cells[3].Value.ToString(),
         dgvProfesor.CurrentRow.Cells[4].Value.ToString()
      );
            Profesor.ShowDialog();
        }
    }
}
