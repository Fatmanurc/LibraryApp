namespace LibraryApp
{
    partial class RevisedBooks
    {
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvRevisedBooks;

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvRevisedBooks = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisedBooks)).BeginInit();
            this.SuspendLayout();
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
            this.lblUsername.TabIndex = 0;
            // 
            // dgvRevisedBooks
            // 
            this.dgvRevisedBooks.AllowUserToAddRows = false;
            this.dgvRevisedBooks.AllowUserToDeleteRows = false;
            this.dgvRevisedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevisedBooks.Location = new System.Drawing.Point(100, 115);
            this.dgvRevisedBooks.Margin = new System.Windows.Forms.Padding(6);
            this.dgvRevisedBooks.Name = "dgvRevisedBooks";
            this.dgvRevisedBooks.RowHeadersWidth = 82;
            this.dgvRevisedBooks.Size = new System.Drawing.Size(600, 385);
            this.dgvRevisedBooks.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.lblTitle.Location = new System.Drawing.Point(102, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 59);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Revised Books List";
            // 
            // RevisedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRevisedBooks);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RevisedBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revised Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
    }
}
