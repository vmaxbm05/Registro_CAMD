namespace pyRegistroAsistencia
{
    partial class SubFrmPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelBuscar = new Panel();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            programa = new DataGridViewTextBoxColumn();
            button4 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnGuardar = new Button();
            cbPrograma = new ComboBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cbTipo = new ComboBox();
            label2 = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblDocumento = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            PanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBuscar
            // 
            PanelBuscar.BackColor = Color.FromArgb(225, 225, 225);
            PanelBuscar.Controls.Add(dataGridView1);
            PanelBuscar.Controls.Add(button4);
            PanelBuscar.Controls.Add(textBox1);
            PanelBuscar.Controls.Add(label5);
            PanelBuscar.Controls.Add(label4);
            PanelBuscar.Dock = DockStyle.Fill;
            PanelBuscar.ForeColor = Color.FromArgb(9, 15, 70);
            PanelBuscar.Location = new Point(0, 0);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(1282, 603);
            PanelBuscar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, apellidos, dni, correo, telefono, tipo, programa });
            dataGridView1.Location = new Point(694, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(564, 401);
            dataGridView1.TabIndex = 20;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombres";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellidos
            // 
            apellidos.HeaderText = "Apellidos";
            apellidos.MinimumWidth = 6;
            apellidos.Name = "apellidos";
            apellidos.Width = 125;
            // 
            // dni
            // 
            dni.HeaderText = "Documento";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.Width = 125;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // programa
            // 
            programa.HeaderText = "Programa Académico";
            programa.MinimumWidth = 6;
            programa.Name = "programa";
            programa.Width = 125;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(9, 15, 70);
            button4.FlatAppearance.BorderColor = Color.Silver;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(225, 225, 225);
            button4.Location = new Point(1136, 71);
            button4.Name = "button4";
            button4.Size = new Size(134, 32);
            button4.TabIndex = 19;
            button4.Text = "BUSCAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(756, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(9, 15, 70);
            label5.Location = new Point(670, 77);
            label5.Name = "label5";
            label5.Size = new Size(113, 39);
            label5.TabIndex = 19;
            label5.Text = "Buscar:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(9, 15, 70);
            label4.Location = new Point(814, 25);
            label4.Name = "label4";
            label4.Size = new Size(326, 50);
            label4.TabIndex = 19;
            label4.Text = "BUSQUEDA ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(9, 15, 70);
            label1.Location = new Point(186, 25);
            label1.Name = "label1";
            label1.Size = new Size(326, 50);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LAS PERSONAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 225, 225);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cbPrograma);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(cbTipo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblDocumento);
            panel1.Controls.Add(lblApellidos);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 603);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(9, 15, 70);
            button3.FlatAppearance.BorderColor = Color.Silver;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(225, 225, 225);
            button3.Location = new Point(496, 455);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 18;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(9, 15, 70);
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(225, 225, 225);
            button2.Location = new Point(344, 455);
            button2.Name = "button2";
            button2.Size = new Size(134, 32);
            button2.TabIndex = 17;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(9, 15, 70);
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(225, 225, 225);
            button1.Location = new Point(186, 455);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 16;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(9, 15, 70);
            btnGuardar.FlatAppearance.BorderColor = Color.Silver;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(225, 225, 225);
            btnGuardar.Location = new Point(31, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 32);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbPrograma
            // 
            cbPrograma.FormattingEnabled = true;
            cbPrograma.Items.AddRange(new object[] { "Pregrado", "Posgrado" });
            cbPrograma.Location = new Point(456, 347);
            cbPrograma.Name = "cbPrograma";
            cbPrograma.Size = new Size(165, 28);
            cbPrograma.TabIndex = 14;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(9, 15, 70);
            label3.Location = new Point(366, 348);
            label3.Name = "label3";
            label3.Size = new Size(113, 39);
            label3.TabIndex = 13;
            label3.Text = "Programa:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(177, 292);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(361, 27);
            txtTelefono.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(177, 242);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(361, 27);
            txtCorreo.TabIndex = 11;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(177, 193);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(361, 27);
            txtDNI.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(177, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 27);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 27);
            txtNombre.TabIndex = 8;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Estudiante", "Docente", "Invitado" });
            cbTipo.Location = new Point(121, 347);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(179, 28);
            cbTipo.TabIndex = 7;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(9, 15, 70);
            label2.Location = new Point(51, 347);
            label2.Name = "label2";
            label2.Size = new Size(113, 39);
            label2.TabIndex = 6;
            label2.Text = "Tipo:";
            // 
            // lblTelefono
            // 
            lblTelefono.ForeColor = Color.FromArgb(9, 15, 70);
            lblTelefono.Location = new Point(72, 295);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(113, 39);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.ForeColor = Color.FromArgb(9, 15, 70);
            lblCorreo.Location = new Point(72, 244);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(113, 39);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            // 
            // lblDocumento
            // 
            lblDocumento.ForeColor = Color.FromArgb(9, 15, 70);
            lblDocumento.Location = new Point(72, 195);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(113, 39);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento:";
            // 
            // lblApellidos
            // 
            lblApellidos.ForeColor = Color.FromArgb(9, 15, 70);
            lblApellidos.Location = new Point(72, 146);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(113, 39);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.ForeColor = Color.FromArgb(9, 15, 70);
            lblNombre.Location = new Point(72, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 39);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombres:";
            // 
            // SubFrmPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1282, 603);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(PanelBuscar);
            Name = "SubFrmPersonas";
            Text = "SubFrmPersonas";
            Load += SubFrmPersonas_Load;
            PanelBuscar.ResumeLayout(false);
            PanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBuscar;
        private Label label1;
        private Panel panel1;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblDocumento;
        private Label lblApellidos;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cbTipo;
        private Label label2;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDNI;
        private Button btnGuardar;
        private ComboBox cbPrograma;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn programa;
        private Button button4;
        private TextBox textBox1;
    }
}