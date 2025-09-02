namespace LernbibliothekFiA
{
    partial class GrundkompetenzenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrundkompetenzenScreen));
            this.btnRtnGK2Menu = new System.Windows.Forms.Button();
            this.txtBoxGKNr = new System.Windows.Forms.TextBox();
            this.datePickerGK = new System.Windows.Forms.DateTimePicker();
            this.lblGKDatum = new System.Windows.Forms.Label();
            this.txtBoxGKBez = new System.Windows.Forms.TextBox();
            this.lblGKBez = new System.Windows.Forms.Label();
            this.lblGKNr = new System.Windows.Forms.Label();
            this.btnClearGK = new System.Windows.Forms.Button();
            this.btnEditGK = new System.Windows.Forms.Button();
            this.btnDeleteGK = new System.Windows.Forms.Button();
            this.btnAddGK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRtnGK2Menu
            // 
            this.btnRtnGK2Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRtnGK2Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRtnGK2Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtnGK2Menu.ForeColor = System.Drawing.Color.White;
            this.btnRtnGK2Menu.Location = new System.Drawing.Point(921, 12);
            this.btnRtnGK2Menu.Name = "btnRtnGK2Menu";
            this.btnRtnGK2Menu.Size = new System.Drawing.Size(75, 23);
            this.btnRtnGK2Menu.TabIndex = 1;
            this.btnRtnGK2Menu.Text = "Zurück";
            this.btnRtnGK2Menu.UseVisualStyleBackColor = false;
            this.btnRtnGK2Menu.Click += new System.EventHandler(this.btnRtnGK2Menu_Click);
            // 
            // txtBoxGKNr
            // 
            this.txtBoxGKNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxGKNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGKNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGKNr.ForeColor = System.Drawing.Color.White;
            this.txtBoxGKNr.Location = new System.Drawing.Point(174, 43);
            this.txtBoxGKNr.Name = "txtBoxGKNr";
            this.txtBoxGKNr.Size = new System.Drawing.Size(108, 22);
            this.txtBoxGKNr.TabIndex = 38;
            // 
            // datePickerGK
            // 
            this.datePickerGK.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datePickerGK.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.datePickerGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerGK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerGK.Location = new System.Drawing.Point(174, 104);
            this.datePickerGK.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerGK.Name = "datePickerGK";
            this.datePickerGK.Size = new System.Drawing.Size(108, 23);
            this.datePickerGK.TabIndex = 37;
            this.datePickerGK.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // lblGKDatum
            // 
            this.lblGKDatum.AutoSize = true;
            this.lblGKDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblGKDatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGKDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGKDatum.ForeColor = System.Drawing.Color.White;
            this.lblGKDatum.Location = new System.Drawing.Point(12, 104);
            this.lblGKDatum.Name = "lblGKDatum";
            this.lblGKDatum.Size = new System.Drawing.Size(149, 20);
            this.lblGKDatum.TabIndex = 36;
            this.lblGKDatum.Text = "Bearbeitungsdatum";
            // 
            // txtBoxGKBez
            // 
            this.txtBoxGKBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxGKBez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGKBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGKBez.ForeColor = System.Drawing.Color.White;
            this.txtBoxGKBez.Location = new System.Drawing.Point(174, 71);
            this.txtBoxGKBez.Name = "txtBoxGKBez";
            this.txtBoxGKBez.Size = new System.Drawing.Size(741, 23);
            this.txtBoxGKBez.TabIndex = 35;
            // 
            // lblGKBez
            // 
            this.lblGKBez.AutoSize = true;
            this.lblGKBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblGKBez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGKBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGKBez.ForeColor = System.Drawing.Color.White;
            this.lblGKBez.Location = new System.Drawing.Point(12, 71);
            this.lblGKBez.Name = "lblGKBez";
            this.lblGKBez.Size = new System.Drawing.Size(102, 20);
            this.lblGKBez.TabIndex = 34;
            this.lblGKBez.Text = "Bezeichnung";
            // 
            // lblGKNr
            // 
            this.lblGKNr.AutoSize = true;
            this.lblGKNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblGKNr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGKNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGKNr.ForeColor = System.Drawing.Color.White;
            this.lblGKNr.Location = new System.Drawing.Point(12, 43);
            this.lblGKNr.Name = "lblGKNr";
            this.lblGKNr.Size = new System.Drawing.Size(69, 20);
            this.lblGKNr.TabIndex = 33;
            this.lblGKNr.Text = "Nummer";
            // 
            // btnClearGK
            // 
            this.btnClearGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClearGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearGK.ForeColor = System.Drawing.Color.White;
            this.btnClearGK.Location = new System.Drawing.Point(255, 148);
            this.btnClearGK.Name = "btnClearGK";
            this.btnClearGK.Size = new System.Drawing.Size(87, 23);
            this.btnClearGK.TabIndex = 42;
            this.btnClearGK.Text = "Felder leeren";
            this.btnClearGK.UseVisualStyleBackColor = false;
            // 
            // btnEditGK
            // 
            this.btnEditGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGK.ForeColor = System.Drawing.Color.White;
            this.btnEditGK.Location = new System.Drawing.Point(174, 148);
            this.btnEditGK.Name = "btnEditGK";
            this.btnEditGK.Size = new System.Drawing.Size(75, 23);
            this.btnEditGK.TabIndex = 41;
            this.btnEditGK.Text = "Editieren";
            this.btnEditGK.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGK
            // 
            this.btnDeleteGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGK.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGK.Location = new System.Drawing.Point(93, 148);
            this.btnDeleteGK.Name = "btnDeleteGK";
            this.btnDeleteGK.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGK.TabIndex = 40;
            this.btnDeleteGK.Text = "Entfernen";
            this.btnDeleteGK.UseVisualStyleBackColor = false;
            // 
            // btnAddGK
            // 
            this.btnAddGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGK.ForeColor = System.Drawing.Color.White;
            this.btnAddGK.Location = new System.Drawing.Point(12, 148);
            this.btnAddGK.Name = "btnAddGK";
            this.btnAddGK.Size = new System.Drawing.Size(75, 23);
            this.btnAddGK.TabIndex = 39;
            this.btnAddGK.Text = "Hinzufügen";
            this.btnAddGK.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(903, 540);
            this.dataGridView1.TabIndex = 43;
            // 
            // GrundkompetenzenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClearGK);
            this.Controls.Add(this.btnEditGK);
            this.Controls.Add(this.btnDeleteGK);
            this.Controls.Add(this.btnAddGK);
            this.Controls.Add(this.txtBoxGKNr);
            this.Controls.Add(this.datePickerGK);
            this.Controls.Add(this.lblGKDatum);
            this.Controls.Add(this.txtBoxGKBez);
            this.Controls.Add(this.lblGKBez);
            this.Controls.Add(this.lblGKNr);
            this.Controls.Add(this.btnRtnGK2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GrundkompetenzenScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grundkompetenzen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRtnGK2Menu;
        private System.Windows.Forms.TextBox txtBoxGKNr;
        private System.Windows.Forms.DateTimePicker datePickerGK;
        private System.Windows.Forms.Label lblGKDatum;
        private System.Windows.Forms.TextBox txtBoxGKBez;
        private System.Windows.Forms.Label lblGKBez;
        private System.Windows.Forms.Label lblGKNr;
        private System.Windows.Forms.Button btnClearGK;
        private System.Windows.Forms.Button btnEditGK;
        private System.Windows.Forms.Button btnDeleteGK;
        private System.Windows.Forms.Button btnAddGK;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}