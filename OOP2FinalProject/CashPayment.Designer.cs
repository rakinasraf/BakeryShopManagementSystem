namespace OOP2FinalProject
{
    partial class CashPayment
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
            this.pnlacashbillinfo = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnpayslip = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblReturnMoney = new System.Windows.Forms.Label();
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.lblTotalOrderBill = new System.Windows.Forms.Label();
            this.pnlcashcustomerinfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.lblCustomerMobile = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnPervioustopayment = new System.Windows.Forms.Button();
            this.pnlacashbillinfo.SuspendLayout();
            this.pnlcashcustomerinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlacashbillinfo
            // 
            this.pnlacashbillinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.pnlacashbillinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlacashbillinfo.Controls.Add(this.btnPervioustopayment);
            this.pnlacashbillinfo.Controls.Add(this.textBox3);
            this.pnlacashbillinfo.Controls.Add(this.textBox2);
            this.pnlacashbillinfo.Controls.Add(this.txtTotalAmount);
            this.pnlacashbillinfo.Controls.Add(this.btnpayslip);
            this.pnlacashbillinfo.Controls.Add(this.label14);
            this.pnlacashbillinfo.Controls.Add(this.lblReturnMoney);
            this.pnlacashbillinfo.Controls.Add(this.lblEnterAmount);
            this.pnlacashbillinfo.Controls.Add(this.lblTotalOrderBill);
            this.pnlacashbillinfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlacashbillinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlacashbillinfo.Location = new System.Drawing.Point(367, 0);
            this.pnlacashbillinfo.Name = "pnlacashbillinfo";
            this.pnlacashbillinfo.Size = new System.Drawing.Size(367, 461);
            this.pnlacashbillinfo.TabIndex = 232;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(33, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 68;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(33, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 67;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(33, 157);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(260, 20);
            this.txtTotalAmount.TabIndex = 66;
            // 
            // btnpayslip
            // 
            this.btnpayslip.BackColor = System.Drawing.Color.Peru;
            this.btnpayslip.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayslip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpayslip.Location = new System.Drawing.Point(218, 387);
            this.btnpayslip.Margin = new System.Windows.Forms.Padding(2);
            this.btnpayslip.Name = "btnpayslip";
            this.btnpayslip.Size = new System.Drawing.Size(126, 38);
            this.btnpayslip.TabIndex = 53;
            this.btnpayslip.Text = "Show PaySlip";
            this.btnpayslip.UseVisualStyleBackColor = false;
            this.btnpayslip.Click += new System.EventHandler(this.btnpayslip_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(-4, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 38);
            this.label14.TabIndex = 44;
            this.label14.Text = "Payment";
            // 
            // lblReturnMoney
            // 
            this.lblReturnMoney.AutoSize = true;
            this.lblReturnMoney.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReturnMoney.Location = new System.Drawing.Point(32, 246);
            this.lblReturnMoney.Name = "lblReturnMoney";
            this.lblReturnMoney.Size = new System.Drawing.Size(119, 18);
            this.lblReturnMoney.TabIndex = 43;
            this.lblReturnMoney.Text = "Return Money";
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnterAmount.Location = new System.Drawing.Point(30, 191);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(118, 18);
            this.lblEnterAmount.TabIndex = 42;
            this.lblEnterAmount.Text = "Enter Amount";
            // 
            // lblTotalOrderBill
            // 
            this.lblTotalOrderBill.AutoSize = true;
            this.lblTotalOrderBill.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrderBill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalOrderBill.Location = new System.Drawing.Point(29, 130);
            this.lblTotalOrderBill.Name = "lblTotalOrderBill";
            this.lblTotalOrderBill.Size = new System.Drawing.Size(122, 23);
            this.lblTotalOrderBill.TabIndex = 39;
            this.lblTotalOrderBill.Text = "Total Order Bill";
            // 
            // pnlcashcustomerinfo
            // 
            this.pnlcashcustomerinfo.BackColor = System.Drawing.Color.Peru;
            this.pnlcashcustomerinfo.Controls.Add(this.label1);
            this.pnlcashcustomerinfo.Controls.Add(this.txtPaymentDate);
            this.pnlcashcustomerinfo.Controls.Add(this.lblPaymentDate);
            this.pnlcashcustomerinfo.Controls.Add(this.lblStaffId);
            this.pnlcashcustomerinfo.Controls.Add(this.txtCustomerMobile);
            this.pnlcashcustomerinfo.Controls.Add(this.lblCustomerMobile);
            this.pnlcashcustomerinfo.Controls.Add(this.txtCustomerName);
            this.pnlcashcustomerinfo.Controls.Add(this.lblCustomerName);
            this.pnlcashcustomerinfo.Controls.Add(this.txtPaymentId);
            this.pnlcashcustomerinfo.Controls.Add(this.lblPaymentId);
            this.pnlcashcustomerinfo.Controls.Add(this.lblPayment);
            this.pnlcashcustomerinfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlcashcustomerinfo.Location = new System.Drawing.Point(0, 0);
            this.pnlcashcustomerinfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlcashcustomerinfo.Name = "pnlcashcustomerinfo";
            this.pnlcashcustomerinfo.Size = new System.Drawing.Size(367, 461);
            this.pnlcashcustomerinfo.TabIndex = 233;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 234;
            this.label1.Text = "*Date Formate (YYYY-MM-DD)";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(71, 328);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(260, 20);
            this.txtPaymentDate.TabIndex = 68;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaymentDate.Location = new System.Drawing.Point(67, 302);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(158, 23);
            this.lblPaymentDate.TabIndex = 67;
            this.lblPaymentDate.Text = "Enter Payment Date";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(38, 54);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(0, 13);
            this.lblStaffId.TabIndex = 66;
            this.lblStaffId.Visible = false;
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(71, 269);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(260, 20);
            this.txtCustomerMobile.TabIndex = 65;
            // 
            // lblCustomerMobile
            // 
            this.lblCustomerMobile.AutoSize = true;
            this.lblCustomerMobile.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerMobile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerMobile.Location = new System.Drawing.Point(67, 243);
            this.lblCustomerMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerMobile.Name = "lblCustomerMobile";
            this.lblCustomerMobile.Size = new System.Drawing.Size(245, 23);
            this.lblCustomerMobile.TabIndex = 64;
            this.lblCustomerMobile.Text = "Enter Customer Phone Number";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(71, 214);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(260, 20);
            this.txtCustomerName.TabIndex = 63;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerName.Location = new System.Drawing.Point(67, 188);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(175, 23);
            this.lblCustomerName.TabIndex = 62;
            this.lblCustomerName.Text = "Enter Customer Name";
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(71, 158);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(260, 20);
            this.txtPaymentId.TabIndex = 61;
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaymentId.Location = new System.Drawing.Point(67, 131);
            this.lblPaymentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(95, 23);
            this.lblPaymentId.TabIndex = 57;
            this.lblPaymentId.Text = "Payment ID";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial Black", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPayment.Location = new System.Drawing.Point(268, 39);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(104, 44);
            this.lblPayment.TabIndex = 56;
            this.lblPayment.Text = "Cash";
            // 
            // btnPervioustopayment
            // 
            this.btnPervioustopayment.BackColor = System.Drawing.Color.Peru;
            this.btnPervioustopayment.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPervioustopayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPervioustopayment.Location = new System.Drawing.Point(88, 387);
            this.btnPervioustopayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPervioustopayment.Name = "btnPervioustopayment";
            this.btnPervioustopayment.Size = new System.Drawing.Size(126, 38);
            this.btnPervioustopayment.TabIndex = 69;
            this.btnPervioustopayment.Text = "Back";
            this.btnPervioustopayment.UseVisualStyleBackColor = false;
            this.btnPervioustopayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlcashcustomerinfo);
            this.Controls.Add(this.pnlacashbillinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashPayment";
            this.Text = "CashPayment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CashPayment_FormClosed);
            this.pnlacashbillinfo.ResumeLayout(false);
            this.pnlacashbillinfo.PerformLayout();
            this.pnlcashcustomerinfo.ResumeLayout(false);
            this.pnlcashcustomerinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlacashbillinfo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnpayslip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblReturnMoney;
        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.Label lblTotalOrderBill;
        private System.Windows.Forms.Panel pnlcashcustomerinfo;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label lblCustomerMobile;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPervioustopayment;
    }
}