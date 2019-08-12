namespace BookDiary.Desktop.Reviews
{
    partial class ReviewDetailsForm
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
            this.reviewerTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reviewDateTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ratingTxt = new System.Windows.Forms.TextBox();
            this.reviewText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.approveReviewCheckbox = new System.Windows.Forms.CheckBox();
            this.finishReviewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reviewer";
            // 
            // reviewerTxt
            // 
            this.reviewerTxt.Location = new System.Drawing.Point(27, 53);
            this.reviewerTxt.Name = "reviewerTxt";
            this.reviewerTxt.ReadOnly = true;
            this.reviewerTxt.Size = new System.Drawing.Size(351, 22);
            this.reviewerTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Review date";
            // 
            // reviewDateTxt
            // 
            this.reviewDateTxt.Location = new System.Drawing.Point(27, 123);
            this.reviewDateTxt.Name = "reviewDateTxt";
            this.reviewDateTxt.ReadOnly = true;
            this.reviewDateTxt.Size = new System.Drawing.Size(351, 22);
            this.reviewDateTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rating";
            // 
            // ratingTxt
            // 
            this.ratingTxt.Location = new System.Drawing.Point(27, 193);
            this.ratingTxt.Name = "ratingTxt";
            this.ratingTxt.ReadOnly = true;
            this.ratingTxt.Size = new System.Drawing.Size(351, 22);
            this.ratingTxt.TabIndex = 5;
            // 
            // reviewText
            // 
            this.reviewText.Location = new System.Drawing.Point(27, 268);
            this.reviewText.Multiline = true;
            this.reviewText.Name = "reviewText";
            this.reviewText.ReadOnly = true;
            this.reviewText.Size = new System.Drawing.Size(351, 179);
            this.reviewText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Summary";
            // 
            // approveReviewCheckbox
            // 
            this.approveReviewCheckbox.AutoSize = true;
            this.approveReviewCheckbox.Location = new System.Drawing.Point(27, 474);
            this.approveReviewCheckbox.Name = "approveReviewCheckbox";
            this.approveReviewCheckbox.Size = new System.Drawing.Size(161, 21);
            this.approveReviewCheckbox.TabIndex = 8;
            this.approveReviewCheckbox.Text = "Approve this review?";
            this.approveReviewCheckbox.UseVisualStyleBackColor = true;
            // 
            // finishReviewForm
            // 
            this.finishReviewForm.Location = new System.Drawing.Point(303, 474);
            this.finishReviewForm.Name = "finishReviewForm";
            this.finishReviewForm.Size = new System.Drawing.Size(75, 23);
            this.finishReviewForm.TabIndex = 9;
            this.finishReviewForm.Text = "Finish";
            this.finishReviewForm.UseVisualStyleBackColor = true;
            this.finishReviewForm.Click += new System.EventHandler(this.FinishReviewForm_Click);
            // 
            // ReviewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 516);
            this.Controls.Add(this.finishReviewForm);
            this.Controls.Add(this.approveReviewCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reviewText);
            this.Controls.Add(this.ratingTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reviewDateTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reviewerTxt);
            this.Controls.Add(this.label1);
            this.Name = "ReviewDetailsForm";
            this.Text = "ReviewDetailsForm";
            this.Load += new System.EventHandler(this.ReviewDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reviewerTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reviewDateTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ratingTxt;
        private System.Windows.Forms.TextBox reviewText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox approveReviewCheckbox;
        private System.Windows.Forms.Button finishReviewForm;
    }
}