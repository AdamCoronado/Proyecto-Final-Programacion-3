namespace FutBol_Torneos_Management
{
    partial class Form_Torneos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Torneos));
            btnNuevoTorneo = new Button();
            btnAdminTorneo = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnNuevoTorneo
            // 
            btnNuevoTorneo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevoTorneo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnNuevoTorneo.ForeColor = Color.White;
            btnNuevoTorneo.Location = new Point(12, 69);
            btnNuevoTorneo.Name = "btnNuevoTorneo";
            btnNuevoTorneo.Size = new Size(92, 40);
            btnNuevoTorneo.TabIndex = 0;
            btnNuevoTorneo.Text = "Nuevo Torneo";
            btnNuevoTorneo.UseVisualStyleBackColor = false;
            btnNuevoTorneo.Click += btnNuevoTorneo_Click;
            // 
            // btnAdminTorneo
            // 
            btnAdminTorneo.BackColor = SystemColors.ActiveCaptionText;
            btnAdminTorneo.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdminTorneo.ForeColor = Color.White;
            btnAdminTorneo.Location = new Point(251, 68);
            btnAdminTorneo.Name = "btnAdminTorneo";
            btnAdminTorneo.Size = new Size(91, 41);
            btnAdminTorneo.TabIndex = 1;
            btnAdminTorneo.Text = "Administrar Torneo";
            btnAdminTorneo.UseVisualStyleBackColor = false;
            btnAdminTorneo.Click += btnAdminTorneo_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.ActiveCaptionText;
            btnRegresar.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.FromArgb(255, 128, 128);
            btnRegresar.Location = new Point(276, 165);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Form_Torneos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(355, 190);
            Controls.Add(btnRegresar);
            Controls.Add(btnAdminTorneo);
            Controls.Add(btnNuevoTorneo);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form_Torneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Torneos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoTorneo;
        private Button btnAdminTorneo;
        private Button btnRegresar;
    }
}