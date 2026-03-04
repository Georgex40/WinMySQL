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
    public partial class frmMateria : Form
    {
        Datos dt = new Datos();
        int id = 0;
        bool updating = false;
        public frmMateria()
        {
            InitializeComponent();
        }
        public frmMateria(int id, string materia, string cveOficial, int creditos)
        {
            InitializeComponent();
            this.id = id;
            txtMateria.Text = materia;
            txtCveOficial.Text = cveOficial;
            txtCreditos.Text = creditos.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Materias (Materias,cveoficial,Creditos)" +
                    $"values ('{txtMateria.Text}','{txtCveOficial.Text}','{txtCreditos.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la materia");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Materias set Materias='{txtMateria.Text}',cveoficial='{txtCveOficial.Text}',Creditos='{txtCreditos.Text}' " +
                    $"where id={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }
        }
    }
}
