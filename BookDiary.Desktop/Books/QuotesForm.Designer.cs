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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.quoteIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromBookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoteIdColumn,
            this.quoteColumn,
            this.fromBookColumn,
            this.showColumn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add quote";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // quoteIdColumn
            // 
            this.quoteIdColumn.HeaderText = "QuoteId";
            this.quoteIdColumn.MinimumWidth = 6;
            this.quoteIdColumn.Name = "quoteIdColumn";
            this.quoteIdColumn.Visible = false;
            this.quoteIdColumn.Width = 125;
            // 
            // quoteColumn
            // 
            this.quoteColumn.HeaderText = "Quote";
            this.quoteColumn.MinimumWidth = 6;
            this.quoteColumn.Name = "quoteColumn";
            this.quoteColumn.Width = 125;
            // 
            // fromBookColumn
            // 
            this.fromBookColumn.HeaderText = "Book";
            this.fromBookColumn.MinimumWidth = 6;
            this.fromBookColumn.Name = "fromBookColumn";
            this.fromBookColumn.Width = 125;
            // 
            // showColumn
            // 
            this.showColumn.HeaderText = "Show Quote";
            this.showColumn.MinimumWidth = 6;
            this.showColumn.Name = "showColumn";
            this.showColumn.Width = 125;
            // 
            // QuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuotesForm";
            this.Text = "QuotesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromBookColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showColumn;
    }
}