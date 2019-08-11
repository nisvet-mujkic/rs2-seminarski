namespace BookDiary.Desktop.Reviews
{
    partial class ReviewsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.approvedCheckBox = new System.Windows.Forms.CheckBox();
            this.pendingCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ReviewerColumn,
            this.DateColumn,
            this.BookColumn,
            this.ratingColumn,
            this.SummaryColumn,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(32, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ReviewId";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 125;
            // 
            // ReviewerColumn
            // 
            this.ReviewerColumn.HeaderText = "Reviewer";
            this.ReviewerColumn.MinimumWidth = 6;
            this.ReviewerColumn.Name = "ReviewerColumn";
            this.ReviewerColumn.Width = 125;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // BookColumn
            // 
            this.BookColumn.HeaderText = "Book";
            this.BookColumn.MinimumWidth = 6;
            this.BookColumn.Name = "BookColumn";
            this.BookColumn.Width = 125;
            // 
            // ratingColumn
            // 
            this.ratingColumn.HeaderText = "Rating";
            this.ratingColumn.MinimumWidth = 6;
            this.ratingColumn.Name = "ratingColumn";
            this.ratingColumn.Width = 125;
            // 
            // SummaryColumn
            // 
            this.SummaryColumn.HeaderText = "Summary";
            this.SummaryColumn.MinimumWidth = 6;
            this.SummaryColumn.Name = "SummaryColumn";
            this.SummaryColumn.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // approvedCheckBox
            // 
            this.approvedCheckBox.AutoSize = true;
            this.approvedCheckBox.Location = new System.Drawing.Point(208, 36);
            this.approvedCheckBox.Name = "approvedCheckBox";
            this.approvedCheckBox.Size = new System.Drawing.Size(179, 21);
            this.approvedCheckBox.TabIndex = 1;
            this.approvedCheckBox.Text = "Show approved reviews";
            this.approvedCheckBox.UseVisualStyleBackColor = true;
            // 
            // pendingCheckBox
            // 
            this.pendingCheckBox.AutoSize = true;
            this.pendingCheckBox.Location = new System.Drawing.Point(32, 36);
            this.pendingCheckBox.Name = "pendingCheckBox";
            this.pendingCheckBox.Size = new System.Drawing.Size(170, 21);
            this.pendingCheckBox.TabIndex = 2;
            this.pendingCheckBox.Text = "Show pending reviews";
            this.pendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 472);
            this.Controls.Add(this.pendingCheckBox);
            this.Controls.Add(this.approvedCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReviewsForm";
            this.Text = "ReviewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummaryColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.CheckBox approvedCheckBox;
        private System.Windows.Forms.CheckBox pendingCheckBox;
    }
}