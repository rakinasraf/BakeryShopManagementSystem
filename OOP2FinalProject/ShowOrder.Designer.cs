namespace OOP2FinalProject
{
    partial class ShowOrder
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
            this.pnlShowOrderMain = new System.Windows.Forms.Panel();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnBacktoProductList = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblShowbill = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlShowOrderMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShowOrderMain
            // 
            this.pnlShowOrderMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlShowOrderMain.Controls.Add(this.btnDelete);
            this.pnlShowOrderMain.Controls.Add(this.lblStaffId);
            this.pnlShowOrderMain.Controls.Add(this.panel1);
            this.pnlShowOrderMain.Controls.Add(this.btnBacktoProductList);
            this.pnlShowOrderMain.Controls.Add(this.btnPayment);
            this.pnlShowOrderMain.Controls.Add(this.lblShowbill);
            this.pnlShowOrderMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowOrderMain.Location = new System.Drawing.Point(0, 0);
            this.pnlShowOrderMain.Name = "pnlShowOrderMain";
            this.pnlShowOrderMain.Size = new System.Drawing.Size(734, 461);
            this.pnlShowOrderMain.TabIndex = 1;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(28, 25);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(0, 13);
            this.lblStaffId.TabIndex = 11;
            this.lblStaffId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvProductList);
            this.panel1.Controls.Add(this.txtGrandTotal);
            this.panel1.Location = new System.Drawing.Point(61, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 288);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grand Total";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Quantity,
            this.Total_Price});
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductList.Location = new System.Drawing.Point(0, 0);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(496, 244);
            this.dgvProductList.TabIndex = 1;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Price.DataPropertyName = "Total_Price";
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.Peru;
            this.txtGrandTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(0, 250);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(496, 38);
            this.txtGrandTotal.TabIndex = 9;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBacktoProductList
            // 
            this.btnBacktoProductList.BackColor = System.Drawing.Color.Peru;
            this.btnBacktoProductList.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoProductList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBacktoProductList.Location = new System.Drawing.Point(599, 340);
            this.btnBacktoProductList.Margin = new System.Windows.Forms.Padding(2);
            this.btnBacktoProductList.Name = "btnBacktoProductList";
            this.btnBacktoProductList.Size = new System.Drawing.Size(97, 38);
            this.btnBacktoProductList.TabIndex = 7;
            this.btnBacktoProductList.Text = "Back";
            this.btnBacktoProductList.UseVisualStyleBackColor = false;
            this.btnBacktoProductList.Click += new System.EventHandler(this.btnPrevioustoProductList_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Peru;
            this.btnPayment.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPayment.Location = new System.Drawing.Point(599, 292);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(97, 38);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblShowbill
            // 
            this.lblShowbill.AutoSize = true;
            this.lblShowbill.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowbill.Location = new System.Drawing.Point(263, 36);
            this.lblShowbill.Name = "lblShowbill";
            this.lblShowbill.Size = new System.Drawing.Size(128, 30);
            this.lblShowbill.TabIndex = 2;
            this.lblShowbill.Text = "Order List";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Peru;
            this.btnDelete.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(599, 241);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 38);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlShowOrderMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowOrder";
            this.Text = "ShowOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowOrder_FormClosed);
            this.pnlShowOrderMain.ResumeLayout(false);
            this.pnlShowOrderMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowOrderMain;
        private System.Windows.Forms.Button btnBacktoProductList;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblShowbill;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}