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
    public partial class frmAlumno : Form
    {
        Datos dt = new Datos();
        bool updating = false;
        public frmAlumno()
        {
            InitializeComponent();
        }
        
        public frmAlumno(string noCtrl, string nombre, string apPaterno, string apMaterno, string telefono)
        {
            InitializeComponent();
            txtNoCtrl.Text = noCtrl;
            txtNombre.Text = nombre;
            txtAppat.Text = apPaterno;
            txtApmat.Text = apMaterno;
            txtTelefono.Text= telefono;
            updating = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Alumnos (No_Control,Nombre,ApPat,ApMat,Telefono)" +
                    $"values ('{txtNoCtrl.Text}','{txtNombre.Text}','{txtAppat.Text}','{txtApmat.Text}','{txtTelefono.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Alumno Registrado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al Registrar Alumno");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Alumnos set Nombre='{txtNombre.Text}',ApPat='{txtAppat.Text}',ApMat='{txtApmat.Text}',Telefono='{txtTelefono.Text}' " +
                    $"where No_Control={txtNoCtrl.Text}");
                if (resultado)
                {
                    MessageBox.Show("Informacion del alumno Actualizada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al Alumno");
                }
            }
        }
    }
    }

