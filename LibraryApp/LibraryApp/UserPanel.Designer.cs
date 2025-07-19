namespace LibraryApp
{
    partial class UserPanel
    {
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnSeeMyBooks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnRevise;

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnSeeMyBooks = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRevise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.lblWelcome.Location = new System.Drawing.Point(400, 38);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 37);
            this.lblWelcome.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.lblUsername.Location = new System.Drawing.Point(40, 38);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 37);
            this.lblUsername.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(36, 86);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(718, 43);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(145)))), ((int)(((byte)(133)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(766, 83);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(36, 146);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(6);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 82;
            this.dgvBooks.Size = new System.Drawing.Size(918, 413);
            this.dgvBooks.TabIndex = 4;
            // 
            // btnSeeMyBooks
            // 
            this.btnSeeMyBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(145)))), ((int)(((byte)(133)))));
            this.btnSeeMyBooks.FlatAppearance.BorderSize = 0;
            this.btnSeeMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeMyBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeMyBooks.ForeColor = System.Drawing.Color.White;
            this.btnSeeMyBooks.Location = new System.Drawing.Point(556, 571);
            this.btnSeeMyBooks.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeeMyBooks.Name = "btnSeeMyBooks";
            this.btnSeeMyBooks.Size = new System.Drawing.Size(398, 56);
            this.btnSeeMyBooks.TabIndex = 5;
            this.btnSeeMyBooks.Text = "See My Books";
            this.btnSeeMyBooks.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.lblTitle.Location = new System.Drawing.Point(26, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 59);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "User Panel";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(127, 578);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(206, 43);
            this.txtID.TabIndex = 7;
            // 
            // btnRevise
            // 
            this.btnRevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(145)))), ((int)(((byte)(133)))));
            this.btnRevise.FlatAppearance.BorderSize = 0;
            this.btnRevise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevise.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevise.ForeColor = System.Drawing.Color.White;
            this.btnRevise.Location = new System.Drawing.Point(345, 571);
            this.btnRevise.Margin = new System.Windows.Forms.Padding(6);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(199, 56);
            this.btnRevise.TabIndex = 8;
            this.btnRevise.Text = "Revise";
            this.btnRevise.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "BookID:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.lblMail.Location = new System.Drawing.Point(31, 677);
            this.lblMail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(925, 30);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "If you want to revise a book, write the ID of the book to be revised and click th" +
    "e Revise button.";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1022, 797);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevise);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSeeMyBooks);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMail;
    }
}
