namespace FutBol_Torneos_Management
{
    partial class Form_TorneosNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TorneosNuevo));
            groupBox1 = new GroupBox();
            txtbLocalizacion = new TextBox();
            txtbFechaFinal = new TextBox();
            txtbFechaInicio = new TextBox();
            txtbNombreTorneo = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCrearTorneo = new Button();
            groupBox2 = new GroupBox();
            btnAgregarEquipo = new Button();
            cbEquiposDisponibles = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            lbEquiposAgregados = new ListBox();
            btnEliminarEquipo = new Button();
            btnRegresar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtbLocalizacion);
            groupBox1.Controls.Add(txtbFechaFinal);
            groupBox1.Controls.Add(txtbFechaInicio);
            groupBox1.Controls.Add(txtbNombreTorneo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Requerida";
            // 
            // txtbLocalizacion
            // 
            txtbLocalizacion.Location = new Point(113, 100);
            txtbLocalizacion.Name = "txtbLocalizacion";
            txtbLocalizacion.Size = new Size(105, 22);
            txtbLocalizacion.TabIndex = 9;
            // 
            // txtbFechaFinal
            // 
            txtbFechaFinal.Location = new Point(113, 75);
            txtbFechaFinal.Name = "txtbFechaFinal";
            txtbFechaFinal.Size = new Size(105, 22);
            txtbFechaFinal.TabIndex = 8;
            // 
            // txtbFechaInicio
            // 
            txtbFechaInicio.Location = new Point(113, 50);
            txtbFechaInicio.Name = "txtbFechaInicio";
            txtbFechaInicio.Size = new Size(105, 22);
            txtbFechaInicio.TabIndex = 7;
            // 
            // txtbNombreTorneo
            // 
            txtbNombreTorneo.Location = new Point(113, 24);
            txtbNombreTorneo.Name = "txtbNombreTorneo";
            txtbNombreTorneo.Size = new Size(105, 22);
            txtbNombreTorneo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 163);
            label6.Name = "label6";
            label6.Size = new Size(0, 16);
            label6.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 103);
            label4.Name = "label4";
            label4.Size = new Size(86, 16);
            label4.TabIndex = 3;
            label4.Text = "Localizacion :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Fin :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Inicio :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // btnCrearTorneo
            // 
            btnCrearTorneo.Enabled = false;
            btnCrearTorneo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCrearTorneo.ForeColor = Color.FromArgb(0, 64, 0);
            btnCrearTorneo.Location = new Point(12, 436);
            btnCrearTorneo.Name = "btnCrearTorneo";
            btnCrearTorneo.Size = new Size(118, 23);
            btnCrearTorneo.TabIndex = 1;
            btnCrearTorneo.Text = "Crear Torneo";
            btnCrearTorneo.UseVisualStyleBackColor = true;
            btnCrearTorneo.Click += btnCrearTorneo_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnAgregarEquipo);
            groupBox2.Controls.Add(cbEquiposDisponibles);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(12, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 85);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Equipos";
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.ForeColor = Color.FromArgb(64, 0, 64);
            btnAgregarEquipo.Location = new Point(63, 56);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(110, 23);
            btnAgregarEquipo.TabIndex = 2;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // cbEquiposDisponibles
            // 
            cbEquiposDisponibles.FormattingEnabled = true;
            cbEquiposDisponibles.Location = new Point(77, 21);
            cbEquiposDisponibles.Name = "cbEquiposDisponibles";
            cbEquiposDisponibles.Size = new Size(138, 24);
            cbEquiposDisponibles.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 27);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 0;
            label5.Text = "Equipo :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(37, 237);
            label7.Name = "label7";
            label7.Size = new Size(171, 16);
            label7.TabIndex = 3;
            label7.Text = "Lista de Equipos Agregados";
            // 
            // lbEquiposAgregados
            // 
            lbEquiposAgregados.FormattingEnabled = true;
            lbEquiposAgregados.ItemHeight = 16;
            lbEquiposAgregados.Location = new Point(47, 256);
            lbEquiposAgregados.Name = "lbEquiposAgregados";
            lbEquiposAgregados.Size = new Size(161, 116);
            lbEquiposAgregados.TabIndex = 4;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Enabled = false;
            btnEliminarEquipo.ForeColor = Color.Navy;
            btnEliminarEquipo.Location = new Point(75, 378);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(110, 23);
            btnEliminarEquipo.TabIndex = 5;
            btnEliminarEquipo.Text = "Eliminar Equipo";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.ForeColor = Color.Maroon;
            btnRegresar.Location = new Point(175, 445);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Form_TorneosNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(253, 471);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(lbEquiposAgregados);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(btnCrearTorneo);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form_TorneosNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crea tu Torneo!!!";
            Load += Form_TorneosNuevo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtbLocalizacion;
        private TextBox txtbFechaFinal;
        private TextBox txtbFechaInicio;
        private TextBox txtbNombreTorneo;
        private Button btnCrearTorneo;
        private GroupBox groupBox2;
        private Button btnAgregarEquipo;
        private ComboBox cbEquiposDisponibles;
        private Label label5;
        private Label label7;
        private ListBox lbEquiposAgregados;
        private Button btnEliminarEquipo;
        private Button btnRegresar;
    }
}