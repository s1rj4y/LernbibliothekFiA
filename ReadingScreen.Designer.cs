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
            this.dataGridViewShowBegriffe = new System.Windows.Forms.DataGridView();
            this.lblShowBegriff = new System.Windows.Forms.Label();
            this.txtBoxBegriffRO = new System.Windows.Forms.TextBox();
            this.richTextBoxBegriffDefRO = new System.Windows.Forms.RichTextBox();
            this.textBoxLFRO = new System.Windows.Forms.TextBox();
            this.lblShowLF = new System.Windows.Forms.Label();
            this.textBoxThemaRO = new System.Windows.Forms.TextBox();
            this.lblShowThema = new System.Windows.Forms.Label();
            this.textBoxGKRO = new System.Windows.Forms.TextBox();
            this.lblShowGK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBegriffe)).BeginInit();
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
            // dataGridViewShowBegriffe
            // 
            this.dataGridViewShowBegriffe.AllowUserToAddRows = false;
            this.dataGridViewShowBegriffe.AllowUserToDeleteRows = false;
            this.dataGridViewShowBegriffe.AllowUserToResizeColumns = false;
            this.dataGridViewShowBegriffe.AllowUserToResizeRows = false;
            this.dataGridViewShowBegriffe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowBegriffe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowBegriffe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowBegriffe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowBegriffe.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewShowBegriffe.MultiSelect = false;
            this.dataGridViewShowBegriffe.Name = "dataGridViewShowBegriffe";
            this.dataGridViewShowBegriffe.ReadOnly = true;
            this.dataGridViewShowBegriffe.RowHeadersVisible = false;
            this.dataGridViewShowBegriffe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowBegriffe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewShowBegriffe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dataGridViewShowBegriffe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowBegriffe.Size = new System.Drawing.Size(334, 360);
            this.dataGridViewShowBegriffe.TabIndex = 48;
            this.dataGridViewShowBegriffe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowBegriffe_CellContentClick);
            // 
            // lblShowBegriff
            // 
            this.lblShowBegriff.AutoSize = true;
            this.lblShowBegriff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblShowBegriff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShowBegriff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowBegriff.ForeColor = System.Drawing.Color.White;
            this.lblShowBegriff.Location = new System.Drawing.Point(371, 223);
            this.lblShowBegriff.Name = "lblShowBegriff";
            this.lblShowBegriff.Size = new System.Drawing.Size(56, 20);
            this.lblShowBegriff.TabIndex = 50;
            this.lblShowBegriff.Text = "Begriff";
            // 
            // txtBoxBegriffRO
            // 
            this.txtBoxBegriffRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxBegriffRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxBegriffRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBegriffRO.ForeColor = System.Drawing.Color.White;
            this.txtBoxBegriffRO.Location = new System.Drawing.Point(510, 223);
            this.txtBoxBegriffRO.Name = "txtBoxBegriffRO";
            this.txtBoxBegriffRO.ReadOnly = true;
            this.txtBoxBegriffRO.Size = new System.Drawing.Size(405, 23);
            this.txtBoxBegriffRO.TabIndex = 51;
            // 
            // richTextBoxBegriffDefRO
            // 
            this.richTextBoxBegriffDefRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBoxBegriffDefRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxBegriffDefRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBegriffDefRO.ForeColor = System.Drawing.Color.White;
            this.richTextBoxBegriffDefRO.Location = new System.Drawing.Point(12, 440);
            this.richTextBoxBegriffDefRO.Name = "richTextBoxBegriffDefRO";
            this.richTextBoxBegriffDefRO.ReadOnly = true;
            this.richTextBoxBegriffDefRO.Size = new System.Drawing.Size(903, 277);
            this.richTextBoxBegriffDefRO.TabIndex = 52;
            this.richTextBoxBegriffDefRO.Text = "";
            // 
            // textBoxLFRO
            // 
            this.textBoxLFRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBoxLFRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLFRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLFRO.ForeColor = System.Drawing.Color.White;
            this.textBoxLFRO.Location = new System.Drawing.Point(510, 276);
            this.textBoxLFRO.Name = "textBoxLFRO";
            this.textBoxLFRO.ReadOnly = true;
            this.textBoxLFRO.Size = new System.Drawing.Size(405, 23);
            this.textBoxLFRO.TabIndex = 54;
            // 
            // lblShowLF
            // 
            this.lblShowLF.AutoSize = true;
            this.lblShowLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblShowLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShowLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLF.ForeColor = System.Drawing.Color.White;
            this.lblShowLF.Location = new System.Drawing.Point(371, 276);
            this.lblShowLF.Name = "lblShowLF";
            this.lblShowLF.Size = new System.Drawing.Size(67, 20);
            this.lblShowLF.TabIndex = 53;
            this.lblShowLF.Text = "Lernfeld";
            // 
            // textBoxThemaRO
            // 
            this.textBoxThemaRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBoxThemaRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxThemaRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThemaRO.ForeColor = System.Drawing.Color.White;
            this.textBoxThemaRO.Location = new System.Drawing.Point(510, 331);
            this.textBoxThemaRO.Name = "textBoxThemaRO";
            this.textBoxThemaRO.ReadOnly = true;
            this.textBoxThemaRO.Size = new System.Drawing.Size(405, 23);
            this.textBoxThemaRO.TabIndex = 56;
            // 
            // lblShowThema
            // 
            this.lblShowThema.AutoSize = true;
            this.lblShowThema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblShowThema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShowThema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowThema.ForeColor = System.Drawing.Color.White;
            this.lblShowThema.Location = new System.Drawing.Point(371, 331);
            this.lblShowThema.Name = "lblShowThema";
            this.lblShowThema.Size = new System.Drawing.Size(58, 20);
            this.lblShowThema.TabIndex = 55;
            this.lblShowThema.Text = "Thema";
            // 
            // textBoxGKRO
            // 
            this.textBoxGKRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBoxGKRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGKRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGKRO.ForeColor = System.Drawing.Color.White;
            this.textBoxGKRO.Location = new System.Drawing.Point(510, 383);
            this.textBoxGKRO.Name = "textBoxGKRO";
            this.textBoxGKRO.ReadOnly = true;
            this.textBoxGKRO.Size = new System.Drawing.Size(405, 23);
            this.textBoxGKRO.TabIndex = 58;
            // 
            // lblShowGK
            // 
            this.lblShowGK.AutoSize = true;
            this.lblShowGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblShowGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblShowGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowGK.ForeColor = System.Drawing.Color.White;
            this.lblShowGK.Location = new System.Drawing.Point(371, 386);
            this.lblShowGK.Name = "lblShowGK";
            this.lblShowGK.Size = new System.Drawing.Size(133, 20);
            this.lblShowGK.TabIndex = 57;
            this.lblShowGK.Text = "Grundkompetenz";
            // 
            // ReadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.textBoxGKRO);
            this.Controls.Add(this.lblShowGK);
            this.Controls.Add(this.textBoxThemaRO);
            this.Controls.Add(this.lblShowThema);
            this.Controls.Add(this.textBoxLFRO);
            this.Controls.Add(this.lblShowLF);
            this.Controls.Add(this.richTextBoxBegriffDefRO);
            this.Controls.Add(this.txtBoxBegriffRO);
            this.Controls.Add(this.lblShowBegriff);
            this.Controls.Add(this.dataGridViewShowBegriffe);
            this.Controls.Add(this.btnRtnReading2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lernbibliothek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBegriffe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRtnReading2Menu;
        private System.Windows.Forms.DataGridView dataGridViewShowBegriffe;
        private System.Windows.Forms.Label lblShowBegriff;
        private System.Windows.Forms.TextBox txtBoxBegriffRO;
        private System.Windows.Forms.RichTextBox richTextBoxBegriffDefRO;
        private System.Windows.Forms.TextBox textBoxLFRO;
        private System.Windows.Forms.Label lblShowLF;
        private System.Windows.Forms.TextBox textBoxThemaRO;
        private System.Windows.Forms.Label lblShowThema;
        private System.Windows.Forms.TextBox textBoxGKRO;
        private System.Windows.Forms.Label lblShowGK;
    }
}