namespace FutBol_Torneos_Management
{
    partial class Form_Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Equipos));
            btnNuevoEquipo = new Button();
            btnModificarEquipo = new Button();
            btnEliminarEquipo = new Button();
            gbInfoEquipo = new GroupBox();
            txtbPartidosEmpatados = new TextBox();
            txtbGolesContra = new TextBox();
            txtbGolesMarcados = new TextBox();
            txtbEntrenador = new TextBox();
            txtbPartidosPerdidos = new TextBox();
            txtbPartidosGanados = new TextBox();
            txtbPartidosJugados = new TextBox();
            txtbPaisOrigen = new TextBox();
            txtbNombreEquipo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbBuscar = new ComboBox();
            btnBuscarEquipo = new Button();
            button1 = new Button();
            gbInfoEquipo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoEquipo
            // 
            btnNuevoEquipo.BackColor = SystemColors.ButtonFace;
            btnNuevoEquipo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnNuevoEquipo.ForeColor = Color.DarkGreen;
            btnNuevoEquipo.Location = new Point(58, 188);
            btnNuevoEquipo.Name = "btnNuevoEquipo";
            btnNuevoEquipo.Size = new Size(109, 23);
            btnNuevoEquipo.TabIndex = 0;
            btnNuevoEquipo.Text = "Nuevo Equipo";
            btnNuevoEquipo.UseVisualStyleBackColor = false;
            btnNuevoEquipo.Click += btnNuevoEquipo_Click;
            // 
            // btnModificarEquipo
            // 
            btnModificarEquipo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnModificarEquipo.ForeColor = Color.Navy;
            btnModificarEquipo.Location = new Point(189, 188);
            btnModificarEquipo.Name = "btnModificarEquipo";
            btnModificarEquipo.Size = new Size(125, 23);
            btnModificarEquipo.TabIndex = 1;
            btnModificarEquipo.Text = "Modificar Equipo";
            btnModificarEquipo.UseVisualStyleBackColor = true;
            btnModificarEquipo.Click += btnModificarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarEquipo.ForeColor = Color.FromArgb(192, 0, 0);
            btnEliminarEquipo.Location = new Point(331, 188);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(113, 24);
            btnEliminarEquipo.TabIndex = 2;
            btnEliminarEquipo.Text = "Eliminar Equipo";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // gbInfoEquipo
            // 
            gbInfoEquipo.BackColor = Color.Transparent;
            gbInfoEquipo.Controls.Add(txtbPartidosEmpatados);
            gbInfoEquipo.Controls.Add(txtbGolesContra);
            gbInfoEquipo.Controls.Add(txtbGolesMarcados);
            gbInfoEquipo.Controls.Add(txtbEntrenador);
            gbInfoEquipo.Controls.Add(txtbPartidosPerdidos);
            gbInfoEquipo.Controls.Add(txtbPartidosGanados);
            gbInfoEquipo.Controls.Add(txtbPartidosJugados);
            gbInfoEquipo.Controls.Add(txtbPaisOrigen);
            gbInfoEquipo.Controls.Add(txtbNombreEquipo);
            gbInfoEquipo.Controls.Add(label9);
            gbInfoEquipo.Controls.Add(label8);
            gbInfoEquipo.Controls.Add(label7);
            gbInfoEquipo.Controls.Add(label6);
            gbInfoEquipo.Controls.Add(label5);
            gbInfoEquipo.Controls.Add(label4);
            gbInfoEquipo.Controls.Add(label3);
            gbInfoEquipo.Controls.Add(label2);
            gbInfoEquipo.Controls.Add(label1);
            gbInfoEquipo.FlatStyle = FlatStyle.Popup;
            gbInfoEquipo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            gbInfoEquipo.ForeColor = SystemColors.Window;
            gbInfoEquipo.Location = new Point(12, 12);
            gbInfoEquipo.Name = "gbInfoEquipo";
            gbInfoEquipo.Size = new Size(449, 168);
            gbInfoEquipo.TabIndex = 3;
            gbInfoEquipo.TabStop = false;
            gbInfoEquipo.Text = "Informacion del Equipo";
            // 
            // txtbPartidosEmpatados
            // 
            txtbPartidosEmpatados.Location = new Point(388, 131);
            txtbPartidosEmpatados.Name = "txtbPartidosEmpatados";
            txtbPartidosEmpatados.Size = new Size(44, 22);
            txtbPartidosEmpatados.TabIndex = 17;
            // 
            // txtbGolesContra
            // 
            txtbGolesContra.Location = new Point(388, 107);
            txtbGolesContra.Name = "txtbGolesContra";
            txtbGolesContra.Size = new Size(44, 22);
            txtbGolesContra.TabIndex = 16;
            // 
            // txtbGolesMarcados
            // 
            txtbGolesMarcados.Location = new Point(388, 82);
            txtbGolesMarcados.Name = "txtbGolesMarcados";
            txtbGolesMarcados.Size = new Size(44, 22);
            txtbGolesMarcados.TabIndex = 15;
            // 
            // txtbEntrenador
            // 
            txtbEntrenador.Location = new Point(319, 51);
            txtbEntrenador.Name = "txtbEntrenador";
            txtbEntrenador.Size = new Size(92, 22);
            txtbEntrenador.TabIndex = 14;
            // 
            // txtbPartidosPerdidos
            // 
            txtbPartidosPerdidos.Location = new Point(153, 131);
            txtbPartidosPerdidos.Name = "txtbPartidosPerdidos";
            txtbPartidosPerdidos.Size = new Size(44, 22);
            txtbPartidosPerdidos.TabIndex = 13;
            // 
            // txtbPartidosGanados
            // 
            txtbPartidosGanados.Location = new Point(153, 107);
            txtbPartidosGanados.Name = "txtbPartidosGanados";
            txtbPartidosGanados.Size = new Size(44, 22);
            txtbPartidosGanados.TabIndex = 12;
            // 
            // txtbPartidosJugados
            // 
            txtbPartidosJugados.Location = new Point(153, 82);
            txtbPartidosJugados.Name = "txtbPartidosJugados";
            txtbPartidosJugados.Size = new Size(44, 22);
            txtbPartidosJugados.TabIndex = 11;
            // 
            // txtbPaisOrigen
            // 
            txtbPaisOrigen.Location = new Point(131, 54);
            txtbPaisOrigen.Name = "txtbPaisOrigen";
            txtbPaisOrigen.Size = new Size(84, 22);
            txtbPaisOrigen.TabIndex = 10;
            // 
            // txtbNombreEquipo
            // 
            txtbNombreEquipo.Location = new Point(97, 24);
            txtbNombreEquipo.Name = "txtbNombreEquipo";
            txtbNombreEquipo.Size = new Size(140, 22);
            txtbNombreEquipo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSteelBlue;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(236, 85);
            label9.Name = "label9";
            label9.Size = new Size(142, 16);
            label9.TabIndex = 8;
            label9.Text = "Total Goles Marcados :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSteelBlue;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(242, 110);
            label8.Name = "label8";
            label8.Size = new Size(140, 16);
            label8.TabIndex = 7;
            label8.Text = "Total Goles en Contra :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(236, 54);
            label7.Name = "label7";
            label7.Size = new Size(77, 16);
            label7.TabIndex = 6;
            label7.Text = "Entrenador :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 137);
            label6.Name = "label6";
            label6.Size = new Size(116, 16);
            label6.TabIndex = 5;
            label6.Text = "Partidos Perdidos :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSteelBlue;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(251, 134);
            label5.Name = "label5";
            label5.Size = new Size(131, 16);
            label5.TabIndex = 4;
            label5.Text = "Partidos Empatados :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 110);
            label4.Name = "label4";
            label4.Size = new Size(119, 16);
            label4.TabIndex = 3;
            label4.Text = "Partidos Ganados :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 85);
            label3.Name = "label3";
            label3.Size = new Size(115, 16);
            label3.TabIndex = 2;
            label3.Text = "Partidos Jugados :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(99, 16);
            label2.TabIndex = 1;
            label2.Text = "Pais de Origen :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cbBuscar);
            groupBox1.Controls.Add(btnBuscarEquipo);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(467, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 97);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // cbBuscar
            // 
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(6, 23);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(131, 24);
            cbBuscar.TabIndex = 1;
            // 
            // btnBuscarEquipo
            // 
            btnBuscarEquipo.ForeColor = Color.DarkCyan;
            btnBuscarEquipo.Location = new Point(20, 53);
            btnBuscarEquipo.Name = "btnBuscarEquipo";
            btnBuscarEquipo.Size = new Size(104, 26);
            btnBuscarEquipo.TabIndex = 0;
            btnBuscarEquipo.Text = "Buscar Equipo";
            btnBuscarEquipo.UseVisualStyleBackColor = true;
            btnBuscarEquipo.Click += btnBuscarEquipo_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(497, 187);
            button1.Name = "button1";
            button1.Size = new Size(113, 24);
            button1.TabIndex = 6;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Equipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(621, 226);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(gbInfoEquipo);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(btnModificarEquipo);
            Controls.Add(btnNuevoEquipo);
            Name = "Form_Equipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de Equipos";
            Load += Form_Equipos_Load;
            gbInfoEquipo.ResumeLayout(false);
            gbInfoEquipo.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoEquipo;
        private Button btnModificarEquipo;
        private Button btnEliminarEquipo;
        private GroupBox gbInfoEquipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox txtbNombreEquipo;
        private Label label9;
        private Label label8;
        private TextBox txtbPaisOrigen;
        private TextBox txtbPartidosEmpatados;
        private TextBox txtbGolesContra;
        private TextBox txtbGolesMarcados;
        private TextBox txtbEntrenador;
        private TextBox txtbPartidosPerdidos;
        private TextBox txtbPartidosGanados;
        private TextBox txtbPartidosJugados;
        private GroupBox groupBox1;
        private ComboBox cbBuscar;
        private Button btnBuscarEquipo;
        private Button button1;
    }
}