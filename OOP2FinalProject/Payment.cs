using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2FinalProject
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(string id, string totalAmount)
        {
            InitializeComponent();
            this.lblStaffId.Text = id;
            this.lblTotalAmount.Text = totalAmount;
        }

        private void btnPaymentCash_Click(object sender, EventArgs e)
        {
            CashPayment cashPayment = new CashPayment(this.lblStaffId.Text,this.lblTotalAmount.Text);
            cashPayment.Visible = true;
            cashPayment.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void BtnPaymentCard_Click(object sender, EventArgs e)
        {
            CardPayment cardPayment = new CardPayment(this.lblStaffId.Text,this.lblTotalAmount.Text);
            cardPayment.Visible = true;
            cardPayment.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
