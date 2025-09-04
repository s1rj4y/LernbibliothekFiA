namespace LernbibliothekFiA
{
    partial class LoginScreen
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
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxUserPW = new System.Windows.Forms.TextBox();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserName.ForeColor = System.Drawing.Color.White;
            this.txtBoxUserName.Location = new System.Drawing.Point(224, 104);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(180, 26);
            this.txtBoxUserName.TabIndex = 32;
            this.txtBoxUserName.Text = "Benutzername";
            this.txtBoxUserName.Enter += new System.EventHandler(this.txtBoxUserName_Enter);
            this.txtBoxUserName.Leave += new System.EventHandler(this.txtBoxUserName_Leave);
            // 
            // txtBoxUserPW
            // 
            this.txtBoxUserPW.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxUserPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxUserPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUserPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserPW.ForeColor = System.Drawing.Color.White;
            this.txtBoxUserPW.Location = new System.Drawing.Point(224, 152);
            this.txtBoxUserPW.Name = "txtBoxUserPW";
            this.txtBoxUserPW.Size = new System.Drawing.Size(180, 26);
            this.txtBoxUserPW.TabIndex = 33;
            this.txtBoxUserPW.Text = "Passwort";
            this.txtBoxUserPW.Enter += new System.EventHandler(this.txtBoxUserPW_Enter);
            this.txtBoxUserPW.Leave += new System.EventHandler(this.txtBoxUserPW_Leave);
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUserCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUserCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserCreate.ForeColor = System.Drawing.Color.White;
            this.btnUserCreate.Location = new System.Drawing.Point(224, 198);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(75, 23);
            this.btnUserCreate.TabIndex = 34;
            this.btnUserCreate.Text = "Registrieren";
            this.btnUserCreate.UseVisualStyleBackColor = false;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogin.ForeColor = System.Drawing.Color.White;
            this.btnUserLogin.Location = new System.Drawing.Point(329, 198);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(75, 23);
            this.btnUserLogin.TabIndex = 35;
            this.btnUserLogin.Text = "Login";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.ForeColor = System.Drawing.Color.White;
            this.btnUserDelete.Location = new System.Drawing.Point(224, 227);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(180, 23);
            this.btnUserDelete.TabIndex = 36;
            this.btnUserDelete.Text = "Profil löschen";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(625, 326);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.btnUserCreate);
            this.Controls.Add(this.txtBoxUserPW);
            this.Controls.Add(this.txtBoxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.LoginScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxUserPW;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnUserDelete;
    }
}