namespace BookDiary.Desktop.Books
{
    partial class BooksForm
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
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBooksBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookSearchTermTextBox = new System.Windows.Forms.TextBox();
            this.bookGenresComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookAuthorsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BookIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIdColumn,
            this.TitleColumn,
            this.AuthorColumn,
            this.GenreColumn,
            this.YearColumn,
            this.PagesColumn,
            this.StatusColumn});
            this.booksDataGridView.Location = new System.Drawing.Point(31, 162);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.Size = new System.Drawing.Size(923, 392);
            this.booksDataGridView.TabIndex = 0;
            this.booksDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellDoubleClick);
            // 
            // searchBooksBtn
            // 
            this.searchBooksBtn.Location = new System.Drawing.Point(867, 60);
            this.searchBooksBtn.Name = "searchBooksBtn";
            this.searchBooksBtn.Size = new System.Drawing.Size(87, 24);
            this.searchBooksBtn.TabIndex = 1;
            this.searchBooksBtn.Text = "Search";
            this.searchBooksBtn.UseVisualStyleBackColor = true;
            this.searchBooksBtn.Click += new System.EventHandler(this.SearchBooksBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(31, 109);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(255, 29);
            this.addBookBtn.TabIndex = 2;
            this.addBookBtn.Text = "Add book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your search term";
            // 
            // bookSearchTermTextBox
            // 
            this.bookSearchTermTextBox.Location = new System.Drawing.Point(31, 62);
            this.bookSearchTermTextBox.Name = "bookSearchTermTextBox";
            this.bookSearchTermTextBox.Size = new System.Drawing.Size(255, 22);
            this.bookSearchTermTextBox.TabIndex = 4;
            // 
            // bookGenresComboBox
            // 
            this.bookGenresComboBox.FormattingEnabled = true;
            this.bookGenresComboBox.Location = new System.Drawing.Point(310, 60);
            this.bookGenresComboBox.Name = "bookGenresComboBox";
            this.bookGenresComboBox.Size = new System.Drawing.Size(255, 24);
            this.bookGenresComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre";
            // 
            // bookAuthorsComboBox
            // 
            this.bookAuthorsComboBox.FormattingEnabled = true;
            this.bookAuthorsComboBox.Location = new System.Drawing.Point(592, 60);
            this.bookAuthorsComboBox.Name = "bookAuthorsComboBox";
            this.bookAuthorsComboBox.Size = new System.Drawing.Size(255, 24);
            this.bookAuthorsComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // BookIdColumn
            // 
            this.BookIdColumn.DataPropertyName = "Id";
            this.BookIdColumn.HeaderText = "BookId";
            this.BookIdColumn.MinimumWidth = 6;
            this.BookIdColumn.Name = "BookIdColumn";
            this.BookIdColumn.Visible = false;
            this.BookIdColumn.Width = 125;
            // 
            // TitleColumn
            // 
            this.TitleColumn.DataPropertyName = "Name";
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 125;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.DataPropertyName = "Author";
            this.AuthorColumn.HeaderText = "Author";
            this.AuthorColumn.MinimumWidth = 6;
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            this.AuthorColumn.Width = 125;
            // 
            // GenreColumn
            // 
            this.GenreColumn.DataPropertyName = "Genre";
            this.GenreColumn.HeaderText = "Genre";
            this.GenreColumn.MinimumWidth = 6;
            this.GenreColumn.Name = "GenreColumn";
            this.GenreColumn.ReadOnly = true;
            this.GenreColumn.Width = 125;
            // 
            // YearColumn
            // 
            this.YearColumn.DataPropertyName = "YearPublished";
            this.YearColumn.HeaderText = "Year Published";
            this.YearColumn.MinimumWidth = 6;
            this.YearColumn.Name = "YearColumn";
            this.YearColumn.ReadOnly = true;
            this.YearColumn.Width = 125;
            // 
            // PagesColumn
            // 
            this.PagesColumn.DataPropertyName = "PagesInTotal";
            this.PagesColumn.HeaderText = "Total Pages";
            this.PagesColumn.MinimumWidth = 6;
            this.PagesColumn.Name = "PagesColumn";
            this.PagesColumn.ReadOnly = true;
            this.PagesColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Archived";
            this.StatusColumn.HeaderText = "Archived";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookAuthorsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookGenresComboBox);
            this.Controls.Add(this.bookSearchTermTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.searchBooksBtn);
            this.Controls.Add(this.booksDataGridView);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Button searchBooksBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookSearchTermTextBox;
        private System.Windows.Forms.ComboBox bookGenresComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bookAuthorsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagesColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusColumn;
    }
}