namespace OOP2FinalProject
{
    partial class ProductDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProductDetails1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.P_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_MakingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.pnlProductDetails2 = new System.Windows.Forms.Panel();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.btnBackpdltoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtMakingDate = new System.Windows.Forms.TextBox();
            this.lblMakingDate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProductDetails1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.pnlProductDetails2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductDetails1
            // 
            this.pnlProductDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlProductDetails1.Controls.Add(this.label1);
            this.pnlProductDetails1.Controls.Add(this.dgvProductDetails);
            this.pnlProductDetails1.Controls.Add(this.txtAutoSearch);
            this.pnlProductDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductDetails1.Location = new System.Drawing.Point(0, 0);
            this.pnlProductDetails1.Name = "pnlProductDetails1";
            this.pnlProductDetails1.Size = new System.Drawing.Size(734, 236);
            this.pnlProductDetails1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_Id,
            this.P_Name,
            this.P_Price,
            this.P_Quantity,
            this.P_MakingDate,
            this.P_ExpiryDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 38);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.RowHeadersVisible = false;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(734, 198);
            this.dgvProductDetails.TabIndex = 2;
            this.dgvProductDetails.DoubleClick += new System.EventHandler(this.dgvProductDetails_DoubleClick);
            // 
            // P_Id
            // 
            this.P_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_Id.DataPropertyName = "P_Id";
            this.P_Id.HeaderText = "Product ID";
            this.P_Id.Name = "P_Id";
            this.P_Id.ReadOnly = true;
            // 
            // P_Name
            // 
            this.P_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_Name.DataPropertyName = "P_Name";
            this.P_Name.HeaderText = "Name";
            this.P_Name.Name = "P_Name";
            this.P_Name.ReadOnly = true;
            // 
            // P_Price
            // 
            this.P_Price.DataPropertyName = "P_Price";
            this.P_Price.HeaderText = "Price";
            this.P_Price.Name = "P_Price";
            this.P_Price.ReadOnly = true;
            this.P_Price.Width = 70;
            // 
            // P_Quantity
            // 
            this.P_Quantity.DataPropertyName = "P_Quantity";
            this.P_Quantity.HeaderText = "Quantity";
            this.P_Quantity.Name = "P_Quantity";
            this.P_Quantity.ReadOnly = true;
            this.P_Quantity.ToolTipText = "Income of the Movie";
            // 
            // P_MakingDate
            // 
            this.P_MakingDate.DataPropertyName = "P_MakingDate";
            this.P_MakingDate.HeaderText = "Making Date";
            this.P_MakingDate.Name = "P_MakingDate";
            this.P_MakingDate.ReadOnly = true;
            // 
            // P_ExpiryDate
            // 
            this.P_ExpiryDate.DataPropertyName = "P_ExpiryDate";
            this.P_ExpiryDate.HeaderText = "Expiry Date";
            this.P_ExpiryDate.Name = "P_ExpiryDate";
            this.P_ExpiryDate.ReadOnly = true;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(476, 12);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(230, 20);
            this.txtAutoSearch.TabIndex = 1;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // pnlProductDetails2
            // 
            this.pnlProductDetails2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlProductDetails2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductDetails2.Controls.Add(this.label3);
            this.pnlProductDetails2.Controls.Add(this.label2);
            this.pnlProductDetails2.Controls.Add(this.lblAdminId);
            this.pnlProductDetails2.Controls.Add(this.btnBackpdltoad);
            this.pnlProductDetails2.Controls.Add(this.btnClear);
            this.pnlProductDetails2.Controls.Add(this.btnDelete);
            this.pnlProductDetails2.Controls.Add(this.btnInsert);
            this.pnlProductDetails2.Controls.Add(this.txtExpiryDate);
            this.pnlProductDetails2.Controls.Add(this.lblExpiryDate);
            this.pnlProductDetails2.Controls.Add(this.txtMakingDate);
            this.pnlProductDetails2.Controls.Add(this.lblMakingDate);
            this.pnlProductDetails2.Controls.Add(this.txtQuantity);
            this.pnlProductDetails2.Controls.Add(this.lblQuantity);
            this.pnlProductDetails2.Controls.Add(this.txtPrice);
            this.pnlProductDetails2.Controls.Add(this.lblPrice);
            this.pnlProductDetails2.Controls.Add(this.txtName);
            this.pnlProductDetails2.Controls.Add(this.lblName);
            this.pnlProductDetails2.Controls.Add(this.txtProductId);
            this.pnlProductDetails2.Controls.Add(this.lblProductId);
            this.pnlProductDetails2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProductDetails2.Location = new System.Drawing.Point(0, 242);
            this.pnlProductDetails2.Name = "pnlProductDetails2";
            this.pnlProductDetails2.Size = new System.Drawing.Size(734, 219);
            this.pnlProductDetails2.TabIndex = 2;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdminId.Location = new System.Drawing.Point(37, 139);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 18);
            this.lblAdminId.TabIndex = 21;
            this.lblAdminId.Visible = false;
            // 
            // btnBackpdltoad
            // 
            this.btnBackpdltoad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBackpdltoad.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackpdltoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackpdltoad.Location = new System.Drawing.Point(450, 166);
            this.btnBackpdltoad.Name = "btnBackpdltoad";
            this.btnBackpdltoad.Size = new System.Drawing.Size(75, 30);
            this.btnBackpdltoad.TabIndex = 20;
            this.btnBackpdltoad.Text = "Back";
            this.btnBackpdltoad.UseVisualStyleBackColor = false;
            this.btnBackpdltoad.Click += new System.EventHandler(this.btnBackpdltoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(369, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
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
            this.btnDelete.Location = new System.Drawing.Point(288, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
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
            this.btnInsert.Location = new System.Drawing.Point(207, 166);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 30);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(399, 116);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(278, 20);
            this.txtExpiryDate.TabIndex = 12;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExpiryDate.Location = new System.Drawing.Point(396, 90);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(100, 18);
            this.lblExpiryDate.TabIndex = 11;
            this.lblExpiryDate.Text = "Expiry Date :";
            // 
            // txtMakingDate
            // 
            this.txtMakingDate.Location = new System.Drawing.Point(399, 67);
            this.txtMakingDate.Name = "txtMakingDate";
            this.txtMakingDate.Size = new System.Drawing.Size(278, 20);
            this.txtMakingDate.TabIndex = 10;
            // 
            // lblMakingDate
            // 
            this.lblMakingDate.AutoSize = true;
            this.lblMakingDate.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakingDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMakingDate.Location = new System.Drawing.Point(396, 38);
            this.lblMakingDate.Name = "lblMakingDate";
            this.lblMakingDate.Size = new System.Drawing.Size(106, 18);
            this.lblMakingDate.TabIndex = 9;
            this.lblMakingDate.Text = "Making Date :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 114);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(230, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantity.Location = new System.Drawing.Point(35, 116);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 18);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(230, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(61, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 18);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(57, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(120, 36);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(230, 20);
            this.txtProductId.TabIndex = 2;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductId.Location = new System.Drawing.Point(24, 39);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(91, 18);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(525, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "*Date Formate (YYYY-MM-DD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(525, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "*Date Formate (YYYY-MM-DD)";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlProductDetails2);
            this.Controls.Add(this.pnlProductDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductDetails";
            this.Text = "Product Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductDetails_FormClosed);
            this.pnlProductDetails1.ResumeLayout(false);
            this.pnlProductDetails1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.pnlProductDetails2.ResumeLayout(false);
            this.pnlProductDetails2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductDetails1;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Panel pnlProductDetails2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtMakingDate;
        private System.Windows.Forms.Label lblMakingDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_MakingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ExpiryDate;
        private System.Windows.Forms.Button btnBackpdltoad;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}