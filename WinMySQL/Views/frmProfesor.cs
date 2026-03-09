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
   
    public partial class frmProfesor : Form
    {
        Datos dt = new Datos();
        bool updating = false;
        public frmProfesor()
        {
            InitializeComponent();
        }
        public frmProfesor(string cve, string nombre, string appat, string apmat, string telefono)
        {
            InitializeComponent();
            txtCvePro.Text = cve;
            txtNombre.Text = nombre;
            txtAppat.Text = appat;
            txtApmat.Text = apmat;
            txtTelefono.Text = telefono;
            updating = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Profesores (Cve_Profesor,Nombre,ApPat,ApMat,Telefono)" +
                    $"values ('{txtCvePro.Text}','{txtNombre.Text}','{txtAppat.Text}','{txtApmat.Text}','{txtTelefono.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Profesor Registrado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al Registrar Profesor");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Profesores set Nombre='{txtNombre.Text}',ApPat='{txtAppat.Text}',ApMat='{txtApmat.Text}',Telefono='{txtTelefono.Text}' " +
                    $"where Cve_Profesor={txtCvePro.Text}");
                if (resultado)
                {
                    MessageBox.Show("Informacion del Profesor Actualizada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al Profesor");
                }
            }
        }
    }
}
