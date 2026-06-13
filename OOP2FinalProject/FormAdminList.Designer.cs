namespace OOP2FinalProject
{
    partial class FormAdminList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.dgvAdminList = new System.Windows.Forms.DataGridView();
            this.userInfoDataSet = new OOP2FinalProject.UserInfoDataSet();
            this.userInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btnAdminInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.A_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmin.Controls.Add(this.lblSearch);
            this.pnlAdmin.Controls.Add(this.lblAdminId);
            this.pnlAdmin.Controls.Add(this.txtAutoSearch);
            this.pnlAdmin.Controls.Add(this.dgvAdminList);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(734, 272);
            this.pnlAdmin.TabIndex = 4;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(11, 8);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 37);
            this.lblAdminId.TabIndex = 14;
            this.lblAdminId.Visible = false;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(555, 11);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(166, 26);
            this.txtAutoSearch.TabIndex = 13;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.AllowUserToAddRows = false;
            this.dgvAdminList.AllowUserToDeleteRows = false;
            this.dgvAdminList.AllowUserToResizeColumns = false;
            this.dgvAdminList.AllowUserToResizeRows = false;
            this.dgvAdminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAdminList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_Id,
            this.A_Name,
            this.A_Gender,
            this.A_Mobile,
            this.A_Address,
            this.A_Email});
            this.dgvAdminList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdminList.Location = new System.Drawing.Point(0, 46);
            this.dgvAdminList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAdminList.Name = "dgvAdminList";
            this.dgvAdminList.ReadOnly = true;
            this.dgvAdminList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdminList.RowHeadersVisible = false;
            this.dgvAdminList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAdminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminList.Size = new System.Drawing.Size(732, 224);
            this.dgvAdminList.TabIndex = 12;
            this.dgvAdminList.DoubleClick += new System.EventHandler(this.dgvAdminList_DoubleClick);
            // 
            // userInfoDataSet
            // 
            this.userInfoDataSet.DataSetName = "UserInfoDataSet";
            this.userInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoDataSetBindingSource
            // 
            this.userInfoDataSetBindingSource.DataSource = this.userInfoDataSet;
            this.userInfoDataSetBindingSource.Position = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(625, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(115, 28);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(139, 20);
            this.txtUserId.TabIndex = 3;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(49, 31);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(60, 18);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "User Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(352, 74);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(127, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(291, 74);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(55, 18);
            this.lblMobile.TabIndex = 10;
            this.lblMobile.Text = "Mobile";
            // 
            // btnAdminInsert
            // 
            this.btnAdminInsert.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdminInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminInsert.ForeColor = System.Drawing.Color.Black;
            this.btnAdminInsert.Location = new System.Drawing.Point(62, 147);
            this.btnAdminInsert.Name = "btnAdminInsert";
            this.btnAdminInsert.Size = new System.Drawing.Size(75, 28);
            this.btnAdminInsert.TabIndex = 13;
            this.btnAdminInsert.Text = "Save";
            this.btnAdminInsert.UseVisualStyleBackColor = false;
            this.btnAdminInsert.Click += new System.EventHandler(this.btnAdminInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(152, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(349, 28);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(130, 20);
            this.txtGender.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gender";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(568, 29);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(554, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(244, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdminInsert);
            this.panel1.Controls.Add(this.lblMobile);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblUserId);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 187);
            this.panel1.TabIndex = 5;
            // 
            // A_Id
            // 
            this.A_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Id.DataPropertyName = "A_Id";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Id.DefaultCellStyle = dataGridViewCellStyle9;
            this.A_Id.HeaderText = "Admin ID";
            this.A_Id.Name = "A_Id";
            this.A_Id.ReadOnly = true;
            // 
            // A_Name
            // 
            this.A_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Name.DataPropertyName = "A_Name";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Name.DefaultCellStyle = dataGridViewCellStyle10;
            this.A_Name.HeaderText = "Name";
            this.A_Name.Name = "A_Name";
            this.A_Name.ReadOnly = true;
            // 
            // A_Gender
            // 
            this.A_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Gender.DataPropertyName = "A_Gender";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Gender.DefaultCellStyle = dataGridViewCellStyle11;
            this.A_Gender.HeaderText = "Gender";
            this.A_Gender.Name = "A_Gender";
            this.A_Gender.ReadOnly = true;
            // 
            // A_Mobile
            // 
            this.A_Mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Mobile.DataPropertyName = "A_Mobile";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Mobile.DefaultCellStyle = dataGridViewCellStyle12;
            this.A_Mobile.HeaderText = "Mobile No";
            this.A_Mobile.Name = "A_Mobile";
            this.A_Mobile.ReadOnly = true;
            // 
            // A_Address
            // 
            this.A_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Address.DataPropertyName = "A_Address";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Address.DefaultCellStyle = dataGridViewCellStyle13;
            this.A_Address.HeaderText = "Address";
            this.A_Address.Name = "A_Address";
            this.A_Address.ReadOnly = true;
            // 
            // A_Email
            // 
            this.A_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Email.DataPropertyName = "A_Email";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_Email.DefaultCellStyle = dataGridViewCellStyle14;
            this.A_Email.HeaderText = "Email";
            this.A_Email.Name = "A_Email";
            this.A_Email.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(494, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 18);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // FormAdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdminList";
            this.Text = "AdminList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminList_FormClosed);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.DataGridView dgvAdminList;
        private System.Windows.Forms.BindingSource userInfoDataSetBindingSource;
        private UserInfoDataSet userInfoDataSet;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Button btnAdminInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Email;
        private System.Windows.Forms.Label lblSearch;
    }
}