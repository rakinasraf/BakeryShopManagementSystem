namespace OOP2FinalProject
{
    partial class PaymentList
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
            this.pnlProductlistMain = new System.Windows.Forms.Panel();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.btnbackpltoad = new System.Windows.Forms.Button();
            this.dgvPaymentList = new System.Windows.Forms.DataGridView();
            this.Payment_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPaymentList = new System.Windows.Forms.Label();
            this.pnlProductlistMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductlistMain
            // 
            this.pnlProductlistMain.BackColor = System.Drawing.Color.Peru;
            this.pnlProductlistMain.Controls.Add(this.lblAdminId);
            this.pnlProductlistMain.Controls.Add(this.btnbackpltoad);
            this.pnlProductlistMain.Controls.Add(this.dgvPaymentList);
            this.pnlProductlistMain.Controls.Add(this.lblPaymentList);
            this.pnlProductlistMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductlistMain.Location = new System.Drawing.Point(0, 0);
            this.pnlProductlistMain.Name = "pnlProductlistMain";
            this.pnlProductlistMain.Size = new System.Drawing.Size(734, 461);
            this.pnlProductlistMain.TabIndex = 2;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(53, 25);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 13);
            this.lblAdminId.TabIndex = 3;
            this.lblAdminId.Visible = false;
            // 
            // btnbackpltoad
            // 
            this.btnbackpltoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.btnbackpltoad.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackpltoad.Location = new System.Drawing.Point(615, 413);
            this.btnbackpltoad.Name = "btnbackpltoad";
            this.btnbackpltoad.Size = new System.Drawing.Size(75, 30);
            this.btnbackpltoad.TabIndex = 2;
            this.btnbackpltoad.Text = "Back";
            this.btnbackpltoad.UseVisualStyleBackColor = false;
            this.btnbackpltoad.Click += new System.EventHandler(this.btnbackpltoad_Click);
            // 
            // dgvPaymentList
            // 
            this.dgvPaymentList.AllowUserToAddRows = false;
            this.dgvPaymentList.AllowUserToDeleteRows = false;
            this.dgvPaymentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Payment_Id,
            this.Customer_Name,
            this.Customer_Mobile,
            this.Total_Amount,
            this.Payment_Date});
            this.dgvPaymentList.Location = new System.Drawing.Point(53, 51);
            this.dgvPaymentList.Name = "dgvPaymentList";
            this.dgvPaymentList.ReadOnly = true;
            this.dgvPaymentList.RowHeadersVisible = false;
            this.dgvPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentList.Size = new System.Drawing.Size(624, 341);
            this.dgvPaymentList.TabIndex = 0;
            // 
            // Payment_Id
            // 
            this.Payment_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payment_Id.DataPropertyName = "Payment_Id";
            this.Payment_Id.HeaderText = "Payment ID";
            this.Payment_Id.Name = "Payment_Id";
            this.Payment_Id.ReadOnly = true;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            // 
            // Customer_Mobile
            // 
            this.Customer_Mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Mobile.DataPropertyName = "Customer_Mobile";
            this.Customer_Mobile.HeaderText = "Customer Mobile";
            this.Customer_Mobile.Name = "Customer_Mobile";
            this.Customer_Mobile.ReadOnly = true;
            // 
            // Total_Amount
            // 
            this.Total_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Amount.DataPropertyName = "Total_Amount";
            this.Total_Amount.HeaderText = "Total Amount";
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.ReadOnly = true;
            // 
            // Payment_Date
            // 
            this.Payment_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payment_Date.DataPropertyName = "Payment_Date";
            this.Payment_Date.HeaderText = "Payment Date";
            this.Payment_Date.Name = "Payment_Date";
            this.Payment_Date.ReadOnly = true;
            // 
            // lblPaymentList
            // 
            this.lblPaymentList.AutoSize = true;
            this.lblPaymentList.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPaymentList.Location = new System.Drawing.Point(298, 9);
            this.lblPaymentList.Name = "lblPaymentList";
            this.lblPaymentList.Size = new System.Drawing.Size(177, 30);
            this.lblPaymentList.TabIndex = 1;
            this.lblPaymentList.Text = " Payment List ";
            // 
            // PaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlProductlistMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaymentList";
            this.Text = "PaymentList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentList_FormClosed);
            this.pnlProductlistMain.ResumeLayout(false);
            this.pnlProductlistMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductlistMain;
        private System.Windows.Forms.Label lblPaymentList;
        private System.Windows.Forms.DataGridView dgvPaymentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Date;
        private System.Windows.Forms.Button btnbackpltoad;
        private System.Windows.Forms.Label lblAdminId;
    }
}