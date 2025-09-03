namespace LernbibliothekFiA
{
    partial class BegriffeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BegriffeScreen));
            this.btnRtnBegriffe2Menu = new System.Windows.Forms.Button();
            this.richTextBoxBegriffDef = new System.Windows.Forms.RichTextBox();
            this.lblGKDef = new System.Windows.Forms.Label();
            this.txtBoxBegriffBez = new System.Windows.Forms.TextBox();
            this.lblBegriffBez = new System.Windows.Forms.Label();
            this.btnClearBegriffe = new System.Windows.Forms.Button();
            this.btnEditBegriffe = new System.Windows.Forms.Button();
            this.btnDeleteBegriffe = new System.Windows.Forms.Button();
            this.btnAddBegriffe = new System.Windows.Forms.Button();
            this.dataGridViewShowBegriffe = new System.Windows.Forms.DataGridView();
            this.comboBoxChooseThema = new System.Windows.Forms.ComboBox();
            this.lblChooseThema = new System.Windows.Forms.Label();
            this.comboBoxChooseGK = new System.Windows.Forms.ComboBox();
            this.lblChooseGK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBegriffe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRtnBegriffe2Menu
            // 
            this.btnRtnBegriffe2Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRtnBegriffe2Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRtnBegriffe2Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtnBegriffe2Menu.ForeColor = System.Drawing.Color.White;
            this.btnRtnBegriffe2Menu.Location = new System.Drawing.Point(921, 12);
            this.btnRtnBegriffe2Menu.Name = "btnRtnBegriffe2Menu";
            this.btnRtnBegriffe2Menu.Size = new System.Drawing.Size(75, 23);
            this.btnRtnBegriffe2Menu.TabIndex = 1;
            this.btnRtnBegriffe2Menu.Text = "Zurück";
            this.btnRtnBegriffe2Menu.UseVisualStyleBackColor = false;
            this.btnRtnBegriffe2Menu.Click += new System.EventHandler(this.btnRtnBegriffe2Menu_Click);
            // 
            // richTextBoxBegriffDef
            // 
            this.richTextBoxBegriffDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBoxBegriffDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxBegriffDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBegriffDef.ForeColor = System.Drawing.Color.White;
            this.richTextBoxBegriffDef.Location = new System.Drawing.Point(174, 76);
            this.richTextBoxBegriffDef.Name = "richTextBoxBegriffDef";
            this.richTextBoxBegriffDef.Size = new System.Drawing.Size(741, 182);
            this.richTextBoxBegriffDef.TabIndex = 30;
            this.richTextBoxBegriffDef.Text = "";
            // 
            // lblGKDef
            // 
            this.lblGKDef.AutoSize = true;
            this.lblGKDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblGKDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGKDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGKDef.ForeColor = System.Drawing.Color.White;
            this.lblGKDef.Location = new System.Drawing.Point(12, 76);
            this.lblGKDef.Name = "lblGKDef";
            this.lblGKDef.Size = new System.Drawing.Size(76, 20);
            this.lblGKDef.TabIndex = 29;
            this.lblGKDef.Text = "Definition";
            // 
            // txtBoxBegriffBez
            // 
            this.txtBoxBegriffBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtBoxBegriffBez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxBegriffBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBegriffBez.ForeColor = System.Drawing.Color.White;
            this.txtBoxBegriffBez.Location = new System.Drawing.Point(174, 43);
            this.txtBoxBegriffBez.Name = "txtBoxBegriffBez";
            this.txtBoxBegriffBez.Size = new System.Drawing.Size(741, 23);
            this.txtBoxBegriffBez.TabIndex = 28;
            // 
            // lblBegriffBez
            // 
            this.lblBegriffBez.AutoSize = true;
            this.lblBegriffBez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblBegriffBez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBegriffBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegriffBez.ForeColor = System.Drawing.Color.White;
            this.lblBegriffBez.Location = new System.Drawing.Point(12, 43);
            this.lblBegriffBez.Name = "lblBegriffBez";
            this.lblBegriffBez.Size = new System.Drawing.Size(102, 20);
            this.lblBegriffBez.TabIndex = 27;
            this.lblBegriffBez.Text = "Bezeichnung";
            // 
            // btnClearBegriffe
            // 
            this.btnClearBegriffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnClearBegriffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBegriffe.ForeColor = System.Drawing.Color.White;
            this.btnClearBegriffe.Location = new System.Drawing.Point(255, 340);
            this.btnClearBegriffe.Name = "btnClearBegriffe";
            this.btnClearBegriffe.Size = new System.Drawing.Size(87, 23);
            this.btnClearBegriffe.TabIndex = 46;
            this.btnClearBegriffe.Text = "Felder leeren";
            this.btnClearBegriffe.UseVisualStyleBackColor = false;
            this.btnClearBegriffe.Click += new System.EventHandler(this.btnClearBegriffe_Click);
            // 
            // btnEditBegriffe
            // 
            this.btnEditBegriffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditBegriffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBegriffe.ForeColor = System.Drawing.Color.White;
            this.btnEditBegriffe.Location = new System.Drawing.Point(174, 340);
            this.btnEditBegriffe.Name = "btnEditBegriffe";
            this.btnEditBegriffe.Size = new System.Drawing.Size(75, 23);
            this.btnEditBegriffe.TabIndex = 45;
            this.btnEditBegriffe.Text = "Editieren";
            this.btnEditBegriffe.UseVisualStyleBackColor = false;
            this.btnEditBegriffe.Click += new System.EventHandler(this.btnEditBegriffe_Click);
            // 
            // btnDeleteBegriffe
            // 
            this.btnDeleteBegriffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDeleteBegriffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBegriffe.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBegriffe.Location = new System.Drawing.Point(93, 340);
            this.btnDeleteBegriffe.Name = "btnDeleteBegriffe";
            this.btnDeleteBegriffe.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBegriffe.TabIndex = 44;
            this.btnDeleteBegriffe.Text = "Entfernen";
            this.btnDeleteBegriffe.UseVisualStyleBackColor = false;
            this.btnDeleteBegriffe.Click += new System.EventHandler(this.btnDeleteBegriffe_Click);
            // 
            // btnAddBegriffe
            // 
            this.btnAddBegriffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddBegriffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBegriffe.ForeColor = System.Drawing.Color.White;
            this.btnAddBegriffe.Location = new System.Drawing.Point(12, 340);
            this.btnAddBegriffe.Name = "btnAddBegriffe";
            this.btnAddBegriffe.Size = new System.Drawing.Size(75, 23);
            this.btnAddBegriffe.TabIndex = 43;
            this.btnAddBegriffe.Text = "Hinzufügen";
            this.btnAddBegriffe.UseVisualStyleBackColor = false;
            this.btnAddBegriffe.Click += new System.EventHandler(this.btnAddBegriffe_Click);
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
            this.dataGridViewShowBegriffe.Location = new System.Drawing.Point(12, 369);
            this.dataGridViewShowBegriffe.MultiSelect = false;
            this.dataGridViewShowBegriffe.Name = "dataGridViewShowBegriffe";
            this.dataGridViewShowBegriffe.ReadOnly = true;
            this.dataGridViewShowBegriffe.RowHeadersVisible = false;
            this.dataGridViewShowBegriffe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewShowBegriffe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewShowBegriffe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dataGridViewShowBegriffe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowBegriffe.Size = new System.Drawing.Size(903, 348);
            this.dataGridViewShowBegriffe.TabIndex = 47;
            this.dataGridViewShowBegriffe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowBegriffe_CellContentClick);
            // 
            // comboBoxChooseThema
            // 
            this.comboBoxChooseThema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBoxChooseThema.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxChooseThema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseThema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseThema.ForeColor = System.Drawing.Color.White;
            this.comboBoxChooseThema.FormattingEnabled = true;
            this.comboBoxChooseThema.Location = new System.Drawing.Point(174, 271);
            this.comboBoxChooseThema.Name = "comboBoxChooseThema";
            this.comboBoxChooseThema.Size = new System.Drawing.Size(741, 24);
            this.comboBoxChooseThema.TabIndex = 49;
            // 
            // lblChooseThema
            // 
            this.lblChooseThema.AutoSize = true;
            this.lblChooseThema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblChooseThema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChooseThema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseThema.ForeColor = System.Drawing.Color.White;
            this.lblChooseThema.Location = new System.Drawing.Point(12, 271);
            this.lblChooseThema.Name = "lblChooseThema";
            this.lblChooseThema.Size = new System.Drawing.Size(58, 20);
            this.lblChooseThema.TabIndex = 48;
            this.lblChooseThema.Text = "Thema";
            // 
            // comboBoxChooseGK
            // 
            this.comboBoxChooseGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBoxChooseGK.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxChooseGK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChooseGK.ForeColor = System.Drawing.Color.White;
            this.comboBoxChooseGK.FormattingEnabled = true;
            this.comboBoxChooseGK.Location = new System.Drawing.Point(174, 305);
            this.comboBoxChooseGK.Name = "comboBoxChooseGK";
            this.comboBoxChooseGK.Size = new System.Drawing.Size(741, 24);
            this.comboBoxChooseGK.TabIndex = 51;
            // 
            // lblChooseGK
            // 
            this.lblChooseGK.AutoSize = true;
            this.lblChooseGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblChooseGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChooseGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseGK.ForeColor = System.Drawing.Color.White;
            this.lblChooseGK.Location = new System.Drawing.Point(12, 305);
            this.lblChooseGK.Name = "lblChooseGK";
            this.lblChooseGK.Size = new System.Drawing.Size(133, 20);
            this.lblChooseGK.TabIndex = 50;
            this.lblChooseGK.Text = "Grundkompetenz";
            // 
            // BegriffeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.comboBoxChooseGK);
            this.Controls.Add(this.lblChooseGK);
            this.Controls.Add(this.comboBoxChooseThema);
            this.Controls.Add(this.lblChooseThema);
            this.Controls.Add(this.dataGridViewShowBegriffe);
            this.Controls.Add(this.btnClearBegriffe);
            this.Controls.Add(this.btnEditBegriffe);
            this.Controls.Add(this.btnDeleteBegriffe);
            this.Controls.Add(this.btnAddBegriffe);
            this.Controls.Add(this.richTextBoxBegriffDef);
            this.Controls.Add(this.lblGKDef);
            this.Controls.Add(this.txtBoxBegriffBez);
            this.Controls.Add(this.lblBegriffBez);
            this.Controls.Add(this.btnRtnBegriffe2Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BegriffeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Begriffe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBegriffe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRtnBegriffe2Menu;
        private System.Windows.Forms.RichTextBox richTextBoxBegriffDef;
        private System.Windows.Forms.Label lblGKDef;
        private System.Windows.Forms.TextBox txtBoxBegriffBez;
        private System.Windows.Forms.Label lblBegriffBez;
        private System.Windows.Forms.Button btnClearBegriffe;
        private System.Windows.Forms.Button btnEditBegriffe;
        private System.Windows.Forms.Button btnDeleteBegriffe;
        private System.Windows.Forms.Button btnAddBegriffe;
        private System.Windows.Forms.DataGridView dataGridViewShowBegriffe;
        private System.Windows.Forms.ComboBox comboBoxChooseThema;
        private System.Windows.Forms.Label lblChooseThema;
        private System.Windows.Forms.ComboBox comboBoxChooseGK;
        private System.Windows.Forms.Label lblChooseGK;
    }
}