namespace BookDiary.Desktop.Books
{
    partial class BookDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.bookGenreComboBox = new System.Windows.Forms.ComboBox();
            this.totalPagesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearPublishedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.archivedCheckBox = new System.Windows.Forms.CheckBox();
            this.addPictureBtn = new System.Windows.Forms.Button();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.finishBookBtn = new System.Windows.Forms.Button();
            this.selectPictureDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(37, 69);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(228, 22);
            this.bookTitleTextBox.TabIndex = 1;
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.Location = new System.Drawing.Point(315, 69);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(185, 231);
            this.bookPictureBox.TabIndex = 2;
            this.bookPictureBox.TabStop = false;
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(34, 121);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(50, 17);
            this.bookAuthorLabel.TabIndex = 3;
            this.bookAuthorLabel.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre";
            // 
            // bookAuthorComboBox
            // 
            this.bookAuthorComboBox.FormattingEnabled = true;
            this.bookAuthorComboBox.Location = new System.Drawing.Point(37, 141);
            this.bookAuthorComboBox.Name = "bookAuthorComboBox";
            this.bookAuthorComboBox.Size = new System.Drawing.Size(228, 24);
            this.bookAuthorComboBox.TabIndex = 5;
            // 
            // bookGenreComboBox
            // 
            this.bookGenreComboBox.FormattingEnabled = true;
            this.bookGenreComboBox.Location = new System.Drawing.Point(37, 213);
            this.bookGenreComboBox.Name = "bookGenreComboBox";
            this.bookGenreComboBox.Size = new System.Drawing.Size(228, 24);
            this.bookGenreComboBox.TabIndex = 6;
            // 
            // totalPagesTextBox
            // 
            this.totalPagesTextBox.Location = new System.Drawing.Point(37, 341);
            this.totalPagesTextBox.Name = "totalPagesTextBox";
            this.totalPagesTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalPagesTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Pages";
            // 
            // yearPublishedTextBox
            // 
            this.yearPublishedTextBox.Location = new System.Drawing.Point(165, 341);
            this.yearPublishedTextBox.Name = "yearPublishedTextBox";
            this.yearPublishedTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearPublishedTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Published in";
            // 
            // archivedCheckBox
            // 
            this.archivedCheckBox.AutoSize = true;
            this.archivedCheckBox.Location = new System.Drawing.Point(37, 383);
            this.archivedCheckBox.Name = "archivedCheckBox";
            this.archivedCheckBox.Size = new System.Drawing.Size(146, 21);
            this.archivedCheckBox.TabIndex = 11;
            this.archivedCheckBox.Text = "Archive this book?";
            this.archivedCheckBox.UseVisualStyleBackColor = true;
            // 
            // addPictureBtn
            // 
            this.addPictureBtn.Location = new System.Drawing.Point(315, 340);
            this.addPictureBtn.Name = "addPictureBtn";
            this.addPictureBtn.Size = new System.Drawing.Size(185, 23);
            this.addPictureBtn.TabIndex = 12;
            this.addPictureBtn.Text = "Add Picture";
            this.addPictureBtn.UseVisualStyleBackColor = true;
            this.addPictureBtn.Click += new System.EventHandler(this.AddPictureBtn_Click);
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Location = new System.Drawing.Point(37, 278);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(228, 22);
            this.pictureTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Picture";
            // 
            // finishBookBtn
            // 
            this.finishBookBtn.Location = new System.Drawing.Point(398, 414);
            this.finishBookBtn.Name = "finishBookBtn";
            this.finishBookBtn.Size = new System.Drawing.Size(102, 34);
            this.finishBookBtn.TabIndex = 15;
            this.finishBookBtn.Text = "Finish";
            this.finishBookBtn.UseVisualStyleBackColor = true;
            // 
            // selectPictureDialog
            // 
            this.selectPictureDialog.FileName = "openFileDialog1";
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 478);
            this.Controls.Add(this.finishBookBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.addPictureBtn);
            this.Controls.Add(this.archivedCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearPublishedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPagesTextBox);
            this.Controls.Add(this.bookGenreComboBox);
            this.Controls.Add(this.bookAuthorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookAuthorLabel);
            this.Controls.Add(this.bookPictureBox);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BookDetailsForm";
            this.Text = "BookDetailsForm";
            this.Load += new System.EventHandler(this.BookDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bookAuthorComboBox;
        private System.Windows.Forms.ComboBox bookGenreComboBox;
        private System.Windows.Forms.TextBox totalPagesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearPublishedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox archivedCheckBox;
        private System.Windows.Forms.Button addPictureBtn;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button finishBookBtn;
        private System.Windows.Forms.OpenFileDialog selectPictureDialog;
    }
}