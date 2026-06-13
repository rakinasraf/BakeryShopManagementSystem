namespace OOP2FinalProject
{
    partial class FormMember
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
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnProductList = new System.Windows.Forms.Button();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserMobile = new System.Windows.Forms.Label();
            this.lblUserPosition = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.DarkKhaki;
            this.pnlAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmin.Controls.Add(this.btnCart);
            this.pnlAdmin.Controls.Add(this.btnProductList);
            this.pnlAdmin.Controls.Add(this.lblUserPassword);
            this.pnlAdmin.Controls.Add(this.lblUserMobile);
            this.pnlAdmin.Controls.Add(this.lblUserPosition);
            this.pnlAdmin.Controls.Add(this.lblUserName);
            this.pnlAdmin.Controls.Add(this.lblUserId);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.btnLogOut);
            this.pnlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdmin.Location = new System.Drawing.Point(58, 25);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(624, 407);
            this.pnlAdmin.TabIndex = 2;
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.Gold;
            this.btnProductList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.Location = new System.Drawing.Point(367, 38);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(200, 50);
            this.btnProductList.TabIndex = 9;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(24, 221);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(100, 18);
            this.lblUserPassword.TabIndex = 8;
            this.lblUserPassword.Text = "Password : ";
            // 
            // lblUserMobile
            // 
            this.lblUserMobile.AutoSize = true;
            this.lblUserMobile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMobile.Location = new System.Drawing.Point(24, 190);
            this.lblUserMobile.Name = "lblUserMobile";
            this.lblUserMobile.Size = new System.Drawing.Size(72, 18);
            this.lblUserMobile.TabIndex = 7;
            this.lblUserMobile.Text = "Mobile : ";
            // 
            // lblUserPosition
            // 
            this.lblUserPosition.AutoSize = true;
            this.lblUserPosition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPosition.Location = new System.Drawing.Point(24, 160);
            this.lblUserPosition.Name = "lblUserPosition";
            this.lblUserPosition.Size = new System.Drawing.Size(85, 18);
            this.lblUserPosition.TabIndex = 6;
            this.lblUserPosition.Text = "Position : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(24, 130);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 18);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Name : ";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(24, 98);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(78, 18);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "User Id : ";
            this.lblUserId.Click += new System.EventHandler(this.lblUserId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Member";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(87, 312);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 28);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Gold;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(367, 109);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(200, 50);
            this.btnCart.TabIndex = 10;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "FormMember";
            this.Text = "Member";
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserMobile;
        private System.Windows.Forms.Label lblUserPosition;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCart;
    }
}