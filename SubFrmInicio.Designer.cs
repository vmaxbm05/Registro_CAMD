namespace pyRegistroAsistencia
{
    partial class SubFrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmInicio));
            picbox_Inicio = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbl_descripcion = new Label();
            label3 = new Label();
            lbl_contador = new Label();
            ((System.ComponentModel.ISupportInitialize)picbox_Inicio).BeginInit();
            SuspendLayout();
            // 
            // picbox_Inicio
            // 
            picbox_Inicio.Location = new Point(0, -1);
            picbox_Inicio.Name = "picbox_Inicio";
            picbox_Inicio.Size = new Size(800, 223);
            picbox_Inicio.TabIndex = 2;
            picbox_Inicio.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16F);
            label1.Location = new Point(355, 154);
            label1.Name = "label1";
            label1.Size = new Size(65, 35);
            label1.TabIndex = 3;
            label1.Text = "Test";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.Location = new Point(37, 245);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.Font = new Font("Trebuchet MS", 12F);
            lbl_descripcion.Location = new Point(180, 245);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(572, 110);
            lbl_descripcion.TabIndex = 5;
            lbl_descripcion.Text = resources.GetString("lbl_descripcion.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.Location = new Point(231, 388);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 6;
            label3.Text = "Asistentes";
            // 
            // lbl_contador
            // 
            lbl_contador.AutoSize = true;
            lbl_contador.Font = new Font("Trebuchet MS", 16F);
            lbl_contador.Location = new Point(382, 380);
            lbl_contador.Name = "lbl_contador";
            lbl_contador.Size = new Size(29, 35);
            lbl_contador.TabIndex = 7;
            lbl_contador.Text = "0";
            // 
            // SubFrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_contador);
            Controls.Add(label3);
            Controls.Add(lbl_descripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picbox_Inicio);
            Name = "SubFrmInicio";
            Text = "SubFrmInicio";
            Load += SubFrmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)picbox_Inicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picbox_Inicio;
        private Label label1;
        private Label label2;
        private Label lbl_descripcion;
        private Label label3;
        private Label lbl_contador;
    }
}