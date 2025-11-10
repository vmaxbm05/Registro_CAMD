using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyRegistroAsistencia
{
    public partial class SubFrmInicio : Form
    {
        public SubFrmInicio()
        {
            InitializeComponent();
        }

        private int ObtenerCantidadAsistentes()
        {
            int cantidad = 0;

            string connectionString = "server=localhost;database=AsistenciaUniversitaria;uid=root;pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Asistencia";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return cantidad;
        }

        private void ActualizarContadorAsistentes()
        {
            int total = ObtenerCantidadAsistentes();
            lbl_contador.Text = $"Asistentes registrados: {total}";
        }

        private void SubFrmInicio_Load(object sender, EventArgs e)
        {
            ActualizarContadorAsistentes();
        }
    }
}
