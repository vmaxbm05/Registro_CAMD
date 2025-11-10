using MySql.Data.MySqlClient;
using System;
using System.IO;
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
    public partial class SubFrmAjustes : Form
    {
        public SubFrmAjustes()
        {
            InitializeComponent();
        }

        private void btn_subirImagen_Click(object sender, EventArgs e)
        {
            // 🔹 Asumimos que tienes un TextBox con el nombre del evento (txt_nombreEvento)
            string nombreEvento = txt_nombreEvento.Text.Trim();

            if (string.IsNullOrEmpty(nombreEvento))
            {
                MessageBox.Show("Por favor, ingresa o selecciona un evento antes de subir una imagen.");
                return;
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string origen = dialog.FileName;
                string carpetaDestino = Path.Combine(Application.StartupPath, "Imagenes");

                // Crear carpeta si no existe
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                // 🔹 Nombre del archivo: nombre del evento + fecha
                string nombreLimpioEvento = string.Concat(nombreEvento.Split(Path.GetInvalidFileNameChars()));
                string nombreArchivo = nombreLimpioEvento + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + Path.GetExtension(origen);

                string destino = Path.Combine(carpetaDestino, nombreArchivo);

                // Copiar imagen
                File.Copy(origen, destino, true);

                // Mostrar imagen en el PictureBox
                picb_preview.Image = Image.FromFile(destino);
                picb_preview.Tag = nombreArchivo;

                // 🔹 Guardar la ruta en la base de datos
                GuardarRutaImagenEnBD(nombreEvento, nombreArchivo);
            }
        }

        private void GuardarRutaImagenEnBD(string nombreEvento, string nombreArchivo)
        {
            string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // 🔹 Buscar el ID del evento según su nombre
                string querySelect = "SELECT id_evento FROM Evento WHERE nombre = @nombre";
                MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn);
                cmdSelect.Parameters.AddWithValue("@nombre", nombreEvento);

                object result = cmdSelect.ExecuteScalar();

                if (result != null)
                {
                    int idEvento = Convert.ToInt32(result);

                    // 🔹 Actualizar la dirección de imagen
                    string queryUpdate = "UPDATE Evento SET direccion_img = @img WHERE id_evento = @id";
                    MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@img", nombreArchivo);
                    cmdUpdate.Parameters.AddWithValue("@id", idEvento);
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Imagen subida y registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un evento con ese nombre.");
                }
            }
        }

        private void CargarFacultades()
        {
            string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_facultad, nombre FROM Facultad";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cmb_facultad.DataSource = dt;
                cmb_facultad.DisplayMember = "nombre";
                cmb_facultad.ValueMember = "id_facultad";
                cmb_facultad.SelectedIndex = -1;
            }
        }

        private void CargarTiposDeEvento()
        {
            string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // 🔹 Trae todos los tipos distintos y no nulos
                string query = "SELECT DISTINCT tipo_evento FROM Evento WHERE tipo_evento IS NOT NULL ORDER BY tipo_evento ASC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmb_evento.Items.Clear();
                while (reader.Read())
                {
                    cmb_evento.Items.Add(reader.GetString("tipo_evento"));
                }

                // 🔹 Agregamos manualmente la opción "Otros"
                cmb_evento.Items.Add("Otros");
            }

            // Por defecto ocultamos el campo "Otro"
            txt_otro_evento.Visible = false;
        }

        private void SubFrmAjustes_Load(object sender, EventArgs e)
        {
            CargarFacultades();
            CargarTiposDeEvento();
        }

        private void btn_guardarEvento_Click(object sender, EventArgs e)
        {
            RegistrarEvento();
        }

        private void RegistrarEvento()
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txt_nombreEvento.Text) ||
                string.IsNullOrWhiteSpace(txt_Descripcion.Text))
            {
                MessageBox.Show("Debe ingresar el nombre y la descripción del evento.");
                return;
            }

            string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Evento 
                        (nombre, descripcion, fecha_inicio, fecha_fin, tipo_evento, id_facultad, direccion_img)
                        VALUES (@nombre, @descripcion, @fecha_inicio, @fecha_fin, @tipo_evento, @id_facultad, @direccion_img)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", txt_nombreEvento.Text.Trim());
                    cmd.Parameters.AddWithValue("@descripcion", txt_Descripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@fecha_inicio", dateTime_Inicio.Value);
                    cmd.Parameters.AddWithValue("@fecha_fin", dateTime_Fin.Value);

                    string tipoEventoSeleccionado = "";

                    if (cmb_evento.SelectedItem != null)
                    {
                        if (cmb_evento.SelectedItem.ToString() == "Otros")
                        {
                            if (string.IsNullOrWhiteSpace(txt_otro_evento.Text))
                            {
                                MessageBox.Show("Debe ingresar un nombre para el nuevo tipo de evento.");
                                return;
                            }

                            tipoEventoSeleccionado = txt_otro_evento.Text.Trim();

                            // 🔹 Insertar este tipo nuevo si no existe ya en la base de datos
                            AgregarNuevoTipoEvento(tipoEventoSeleccionado);
                        }
                        else
                        {
                            tipoEventoSeleccionado = cmb_evento.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        tipoEventoSeleccionado = null;
                    }

                    cmd.Parameters.AddWithValue("@tipo_evento", tipoEventoSeleccionado);

                    if (cmb_facultad.SelectedValue != null)
                        cmd.Parameters.AddWithValue("@id_facultad", cmb_facultad.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@id_facultad", DBNull.Value);

                    // Si aún no hay imagen cargada, va NULL
                    if (picb_preview.Tag != null)
                        cmd.Parameters.AddWithValue("@direccion_img", picb_preview.Tag.ToString());
                    else
                        cmd.Parameters.AddWithValue("@direccion_img", DBNull.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Evento registrado correctamente.");
            }
        }

        private void AgregarNuevoTipoEvento(string nuevoTipo)
        {
            string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Verificar si ya existe
                string queryCheck = "SELECT COUNT(*) FROM Evento WHERE tipo_evento = @tipo";
                MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@tipo", nuevoTipo);

                long existe = (long)cmdCheck.ExecuteScalar();
                if (existe == 0)
                {
                    // No existe → insertar un registro "temporal" vacío con ese tipo
                    string queryInsert = "INSERT INTO Evento (nombre, descripcion, fecha_inicio, tipo_evento) VALUES ('Tipo temporal', 'Auto-generado', NOW(), @tipo)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@tipo", nuevoTipo);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }

        private void cmb_evento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_evento.SelectedItem != null && cmb_evento.SelectedItem.ToString() == "Otros")
            {
                txt_otro_evento.Visible = true;
                txt_otro_evento.Focus();
            }
            else
            {
                txt_otro_evento.Visible = false;
                txt_otro_evento.Clear();
            }
        }
    }
}
