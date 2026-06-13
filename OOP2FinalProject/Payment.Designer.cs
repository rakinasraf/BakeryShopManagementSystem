namespace OOP2FinalProject
{
    partial class Payment
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
            this.pnlPaymentOption = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPaymentCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChossepaymentop = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnPaymentCash = new System.Windows.Forms.Button();
            this.pnlPaymentOption.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaymentOption
            // 
            this.pnlPaymentOption.BackColor = System.Drawing.Color.Peru;
            this.pnlPaymentOption.Controls.Add(this.lblTotalAmount);
            this.pnlPaymentOption.Controls.Add(this.lblStaffId);
            this.pnlPaymentOption.Controls.Add(this.panel2);
            this.pnlPaymentOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentOption.Location = new System.Drawing.Point(0, 0);
            this.pnlPaymentOption.Name = "pnlPaymentOption";
            this.pnlPaymentOption.Size = new System.Drawing.Size(734, 461);
            this.pnlPaymentOption.TabIndex = 1;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Location = new System.Drawing.Point(586, 40);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Visible = false;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(75, 25);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(0, 13);
            this.lblStaffId.TabIndex = 9;
            this.lblStaffId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.BtnPaymentCard);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblChossepaymentop);
            this.panel2.Controls.Add(this.lblPayment);
            this.panel2.Controls.Add(this.btnPaymentCash);
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 461);
            this.panel2.TabIndex = 8;
            // 
            // BtnPaymentCard
            // 
            this.BtnPaymentCard.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnPaymentCard.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaymentCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPaymentCard.Location = new System.Drawing.Point(117, 278);
            this.BtnPaymentCard.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPaymentCard.Name = "BtnPaymentCard";
            this.BtnPaymentCard.Size = new System.Drawing.Size(126, 38);
            this.BtnPaymentCard.TabIndex = 59;
            this.BtnPaymentCard.Text = "Card";
            this.BtnPaymentCard.UseVisualStyleBackColor = false;
            this.BtnPaymentCard.Click += new System.EventHandler(this.BtnPaymentCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(155, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Payment Option";
            // 
            // lblChossepaymentop
            // 
            this.lblChossepaymentop.AutoSize = true;
            this.lblChossepaymentop.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChossepaymentop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChossepaymentop.Location = new System.Drawing.Point(80, 146);
            this.lblChossepaymentop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChossepaymentop.Name = "lblChossepaymentop";
            this.lblChossepaymentop.Size = new System.Drawing.Size(85, 23);
            this.lblChossepaymentop.TabIndex = 57;
            this.lblChossepaymentop.Text = "Chosse a ";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial Black", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPayment.Location = new System.Drawing.Point(99, 78);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(167, 44);
            this.lblPayment.TabIndex = 56;
            this.lblPayment.Text = "Payment";
            // 
            // btnPaymentCash
            // 
            this.btnPaymentCash.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPaymentCash.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPaymentCash.Location = new System.Drawing.Point(117, 217);
            this.btnPaymentCash.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaymentCash.Name = "btnPaymentCash";
            this.btnPaymentCash.Size = new System.Drawing.Size(126, 38);
            this.btnPaymentCash.TabIndex = 2;
            this.btnPaymentCash.Text = "Cash";
            this.btnPaymentCash.UseVisualStyleBackColor = false;
            this.btnPaymentCash.Click += new System.EventHandler(this.btnPaymentCash_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnlPaymentOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.pnlPaymentOption.ResumeLayout(false);
            this.pnlPaymentOption.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaymentOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPaymentCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChossepaymentop;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnPaymentCash;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}