namespace BookDiary.Desktop.Books
{
    partial class QuotesForm
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
            this.quotesDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOfTheBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archived = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.openQuoteFormBtn = new System.Windows.Forms.Button();
            this.showQuotesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // quotesDataGrid
            // 
            this.quotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.idOfTheBook,
            this.QuoteText,
            this.BookId,
            this.Archived});
            this.quotesDataGrid.Location = new System.Drawing.Point(30, 96);
            this.quotesDataGrid.Name = "quotesDataGrid";
            this.quotesDataGrid.RowHeadersWidth = 51;
            this.quotesDataGrid.RowTemplate.Height = 24;
            this.quotesDataGrid.Size = new System.Drawing.Size(876, 410);
            this.quotesDataGrid.TabIndex = 0;
            this.quotesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuotesDataGrid_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "QuoteId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // idOfTheBook
            // 
            this.idOfTheBook.DataPropertyName = "BookId";
            this.idOfTheBook.HeaderText = "BookId";
            this.idOfTheBook.MinimumWidth = 6;
            this.idOfTheBook.Name = "idOfTheBook";
            this.idOfTheBook.Width = 125;
            // 
            // QuoteText
            // 
            this.QuoteText.DataPropertyName = "QuoteText";
            this.QuoteText.HeaderText = "Quote";
            this.QuoteText.MinimumWidth = 6;
            this.QuoteText.Name = "QuoteText";
            this.QuoteText.Width = 125;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "Book";
            this.BookId.HeaderText = "Book";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 125;
            // 
            // Archived
            // 
            this.Archived.DataPropertyName = "Archived";
            this.Archived.HeaderText = "Archived";
            this.Archived.MinimumWidth = 6;
            this.Archived.Name = "Archived";
            this.Archived.Width = 125;
            // 
            // openQuoteFormBtn
            // 
            this.openQuoteFormBtn.Location = new System.Drawing.Point(794, 32);
            this.openQuoteFormBtn.Name = "openQuoteFormBtn";
            this.openQuoteFormBtn.Size = new System.Drawing.Size(112, 35);
            this.openQuoteFormBtn.TabIndex = 1;
            this.openQuoteFormBtn.Text = "Add Quote";
            this.openQuoteFormBtn.UseVisualStyleBackColor = true;
            this.openQuoteFormBtn.Click += new System.EventHandler(this.OpenQuoteFormBtn_Click);
            // 
            // showQuotesBtn
            // 
            this.showQuotesBtn.Location = new System.Drawing.Point(30, 32);
            this.showQuotesBtn.Name = "showQuotesBtn";
            this.showQuotesBtn.Size = new System.Drawing.Size(112, 35);
            this.showQuotesBtn.TabIndex = 2;
            this.showQuotesBtn.Text = "Show Quotes";
            this.showQuotesBtn.UseVisualStyleBackColor = true;
            this.showQuotesBtn.Click += new System.EventHandler(this.ShowQuotesBtn_Click);
            // 
            // QuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 539);
            this.Controls.Add(this.showQuotesBtn);
            this.Controls.Add(this.openQuoteFormBtn);
            this.Controls.Add(this.quotesDataGrid);
            this.Name = "QuotesForm";
            this.Text = "QuotesForm";
            this.Load += new System.EventHandler(this.QuotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView quotesDataGrid;
        private System.Windows.Forms.Button openQuoteFormBtn;
        private System.Windows.Forms.Button showQuotesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfTheBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteText;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Archived;
    }
}