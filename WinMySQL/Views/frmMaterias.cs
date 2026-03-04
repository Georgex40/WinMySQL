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
    }
}
