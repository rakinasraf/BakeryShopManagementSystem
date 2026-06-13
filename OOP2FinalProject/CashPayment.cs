using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace OOP2FinalProject
{
    public partial class CashPayment : Form
    {
        private DataAccess Da { get; set; }
        public CashPayment()
        {
            InitializeComponent();
        }
        public CashPayment(string id, string totalAmount)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.lblStaffId.Text = id;
            this.AutoIdGenerate();
            this.txtTotalAmount.Text = totalAmount;
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtPaymentId.Text) || string.IsNullOrEmpty(this.txtCustomerName.Text) ||
                string.IsNullOrEmpty(this.txtCustomerMobile.Text) || string.IsNullOrEmpty(this.txtPaymentDate.Text) ||
                string.IsNullOrEmpty(this.txtTotalAmount.Text))
            { return false; }
            else { return true; }
        }

        private void btnpayslip_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                var sql = "insert into PaymentList values('" + this.txtPaymentId.Text + "', '" + this.txtCustomerName.Text + "', '" + this.txtCustomerMobile.Text + "', " + this.txtTotalAmount.Text + ", '" + this.txtPaymentDate.Text + "');";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data has been added");
                    PaymentSlip paymentslip = new PaymentSlip(this.lblStaffId.Text,this.txtPaymentId.Text);
                    paymentslip.Visible = true;
                    paymentslip.Location = new Point(this.Location.X, this.Location.Y);
                    this.Hide();
                } 
                else
                    MessageBox.Show("Data hasn't been added");
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        
        private void AutoIdGenerate()
        {
            try 
            {
                var query = "select max(Payment_Id) from PaymentList;";
                var dt = this.Da.ExecuteQueryTable(query);
                var oldId = dt.Rows[0][0].ToString();
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);
                var newId = "invoice-" + (++temp).ToString();
                this.txtPaymentId.Text = newId;
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        private void CashPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(this.lblStaffId.Text, txtTotalAmount.Text);
            payment.Visible = true;
            payment.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
    }
}
