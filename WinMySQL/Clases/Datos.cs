using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        //Generar cadena de conexión
        string cadenaConexión="server=localhost;user=luis;pwd=joseluis";
        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexión);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Desconectar()
        {
            try
            {
                if(conexion!= null)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
