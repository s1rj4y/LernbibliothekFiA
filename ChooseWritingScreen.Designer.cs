namespace LernbibliothekFiA
{
    partial class ChooseWritingScreen
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
            this.btnChooseLF = new System.Windows.Forms.Button();
            this.btnChooseThemen = new System.Windows.Forms.Button();
            this.btnChooseGK = new System.Windows.Forms.Button();
            this.btnChooseBegriffe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseLF
            // 
            this.btnChooseLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnChooseLF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseLF.ForeColor = System.Drawing.Color.White;
            this.btnChooseLF.Location = new System.Drawing.Point(12, 12);
            this.btnChooseLF.Name = "btnChooseLF";
            this.btnChooseLF.Size = new System.Drawing.Size(600, 63);
            this.btnChooseLF.TabIndex = 0;
            this.btnChooseLF.Text = "Lernfelder";
            this.btnChooseLF.UseVisualStyleBackColor = false;
            this.btnChooseLF.Click += new System.EventHandler(this.btnChooseLF_Click);
            // 
            // btnChooseThemen
            // 
            this.btnChooseThemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnChooseThemen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseThemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseThemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseThemen.ForeColor = System.Drawing.Color.White;
            this.btnChooseThemen.Location = new System.Drawing.Point(12, 93);
            this.btnChooseThemen.Name = "btnChooseThemen";
            this.btnChooseThemen.Size = new System.Drawing.Size(600, 63);
            this.btnChooseThemen.TabIndex = 1;
            this.btnChooseThemen.Text = "Themen";
            this.btnChooseThemen.UseVisualStyleBackColor = false;
            this.btnChooseThemen.Click += new System.EventHandler(this.btnChooseThemen_Click);
            // 
            // btnChooseGK
            // 
            this.btnChooseGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnChooseGK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseGK.ForeColor = System.Drawing.Color.White;
            this.btnChooseGK.Location = new System.Drawing.Point(12, 172);
            this.btnChooseGK.Name = "btnChooseGK";
            this.btnChooseGK.Size = new System.Drawing.Size(600, 63);
            this.btnChooseGK.TabIndex = 2;
            this.btnChooseGK.Text = "Grundkompetenzen";
            this.btnChooseGK.UseVisualStyleBackColor = false;
            this.btnChooseGK.Click += new System.EventHandler(this.btnChooseGK_Click);
            // 
            // btnChooseBegriffe
            // 
            this.btnChooseBegriffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnChooseBegriffe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseBegriffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseBegriffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseBegriffe.ForeColor = System.Drawing.Color.White;
            this.btnChooseBegriffe.Location = new System.Drawing.Point(12, 251);
            this.btnChooseBegriffe.Name = "btnChooseBegriffe";
            this.btnChooseBegriffe.Size = new System.Drawing.Size(600, 63);
            this.btnChooseBegriffe.TabIndex = 3;
            this.btnChooseBegriffe.Text = "Begriffe";
            this.btnChooseBegriffe.UseVisualStyleBackColor = false;
            this.btnChooseBegriffe.Click += new System.EventHandler(this.btnChooseBegriffe_Click);
            // 
            // ChooseWritingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(624, 326);
            this.Controls.Add(this.btnChooseBegriffe);
            this.Controls.Add(this.btnChooseGK);
            this.Controls.Add(this.btnChooseThemen);
            this.Controls.Add(this.btnChooseLF);
            this.MaximizeBox = false;
            this.Name = "ChooseWritingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseWritingScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseLF;
        private System.Windows.Forms.Button btnChooseThemen;
        private System.Windows.Forms.Button btnChooseGK;
        private System.Windows.Forms.Button btnChooseBegriffe;
    }
}