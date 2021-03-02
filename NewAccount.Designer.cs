
namespace LoyaltyPrime
{
    partial class NewAccount
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
            this.acountStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.acountNameComboxBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewAccount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // acountStatusComboBox
            // 
            this.acountStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acountStatusComboBox.FormattingEnabled = true;
            this.acountStatusComboBox.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.acountStatusComboBox.Location = new System.Drawing.Point(292, 315);
            this.acountStatusComboBox.Name = "acountStatusComboBox";
            this.acountStatusComboBox.Size = new System.Drawing.Size(314, 32);
            this.acountStatusComboBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Account Status";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(194, 264);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(36, 13);
            this.points.TabIndex = 23;
            this.points.Text = "Points";
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsTextBox.Location = new System.Drawing.Point(292, 255);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(314, 29);
            this.pointsTextBox.TabIndex = 21;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(444, 374);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(241, 70);
            this.cancel.TabIndex = 28;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // acountNameComboxBox
            // 
            this.acountNameComboxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acountNameComboxBox.FormattingEnabled = true;
            this.acountNameComboxBox.Items.AddRange(new object[] {
            "BURGER KING",
            "MCDONALDS",
            "PLAYSTATION",
            "XBOX",
            "BMW"});
            this.acountNameComboxBox.Location = new System.Drawing.Point(292, 192);
            this.acountNameComboxBox.Name = "acountNameComboxBox";
            this.acountNameComboxBox.Size = new System.Drawing.Size(314, 32);
            this.acountNameComboxBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Account Name";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(318, 479);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(314, 29);
            this.filterTextBox.TabIndex = 32;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Filter By First Name";
            // 
            // createNewAccount
            // 
            this.createNewAccount.Location = new System.Drawing.Point(162, 374);
            this.createNewAccount.Name = "createNewAccount";
            this.createNewAccount.Size = new System.Drawing.Size(241, 70);
            this.createNewAccount.TabIndex = 35;
            this.createNewAccount.Text = "Create";
            this.createNewAccount.UseVisualStyleBackColor = true;
            this.createNewAccount.Click += new System.EventHandler(this.createNewAccount_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(47, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 320);
            this.dataGridView1.TabIndex = 36;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "UserID";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(292, 132);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.ReadOnly = true;
            this.userIDTextBox.Size = new System.Drawing.Size(314, 29);
            this.userIDTextBox.TabIndex = 37;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(196, 75);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 42;
            this.lastName.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(196, 12);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 41;
            this.firstName.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(292, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(314, 29);
            this.firstNameTextBox.TabIndex = 39;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(292, 72);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(314, 29);
            this.lastNameTextBox.TabIndex = 40;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 864);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.createNewAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.acountNameComboxBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.acountStatusComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.points);
            this.Controls.Add(this.pointsTextBox);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox acountStatusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox acountNameComboxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createNewAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
    }
}