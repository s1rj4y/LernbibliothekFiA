namespace LernbibliothekFiA
{
    partial class ThemenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemenScreen));
            this.btnRtnThemen2Menu = new System.Windows.Forms.Button();
            this.datePickerThema = new System.Windows.Forms.DateTimePicker();
            this.lblThemaDatum = new System.Windows.Forms.Label();
            this.txtBoxThemenBez = new System.Windows.Forms.TextBox();
            this.lblThemaBez = new System.Windows.Forms.Label();
            this.btnClearThemen = new System.Windows.Forms.Button();
            this.btnEditThemen = new System.Windows.Forms.Button();
            this.btnDeleteThemen = new System.Windows.Forms.Button();
            this.btnAddThemen = new System.Windows.Forms.Button();
            this.dataGridViewShowThemen = new System.Windows.Forms.DataGridView();
            this.lblChooseLF = new System.Windows.Forms.Label();
            this.comboBoxChooseLF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowThemen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRtnThemen2Menu
            // 
            this.btnRtnThemen2Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRtnThemen2Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRtnThemen2Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtnThemen2Menu.ForeColor = System.Drawing.Color.White;
            this.btnRtnThemen2Menu.Location = new System.Drawing.Point(921, 12);
            this.btnRtnThemen2Menu.Name = "btnRtnThemen2Menu";
            this.btnRtnThemen2Menu.Size = new System.Drawing.Size(75, 23);
            this.btnRtnThemen2Menu.TabIndex = 1;
            this.btnRtnThemen2Menu.Text = "Zurück";
            this.btnRtnThemen2Menu.UseVisualStyleBackColor = false;
            this.btnRtnThemen2Menu.Click += new System.EventHandler(this.btnRtnThemen2Menu_Click);
            // 
            // datePickerThema
            // 
            this.datePickerThema.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datePickerThema.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.datePickerThema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerThema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerThema.Location = new System.Drawing.Point(174, 72);
            this.datePickerThema.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerThema.Name = "datePickerThema";
            this.datePickerThema.Size = new System.Drawing.Size(108, 23);
            this.datePickerThema.TabIndex = 18;
            this.datePickerThema.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // lblThemaDatum
            // 
            this.lblThemaDatum.AutoSize = true;
            this.lblThemaDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblThemaDatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThemaDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemaDatum.ForeColor = System.Drawing.Color.White;
            this.lblThemaDatum.Location = new System.Drawing.Point(12, 72);
            this.lblThemaDatum.Name = "lblThemaDatum";
            this.lblThemaDatum.Size = new System.Drawing.Size(149, 20);
            this.lblThemaDatum.TabIndex = 17;
            this.lblThemaDatum.Text = "Bearbeitungsdatum";
            // 
            // txtBoxThemenBez
            // 
            this.txtBoxThemenBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxThemenBez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxThemenBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxThemenBez.ForeColor = System.Drawing.Color.White;
            this.txtBoxThemenBez.Location = new System.Drawing.Point(174, 42);
            this.txtBoxThemenBez.Name = "txtBoxThemenBez";
            this.txtBoxThemenBez.Size = new System.Drawing.Size(741, 23);
            this.txtBoxThemenBez.TabIndex = 16;
            // 
            // lblThemaBez
            // 
            this.lblThemaBez.AutoSize = true;
            this.lblThemaBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblThemaBez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThemaBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemaBez.ForeColor = System.Drawing.Color.White;
            this.lblThemaBez.Location = new System.Drawing.Point(12, 42);
            this.lblThemaBez.Name = "lblThemaBez";
            this.lblThemaBez.Size = new System.Drawing.Size(102, 20);
            this.lblThemaBez.TabIndex = 15;
            this.lblThemaBez.Text = "Bezeichnung";
            // 
            // btnClearThemen
            // 
            this.btnClearThemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClearThemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearThemen.ForeColor = System.Drawing.Color.White;
            this.btnClearThemen.Location = new System.Drawing.Point(255, 149);
            this.btnClearThemen.Name = "btnClearThemen";
            this.btnClearThemen.Size = new System.Drawing.Size(87, 23);
            this.btnClearThemen.TabIndex = 34;
            this.btnClearThemen.Text = "Felder leeren";
            this.btnClearThemen.UseVisualStyleBackColor = false;
            this.btnClearThemen.Click += new System.EventHandler(this.btnClearThemen_Click);
            // 
            // btnEditThemen
            // 
            this.btnEditThemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditThemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditThemen.ForeColor = System.Drawing.Color.White;
            this.btnEditThemen.Location = new System.Drawing.Point(174, 149);
            this.btnEditThemen.Name = "btnEditThemen";
            this.btnEditThemen.Size = new System.Drawing.Size(75, 23);
            this.btnEditThemen.TabIndex = 33;
            this.btnEditThemen.Text = "Editieren";
            this.btnEditThemen.UseVisualStyleBackColor = false;
            this.btnEditThemen.Click += new System.EventHandler(this.btnEditThemen_Click);
            // 
            // btnDeleteThemen
            // 
            this.btnDeleteThemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteThemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteThemen.ForeColor = System.Drawing.Color.White;
            this.btnDeleteThemen.Location = new System.Drawing.Point(93, 149);
            this.btnDeleteThemen.Name = "btnDeleteThemen";
            this.btnDeleteThemen.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteThemen.TabIndex = 32;
            this.btnDeleteThemen.Text = "Entfernen";
            this.btnDeleteThemen.UseVisualStyleBackColor = false;
            this.btnDeleteThemen.Click += new System.EventHandler(this.btnDeleteThemen_Click);
            // 
            // btnAddThemen
            // 
            this.btnAddThemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddThemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddThemen.ForeColor = System.Drawing.Color.White;
            this.btnAddThemen.Location = new System.Drawing.Point(12, 149);
            this.btnAddThemen.Name = "btnAddThemen";
            this.btnAddThemen.Size = new System.Drawing.Size(75, 23);
            this.btnAddThemen.TabIndex = 31;
            this.btnAddThemen.Text = "Hinzufügen";
            this.btnAddThemen.UseVisualStyleBackColor = false;
            this.btnAddThemen.Click += new System.EventHandler(this.btnAddThemen_Click);
            // 
            // dataGridViewShowThemen
            // 
            this.dataGridViewShowThemen.AllowUserToAddRows = false;
            this.dataGridViewShowThemen.AllowUserToDeleteRows = false;
            this.dataGridViewShowThemen.AllowUserToResizeColumns = false;
            this.dataGridViewShowThemen.AllowUserToResizeRows = false;
            this.dataGridViewShowThemen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowThemen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowThemen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowThemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowThemen.Location = new System.Drawing.Point(12, 178);
            this.dataGridViewShowThemen.MultiSelect = false;
            this.dataGridViewShowThemen.Name = "dataGridViewShowThemen";
            this.dataGridViewShowThemen.ReadOnly = true;
            this.dataGridViewShowThemen.RowHeadersVisible = false;
            this.dataGridViewShowThemen.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowThemen.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewShowThemen.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dataGridViewShowThemen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowThemen.Size = new System.Drawing.Size(903, 539);
            this.dataGridViewShowThemen.TabIndex = 35;
            this.dataGridViewShowThemen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowThemen_CellContentClick);
            // 
            // lblChooseLF
            // 
            this.lblChooseLF.AutoSize = true;
            this.lblChooseLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblChooseLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChooseLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseLF.ForeColor = System.Drawing.Color.White;
            this.lblChooseLF.Location = new System.Drawing.Point(12, 105);
            this.lblChooseLF.Name = "lblChooseLF";
            this.lblChooseLF.Size = new System.Drawing.Size(67, 20);
            this.lblChooseLF.TabIndex = 36;
            this.lblChooseLF.Text = "Lernfeld";
            // 
            // comboBoxChooseLF
            // 
            this.comboBoxChooseLF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBoxChooseLF.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxChooseLF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseLF.ForeColor = System.Drawing.Color.White;
            this.comboBoxChooseLF.FormattingEnabled = true;
            this.comboBoxChooseLF.Location = new System.Drawing.Point(174, 105);
            this.comboBoxChooseLF.Name = "comboBoxChooseLF";
            this.comboBoxChooseLF.Size = new System.Drawing.Size(741, 24);
            this.comboBoxChooseLF.TabIndex = 37;
            // 
            // ThemenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.comboBoxChooseLF);
            this.Controls.Add(this.lblChooseLF);
            this.Controls.Add(this.dataGridViewShowThemen);
            this.Controls.Add(this.btnClearThemen);
            this.Controls.Add(this.btnEditThemen);
            this.Controls.Add(this.btnDeleteThemen);
            this.Controls.Add(this.btnAddThemen);
            this.Controls.Add(this.datePickerThema);
            this.Controls.Add(this.lblThemaDatum);
            this.Controls.Add(this.txtBoxThemenBez);
            this.Controls.Add(this.lblThemaBez);
            this.Controls.Add(this.btnRtnThemen2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThemenScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Themen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowThemen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRtnThemen2Menu;
        private System.Windows.Forms.DateTimePicker datePickerThema;
        private System.Windows.Forms.Label lblThemaDatum;
        private System.Windows.Forms.TextBox txtBoxThemenBez;
        private System.Windows.Forms.Label lblThemaBez;
        private System.Windows.Forms.Button btnClearThemen;
        private System.Windows.Forms.Button btnEditThemen;
        private System.Windows.Forms.Button btnDeleteThemen;
        private System.Windows.Forms.Button btnAddThemen;
        private System.Windows.Forms.DataGridView dataGridViewShowThemen;
        private System.Windows.Forms.Label lblChooseLF;
        private System.Windows.Forms.ComboBox comboBoxChooseLF;
    }
}