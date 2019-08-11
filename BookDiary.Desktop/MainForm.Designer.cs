namespace BookDiary.Desktop
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quotesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostActiveUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreComparisonReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.reviewsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksManagementToolStripMenuItem,
            this.quotesManagementToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // booksManagementToolStripMenuItem
            // 
            this.booksManagementToolStripMenuItem.Name = "booksManagementToolStripMenuItem";
            this.booksManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.booksManagementToolStripMenuItem.Text = "Books Management";
            // 
            // quotesManagementToolStripMenuItem
            // 
            this.quotesManagementToolStripMenuItem.Name = "quotesManagementToolStripMenuItem";
            this.quotesManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.quotesManagementToolStripMenuItem.Text = "Quotes Management";
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewsManagementToolStripMenuItem});
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // reviewsManagementToolStripMenuItem
            // 
            this.reviewsManagementToolStripMenuItem.Name = "reviewsManagementToolStripMenuItem";
            this.reviewsManagementToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.reviewsManagementToolStripMenuItem.Text = "Reviews Management";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsManagementToolStripMenuItem,
            this.mostActiveUsersToolStripMenuItem,
            this.genreComparisonReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // reportsManagementToolStripMenuItem
            // 
            this.reportsManagementToolStripMenuItem.Name = "reportsManagementToolStripMenuItem";
            this.reportsManagementToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.reportsManagementToolStripMenuItem.Text = "Most Popular Books";
            // 
            // mostActiveUsersToolStripMenuItem
            // 
            this.mostActiveUsersToolStripMenuItem.Name = "mostActiveUsersToolStripMenuItem";
            this.mostActiveUsersToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.mostActiveUsersToolStripMenuItem.Text = "Most Active Users";
            // 
            // genreComparisonReportToolStripMenuItem
            // 
            this.genreComparisonReportToolStripMenuItem.Name = "genreComparisonReportToolStripMenuItem";
            this.genreComparisonReportToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.genreComparisonReportToolStripMenuItem.Text = "Genre Comparison Report";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quotesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostActiveUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreComparisonReportToolStripMenuItem;
    }
}