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
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void frmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {

                ds = datos.ejecutar("SELECT * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            { }
        }
        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

  
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string No_Control = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            string nombre = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el Registro del Alumno con el numero de control: " + No_Control + " ?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"DELETE FROM Alumnos WHERE nombre='{nombre}'");
                if (f)
                {
                    MessageBox.Show("Registro del Alumno Eliminado Correctamente", "Sistema");

                }
                else
                {
                    MessageBox.Show("Error al eliminar el Registro", "Sistema");
                }
            }
        }

        private void dgvAlumnos_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmAlumno alumno = new frmAlumno(
     dgvAlumnos.CurrentRow.Cells[0].Value.ToString(),
      dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
      dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
      dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
      dgvAlumnos.CurrentRow.Cells[4].Value.ToString()
      );
            alumno.ShowDialog();
        }
    }
}
