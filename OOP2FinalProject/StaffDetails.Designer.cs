namespace OOP2FinalProject
{
    partial class StaffDetails
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
            this.pnlStuffLDetails1 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.dgvStaffDetails = new System.Windows.Forms.DataGridView();
            this.S_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoDataSet = new OOP2FinalProject.UserInfoDataSet();
            this.pnlStaffDetails2 = new System.Windows.Forms.Panel();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtJoiningDate = new System.Windows.Forms.TextBox();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStuffLDetails1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet)).BeginInit();
            this.pnlStaffDetails2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStuffLDetails1
            // 
            this.pnlStuffLDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlStuffLDetails1.Controls.Add(this.label1);
            this.pnlStuffLDetails1.Controls.Add(this.txtAutoSearch);
            this.pnlStuffLDetails1.Controls.Add(this.dgvStaffDetails);
            this.pnlStuffLDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStuffLDetails1.Location = new System.Drawing.Point(0, 0);
            this.pnlStuffLDetails1.Name = "pnlStuffLDetails1";
            this.pnlStuffLDetails1.Size = new System.Drawing.Size(734, 236);
            this.pnlStuffLDetails1.TabIndex = 0;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(492, 12);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(230, 20);
            this.txtAutoSearch.TabIndex = 1;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // dgvStaffDetails
            // 
            this.dgvStaffDetails.AllowUserToAddRows = false;
            this.dgvStaffDetails.AllowUserToOrderColumns = true;
            this.dgvStaffDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStaffDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_Id,
            this.S_Name,
            this.S_Gender,
            this.S_Mobile,
            this.S_Address,
            this.S_JoiningDate,
            this.S_Salary,
            this.S_Email});
            this.dgvStaffDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStaffDetails.Location = new System.Drawing.Point(0, 38);
            this.dgvStaffDetails.Name = "dgvStaffDetails";
            this.dgvStaffDetails.ReadOnly = true;
            this.dgvStaffDetails.RowHeadersVisible = false;
            this.dgvStaffDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffDetails.Size = new System.Drawing.Size(734, 198);
            this.dgvStaffDetails.TabIndex = 0;
            this.dgvStaffDetails.DoubleClick += new System.EventHandler(this.dgvStaffDetails_DoubleClick);
            // 
            // S_Id
            // 
            this.S_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Id.DataPropertyName = "S_Id";
            this.S_Id.HeaderText = "Staff_ID";
            this.S_Id.Name = "S_Id";
            this.S_Id.ReadOnly = true;
            // 
            // S_Name
            // 
            this.S_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Name.DataPropertyName = "S_Name";
            this.S_Name.HeaderText = "Name";
            this.S_Name.Name = "S_Name";
            this.S_Name.ReadOnly = true;
            // 
            // S_Gender
            // 
            this.S_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Gender.DataPropertyName = "S_Gender";
            this.S_Gender.HeaderText = "Gender";
            this.S_Gender.Name = "S_Gender";
            this.S_Gender.ReadOnly = true;
            // 
            // S_Mobile
            // 
            this.S_Mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Mobile.DataPropertyName = "S_Mobile";
            this.S_Mobile.HeaderText = "Mobile";
            this.S_Mobile.Name = "S_Mobile";
            this.S_Mobile.ReadOnly = true;
            // 
            // S_Address
            // 
            this.S_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Address.DataPropertyName = "S_Address";
            this.S_Address.HeaderText = "Address";
            this.S_Address.Name = "S_Address";
            this.S_Address.ReadOnly = true;
            // 
            // S_JoiningDate
            // 
            this.S_JoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_JoiningDate.DataPropertyName = "S_JoiningDate";
            this.S_JoiningDate.HeaderText = "Joining Date";
            this.S_JoiningDate.Name = "S_JoiningDate";
            this.S_JoiningDate.ReadOnly = true;
            // 
            // S_Salary
            // 
            this.S_Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Salary.DataPropertyName = "S_Salary";
            this.S_Salary.HeaderText = "Salary";
            this.S_Salary.Name = "S_Salary";
            this.S_Salary.ReadOnly = true;
            // 
            // S_Email
            // 
            this.S_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S_Email.DataPropertyName = "S_Email";
            this.S_Email.HeaderText = "Email";
            this.S_Email.Name = "S_Email";
            this.S_Email.ReadOnly = true;
            // 
            // userInfoDataSetBindingSource
            // 
            this.userInfoDataSetBindingSource.DataSource = this.userInfoDataSet;
            this.userInfoDataSetBindingSource.Position = 0;
            // 
            // userInfoDataSet
            // 
            this.userInfoDataSet.DataSetName = "UserInfoDataSet";
            this.userInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlStaffDetails2
            // 
            this.pnlStaffDetails2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlStaffDetails2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffDetails2.Controls.Add(this.lblAdminId);
            this.pnlStaffDetails2.Controls.Add(this.btnBack);
            this.pnlStaffDetails2.Controls.Add(this.btnClear);
            this.pnlStaffDetails2.Controls.Add(this.btnDelete);
            this.pnlStaffDetails2.Controls.Add(this.btnInsert);
            this.pnlStaffDetails2.Controls.Add(this.txtEmail);
            this.pnlStaffDetails2.Controls.Add(this.lblEmail);
            this.pnlStaffDetails2.Controls.Add(this.txtSalary);
            this.pnlStaffDetails2.Controls.Add(this.lblSalary);
            this.pnlStaffDetails2.Controls.Add(this.txtJoiningDate);
            this.pnlStaffDetails2.Controls.Add(this.lblJoiningDate);
            this.pnlStaffDetails2.Controls.Add(this.txtAddress);
            this.pnlStaffDetails2.Controls.Add(this.lblAddress);
            this.pnlStaffDetails2.Controls.Add(this.txtMobile);
            this.pnlStaffDetails2.Controls.Add(this.lblMobile);
            this.pnlStaffDetails2.Controls.Add(this.txtGender);
            this.pnlStaffDetails2.Controls.Add(this.lblGender);
            this.pnlStaffDetails2.Controls.Add(this.txtName);
            this.pnlStaffDetails2.Controls.Add(this.lblName);
            this.pnlStaffDetails2.Controls.Add(this.txtUserId);
            this.pnlStaffDetails2.Controls.Add(this.lblUserId);
            this.pnlStaffDetails2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStaffDetails2.Location = new System.Drawing.Point(0, 242);
            this.pnlStaffDetails2.Name = "pnlStaffDetails2";
            this.pnlStaffDetails2.Size = new System.Drawing.Size(734, 219);
            this.pnlStaffDetails2.TabIndex = 1;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(633, 128);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 13);
            this.lblAdminId.TabIndex = 21;
            this.lblAdminId.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(443, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(362, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDelete.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(281, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInsert.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsert.Location = new System.Drawing.Point(200, 147);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(470, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(411, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 18);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email :";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(470, 70);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(230, 20);
            this.txtSalary.TabIndex = 14;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalary.Location = new System.Drawing.Point(405, 73);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(62, 18);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Salary :";
            // 
            // txtJoiningDate
            // 
            this.txtJoiningDate.Location = new System.Drawing.Point(470, 44);
            this.txtJoiningDate.Name = "txtJoiningDate";
            this.txtJoiningDate.Size = new System.Drawing.Size(230, 20);
            this.txtJoiningDate.TabIndex = 12;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJoiningDate.Location = new System.Drawing.Point(361, 47);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(107, 18);
            this.lblJoiningDate.TabIndex = 11;
            this.lblJoiningDate.Text = "Joining Date :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(470, 18);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.Location = new System.Drawing.Point(394, 21);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 18);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address :";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(96, 96);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(230, 20);
            this.txtMobile.TabIndex = 8;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMobile.Location = new System.Drawing.Point(27, 99);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(63, 18);
            this.lblMobile.TabIndex = 7;
            this.lblMobile.Text = "Mobile :";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(96, 70);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(230, 20);
            this.txtGender.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(23, 73);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 18);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(30, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(96, 18);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(230, 20);
            this.txtUserId.TabIndex = 2;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserId.Location = new System.Drawing.Point(24, 21);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(68, 18);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlStaffDetails2);
            this.Controls.Add(this.pnlStuffLDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StaffDetails";
            this.Text = "StaffDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDetails_FormClosed);
            this.pnlStuffLDetails1.ResumeLayout(false);
            this.pnlStuffLDetails1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet)).EndInit();
            this.pnlStaffDetails2.ResumeLayout(false);
            this.pnlStaffDetails2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStuffLDetails1;
        private System.Windows.Forms.DataGridView dgvStaffDetails;
        private System.Windows.Forms.Panel pnlStaffDetails2;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtJoiningDate;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.BindingSource userInfoDataSetBindingSource;
        private UserInfoDataSet userInfoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Email;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label label1;
    }
}