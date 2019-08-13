namespace BookDiary.Desktop.Users
{
    partial class UsersForm
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
            this.allUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.disabledUsersCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allUsersDataGrid
            // 
            this.allUsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allUsersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.usernameColumn,
            this.nameColumn,
            this.LastName,
            this.emailColumn,
            this.statusColumn});
            this.allUsersDataGrid.Location = new System.Drawing.Point(42, 128);
            this.allUsersDataGrid.Name = "allUsersDataGrid";
            this.allUsersDataGrid.RowHeadersWidth = 51;
            this.allUsersDataGrid.RowTemplate.Height = 24;
            this.allUsersDataGrid.Size = new System.Drawing.Size(920, 396);
            this.allUsersDataGrid.TabIndex = 0;
            this.allUsersDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllUsersDataGrid_CellDoubleClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "Id";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // usernameColumn
            // 
            this.usernameColumn.DataPropertyName = "Username";
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.MinimumWidth = 6;
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.Width = 125;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "FirstName";
            this.nameColumn.HeaderText = "First Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // emailColumn
            // 
            this.emailColumn.DataPropertyName = "Email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Width = 125;
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "Archived";
            this.statusColumn.HeaderText = "Disabled";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusColumn.Width = 125;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(361, 41);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 35);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(863, 41);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(99, 35);
            this.addUserBtn.TabIndex = 2;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your search term";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(42, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(296, 22);
            this.searchTextBox.TabIndex = 4;
            // 
            // disabledUsersCheckBox
            // 
            this.disabledUsersCheckBox.AutoSize = true;
            this.disabledUsersCheckBox.Location = new System.Drawing.Point(42, 87);
            this.disabledUsersCheckBox.Name = "disabledUsersCheckBox";
            this.disabledUsersCheckBox.Size = new System.Drawing.Size(160, 21);
            this.disabledUsersCheckBox.TabIndex = 5;
            this.disabledUsersCheckBox.Text = "Show disabled users";
            this.disabledUsersCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.disabledUsersCheckBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.allUsersDataGrid);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allUsersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allUsersDataGrid;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox disabledUsersCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusColumn;
    }
}