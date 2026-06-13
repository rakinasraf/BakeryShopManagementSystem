namespace OOP2FinalProject
{
    partial class FormProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProductlistMain = new System.Windows.Forms.Panel();
            this.btnBacktoStaff = new System.Windows.Forms.Button();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.lblProductList = new System.Windows.Forms.Label();
            this.pnldgvProductList = new System.Windows.Forms.Panel();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.P_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_MakingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlProductlistMain.SuspendLayout();
            this.pnldgvProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductlistMain
            // 
            this.pnlProductlistMain.BackColor = System.Drawing.Color.Peru;
            this.pnlProductlistMain.Controls.Add(this.nudQuantity);
            this.pnlProductlistMain.Controls.Add(this.label1);
            this.pnlProductlistMain.Controls.Add(this.btnBacktoStaff);
            this.pnlProductlistMain.Controls.Add(this.lblStaffId);
            this.pnlProductlistMain.Controls.Add(this.txtAutoSearch);
            this.pnlProductlistMain.Controls.Add(this.lblQuantity);
            this.pnlProductlistMain.Controls.Add(this.btnAddToCart);
            this.pnlProductlistMain.Controls.Add(this.btnShowOrder);
            this.pnlProductlistMain.Controls.Add(this.lblProductList);
            this.pnlProductlistMain.Controls.Add(this.pnldgvProductList);
            this.pnlProductlistMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductlistMain.Location = new System.Drawing.Point(0, 0);
            this.pnlProductlistMain.Name = "pnlProductlistMain";
            this.pnlProductlistMain.Size = new System.Drawing.Size(734, 461);
            this.pnlProductlistMain.TabIndex = 1;
            // 
            // btnBacktoStaff
            // 
            this.btnBacktoStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.btnBacktoStaff.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBacktoStaff.Location = new System.Drawing.Point(634, 415);
            this.btnBacktoStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnBacktoStaff.Name = "btnBacktoStaff";
            this.btnBacktoStaff.Size = new System.Drawing.Size(97, 38);
            this.btnBacktoStaff.TabIndex = 9;
            this.btnBacktoStaff.Text = "Back";
            this.btnBacktoStaff.UseVisualStyleBackColor = false;
            this.btnBacktoStaff.Click += new System.EventHandler(this.btnBacktoStaff_Click);
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(27, 15);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(0, 13);
            this.lblStaffId.TabIndex = 8;
            this.lblStaffId.Visible = false;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.txtAutoSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAutoSearch.Location = new System.Drawing.Point(575, 13);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(146, 20);
            this.txtAutoSearch.TabIndex = 7;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged_1);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantity.Location = new System.Drawing.Point(639, 247);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 23);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToCart.Location = new System.Drawing.Point(635, 309);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(97, 45);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.btnShowOrder.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowOrder.Location = new System.Drawing.Point(635, 360);
            this.btnShowOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(97, 51);
            this.btnShowOrder.TabIndex = 3;
            this.btnShowOrder.Text = "Show Order";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(215, 7);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(152, 30);
            this.lblProductList.TabIndex = 1;
            this.lblProductList.Text = "Product List";
            // 
            // pnldgvProductList
            // 
            this.pnldgvProductList.Controls.Add(this.dgvProductDetails);
            this.pnldgvProductList.Location = new System.Drawing.Point(1, 42);
            this.pnldgvProductList.Name = "pnldgvProductList";
            this.pnldgvProductList.Size = new System.Drawing.Size(631, 419);
            this.pnldgvProductList.TabIndex = 0;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_Id,
            this.P_Name,
            this.P_Price,
            this.P_Quantity,
            this.P_MakingDate,
            this.P_ExpiryDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.RowHeadersVisible = false;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(631, 419);
            this.dgvProductDetails.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.nudQuantity.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(638, 273);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(90, 31);
            this.nudQuantity.TabIndex = 11;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlProductlistMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProductList";
            this.Text = "ProdectList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProductList_FormClosed);
            this.pnlProductlistMain.ResumeLayout(false);
            this.pnlProductlistMain.PerformLayout();
            this.pnldgvProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductlistMain;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Panel pnldgvProductList;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_MakingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ExpiryDate;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Button btnBacktoStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}