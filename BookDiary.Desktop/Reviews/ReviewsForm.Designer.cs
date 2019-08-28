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
            this.reviewsDataGrid = new System.Windows.Forms.DataGridView();
            this.approvedCheckBox = new System.Windows.Forms.CheckBox();
            this.pendingCheckBox = new System.Windows.Forms.CheckBox();
            this.showReviewsButton = new System.Windows.Forms.Button();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rejectedReviewsCheckBox = new System.Windows.Forms.CheckBox();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewsDataGrid
            // 
            this.reviewsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ReviewerColumn,
            this.DateColumn,
            this.ratingColumn,
            this.SummaryColumn,
            this.Status});
            this.reviewsDataGrid.Location = new System.Drawing.Point(12, 140);
            this.reviewsDataGrid.Name = "reviewsDataGrid";
            this.reviewsDataGrid.RowHeadersWidth = 51;
            this.reviewsDataGrid.RowTemplate.Height = 24;
            this.reviewsDataGrid.Size = new System.Drawing.Size(969, 388);
            this.reviewsDataGrid.TabIndex = 0;
            this.reviewsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewsDataGrid_CellDoubleClick);
            // 
            // approvedCheckBox
            // 
            this.approvedCheckBox.AutoSize = true;
            this.approvedCheckBox.Location = new System.Drawing.Point(219, 36);
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
            // showReviewsButton
            // 
            this.showReviewsButton.Location = new System.Drawing.Point(859, 36);
            this.showReviewsButton.Name = "showReviewsButton";
            this.showReviewsButton.Size = new System.Drawing.Size(122, 36);
            this.showReviewsButton.TabIndex = 3;
            this.showReviewsButton.Text = "Search";
            this.showReviewsButton.UseVisualStyleBackColor = true;
            this.showReviewsButton.Click += new System.EventHandler(this.ShowReviewsButton_Click);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(32, 88);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(123, 22);
            this.fromDatePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(219, 88);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(123, 22);
            this.toDatePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // rejectedReviewsCheckBox
            // 
            this.rejectedReviewsCheckBox.AutoSize = true;
            this.rejectedReviewsCheckBox.Location = new System.Drawing.Point(419, 36);
            this.rejectedReviewsCheckBox.Name = "rejectedReviewsCheckBox";
            this.rejectedReviewsCheckBox.Size = new System.Drawing.Size(170, 21);
            this.rejectedReviewsCheckBox.TabIndex = 8;
            this.rejectedReviewsCheckBox.Text = "Show rejected reviews";
            this.rejectedReviewsCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "UserBookId";
            this.IdColumn.HeaderText = "ReviewId";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 125;
            // 
            // ReviewerColumn
            // 
            this.ReviewerColumn.DataPropertyName = "UserBook";
            this.ReviewerColumn.HeaderText = "Details";
            this.ReviewerColumn.MinimumWidth = 6;
            this.ReviewerColumn.Name = "ReviewerColumn";
            this.ReviewerColumn.Width = 125;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "CreatedAt";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // ratingColumn
            // 
            this.ratingColumn.DataPropertyName = "Rating";
            this.ratingColumn.HeaderText = "Rating";
            this.ratingColumn.MinimumWidth = 6;
            this.ratingColumn.Name = "ratingColumn";
            this.ratingColumn.Width = 125;
            // 
            // SummaryColumn
            // 
            this.SummaryColumn.DataPropertyName = "Summary";
            this.SummaryColumn.HeaderText = "Summary";
            this.SummaryColumn.MinimumWidth = 6;
            this.SummaryColumn.Name = "SummaryColumn";
            this.SummaryColumn.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Approved";
            this.Status.HeaderText = "Approved";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 567);
            this.Controls.Add(this.rejectedReviewsCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.showReviewsButton);
            this.Controls.Add(this.pendingCheckBox);
            this.Controls.Add(this.approvedCheckBox);
            this.Controls.Add(this.reviewsDataGrid);
            this.Name = "ReviewsForm";
            this.Text = "ReviewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.reviewsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewsDataGrid;
        private System.Windows.Forms.CheckBox approvedCheckBox;
        private System.Windows.Forms.CheckBox pendingCheckBox;
        private System.Windows.Forms.Button showReviewsButton;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rejectedReviewsCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummaryColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}