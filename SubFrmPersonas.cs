using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace pyRegistroAsistencia
{
    public partial class SubFrmPersonas : Form
    {
        string cadenaConexion = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";
        MySqlConnection conexion;
        public SubFrmPersonas()
        {
            InitializeComponent();
            conexion = new MySqlConnection(cadenaConexion);
        }

        private void SubFrmPersonas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO personas (dni, nombre, apellido, correo, telefono, tipo, programa) " +
                   "VALUES (@dni, @nombre, @apellido, @correo, @telefono, @tipo, @programa)";

            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dni", txtDNI.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@tipo", cbTipo.Text);
                cmd.Parameters.AddWithValue("@programa", cbPrograma.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Persona registrada correctamente");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
