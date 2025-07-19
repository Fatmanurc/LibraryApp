namespace LibraryApp
{
    partial class PersonelPanel
    {
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.TextBox txtBookName; // Added
        private System.Windows.Forms.TextBox txtAuthor;   // Added
        private System.Windows.Forms.CheckBox chkRevise; // Added

        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.chkRevise = new System.Windows.Forms.CheckBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbRevisedBy = new System.Windows.Forms.ComboBox();
            this.lblRevisedBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(522, 92);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(6);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 82;
            this.dgvBooks.Size = new System.Drawing.Size(719, 416);
            this.dgvBooks.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(145)))), ((int)(((byte)(133)))));
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(155, 366);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(336, 58);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(145)))), ((int)(((byte)(133)))));
            this.btnRemoveBook.FlatAppearance.BorderSize = 0;
            this.btnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBook.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBook.Location = new System.Drawing.Point(155, 450);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(336, 58);
            this.btnRemoveBook.TabIndex = 2;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 59);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Personel Panel";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(155, 92);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(336, 31);
            this.txtBookName.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(155, 162);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(336, 31);
            this.txtAuthor.TabIndex = 5;
            // 
            // chkRevise
            // 
            this.chkRevise.AutoSize = true;
            this.chkRevise.Location = new System.Drawing.Point(381, 303);
            this.chkRevise.Name = "chkRevise";
            this.chkRevise.Size = new System.Drawing.Size(110, 29);
            this.chkRevise.TabIndex = 7;
            this.chkRevise.Text = "Revise";
            this.chkRevise.UseVisualStyleBackColor = true;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(20, 98);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(129, 25);
            this.lblBook.TabIndex = 10;
            this.lblBook.Text = "Book Name:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(20, 168);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(81, 25);
            this.lblAuthor.TabIndex = 11;
            this.lblAuthor.Text = "Author:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 31);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(20, 232);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(64, 25);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year:";
            // 
            // cmbRevisedBy
            // 
            this.cmbRevisedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevisedBy.FormattingEnabled = true;
            this.cmbRevisedBy.Location = new System.Drawing.Point(155, 299);
            this.cmbRevisedBy.Name = "cmbRevisedBy";
            this.cmbRevisedBy.Size = new System.Drawing.Size(177, 33);
            this.cmbRevisedBy.TabIndex = 14;
            // 
            // lblRevisedBy
            // 
            this.lblRevisedBy.AutoSize = true;
            this.lblRevisedBy.Location = new System.Drawing.Point(20, 299);
            this.lblRevisedBy.Name = "lblRevisedBy";
            this.lblRevisedBy.Size = new System.Drawing.Size(127, 25);
            this.lblRevisedBy.TabIndex = 15;
            this.lblRevisedBy.Text = "Revised By:";
            // 
            // PersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1297, 648);
            this.Controls.Add(this.lblRevisedBy);
            this.Controls.Add(this.cmbRevisedBy);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.chkRevise);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "PersonelPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel Panel";
            this.Load += new System.EventHandler(this.PersonelPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbRevisedBy;
        private System.Windows.Forms.Label lblRevisedBy;
        // private System.Windows.Forms.TextBox txtBookName; // Removed
        // private System.Windows.Forms.TextBox txtAuthor;   // Removed
        // private System.Windows.Forms.TextBox txtYear;     // Removed
        // private System.Windows.Forms.CheckBox chkRevise; // Removed
        // private System.Windows.Forms.TextBox txtRevisedBy; // Removed
        // private System.Windows.Forms.TextBox txtBookNameToRemove; // Removed
    }
}
