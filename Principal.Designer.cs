namespace FutBol_Torneos_Management
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            btnCrearTorneo = new Button();
            btnCrearEquipo = new Button();
            btn_AdminJugadores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(210, 24);
            label1.Name = "label1";
            label1.Size = new Size(218, 63);
            label1.TabIndex = 0;
            label1.Text = "FUTBOL Torneos Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCrearTorneo
            // 
            btnCrearTorneo.BackColor = SystemColors.ActiveCaptionText;
            btnCrearTorneo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCrearTorneo.ForeColor = SystemColors.ButtonHighlight;
            btnCrearTorneo.Location = new Point(12, 90);
            btnCrearTorneo.Name = "btnCrearTorneo";
            btnCrearTorneo.Size = new Size(91, 26);
            btnCrearTorneo.TabIndex = 1;
            btnCrearTorneo.Text = "TORNEOS";
            btnCrearTorneo.UseVisualStyleBackColor = false;
            btnCrearTorneo.Click += btnCrearTorneo_Click;
            // 
            // btnCrearEquipo
            // 
            btnCrearEquipo.BackColor = SystemColors.ActiveCaptionText;
            btnCrearEquipo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCrearEquipo.ForeColor = SystemColors.ButtonHighlight;
            btnCrearEquipo.Location = new Point(109, 90);
            btnCrearEquipo.Name = "btnCrearEquipo";
            btnCrearEquipo.Size = new Size(91, 26);
            btnCrearEquipo.TabIndex = 2;
            btnCrearEquipo.Text = "EQUIPOS";
            btnCrearEquipo.UseVisualStyleBackColor = false;
            btnCrearEquipo.Click += btnCrearEquipo_Click;
            // 
            // btn_AdminJugadores
            // 
            btn_AdminJugadores.BackColor = SystemColors.ActiveCaptionText;
            btn_AdminJugadores.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_AdminJugadores.ForeColor = SystemColors.ButtonHighlight;
            btn_AdminJugadores.Location = new Point(206, 90);
            btn_AdminJugadores.Name = "btn_AdminJugadores";
            btn_AdminJugadores.Size = new Size(109, 26);
            btn_AdminJugadores.TabIndex = 3;
            btn_AdminJugadores.Text = "JUGADORES";
            btn_AdminJugadores.UseVisualStyleBackColor = false;
            btn_AdminJugadores.Click += btn_AdminJugadores_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(430, 148);
            Controls.Add(btn_AdminJugadores);
            Controls.Add(btnCrearEquipo);
            Controls.Add(btnCrearTorneo);
            Controls.Add(label1);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FUTBOL Torneos Management";
            Load += Principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCrearTorneo;
        private Button btnCrearEquipo;
        private Button btn_AdminJugadores;
    }
}