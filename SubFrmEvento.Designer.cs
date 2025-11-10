namespace pyRegistroAsistencia
{
    partial class SubFrmAjustes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nombreEvento = new TextBox();
            txt_Descripcion = new TextBox();
            btn_subirImagen = new Button();
            btn_guardarEvento = new Button();
            picb_preview = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTime_Inicio = new DateTimePicker();
            dateTime_Fin = new DateTimePicker();
            cmb_evento = new ComboBox();
            cmb_facultad = new ComboBox();
            label8 = new Label();
            txt_otro_evento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picb_preview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Evento :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 369);
            label2.Name = "label2";
            label2.Size = new Size(91, 26);
            label2.TabIndex = 1;
            label2.Text = "Imagen :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 71);
            label3.Name = "label3";
            label3.Size = new Size(232, 26);
            label3.TabIndex = 2;
            label3.Text = "Descripcion del evento :";
            // 
            // txt_nombreEvento
            // 
            txt_nombreEvento.Location = new Point(296, 23);
            txt_nombreEvento.Name = "txt_nombreEvento";
            txt_nombreEvento.Size = new Size(401, 27);
            txt_nombreEvento.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new Point(296, 72);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.ScrollBars = ScrollBars.Vertical;
            txt_Descripcion.Size = new Size(401, 70);
            txt_Descripcion.TabIndex = 4;
            // 
            // btn_subirImagen
            // 
            btn_subirImagen.Location = new Point(296, 369);
            btn_subirImagen.Name = "btn_subirImagen";
            btn_subirImagen.Size = new Size(114, 29);
            btn_subirImagen.TabIndex = 5;
            btn_subirImagen.Text = "subir imagen";
            btn_subirImagen.UseVisualStyleBackColor = true;
            btn_subirImagen.Click += btn_subirImagen_Click;
            // 
            // btn_guardarEvento
            // 
            btn_guardarEvento.Location = new Point(332, 448);
            btn_guardarEvento.Name = "btn_guardarEvento";
            btn_guardarEvento.Size = new Size(187, 36);
            btn_guardarEvento.TabIndex = 6;
            btn_guardarEvento.Text = "Guardar Evento";
            btn_guardarEvento.UseVisualStyleBackColor = true;
            btn_guardarEvento.Click += btn_guardarEvento_Click;
            // 
            // picb_preview
            // 
            picb_preview.BackColor = Color.PeachPuff;
            picb_preview.Location = new Point(434, 347);
            picb_preview.Name = "picb_preview";
            picb_preview.Size = new Size(196, 80);
            picb_preview.TabIndex = 7;
            picb_preview.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10F);
            label4.Location = new Point(39, 165);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 8;
            label4.Text = "Fecha inicio :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10F);
            label5.Location = new Point(39, 212);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 9;
            label5.Text = "Fecha Fin :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 10F);
            label6.Location = new Point(39, 255);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 10;
            label6.Text = "Tipo de evento :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 10F);
            label7.Location = new Point(39, 305);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 11;
            label7.Text = "Facultad :";
            // 
            // dateTime_Inicio
            // 
            dateTime_Inicio.Location = new Point(296, 161);
            dateTime_Inicio.Name = "dateTime_Inicio";
            dateTime_Inicio.Size = new Size(250, 27);
            dateTime_Inicio.TabIndex = 12;
            // 
            // dateTime_Fin
            // 
            dateTime_Fin.Location = new Point(296, 208);
            dateTime_Fin.Name = "dateTime_Fin";
            dateTime_Fin.Size = new Size(250, 27);
            dateTime_Fin.TabIndex = 13;
            // 
            // cmb_evento
            // 
            cmb_evento.FormattingEnabled = true;
            cmb_evento.Location = new Point(296, 253);
            cmb_evento.Name = "cmb_evento";
            cmb_evento.Size = new Size(223, 28);
            cmb_evento.TabIndex = 14;
            cmb_evento.SelectedIndexChanged += cmb_evento_SelectedIndexChanged;
            // 
            // cmb_facultad
            // 
            cmb_facultad.FormattingEnabled = true;
            cmb_facultad.Location = new Point(296, 303);
            cmb_facultad.Name = "cmb_facultad";
            cmb_facultad.Size = new Size(401, 28);
            cmb_facultad.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 10F);
            label8.Location = new Point(542, 255);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 16;
            label8.Text = "Otro :";
            // 
            // txt_otro_evento
            // 
            txt_otro_evento.Location = new Point(603, 254);
            txt_otro_evento.Name = "txt_otro_evento";
            txt_otro_evento.Size = new Size(145, 27);
            txt_otro_evento.TabIndex = 17;
            // 
            // SubFrmAjustes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 508);
            Controls.Add(txt_otro_evento);
            Controls.Add(label8);
            Controls.Add(cmb_facultad);
            Controls.Add(cmb_evento);
            Controls.Add(dateTime_Fin);
            Controls.Add(dateTime_Inicio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(picb_preview);
            Controls.Add(btn_guardarEvento);
            Controls.Add(btn_subirImagen);
            Controls.Add(txt_Descripcion);
            Controls.Add(txt_nombreEvento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubFrmAjustes";
            Text = "SubFrmAjustes";
            Load += SubFrmAjustes_Load;
            ((System.ComponentModel.ISupportInitialize)picb_preview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nombreEvento;
        private TextBox txt_Descripcion;
        private Button btn_subirImagen;
        private Button btn_guardarEvento;
        private PictureBox picb_preview;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTime_Inicio;
        private DateTimePicker dateTime_Fin;
        private ComboBox cmb_evento;
        private ComboBox cmb_facultad;
        private Label label8;
        private TextBox txt_otro_evento;
    }
}