
namespace LoyaltyPrime
{
    partial class LoyaltyPrime
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
            this.newUser = new System.Windows.Forms.Button();
            this.newAccount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.addPoints = new System.Windows.Forms.Button();
            this.usePoints = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteUser = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.AccountIDTextBox = new System.Windows.Forms.TextBox();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.availablePointsTextBox = new System.Windows.Forms.TextBox();
            this.accountStatusTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextAccount = new System.Windows.Forms.TextBox();
            this.pointsUsedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.ToggleStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // newUser
            // 
            this.newUser.Location = new System.Drawing.Point(12, 31);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(241, 70);
            this.newUser.TabIndex = 5;
            this.newUser.Text = "Create New User";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // newAccount
            // 
            this.newAccount.Location = new System.Drawing.Point(809, 28);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(241, 64);
            this.newAccount.TabIndex = 6;
            this.newAccount.Text = "New Account";
            this.newAccount.UseVisualStyleBackColor = true;
            this.newAccount.Click += new System.EventHandler(this.newAccount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 458);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UserID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Location = new System.Drawing.Point(870, 214);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(78, 13);
            this.accountName.TabIndex = 10;
            this.accountName.Text = "Account Name";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(870, 257);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(36, 13);
            this.points.TabIndex = 11;
            this.points.Text = "Points";
            // 
            // addPoints
            // 
            this.addPoints.Location = new System.Drawing.Point(569, 128);
            this.addPoints.Name = "addPoints";
            this.addPoints.Size = new System.Drawing.Size(241, 64);
            this.addPoints.TabIndex = 14;
            this.addPoints.Text = "Add points";
            this.addPoints.UseVisualStyleBackColor = true;
            this.addPoints.Click += new System.EventHandler(this.addPoints_Click);
            // 
            // usePoints
            // 
            this.usePoints.Location = new System.Drawing.Point(569, 212);
            this.usePoints.Name = "usePoints";
            this.usePoints.Size = new System.Drawing.Size(241, 70);
            this.usePoints.TabIndex = 13;
            this.usePoints.Text = "Use Points";
            this.usePoints.UseVisualStyleBackColor = true;
            this.usePoints.Click += new System.EventHandler(this.usePoints_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView2.Location = new System.Drawing.Point(702, 415);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(633, 458);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "AccountID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UserID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Account Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Points Available";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Points Spent";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Status";
            this.Column11.Name = "Column11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "List of Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "List of Accounts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Account Status";
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(320, 31);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(241, 70);
            this.deleteUser.TabIndex = 21;
            this.deleteUser.Text = "Delete User";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(60, 323);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 27;
            this.address.Text = "Address";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(60, 269);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 26;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(60, 222);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 25;
            this.firstName.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(156, 222);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(314, 29);
            this.firstNameTextBox.TabIndex = 22;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(156, 269);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(314, 29);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(156, 316);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(314, 29);
            this.addressTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "UserID";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(156, 171);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.ReadOnly = true;
            this.userIDTextBox.Size = new System.Drawing.Size(314, 29);
            this.userIDTextBox.TabIndex = 28;
            // 
            // AccountIDTextBox
            // 
            this.AccountIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountIDTextBox.Location = new System.Drawing.Point(977, 117);
            this.AccountIDTextBox.Name = "AccountIDTextBox";
            this.AccountIDTextBox.ReadOnly = true;
            this.AccountIDTextBox.Size = new System.Drawing.Size(314, 29);
            this.AccountIDTextBox.TabIndex = 33;
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameTextBox.Location = new System.Drawing.Point(977, 201);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.ReadOnly = true;
            this.accountNameTextBox.Size = new System.Drawing.Size(314, 29);
            this.accountNameTextBox.TabIndex = 30;
            // 
            // availablePointsTextBox
            // 
            this.availablePointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePointsTextBox.Location = new System.Drawing.Point(977, 243);
            this.availablePointsTextBox.Name = "availablePointsTextBox";
            this.availablePointsTextBox.ReadOnly = true;
            this.availablePointsTextBox.Size = new System.Drawing.Size(314, 29);
            this.availablePointsTextBox.TabIndex = 31;
            // 
            // accountStatusTextBox
            // 
            this.accountStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStatusTextBox.Location = new System.Drawing.Point(977, 327);
            this.accountStatusTextBox.Name = "accountStatusTextBox";
            this.accountStatusTextBox.ReadOnly = true;
            this.accountStatusTextBox.Size = new System.Drawing.Size(314, 29);
            this.accountStatusTextBox.TabIndex = 32;
            // 
            // userIDTextAccount
            // 
            this.userIDTextAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextAccount.Location = new System.Drawing.Point(977, 159);
            this.userIDTextAccount.Name = "userIDTextAccount";
            this.userIDTextAccount.ReadOnly = true;
            this.userIDTextAccount.Size = new System.Drawing.Size(314, 29);
            this.userIDTextAccount.TabIndex = 34;
            // 
            // pointsUsedTextBox
            // 
            this.pointsUsedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsUsedTextBox.Location = new System.Drawing.Point(977, 285);
            this.pointsUsedTextBox.Name = "pointsUsedTextBox";
            this.pointsUsedTextBox.ReadOnly = true;
            this.pointsUsedTextBox.Size = new System.Drawing.Size(314, 29);
            this.pointsUsedTextBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(870, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Points Used";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(870, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "AccountID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(870, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "UserID";
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(1077, 28);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(241, 70);
            this.deleteAccount.TabIndex = 39;
            this.deleteAccount.Text = "Delete Account";
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // ToggleStatus
            // 
            this.ToggleStatus.Location = new System.Drawing.Point(569, 304);
            this.ToggleStatus.Name = "ToggleStatus";
            this.ToggleStatus.Size = new System.Drawing.Size(241, 70);
            this.ToggleStatus.TabIndex = 40;
            this.ToggleStatus.Text = "Toggle Account Status";
            this.ToggleStatus.UseVisualStyleBackColor = true;
            this.ToggleStatus.Click += new System.EventHandler(this.ToggleStatus_Click);
            // 
            // LoyaltyPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 904);
            this.Controls.Add(this.ToggleStatus);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pointsUsedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userIDTextAccount);
            this.Controls.Add(this.AccountIDTextBox);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.availablePointsTextBox);
            this.Controls.Add(this.accountStatusTextBox);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.addPoints);
            this.Controls.Add(this.usePoints);
            this.Controls.Add(this.points);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newAccount);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Name = "LoyaltyPrime";
            this.Text = "Loyalty Prime";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button newAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Button addPoints;
        private System.Windows.Forms.Button usePoints;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox AccountIDTextBox;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.TextBox availablePointsTextBox;
        private System.Windows.Forms.TextBox accountStatusTextBox;
        private System.Windows.Forms.TextBox userIDTextAccount;
        private System.Windows.Forms.TextBox pointsUsedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Button ToggleStatus;
    }
}

