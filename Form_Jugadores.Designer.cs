namespace FutBol_Torneos_Management
{
    partial class Form_Jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jugadores));
            btnNuevoJugador = new Button();
            btnModJugador = new Button();
            btnEliminarJugador = new Button();
            btnRegresar = new Button();
            groupBox1 = new GroupBox();
            txtbNacionalidadJ = new TextBox();
            label16 = new Label();
            cbClub = new ComboBox();
            txtbAsistenciasJ = new TextBox();
            txtbPasesComplJ = new TextBox();
            txtbTarjetasRojas = new TextBox();
            txtbTarjetasAmarillas = new TextBox();
            txtbPenalesFallados = new TextBox();
            txtbGolesXPenalJ = new TextBox();
            txtbGolesMarcadosJ = new TextBox();
            txtbMinJugadosJ = new TextBox();
            txtbFechaNacJ = new TextBox();
            txtbPosicionJ = new TextBox();
            txtbEdadJ = new TextBox();
            txtbNombreJ = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbBuscarJugador = new ComboBox();
            label15 = new Label();
            cbdClubBusqueda = new ComboBox();
            label14 = new Label();
            btnBuscarJugador = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoJugador
            // 
            btnNuevoJugador.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnNuevoJugador.ForeColor = Color.FromArgb(0, 64, 0);
            btnNuevoJugador.Location = new Point(38, 249);
            btnNuevoJugador.Name = "btnNuevoJugador";
            btnNuevoJugador.Size = new Size(116, 28);
            btnNuevoJugador.TabIndex = 0;
            btnNuevoJugador.Text = "Nuevo Jugador";
            btnNuevoJugador.UseVisualStyleBackColor = true;
            btnNuevoJugador.Click += btnNuevoJugador_Click;
            // 
            // btnModJugador
            // 
            btnModJugador.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnModJugador.ForeColor = Color.DarkGoldenrod;
            btnModJugador.Location = new Point(160, 249);
            btnModJugador.Name = "btnModJugador";
            btnModJugador.Size = new Size(126, 28);
            btnModJugador.TabIndex = 1;
            btnModJugador.Text = "Modificar Jugador";
            btnModJugador.UseVisualStyleBackColor = true;
            btnModJugador.Click += btnModJugador_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarJugador.ForeColor = Color.Firebrick;
            btnEliminarJugador.Location = new Point(292, 249);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(123, 28);
            btnEliminarJugador.TabIndex = 2;
            btnEliminarJugador.Text = "Eliminar Jugador";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.FromArgb(64, 0, 64);
            btnRegresar.Location = new Point(524, 269);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 25);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtbNacionalidadJ);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(cbClub);
            groupBox1.Controls.Add(txtbAsistenciasJ);
            groupBox1.Controls.Add(txtbPasesComplJ);
            groupBox1.Controls.Add(txtbTarjetasRojas);
            groupBox1.Controls.Add(txtbTarjetasAmarillas);
            groupBox1.Controls.Add(txtbPenalesFallados);
            groupBox1.Controls.Add(txtbGolesXPenalJ);
            groupBox1.Controls.Add(txtbGolesMarcadosJ);
            groupBox1.Controls.Add(txtbMinJugadosJ);
            groupBox1.Controls.Add(txtbFechaNacJ);
            groupBox1.Controls.Add(txtbPosicionJ);
            groupBox1.Controls.Add(txtbEdadJ);
            groupBox1.Controls.Add(txtbNombreJ);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(421, 233);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Jugadores";
            // 
            // txtbNacionalidadJ
            // 
            txtbNacionalidadJ.Location = new Point(114, 88);
            txtbNacionalidadJ.Name = "txtbNacionalidadJ";
            txtbNacionalidadJ.Size = new Size(125, 22);
            txtbNacionalidadJ.TabIndex = 28;
            txtbNacionalidadJ.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(0, 64, 0);
            label16.Location = new Point(15, 91);
            label16.Name = "label16";
            label16.Size = new Size(93, 16);
            label16.TabIndex = 27;
            label16.Text = "Nacionalidad :";
            // 
            // cbClub
            // 
            cbClub.FormattingEnabled = true;
            cbClub.Location = new Point(269, 28);
            cbClub.Name = "cbClub";
            cbClub.Size = new Size(142, 24);
            cbClub.TabIndex = 26;
            // 
            // txtbAsistenciasJ
            // 
            txtbAsistenciasJ.Location = new Point(341, 201);
            txtbAsistenciasJ.Name = "txtbAsistenciasJ";
            txtbAsistenciasJ.Size = new Size(41, 22);
            txtbAsistenciasJ.TabIndex = 25;
            txtbAsistenciasJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPasesComplJ
            // 
            txtbPasesComplJ.Location = new Point(341, 174);
            txtbPasesComplJ.Name = "txtbPasesComplJ";
            txtbPasesComplJ.Size = new Size(41, 22);
            txtbPasesComplJ.TabIndex = 24;
            txtbPasesComplJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbTarjetasRojas
            // 
            txtbTarjetasRojas.Location = new Point(341, 145);
            txtbTarjetasRojas.Name = "txtbTarjetasRojas";
            txtbTarjetasRojas.Size = new Size(41, 22);
            txtbTarjetasRojas.TabIndex = 23;
            txtbTarjetasRojas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbTarjetasAmarillas
            // 
            txtbTarjetasAmarillas.Location = new Point(341, 116);
            txtbTarjetasAmarillas.Name = "txtbTarjetasAmarillas";
            txtbTarjetasAmarillas.Size = new Size(41, 22);
            txtbTarjetasAmarillas.TabIndex = 22;
            txtbTarjetasAmarillas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPenalesFallados
            // 
            txtbPenalesFallados.Location = new Point(134, 201);
            txtbPenalesFallados.Name = "txtbPenalesFallados";
            txtbPenalesFallados.Size = new Size(41, 22);
            txtbPenalesFallados.TabIndex = 21;
            txtbPenalesFallados.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbGolesXPenalJ
            // 
            txtbGolesXPenalJ.Location = new Point(134, 171);
            txtbGolesXPenalJ.Name = "txtbGolesXPenalJ";
            txtbGolesXPenalJ.Size = new Size(41, 22);
            txtbGolesXPenalJ.TabIndex = 20;
            txtbGolesXPenalJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbGolesMarcadosJ
            // 
            txtbGolesMarcadosJ.Location = new Point(134, 145);
            txtbGolesMarcadosJ.Name = "txtbGolesMarcadosJ";
            txtbGolesMarcadosJ.Size = new Size(41, 22);
            txtbGolesMarcadosJ.TabIndex = 19;
            txtbGolesMarcadosJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbMinJugadosJ
            // 
            txtbMinJugadosJ.Location = new Point(134, 116);
            txtbMinJugadosJ.Name = "txtbMinJugadosJ";
            txtbMinJugadosJ.Size = new Size(41, 22);
            txtbMinJugadosJ.TabIndex = 18;
            txtbMinJugadosJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbFechaNacJ
            // 
            txtbFechaNacJ.Location = new Point(119, 55);
            txtbFechaNacJ.Name = "txtbFechaNacJ";
            txtbFechaNacJ.Size = new Size(88, 22);
            txtbFechaNacJ.TabIndex = 14;
            txtbFechaNacJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbPosicionJ
            // 
            txtbPosicionJ.Location = new Point(291, 58);
            txtbPosicionJ.Name = "txtbPosicionJ";
            txtbPosicionJ.Size = new Size(77, 22);
            txtbPosicionJ.TabIndex = 17;
            txtbPosicionJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbEdadJ
            // 
            txtbEdadJ.Location = new Point(304, 88);
            txtbEdadJ.Name = "txtbEdadJ";
            txtbEdadJ.Size = new Size(41, 22);
            txtbEdadJ.TabIndex = 15;
            txtbEdadJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbNombreJ
            // 
            txtbNombreJ.Location = new Point(82, 28);
            txtbNombreJ.Name = "txtbNombreJ";
            txtbNombreJ.Size = new Size(125, 22);
            txtbNombreJ.TabIndex = 13;
            txtbNombreJ.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(0, 64, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(213, 145);
            label13.Name = "label13";
            label13.Size = new Size(122, 16);
            label13.TabIndex = 12;
            label13.Text = "Total Tarjetas rojas :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 64, 0);
            label12.Location = new Point(188, 119);
            label12.Name = "label12";
            label12.Size = new Size(147, 16);
            label12.TabIndex = 11;
            label12.Text = "Total tarjetas Amarillas :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 64, 0);
            label11.Location = new Point(15, 204);
            label11.Name = "label11";
            label11.Size = new Size(113, 16);
            label11.TabIndex = 10;
            label11.Text = "Penales Fallados :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 64, 0);
            label10.Location = new Point(15, 174);
            label10.Name = "label10";
            label10.Size = new Size(107, 16);
            label10.TabIndex = 9;
            label10.Text = "Goles por Penal :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(15, 148);
            label9.Name = "label9";
            label9.Size = new Size(111, 16);
            label9.TabIndex = 8;
            label9.Text = "Goles Marcados :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(203, 204);
            label8.Name = "label8";
            label8.Size = new Size(115, 16);
            label8.TabIndex = 7;
            label8.Text = "Asistencias a Gol :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 64, 0);
            label7.Location = new Point(203, 178);
            label7.Name = "label7";
            label7.Size = new Size(132, 16);
            label7.TabIndex = 6;
            label7.Text = "Pases Completados :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 64, 0);
            label6.Location = new Point(15, 119);
            label6.Name = "label6";
            label6.Size = new Size(113, 16);
            label6.TabIndex = 5;
            label6.Text = "Minutos Jugados :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(223, 34);
            label5.Name = "label5";
            label5.Size = new Size(40, 16);
            label5.TabIndex = 4;
            label5.Text = "Club :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(223, 61);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 3;
            label4.Text = "Posicion :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(15, 58);
            label3.Name = "label3";
            label3.Size = new Size(98, 16);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nac. :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(255, 91);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 1;
            label2.Text = "Edad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(cbBuscarJugador);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(cbdClubBusqueda);
            groupBox2.Controls.Add(label14);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(439, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(160, 127);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // cbBuscarJugador
            // 
            cbBuscarJugador.FormattingEnabled = true;
            cbBuscarJugador.Location = new Point(17, 91);
            cbBuscarJugador.Name = "cbBuscarJugador";
            cbBuscarJugador.Size = new Size(137, 24);
            cbBuscarJugador.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(0, 64, 0);
            label15.Location = new Point(6, 74);
            label15.Name = "label15";
            label15.Size = new Size(61, 16);
            label15.TabIndex = 27;
            label15.Text = "Nombre :";
            // 
            // cbdClubBusqueda
            // 
            cbdClubBusqueda.FormattingEnabled = true;
            cbdClubBusqueda.Location = new Point(24, 47);
            cbdClubBusqueda.Name = "cbdClubBusqueda";
            cbdClubBusqueda.Size = new Size(130, 24);
            cbdClubBusqueda.TabIndex = 27;
            cbdClubBusqueda.TextChanged += cbdClubBusqueda_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 64, 0);
            label14.Location = new Point(6, 28);
            label14.Name = "label14";
            label14.Size = new Size(40, 16);
            label14.TabIndex = 27;
            label14.Text = "Club :";
            // 
            // btnBuscarJugador
            // 
            btnBuscarJugador.ForeColor = Color.DarkBlue;
            btnBuscarJugador.Location = new Point(489, 151);
            btnBuscarJugador.Name = "btnBuscarJugador";
            btnBuscarJugador.Size = new Size(67, 23);
            btnBuscarJugador.TabIndex = 6;
            btnBuscarJugador.Text = "Buscar";
            btnBuscarJugador.UseVisualStyleBackColor = true;
            btnBuscarJugador.Click += btnBuscarJugador_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(455, 180);
            button1.Name = "button1";
            button1.Size = new Size(144, 28);
            button1.TabIndex = 7;
            button1.Text = "Restablecer Campos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Jugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(606, 298);
            Controls.Add(button1);
            Controls.Add(btnBuscarJugador);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminarJugador);
            Controls.Add(btnModJugador);
            Controls.Add(btnNuevoJugador);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form_Jugadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de Jugadores";
            Load += Form_Jugadores_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoJugador;
        private Button btnModJugador;
        private Button btnEliminarJugador;
        private Button btnRegresar;
        private GroupBox groupBox1;
        private Label label1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtbFechaNacJ;
        private TextBox txtbPosicionJ;
        private TextBox txtbEdadJ;
        private TextBox txtbNombreJ;
        private TextBox txtbTarjetasAmarillas;
        private TextBox txtbPenalesFallados;
        private TextBox txtbGolesXPenalJ;
        private TextBox txtbGolesMarcadosJ;
        private TextBox txtbMinJugadosJ;
        private ComboBox cbClub;
        private TextBox txtbAsistenciasJ;
        private TextBox txtbPasesComplJ;
        private TextBox txtbTarjetasRojas;
        private GroupBox groupBox2;
        private Label label15;
        private ComboBox cbdClubBusqueda;
        private Label label14;
        private Button btnBuscarJugador;
        private ComboBox cbBuscarJugador;
        private Button button1;
        private TextBox txtbNacionalidadJ;
        private Label label16;
    }
}