using System.Runtime.InteropServices;

namespace pyRegistroAsistencia
{
    public partial class FrmPrincipal : Form
    {
        private string rolUsuario;

        public FrmPrincipal(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarPorRol();
        }

        private void ConfigurarPorRol()
        {
            if (rolUsuario == "Registrador")
            {
                btnCrearUsuario.Visible = false;
                BtnReportes.Visible = false;
            }
            else if (rolUsuario == "Administrador")
            {
                btnCrearUsuario.Visible = false;
                BtnReportes.Visible = false;
                btnAjustes.Visible = false;
            }
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void IconSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
