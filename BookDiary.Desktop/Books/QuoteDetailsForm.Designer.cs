namespace BookDiary.Desktop.Books
{
    partial class QuoteDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quoteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitQuoteBtn = new System.Windows.Forms.Button();
            this.archiveQuoteCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // booksComboBox
            // 
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(27, 59);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(471, 24);
            this.booksComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book";
            // 
            // quoteTextBox
            // 
            this.quoteTextBox.Location = new System.Drawing.Point(27, 138);
            this.quoteTextBox.Multiline = true;
            this.quoteTextBox.Name = "quoteTextBox";
            this.quoteTextBox.Size = new System.Drawing.Size(471, 179);
            this.quoteTextBox.TabIndex = 3;
            this.quoteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.QuoteTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quote";
            // 
            // submitQuoteBtn
            // 
            this.submitQuoteBtn.Location = new System.Drawing.Point(404, 339);
            this.submitQuoteBtn.Name = "submitQuoteBtn";
            this.submitQuoteBtn.Size = new System.Drawing.Size(94, 33);
            this.submitQuoteBtn.TabIndex = 5;
            this.submitQuoteBtn.Text = "Add";
            this.submitQuoteBtn.UseVisualStyleBackColor = true;
            this.submitQuoteBtn.Click += new System.EventHandler(this.SubmitQuoteBtn_Click);
            // 
            // archiveQuoteCheckBox
            // 
            this.archiveQuoteCheckBox.AutoSize = true;
            this.archiveQuoteCheckBox.Location = new System.Drawing.Point(27, 339);
            this.archiveQuoteCheckBox.Name = "archiveQuoteCheckBox";
            this.archiveQuoteCheckBox.Size = new System.Drawing.Size(151, 21);
            this.archiveQuoteCheckBox.TabIndex = 6;
            this.archiveQuoteCheckBox.Text = "Archive this quote?";
            this.archiveQuoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // QuoteDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 398);
            this.Controls.Add(this.archiveQuoteCheckBox);
            this.Controls.Add(this.submitQuoteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quoteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksComboBox);
            this.Name = "QuoteDetailsForm";
            this.Text = "QuoteDetailsForm";
            this.Load += new System.EventHandler(this.QuoteDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox booksComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quoteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitQuoteBtn;
        private System.Windows.Forms.CheckBox archiveQuoteCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}