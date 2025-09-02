namespace LernbibliothekFiA
{
    partial class ReadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingScreen));
            this.btnRtnReading2Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRtnReading2Menu
            // 
            this.btnRtnReading2Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRtnReading2Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRtnReading2Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtnReading2Menu.ForeColor = System.Drawing.Color.White;
            this.btnRtnReading2Menu.Location = new System.Drawing.Point(921, 12);
            this.btnRtnReading2Menu.Name = "btnRtnReading2Menu";
            this.btnRtnReading2Menu.Size = new System.Drawing.Size(75, 23);
            this.btnRtnReading2Menu.TabIndex = 1;
            this.btnRtnReading2Menu.Text = "Return";
            this.btnRtnReading2Menu.UseVisualStyleBackColor = false;
            this.btnRtnReading2Menu.Click += new System.EventHandler(this.btnRtnReading2Menu_Click);
            // 
            // ReadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnRtnReading2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lernbibliothek";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRtnReading2Menu;
    }
}