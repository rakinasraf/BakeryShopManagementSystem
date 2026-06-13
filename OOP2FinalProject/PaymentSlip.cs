using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2FinalProject
{
    public partial class PaymentSlip : Form
    {
        private DataAccess Da { get; set; }
        public PaymentSlip()
        {
            InitializeComponent();
        }
        public PaymentSlip(string sid, string pid)
        {
            InitializeComponent();
            this.lblStaffId.Text = sid;
            this.Da = new DataAccess();

            var ds1 = this.Da.ExecuteQuery("select * from PaymentList where Payment_Id = '" + pid + "'");
            this.lblPaymentId.Text += ds1.Tables[0].Rows[0][0].ToString();
            this.lblCustomerName.Text += ds1.Tables[0].Rows[0][1].ToString();
            this.lblCustomerMobile.Text += ds1.Tables[0].Rows[0][2].ToString();
            this.lblTotalAmount.Text += ds1.Tables[0].Rows[0][3].ToString();
            this.lblPaymentDate.Text += ds1.Tables[0].Rows[0][4].ToString();

            var ds2 = this.Da.ExecuteQuery("select * from StaffInfo where S_Id = '" + sid + "'");
            this.lblStaffName.Text = ds2.Tables[0].Rows[0][1].ToString();
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            try 
            {
                this.Da.ExecuteDDLQuery("TRUNCATE TABLE OrderDetails");
                MessageBox.Show("Done");
                Staff staff = new Staff(this.lblStaffId.Text);
                staff.Visible = true;
                staff.Location = new Point(this.Location.X, this.Location.Y);
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void PaymentSlip_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
