namespace FutBol_Torneos_Management
{
    partial class Form_AdminTorneos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminTorneos));
            label3 = new Label();
            groupBox4 = new GroupBox();
            btnEliminarTarjetaVisitante = new Button();
            btnEliminarGolVisitante = new Button();
            lbGolesVisitante = new ListBox();
            lbTarjetasVisitante = new ListBox();
            groupBox5 = new GroupBox();
            btnGuardarGolVisitante = new Button();
            txtbMinGolVisitante = new TextBox();
            cbTipoGolesVisitante = new ComboBox();
            label14 = new Label();
            cbJugadoresGolesVisitante = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            groupBox6 = new GroupBox();
            btnGuardarTarjetaVisitante = new Button();
            txtbMinTarjetaVisitante = new TextBox();
            cbTipoTarjetaVisitante = new ComboBox();
            cbJugadoresTarjetasVisitante = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            cbEquiposVisitantes = new ComboBox();
            label21 = new Label();
            groupBox7 = new GroupBox();
            btnBuscar = new Button();
            cbEquiposBusqueda = new ComboBox();
            label22 = new Label();
            txtbSede = new TextBox();
            label4 = new Label();
            label10 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnEliminarTarjetaLocal = new Button();
            btnEliminarGolLocal = new Button();
            lbGolesEquipoLocal = new ListBox();
            lbTarjetasEquipoLocal = new ListBox();
            groupBox3 = new GroupBox();
            btnGuardarGolLocal = new Button();
            txtbMinGolLocal = new TextBox();
            cbTipoGolLocal = new ComboBox();
            label13 = new Label();
            cbJugadoresGolesLocal = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            btnGuardarTarjetaLocal = new Button();
            txtbMinTarjetaLocal = new TextBox();
            cbTipoTarjetaLocal = new ComboBox();
            cbJugadoresTarjetasLocal = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            cbEquiposLocales = new ComboBox();
            label5 = new Label();
            txtbFechaPartido = new TextBox();
            label6 = new Label();
            cbTorneos = new ComboBox();
            label1 = new Label();
            btnAgregarPartido = new Button();
            btnElimnarPartido = new Button();
            btnRegresar = new Button();
            btnEliminarTorneo = new Button();
            btnBorrarDatos = new Button();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(318, 143);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 24;
            label3.Text = "EQUIPO VISITANTE";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(btnEliminarTarjetaVisitante);
            groupBox4.Controls.Add(btnEliminarGolVisitante);
            groupBox4.Controls.Add(lbGolesVisitante);
            groupBox4.Controls.Add(lbTarjetasVisitante);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(cbEquiposVisitantes);
            groupBox4.Controls.Add(label21);
            groupBox4.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(264, 158);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 481);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            // 
            // btnEliminarTarjetaVisitante
            // 
            btnEliminarTarjetaVisitante.ForeColor = Color.Maroon;
            btnEliminarTarjetaVisitante.Location = new Point(90, 240);
            btnEliminarTarjetaVisitante.Name = "btnEliminarTarjetaVisitante";
            btnEliminarTarjetaVisitante.Size = new Size(75, 23);
            btnEliminarTarjetaVisitante.TabIndex = 15;
            btnEliminarTarjetaVisitante.Text = "Eliminar";
            btnEliminarTarjetaVisitante.UseVisualStyleBackColor = true;
            btnEliminarTarjetaVisitante.Click += btnEliminarTarjetaVisitante_Click;
            // 
            // btnEliminarGolVisitante
            // 
            btnEliminarGolVisitante.ForeColor = Color.Maroon;
            btnEliminarGolVisitante.Location = new Point(90, 449);
            btnEliminarGolVisitante.Name = "btnEliminarGolVisitante";
            btnEliminarGolVisitante.Size = new Size(75, 23);
            btnEliminarGolVisitante.TabIndex = 14;
            btnEliminarGolVisitante.Text = "Eliminar";
            btnEliminarGolVisitante.UseVisualStyleBackColor = true;
            btnEliminarGolVisitante.Click += btnEliminarGolVisitante_Click;
            // 
            // lbGolesVisitante
            // 
            lbGolesVisitante.FormattingEnabled = true;
            lbGolesVisitante.ItemHeight = 16;
            lbGolesVisitante.Location = new Point(16, 391);
            lbGolesVisitante.Name = "lbGolesVisitante";
            lbGolesVisitante.Size = new Size(220, 52);
            lbGolesVisitante.TabIndex = 12;
            // 
            // lbTarjetasVisitante
            // 
            lbTarjetasVisitante.FormattingEnabled = true;
            lbTarjetasVisitante.ItemHeight = 16;
            lbTarjetasVisitante.Location = new Point(16, 175);
            lbTarjetasVisitante.Name = "lbTarjetasVisitante";
            lbTarjetasVisitante.Size = new Size(220, 52);
            lbTarjetasVisitante.TabIndex = 11;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnGuardarGolVisitante);
            groupBox5.Controls.Add(txtbMinGolVisitante);
            groupBox5.Controls.Add(cbTipoGolesVisitante);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(cbJugadoresGolesVisitante);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label16);
            groupBox5.ForeColor = SystemColors.ButtonHighlight;
            groupBox5.Location = new Point(16, 269);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(220, 116);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Goles";
            // 
            // btnGuardarGolVisitante
            // 
            btnGuardarGolVisitante.ForeColor = Color.FromArgb(0, 64, 0);
            btnGuardarGolVisitante.Location = new Point(74, 87);
            btnGuardarGolVisitante.Name = "btnGuardarGolVisitante";
            btnGuardarGolVisitante.Size = new Size(75, 23);
            btnGuardarGolVisitante.TabIndex = 13;
            btnGuardarGolVisitante.Text = "Guardar";
            btnGuardarGolVisitante.UseVisualStyleBackColor = true;
            btnGuardarGolVisitante.Click += btnGuardarGolVisitante_Click;
            // 
            // txtbMinGolVisitante
            // 
            txtbMinGolVisitante.Location = new Point(172, 56);
            txtbMinGolVisitante.Name = "txtbMinGolVisitante";
            txtbMinGolVisitante.Size = new Size(43, 22);
            txtbMinGolVisitante.TabIndex = 13;
            txtbMinGolVisitante.TextAlign = HorizontalAlignment.Center;
            // 
            // cbTipoGolesVisitante
            // 
            cbTipoGolesVisitante.FormattingEnabled = true;
            cbTipoGolesVisitante.Location = new Point(52, 54);
            cbTipoGolesVisitante.Name = "cbTipoGolesVisitante";
            cbTipoGolesVisitante.Size = new Size(60, 24);
            cbTipoGolesVisitante.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(118, 62);
            label14.Name = "label14";
            label14.Size = new Size(53, 16);
            label14.TabIndex = 12;
            label14.Text = "Minuto :";
            // 
            // cbJugadoresGolesVisitante
            // 
            cbJugadoresGolesVisitante.FormattingEnabled = true;
            cbJugadoresGolesVisitante.Location = new Point(74, 21);
            cbJugadoresGolesVisitante.Name = "cbJugadoresGolesVisitante";
            cbJugadoresGolesVisitante.Size = new Size(136, 24);
            cbJugadoresGolesVisitante.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(9, 59);
            label15.Name = "label15";
            label15.Size = new Size(37, 16);
            label15.TabIndex = 3;
            label15.Text = "Tipo :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(6, 29);
            label16.Name = "label16";
            label16.Size = new Size(62, 16);
            label16.TabIndex = 4;
            label16.Text = "Jugador :";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnGuardarTarjetaVisitante);
            groupBox6.Controls.Add(txtbMinTarjetaVisitante);
            groupBox6.Controls.Add(cbTipoTarjetaVisitante);
            groupBox6.Controls.Add(cbJugadoresTarjetasVisitante);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(label19);
            groupBox6.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox6.ForeColor = SystemColors.HighlightText;
            groupBox6.Location = new Point(16, 56);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(220, 113);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tarjetas";
            // 
            // btnGuardarTarjetaVisitante
            // 
            btnGuardarTarjetaVisitante.ForeColor = Color.FromArgb(0, 64, 0);
            btnGuardarTarjetaVisitante.Location = new Point(74, 84);
            btnGuardarTarjetaVisitante.Name = "btnGuardarTarjetaVisitante";
            btnGuardarTarjetaVisitante.Size = new Size(75, 23);
            btnGuardarTarjetaVisitante.TabIndex = 12;
            btnGuardarTarjetaVisitante.Text = "Guardar";
            btnGuardarTarjetaVisitante.UseVisualStyleBackColor = true;
            btnGuardarTarjetaVisitante.Click += btnGuardarTarjetaVisitante_Click;
            // 
            // txtbMinTarjetaVisitante
            // 
            txtbMinTarjetaVisitante.Location = new Point(173, 51);
            txtbMinTarjetaVisitante.Name = "txtbMinTarjetaVisitante";
            txtbMinTarjetaVisitante.Size = new Size(37, 22);
            txtbMinTarjetaVisitante.TabIndex = 11;
            txtbMinTarjetaVisitante.TextAlign = HorizontalAlignment.Center;
            // 
            // cbTipoTarjetaVisitante
            // 
            cbTipoTarjetaVisitante.FormattingEnabled = true;
            cbTipoTarjetaVisitante.Location = new Point(51, 51);
            cbTipoTarjetaVisitante.Name = "cbTipoTarjetaVisitante";
            cbTipoTarjetaVisitante.Size = new Size(60, 24);
            cbTipoTarjetaVisitante.TabIndex = 9;
            // 
            // cbJugadoresTarjetasVisitante
            // 
            cbJugadoresTarjetasVisitante.FormattingEnabled = true;
            cbJugadoresTarjetasVisitante.Location = new Point(74, 21);
            cbJugadoresTarjetasVisitante.Name = "cbJugadoresTarjetasVisitante";
            cbJugadoresTarjetasVisitante.Size = new Size(136, 24);
            cbJugadoresTarjetasVisitante.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(64, 64, 64);
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(9, 54);
            label17.Name = "label17";
            label17.Size = new Size(37, 16);
            label17.TabIndex = 3;
            label17.Text = "Tipo :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(64, 64, 64);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(6, 29);
            label18.Name = "label18";
            label18.Size = new Size(62, 16);
            label18.TabIndex = 4;
            label18.Text = "Jugador :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(64, 64, 64);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(120, 54);
            label19.Name = "label19";
            label19.Size = new Size(53, 16);
            label19.TabIndex = 2;
            label19.Text = "Minuto :";
            // 
            // cbEquiposVisitantes
            // 
            cbEquiposVisitantes.FormattingEnabled = true;
            cbEquiposVisitantes.Location = new Point(75, 25);
            cbEquiposVisitantes.Name = "cbEquiposVisitantes";
            cbEquiposVisitantes.Size = new Size(141, 24);
            cbEquiposVisitantes.TabIndex = 6;
            cbEquiposVisitantes.TextChanged += cbEquiposVisitantes_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(16, 28);
            label21.Name = "label21";
            label21.Size = new Size(53, 16);
            label21.TabIndex = 0;
            label21.Text = "Equipo :";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Transparent;
            groupBox7.Controls.Add(btnBuscar);
            groupBox7.Controls.Add(cbEquiposBusqueda);
            groupBox7.Controls.Add(label22);
            groupBox7.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox7.ForeColor = SystemColors.ControlLightLight;
            groupBox7.Location = new Point(299, 36);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(210, 104);
            groupBox7.TabIndex = 25;
            groupBox7.TabStop = false;
            groupBox7.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Navy;
            btnBuscar.Location = new Point(69, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(71, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbEquiposBusqueda
            // 
            cbEquiposBusqueda.FormattingEnabled = true;
            cbEquiposBusqueda.Location = new Point(9, 45);
            cbEquiposBusqueda.Name = "cbEquiposBusqueda";
            cbEquiposBusqueda.Size = new Size(195, 24);
            cbEquiposBusqueda.TabIndex = 2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(64, 64, 64);
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(9, 18);
            label22.Name = "label22";
            label22.Size = new Size(159, 16);
            label22.TabIndex = 0;
            label22.Text = "Equipos : (Local-Visitante)";
            // 
            // txtbSede
            // 
            txtbSede.Location = new Point(70, 64);
            txtbSede.Name = "txtbSede";
            txtbSede.Size = new Size(100, 23);
            txtbSede.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(10, 36);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 21;
            label4.Text = "PARTIDO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(64, 64, 64);
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(18, 67);
            label10.Name = "label10";
            label10.Size = new Size(51, 16);
            label10.TabIndex = 22;
            label10.Text = "Sede : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(75, 143);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 20;
            label2.Text = "EQUIPO LOCAL";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnEliminarTarjetaLocal);
            groupBox1.Controls.Add(btnEliminarGolLocal);
            groupBox1.Controls.Add(lbGolesEquipoLocal);
            groupBox1.Controls.Add(lbTarjetasEquipoLocal);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbEquiposLocales);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(10, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 481);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // btnEliminarTarjetaLocal
            // 
            btnEliminarTarjetaLocal.ForeColor = Color.Maroon;
            btnEliminarTarjetaLocal.Location = new Point(85, 240);
            btnEliminarTarjetaLocal.Name = "btnEliminarTarjetaLocal";
            btnEliminarTarjetaLocal.Size = new Size(75, 23);
            btnEliminarTarjetaLocal.TabIndex = 15;
            btnEliminarTarjetaLocal.Text = "Eliminar";
            btnEliminarTarjetaLocal.UseVisualStyleBackColor = true;
            btnEliminarTarjetaLocal.Click += btnEliminarTarjetaLocal_Click;
            // 
            // btnEliminarGolLocal
            // 
            btnEliminarGolLocal.ForeColor = Color.Maroon;
            btnEliminarGolLocal.Location = new Point(83, 449);
            btnEliminarGolLocal.Name = "btnEliminarGolLocal";
            btnEliminarGolLocal.Size = new Size(75, 23);
            btnEliminarGolLocal.TabIndex = 14;
            btnEliminarGolLocal.Text = "Eliminar";
            btnEliminarGolLocal.UseVisualStyleBackColor = true;
            btnEliminarGolLocal.Click += btnEliminarGolLocal_Click;
            // 
            // lbGolesEquipoLocal
            // 
            lbGolesEquipoLocal.FormattingEnabled = true;
            lbGolesEquipoLocal.ItemHeight = 16;
            lbGolesEquipoLocal.Location = new Point(9, 391);
            lbGolesEquipoLocal.Name = "lbGolesEquipoLocal";
            lbGolesEquipoLocal.Size = new Size(220, 52);
            lbGolesEquipoLocal.TabIndex = 12;
            // 
            // lbTarjetasEquipoLocal
            // 
            lbTarjetasEquipoLocal.FormattingEnabled = true;
            lbTarjetasEquipoLocal.ItemHeight = 16;
            lbTarjetasEquipoLocal.Location = new Point(9, 175);
            lbTarjetasEquipoLocal.Name = "lbTarjetasEquipoLocal";
            lbTarjetasEquipoLocal.Size = new Size(220, 52);
            lbTarjetasEquipoLocal.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuardarGolLocal);
            groupBox3.Controls.Add(txtbMinGolLocal);
            groupBox3.Controls.Add(cbTipoGolLocal);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(cbJugadoresGolesLocal);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(9, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(220, 116);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Goles";
            // 
            // btnGuardarGolLocal
            // 
            btnGuardarGolLocal.ForeColor = Color.FromArgb(0, 64, 0);
            btnGuardarGolLocal.Location = new Point(74, 87);
            btnGuardarGolLocal.Name = "btnGuardarGolLocal";
            btnGuardarGolLocal.Size = new Size(75, 23);
            btnGuardarGolLocal.TabIndex = 13;
            btnGuardarGolLocal.Text = "Guardar";
            btnGuardarGolLocal.UseVisualStyleBackColor = true;
            btnGuardarGolLocal.Click += btnGuardarGolLocal_Click;
            // 
            // txtbMinGolLocal
            // 
            txtbMinGolLocal.Location = new Point(172, 56);
            txtbMinGolLocal.Name = "txtbMinGolLocal";
            txtbMinGolLocal.Size = new Size(43, 22);
            txtbMinGolLocal.TabIndex = 13;
            txtbMinGolLocal.TextAlign = HorizontalAlignment.Center;
            // 
            // cbTipoGolLocal
            // 
            cbTipoGolLocal.FormattingEnabled = true;
            cbTipoGolLocal.Location = new Point(52, 54);
            cbTipoGolLocal.Name = "cbTipoGolLocal";
            cbTipoGolLocal.Size = new Size(60, 24);
            cbTipoGolLocal.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(118, 62);
            label13.Name = "label13";
            label13.Size = new Size(53, 16);
            label13.TabIndex = 12;
            label13.Text = "Minuto :";
            // 
            // cbJugadoresGolesLocal
            // 
            cbJugadoresGolesLocal.FormattingEnabled = true;
            cbJugadoresGolesLocal.Location = new Point(74, 21);
            cbJugadoresGolesLocal.Name = "cbJugadoresGolesLocal";
            cbJugadoresGolesLocal.Size = new Size(136, 24);
            cbJugadoresGolesLocal.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(9, 59);
            label11.Name = "label11";
            label11.Size = new Size(37, 16);
            label11.TabIndex = 3;
            label11.Text = "Tipo :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(6, 29);
            label12.Name = "label12";
            label12.Size = new Size(62, 16);
            label12.TabIndex = 4;
            label12.Text = "Jugador :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuardarTarjetaLocal);
            groupBox2.Controls.Add(txtbMinTarjetaLocal);
            groupBox2.Controls.Add(cbTipoTarjetaLocal);
            groupBox2.Controls.Add(cbJugadoresTarjetasLocal);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(9, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 113);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tarjetas";
            // 
            // btnGuardarTarjetaLocal
            // 
            btnGuardarTarjetaLocal.ForeColor = Color.FromArgb(0, 64, 0);
            btnGuardarTarjetaLocal.Location = new Point(74, 84);
            btnGuardarTarjetaLocal.Name = "btnGuardarTarjetaLocal";
            btnGuardarTarjetaLocal.Size = new Size(75, 23);
            btnGuardarTarjetaLocal.TabIndex = 12;
            btnGuardarTarjetaLocal.Text = "Guardar";
            btnGuardarTarjetaLocal.UseVisualStyleBackColor = true;
            btnGuardarTarjetaLocal.Click += btnGuardarTarjetaLocal_Click;
            // 
            // txtbMinTarjetaLocal
            // 
            txtbMinTarjetaLocal.Location = new Point(173, 51);
            txtbMinTarjetaLocal.Name = "txtbMinTarjetaLocal";
            txtbMinTarjetaLocal.Size = new Size(37, 22);
            txtbMinTarjetaLocal.TabIndex = 11;
            txtbMinTarjetaLocal.TextAlign = HorizontalAlignment.Center;
            // 
            // cbTipoTarjetaLocal
            // 
            cbTipoTarjetaLocal.FormattingEnabled = true;
            cbTipoTarjetaLocal.Location = new Point(51, 51);
            cbTipoTarjetaLocal.Name = "cbTipoTarjetaLocal";
            cbTipoTarjetaLocal.Size = new Size(60, 24);
            cbTipoTarjetaLocal.TabIndex = 9;
            // 
            // cbJugadoresTarjetasLocal
            // 
            cbJugadoresTarjetasLocal.FormattingEnabled = true;
            cbJugadoresTarjetasLocal.Location = new Point(74, 21);
            cbJugadoresTarjetasLocal.Name = "cbJugadoresTarjetasLocal";
            cbJugadoresTarjetasLocal.Size = new Size(136, 24);
            cbJugadoresTarjetasLocal.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(9, 54);
            label8.Name = "label8";
            label8.Size = new Size(37, 16);
            label8.TabIndex = 3;
            label8.Text = "Tipo :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(6, 29);
            label9.Name = "label9";
            label9.Size = new Size(62, 16);
            label9.TabIndex = 4;
            label9.Text = "Jugador :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(120, 54);
            label7.Name = "label7";
            label7.Size = new Size(53, 16);
            label7.TabIndex = 2;
            label7.Text = "Minuto :";
            // 
            // cbEquiposLocales
            // 
            cbEquiposLocales.FormattingEnabled = true;
            cbEquiposLocales.Location = new Point(78, 22);
            cbEquiposLocales.Name = "cbEquiposLocales";
            cbEquiposLocales.Size = new Size(141, 24);
            cbEquiposLocales.TabIndex = 6;
            cbEquiposLocales.TextChanged += cbEquiposLocales_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 64, 64);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(19, 25);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 0;
            label5.Text = "Equipo :";
            // 
            // txtbFechaPartido
            // 
            txtbFechaPartido.Location = new Point(70, 93);
            txtbFechaPartido.Name = "txtbFechaPartido";
            txtbFechaPartido.Size = new Size(100, 23);
            txtbFechaPartido.TabIndex = 7;
            txtbFechaPartido.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(64, 64, 64);
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(15, 100);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 1;
            label6.Text = "Fecha :";
            // 
            // cbTorneos
            // 
            cbTorneos.FormattingEnabled = true;
            cbTorneos.Location = new Point(245, 6);
            cbTorneos.Name = "cbTorneos";
            cbTorneos.Size = new Size(141, 23);
            cbTorneos.TabIndex = 18;
            cbTorneos.TextChanged += cbTorneos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 16);
            label1.TabIndex = 17;
            label1.Text = "Selecciona el Torneo a Administrar :";
            // 
            // btnAgregarPartido
            // 
            btnAgregarPartido.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAgregarPartido.ForeColor = Color.FromArgb(0, 64, 0);
            btnAgregarPartido.Location = new Point(10, 645);
            btnAgregarPartido.Name = "btnAgregarPartido";
            btnAgregarPartido.Size = new Size(139, 27);
            btnAgregarPartido.TabIndex = 16;
            btnAgregarPartido.Text = "Agregar Partido";
            btnAgregarPartido.UseVisualStyleBackColor = true;
            btnAgregarPartido.Click += btnAgregarPartido_Click;
            // 
            // btnElimnarPartido
            // 
            btnElimnarPartido.Enabled = false;
            btnElimnarPartido.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnElimnarPartido.ForeColor = Color.Maroon;
            btnElimnarPartido.Location = new Point(155, 645);
            btnElimnarPartido.Name = "btnElimnarPartido";
            btnElimnarPartido.Size = new Size(139, 27);
            btnElimnarPartido.TabIndex = 27;
            btnElimnarPartido.Text = "Eliminar Partido";
            btnElimnarPartido.UseVisualStyleBackColor = true;
            btnElimnarPartido.Click += btnElimnarPartido_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.FromArgb(64, 0, 64);
            btnRegresar.Location = new Point(433, 645);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 16;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminarTorneo
            // 
            btnEliminarTorneo.BackColor = Color.DarkRed;
            btnEliminarTorneo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarTorneo.ForeColor = Color.White;
            btnEliminarTorneo.Location = new Point(308, 645);
            btnEliminarTorneo.Name = "btnEliminarTorneo";
            btnEliminarTorneo.Size = new Size(110, 23);
            btnEliminarTorneo.TabIndex = 28;
            btnEliminarTorneo.Text = "Eliminar Torneo";
            btnEliminarTorneo.UseVisualStyleBackColor = false;
            btnEliminarTorneo.Click += btnEliminarTorneo_Click;
            // 
            // btnBorrarDatos
            // 
            btnBorrarDatos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBorrarDatos.ForeColor = Color.Navy;
            btnBorrarDatos.Location = new Point(222, 123);
            btnBorrarDatos.Name = "btnBorrarDatos";
            btnBorrarDatos.Size = new Size(71, 41);
            btnBorrarDatos.TabIndex = 16;
            btnBorrarDatos.Text = "Borrar Datos";
            btnBorrarDatos.UseVisualStyleBackColor = true;
            btnBorrarDatos.Click += btnBorrarDatos_Click;
            // 
            // Form_AdminTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(520, 680);
            Controls.Add(btnBorrarDatos);
            Controls.Add(btnEliminarTorneo);
            Controls.Add(btnRegresar);
            Controls.Add(btnElimnarPartido);
            Controls.Add(btnAgregarPartido);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox7);
            Controls.Add(txtbSede);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(txtbFechaPartido);
            Controls.Add(label6);
            Controls.Add(cbTorneos);
            Controls.Add(label1);
            Name = "Form_AdminTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AdminTorneos";
            Load += Form_AdminTorneos_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox4;
        private Button btnEliminarTarjetaVisitante;
        private Button btnEliminarGolVisitante;
        private ListBox lbGolesVisitante;
        private ListBox lbTarjetasVisitante;
        private GroupBox groupBox5;
        private Button btnGuardarGolVisitante;
        private TextBox txtbMinGolVisitante;
        private ComboBox cbTipoGolesVisitante;
        private Label label14;
        private ComboBox cbJugadoresGolesVisitante;
        private Label label15;
        private Label label16;
        private GroupBox groupBox6;
        private Button btnGuardarTarjetaVisitante;
        private TextBox txtbMinTarjetaVisitante;
        private ComboBox cbTipoTarjetaVisitante;
        private ComboBox cbJugadoresTarjetasVisitante;
        private Label label17;
        private Label label18;
        private Label label19;
        private ComboBox cbEquiposVisitantes;
        private Label label21;
        private GroupBox groupBox7;
        private Button btnBuscar;
        private ComboBox cbEquiposBusqueda;
        private Label label22;
        private TextBox txtbSede;
        private Label label4;
        private Label label10;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnEliminarTarjetaLocal;
        private Button btnEliminarGolLocal;
        private ListBox lbGolesEquipoLocal;
        private ListBox lbTarjetasEquipoLocal;
        private GroupBox groupBox3;
        private Button btnGuardarGolLocal;
        private TextBox txtbMinGolLocal;
        private ComboBox cbTipoGolLocal;
        private Label label13;
        private ComboBox cbJugadoresGolesLocal;
        private Label label11;
        private Label label12;
        private GroupBox groupBox2;
        private Button btnGuardarTarjetaLocal;
        private TextBox txtbMinTarjetaLocal;
        private ComboBox cbTipoTarjetaLocal;
        private ComboBox cbJugadoresTarjetasLocal;
        private Label label8;
        private Label label9;
        private Label label7;
        private TextBox txtbFechaPartido;
        private ComboBox cbEquiposLocales;
        private Label label6;
        private Label label5;
        private ComboBox cbTorneos;
        private Label label1;
        private Button btnAgregarPartido;
        private Button btnElimnarPartido;
        private Button btnRegresar;
        private Button btnEliminarTorneo;
        private Button btnBorrarDatos;
    }
}