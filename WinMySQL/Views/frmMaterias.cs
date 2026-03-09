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
    public partial class frmMaterias : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        int id = 0;
        public frmMaterias()
        {
            InitializeComponent();
        }



        private void frmMaterias_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMateria frmMateria = new frmMateria();
            frmMateria.ShowDialog();
        }

        private void frmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {

                ds = datos.ejecutar("SELECT * from Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            { }
        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmMateria Materia = new frmMateria(
                Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
                dgvMaterias.CurrentRow.Cells[1].Value.ToString(),

                dgvMaterias.CurrentRow.Cells[3].Value.ToString(),
                Convert.ToInt32(dgvMaterias.CurrentRow.Cells[2].Value)
                );
            Materia.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("¿Desea eliminar la materia"+ dgvMaterias.CurrentRow.Cells[1].Value.ToString()+ " ?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"DELETE FROM Materias WHERE idMaterias={idMateria}");
                if (f)
                {
                    MessageBox.Show("Materia eliminada correctamente","Sistema");
                  
                }
                else
                {
                    MessageBox.Show("Error al eliminar la materia");
                }
            }
        }
    }
}
