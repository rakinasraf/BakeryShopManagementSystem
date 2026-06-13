namespace OOP2FinalProject
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnEditStaffprofile = new System.Windows.Forms.Button();
            this.btnProductDetails = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.lblStaffSalary = new System.Windows.Forms.Label();
            this.lblstaffName = new System.Windows.Forms.Label();
            this.lblStaffGender = new System.Windows.Forms.Label();
            this.lblStaffMobile = new System.Windows.Forms.Label();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.lblStaffPassword = new System.Windows.Forms.Label();
            this.lblStaffJoiningDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.btnEditStaffprofile);
            this.panel2.Controls.Add(this.btnProductDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 461);
            this.panel2.TabIndex = 228;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(73, 60);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(73, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "WELCOME,";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.Location = new System.Drawing.Point(43, 410);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(150, 35);
            this.btnlogout.TabIndex = 50;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnEditStaffprofile
            // 
            this.btnEditStaffprofile.BackColor = System.Drawing.Color.Transparent;
            this.btnEditStaffprofile.FlatAppearance.BorderSize = 0;
            this.btnEditStaffprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaffprofile.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaffprofile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditStaffprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStaffprofile.Image")));
            this.btnEditStaffprofile.Location = new System.Drawing.Point(27, 179);
            this.btnEditStaffprofile.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditStaffprofile.Name = "btnEditStaffprofile";
            this.btnEditStaffprofile.Size = new System.Drawing.Size(208, 35);
            this.btnEditStaffprofile.TabIndex = 55;
            this.btnEditStaffprofile.Text = " Edit profile";
            this.btnEditStaffprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStaffprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStaffprofile.UseVisualStyleBackColor = false;
            this.btnEditStaffprofile.Click += new System.EventHandler(this.btnEditStaffprofile_Click);
            // 
            // btnProductDetails
            // 
            this.btnProductDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnProductDetails.FlatAppearance.BorderSize = 0;
            this.btnProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDetails.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDetails.Image")));
            this.btnProductDetails.Location = new System.Drawing.Point(27, 137);
            this.btnProductDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDetails.Name = "btnProductDetails";
            this.btnProductDetails.Size = new System.Drawing.Size(208, 35);
            this.btnProductDetails.TabIndex = 51;
            this.btnProductDetails.Text = " Product Details";
            this.btnProductDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductDetails.UseVisualStyleBackColor = false;
            this.btnProductDetails.Click += new System.EventHandler(this.btnProductDetails_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.lblStaffId);
            this.pnlAdmin.Controls.Add(this.lblStaffEmail);
            this.pnlAdmin.Controls.Add(this.lblStaffSalary);
            this.pnlAdmin.Controls.Add(this.lblstaffName);
            this.pnlAdmin.Controls.Add(this.lblStaffGender);
            this.pnlAdmin.Controls.Add(this.lblStaffMobile);
            this.pnlAdmin.Controls.Add(this.lblStaffAddress);
            this.pnlAdmin.Controls.Add(this.lblStaffPassword);
            this.pnlAdmin.Controls.Add(this.lblStaffJoiningDate);
            this.pnlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdmin.Location = new System.Drawing.Point(67, 25);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(354, 406);
            this.pnlAdmin.TabIndex = 229;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "User Id : ";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffId.Location = new System.Drawing.Point(137, 96);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(0, 18);
            this.lblStaffId.TabIndex = 54;
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffEmail.ForeColor = System.Drawing.Color.Black;
            this.lblStaffEmail.Location = new System.Drawing.Point(76, 300);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(64, 18);
            this.lblStaffEmail.TabIndex = 53;
            this.lblStaffEmail.Text = "Email : ";
            // 
            // lblStaffSalary
            // 
            this.lblStaffSalary.AutoSize = true;
            this.lblStaffSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSalary.ForeColor = System.Drawing.Color.Black;
            this.lblStaffSalary.Location = new System.Drawing.Point(76, 270);
            this.lblStaffSalary.Name = "lblStaffSalary";
            this.lblStaffSalary.Size = new System.Drawing.Size(72, 18);
            this.lblStaffSalary.TabIndex = 52;
            this.lblStaffSalary.Text = "Salary : ";
            // 
            // lblstaffName
            // 
            this.lblstaffName.AutoSize = true;
            this.lblstaffName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaffName.ForeColor = System.Drawing.Color.Black;
            this.lblstaffName.Location = new System.Drawing.Point(73, 124);
            this.lblstaffName.Name = "lblstaffName";
            this.lblstaffName.Size = new System.Drawing.Size(67, 18);
            this.lblstaffName.TabIndex = 46;
            this.lblstaffName.Text = "Name : ";
            // 
            // lblStaffGender
            // 
            this.lblStaffGender.AutoSize = true;
            this.lblStaffGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffGender.ForeColor = System.Drawing.Color.Black;
            this.lblStaffGender.Location = new System.Drawing.Point(59, 154);
            this.lblStaffGender.Name = "lblStaffGender";
            this.lblStaffGender.Size = new System.Drawing.Size(81, 18);
            this.lblStaffGender.TabIndex = 47;
            this.lblStaffGender.Text = "Gender : ";
            // 
            // lblStaffMobile
            // 
            this.lblStaffMobile.AutoSize = true;
            this.lblStaffMobile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMobile.ForeColor = System.Drawing.Color.Black;
            this.lblStaffMobile.Location = new System.Drawing.Point(68, 183);
            this.lblStaffMobile.Name = "lblStaffMobile";
            this.lblStaffMobile.Size = new System.Drawing.Size(72, 18);
            this.lblStaffMobile.TabIndex = 48;
            this.lblStaffMobile.Text = "Mobile : ";
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAddress.ForeColor = System.Drawing.Color.Black;
            this.lblStaffAddress.Location = new System.Drawing.Point(52, 214);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(88, 18);
            this.lblStaffAddress.TabIndex = 49;
            this.lblStaffAddress.Text = "Address : ";
            // 
            // lblStaffPassword
            // 
            this.lblStaffPassword.AutoSize = true;
            this.lblStaffPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPassword.ForeColor = System.Drawing.Color.Black;
            this.lblStaffPassword.Location = new System.Drawing.Point(40, 329);
            this.lblStaffPassword.Name = "lblStaffPassword";
            this.lblStaffPassword.Size = new System.Drawing.Size(100, 18);
            this.lblStaffPassword.TabIndex = 50;
            this.lblStaffPassword.Text = "Password : ";
            // 
            // lblStaffJoiningDate
            // 
            this.lblStaffJoiningDate.AutoSize = true;
            this.lblStaffJoiningDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffJoiningDate.ForeColor = System.Drawing.Color.Black;
            this.lblStaffJoiningDate.Location = new System.Drawing.Point(20, 242);
            this.lblStaffJoiningDate.Name = "lblStaffJoiningDate";
            this.lblStaffJoiningDate.Size = new System.Drawing.Size(120, 18);
            this.lblStaffJoiningDate.TabIndex = 51;
            this.lblStaffJoiningDate.Text = "Joining Date : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pnlAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(258, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 461);
            this.panel1.TabIndex = 229;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 45);
            this.label2.TabIndex = 56;
            this.label2.Text = "Staff";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Staff";
            this.Text = "Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnEditStaffprofile;
        private System.Windows.Forms.Button btnProductDetails;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblstaffName;
        private System.Windows.Forms.Label lblStaffGender;
        private System.Windows.Forms.Label lblStaffMobile;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.Label lblStaffPassword;
        private System.Windows.Forms.Label lblStaffJoiningDate;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.Label lblStaffSalary;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}