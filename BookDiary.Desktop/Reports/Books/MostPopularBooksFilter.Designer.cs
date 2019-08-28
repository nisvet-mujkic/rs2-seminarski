namespace BookDiary.Desktop.Reports.Books
{
    partial class MostPopularBooksFilter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDtp = new System.Windows.Forms.DateTimePicker();
            this.fromDtp = new System.Windows.Forms.DateTimePicker();
            this.showReportBtn = new System.Windows.Forms.Button();
            this.genresComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // toDtp
            // 
            this.toDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDtp.Location = new System.Drawing.Point(177, 55);
            this.toDtp.Name = "toDtp";
            this.toDtp.Size = new System.Drawing.Size(119, 22);
            this.toDtp.TabIndex = 7;
            // 
            // fromDtp
            // 
            this.fromDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDtp.Location = new System.Drawing.Point(25, 55);
            this.fromDtp.Name = "fromDtp";
            this.fromDtp.Size = new System.Drawing.Size(119, 22);
            this.fromDtp.TabIndex = 6;
            // 
            // showReportBtn
            // 
            this.showReportBtn.Location = new System.Drawing.Point(493, 54);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(128, 23);
            this.showReportBtn.TabIndex = 10;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.ShowReportBtn_Click);
            // 
            // genresComboBox
            // 
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Location = new System.Drawing.Point(318, 54);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(135, 24);
            this.genresComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Genre";
            // 
            // MostPopularBooksFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genresComboBox);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDtp);
            this.Controls.Add(this.fromDtp);
            this.Name = "MostPopularBooksFilter";
            this.Text = "MostPopularBooksFilter";
            this.Load += new System.EventHandler(this.MostPopularBooksFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDtp;
        private System.Windows.Forms.DateTimePicker fromDtp;
        private System.Windows.Forms.Button showReportBtn;
        private System.Windows.Forms.ComboBox genresComboBox;
        private System.Windows.Forms.Label label3;
    }
}