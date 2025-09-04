namespace LernbibliothekFiA
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.btnWritingScreen = new System.Windows.Forms.Button();
            this.btnReadingScreen = new System.Windows.Forms.Button();
            this.lblWriting = new System.Windows.Forms.Label();
            this.lblReading = new System.Windows.Forms.Label();
            this.btnRtnLoginScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWritingScreen
            // 
            this.btnWritingScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWritingScreen.BackgroundImage")));
            this.btnWritingScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWritingScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWritingScreen.Location = new System.Drawing.Point(12, 12);
            this.btnWritingScreen.Name = "btnWritingScreen";
            this.btnWritingScreen.Size = new System.Drawing.Size(266, 266);
            this.btnWritingScreen.TabIndex = 0;
            this.btnWritingScreen.UseVisualStyleBackColor = true;
            this.btnWritingScreen.Click += new System.EventHandler(this.btnWritingScreen_Click);
            // 
            // btnReadingScreen
            // 
            this.btnReadingScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReadingScreen.BackgroundImage")));
            this.btnReadingScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadingScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadingScreen.Location = new System.Drawing.Point(346, 12);
            this.btnReadingScreen.Name = "btnReadingScreen";
            this.btnReadingScreen.Size = new System.Drawing.Size(266, 266);
            this.btnReadingScreen.TabIndex = 1;
            this.btnReadingScreen.UseVisualStyleBackColor = true;
            this.btnReadingScreen.Click += new System.EventHandler(this.btnReadingScreen_Click);
            // 
            // lblWriting
            // 
            this.lblWriting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblWriting.AutoSize = true;
            this.lblWriting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriting.ForeColor = System.Drawing.Color.White;
            this.lblWriting.Location = new System.Drawing.Point(12, 281);
            this.lblWriting.Name = "lblWriting";
            this.lblWriting.Size = new System.Drawing.Size(106, 24);
            this.lblWriting.TabIndex = 2;
            this.lblWriting.Text = "Schreiben";
            // 
            // lblReading
            // 
            this.lblReading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReading.AutoSize = true;
            this.lblReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReading.ForeColor = System.Drawing.Color.White;
            this.lblReading.Location = new System.Drawing.Point(545, 281);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(67, 24);
            this.lblReading.TabIndex = 3;
            this.lblReading.Text = "Lesen";
            // 
            // btnRtnLoginScreen
            // 
            this.btnRtnLoginScreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRtnLoginScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRtnLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtnLoginScreen.ForeColor = System.Drawing.Color.White;
            this.btnRtnLoginScreen.Location = new System.Drawing.Point(224, 288);
            this.btnRtnLoginScreen.Name = "btnRtnLoginScreen";
            this.btnRtnLoginScreen.Size = new System.Drawing.Size(176, 32);
            this.btnRtnLoginScreen.TabIndex = 37;
            this.btnRtnLoginScreen.Text = "Benutzer wechseln";
            this.btnRtnLoginScreen.UseVisualStyleBackColor = false;
            this.btnRtnLoginScreen.Click += new System.EventHandler(this.btnRtnLoginScreen_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(625, 326);
            this.Controls.Add(this.btnRtnLoginScreen);
            this.Controls.Add(this.lblReading);
            this.Controls.Add(this.lblWriting);
            this.Controls.Add(this.btnReadingScreen);
            this.Controls.Add(this.btnWritingScreen);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWritingScreen;
        private System.Windows.Forms.Button btnReadingScreen;
        private System.Windows.Forms.Label lblWriting;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.Button btnRtnLoginScreen;
    }
}