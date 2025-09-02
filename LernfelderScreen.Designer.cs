namespace LernbibliothekFiA
{
    partial class LernfelderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LernfelderScreen));
            this.btnRtnLF2Menu = new System.Windows.Forms.Button();
            this.lblLFNr = new System.Windows.Forms.Label();
            this.txtBoxLFBez = new System.Windows.Forms.TextBox();
            this.lblLFBez = new System.Windows.Forms.Label();
            this.lblLFDatum = new System.Windows.Forms.Label();
            this.datePickerLF = new System.Windows.Forms.DateTimePicker();
            this.lblLFBeschr = new System.Windows.Forms.Label();
            this.richTextBoxLFBeschr = new System.Windows.Forms.RichTextBox();
            this.btnAddLF = new System.Windows.Forms.Button();
            this.btnDeleteLF = new System.Windows.Forms.Button();
            this.btnEditLF = new System.Windows.Forms.Button();
            this.btnClearLF = new System.Windows.Forms.Button();
            this.txtBoxLFNr = new System.Windows.Forms.TextBox();
            this.dataGridViewShowLF = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowLF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRtnLF2Menu
            // 
            this.btnRtnLF2Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRtnLF2Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRtnLF2Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtnLF2Menu.ForeColor = System.Drawing.Color.White;
            this.btnRtnLF2Menu.Location = new System.Drawing.Point(921, 12);
            this.btnRtnLF2Menu.Name = "btnRtnLF2Menu";
            this.btnRtnLF2Menu.Size = new System.Drawing.Size(75, 23);
            this.btnRtnLF2Menu.TabIndex = 0;
            this.btnRtnLF2Menu.Text = "Zurück";
            this.btnRtnLF2Menu.UseVisualStyleBackColor = false;
            this.btnRtnLF2Menu.Click += new System.EventHandler(this.btnRtnLF2Menu_Click);
            // 
            // lblLFNr
            // 
            this.lblLFNr.AutoSize = true;
            this.lblLFNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblLFNr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLFNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLFNr.ForeColor = System.Drawing.Color.White;
            this.lblLFNr.Location = new System.Drawing.Point(12, 42);
            this.lblLFNr.Name = "lblLFNr";
            this.lblLFNr.Size = new System.Drawing.Size(69, 20);
            this.lblLFNr.TabIndex = 1;
            this.lblLFNr.Text = "Nummer";
            // 
            // txtBoxLFBez
            // 
            this.txtBoxLFBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxLFBez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLFBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLFBez.ForeColor = System.Drawing.Color.White;
            this.txtBoxLFBez.Location = new System.Drawing.Point(174, 78);
            this.txtBoxLFBez.Name = "txtBoxLFBez";
            this.txtBoxLFBez.Size = new System.Drawing.Size(741, 23);
            this.txtBoxLFBez.TabIndex = 2;
            // 
            // lblLFBez
            // 
            this.lblLFBez.AutoSize = true;
            this.lblLFBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblLFBez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLFBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLFBez.ForeColor = System.Drawing.Color.White;
            this.lblLFBez.Location = new System.Drawing.Point(13, 78);
            this.lblLFBez.Name = "lblLFBez";
            this.lblLFBez.Size = new System.Drawing.Size(102, 20);
            this.lblLFBez.TabIndex = 4;
            this.lblLFBez.Text = "Bezeichnung";
            // 
            // lblLFDatum
            // 
            this.lblLFDatum.AutoSize = true;
            this.lblLFDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblLFDatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLFDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLFDatum.ForeColor = System.Drawing.Color.White;
            this.lblLFDatum.Location = new System.Drawing.Point(12, 112);
            this.lblLFDatum.Name = "lblLFDatum";
            this.lblLFDatum.Size = new System.Drawing.Size(89, 20);
            this.lblLFDatum.TabIndex = 5;
            this.lblLFDatum.Text = "Startdatum";
            // 
            // datePickerLF
            // 
            this.datePickerLF.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datePickerLF.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.datePickerLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerLF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerLF.Location = new System.Drawing.Point(174, 112);
            this.datePickerLF.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerLF.Name = "datePickerLF";
            this.datePickerLF.Size = new System.Drawing.Size(108, 23);
            this.datePickerLF.TabIndex = 6;
            this.datePickerLF.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // lblLFBeschr
            // 
            this.lblLFBeschr.AutoSize = true;
            this.lblLFBeschr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblLFBeschr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLFBeschr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLFBeschr.ForeColor = System.Drawing.Color.White;
            this.lblLFBeschr.Location = new System.Drawing.Point(12, 147);
            this.lblLFBeschr.Name = "lblLFBeschr";
            this.lblLFBeschr.Size = new System.Drawing.Size(107, 20);
            this.lblLFBeschr.TabIndex = 7;
            this.lblLFBeschr.Text = "Beschreibung";
            // 
            // richTextBoxLFBeschr
            // 
            this.richTextBoxLFBeschr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBoxLFBeschr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLFBeschr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxLFBeschr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLFBeschr.ForeColor = System.Drawing.Color.White;
            this.richTextBoxLFBeschr.Location = new System.Drawing.Point(174, 147);
            this.richTextBoxLFBeschr.Name = "richTextBoxLFBeschr";
            this.richTextBoxLFBeschr.Size = new System.Drawing.Size(741, 130);
            this.richTextBoxLFBeschr.TabIndex = 8;
            this.richTextBoxLFBeschr.Text = "";
            // 
            // btnAddLF
            // 
            this.btnAddLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLF.ForeColor = System.Drawing.Color.White;
            this.btnAddLF.Location = new System.Drawing.Point(12, 290);
            this.btnAddLF.Name = "btnAddLF";
            this.btnAddLF.Size = new System.Drawing.Size(75, 23);
            this.btnAddLF.TabIndex = 27;
            this.btnAddLF.Text = "Hinzufügen";
            this.btnAddLF.UseVisualStyleBackColor = false;
            this.btnAddLF.Click += new System.EventHandler(this.btnAddLF_Click);
            // 
            // btnDeleteLF
            // 
            this.btnDeleteLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLF.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLF.Location = new System.Drawing.Point(93, 290);
            this.btnDeleteLF.Name = "btnDeleteLF";
            this.btnDeleteLF.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLF.TabIndex = 28;
            this.btnDeleteLF.Text = "Entfernen";
            this.btnDeleteLF.UseVisualStyleBackColor = false;
            this.btnDeleteLF.Click += new System.EventHandler(this.btnDeleteLF_Click);
            // 
            // btnEditLF
            // 
            this.btnEditLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLF.ForeColor = System.Drawing.Color.White;
            this.btnEditLF.Location = new System.Drawing.Point(174, 290);
            this.btnEditLF.Name = "btnEditLF";
            this.btnEditLF.Size = new System.Drawing.Size(75, 23);
            this.btnEditLF.TabIndex = 29;
            this.btnEditLF.Text = "Editieren";
            this.btnEditLF.UseVisualStyleBackColor = false;
            this.btnEditLF.Click += new System.EventHandler(this.btnEditLF_Click);
            // 
            // btnClearLF
            // 
            this.btnClearLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClearLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLF.ForeColor = System.Drawing.Color.White;
            this.btnClearLF.Location = new System.Drawing.Point(255, 290);
            this.btnClearLF.Name = "btnClearLF";
            this.btnClearLF.Size = new System.Drawing.Size(87, 23);
            this.btnClearLF.TabIndex = 30;
            this.btnClearLF.Text = "Felder leeren";
            this.btnClearLF.UseVisualStyleBackColor = false;
            this.btnClearLF.Click += new System.EventHandler(this.btnClearLF_Click);
            // 
            // txtBoxLFNr
            // 
            this.txtBoxLFNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxLFNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLFNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLFNr.ForeColor = System.Drawing.Color.White;
            this.txtBoxLFNr.Location = new System.Drawing.Point(174, 42);
            this.txtBoxLFNr.Name = "txtBoxLFNr";
            this.txtBoxLFNr.Size = new System.Drawing.Size(108, 22);
            this.txtBoxLFNr.TabIndex = 31;
            // 
            // dataGridViewShowLF
            // 
            this.dataGridViewShowLF.AllowUserToAddRows = false;
            this.dataGridViewShowLF.AllowUserToDeleteRows = false;
            this.dataGridViewShowLF.AllowUserToResizeColumns = false;
            this.dataGridViewShowLF.AllowUserToResizeRows = false;
            this.dataGridViewShowLF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowLF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowLF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowLF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowLF.Location = new System.Drawing.Point(12, 319);
            this.dataGridViewShowLF.MultiSelect = false;
            this.dataGridViewShowLF.Name = "dataGridViewShowLF";
            this.dataGridViewShowLF.ReadOnly = true;
            this.dataGridViewShowLF.RowHeadersVisible = false;
            this.dataGridViewShowLF.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowLF.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewShowLF.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dataGridViewShowLF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowLF.Size = new System.Drawing.Size(903, 396);
            this.dataGridViewShowLF.TabIndex = 32;
            this.dataGridViewShowLF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowLF_CellContentClick);
            // 
            // LernfelderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridViewShowLF);
            this.Controls.Add(this.txtBoxLFNr);
            this.Controls.Add(this.btnClearLF);
            this.Controls.Add(this.btnEditLF);
            this.Controls.Add(this.btnDeleteLF);
            this.Controls.Add(this.btnAddLF);
            this.Controls.Add(this.richTextBoxLFBeschr);
            this.Controls.Add(this.lblLFBeschr);
            this.Controls.Add(this.datePickerLF);
            this.Controls.Add(this.lblLFDatum);
            this.Controls.Add(this.lblLFBez);
            this.Controls.Add(this.txtBoxLFBez);
            this.Controls.Add(this.lblLFNr);
            this.Controls.Add(this.btnRtnLF2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LernfelderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lernfelder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowLF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRtnLF2Menu;
        private System.Windows.Forms.Label lblLFNr;
        private System.Windows.Forms.TextBox txtBoxLFBez;
        private System.Windows.Forms.Label lblLFBez;
        private System.Windows.Forms.Label lblLFDatum;
        private System.Windows.Forms.DateTimePicker datePickerLF;
        private System.Windows.Forms.Label lblLFBeschr;
        private System.Windows.Forms.RichTextBox richTextBoxLFBeschr;
        private System.Windows.Forms.Button btnAddLF;
        private System.Windows.Forms.Button btnDeleteLF;
        private System.Windows.Forms.Button btnEditLF;
        private System.Windows.Forms.Button btnClearLF;
        private System.Windows.Forms.TextBox txtBoxLFNr;
        private System.Windows.Forms.DataGridView dataGridViewShowLF;
    }
}