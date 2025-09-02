namespace LernbibliothekFiA
{
    partial class WelcomeScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.btnEnterLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterLogin
            // 
            this.btnEnterLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterLogin.FlatAppearance.BorderSize = 0;
            this.btnEnterLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEnterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnterLogin.Location = new System.Drawing.Point(255, 245);
            this.btnEnterLogin.Name = "btnEnterLogin";
            this.btnEnterLogin.Size = new System.Drawing.Size(131, 229);
            this.btnEnterLogin.TabIndex = 0;
            this.btnEnterLogin.UseVisualStyleBackColor = false;
            this.btnEnterLogin.Click += new System.EventHandler(this.btnEnterLogin_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.btnEnterLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Willkommen, in der Lernbibliothek für Fachinformatiker!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterLogin;
    }
}

