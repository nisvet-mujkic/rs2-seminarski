namespace BookDiary.Desktop.Reports.Users
{
    partial class MostActiveUsersFilter
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
            this.fromDtp = new System.Windows.Forms.DateTimePicker();
            this.toDtp = new System.Windows.Forms.DateTimePicker();
            this.showReportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromDtp
            // 
            this.fromDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDtp.Location = new System.Drawing.Point(55, 66);
            this.fromDtp.Name = "fromDtp";
            this.fromDtp.Size = new System.Drawing.Size(119, 22);
            this.fromDtp.TabIndex = 0;
            // 
            // toDtp
            // 
            this.toDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDtp.Location = new System.Drawing.Point(207, 66);
            this.toDtp.Name = "toDtp";
            this.toDtp.Size = new System.Drawing.Size(119, 22);
            this.toDtp.TabIndex = 1;
            // 
            // showReportBtn
            // 
            this.showReportBtn.Location = new System.Drawing.Point(356, 64);
            this.showReportBtn.Name = "showReportBtn";
            this.showReportBtn.Size = new System.Drawing.Size(122, 30);
            this.showReportBtn.TabIndex = 3;
            this.showReportBtn.Text = "Show Report";
            this.showReportBtn.UseVisualStyleBackColor = true;
            this.showReportBtn.Click += new System.EventHandler(this.ShowReportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // MostActiveUsersFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showReportBtn);
            this.Controls.Add(this.toDtp);
            this.Controls.Add(this.fromDtp);
            this.Name = "MostActiveUsersFilter";
            this.Text = "MostActiveUsersFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDtp;
        private System.Windows.Forms.DateTimePicker toDtp;
        private System.Windows.Forms.Button showReportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}