using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2FinalProject
{
    public partial class Admin : Form
    {
        private DataAccess Da { get; set; }
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            var ds = this.Da.ExecuteQuery("select * from AdminInfo where A_Id = '" + id + "'");
            try 
            {
                this.lblAdminId.Text = ds.Tables[0].Rows[0][0].ToString();
                this.lblAdminName.Text += ds.Tables[0].Rows[0][1].ToString();
                this.lblName.Text = ds.Tables[0].Rows[0][1].ToString();
                this.lblAdminGender.Text += ds.Tables[0].Rows[0][2].ToString();
                this.lblAdminMobile.Text += ds.Tables[0].Rows[0][3].ToString();
                this.lblAdminAddress.Text += ds.Tables[0].Rows[0][4].ToString();
                this.lblAdminEmail.Text += ds.Tables[0].Rows[0][5].ToString();
                this.lblAdminPassword.Text += ds.Tables[0].Rows[0][6].ToString();
            }
            catch(Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            login.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            StaffDetails sd = new StaffDetails(this.lblAdminId.Text);
            sd.Visible = true;
            sd.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(this.lblAdminId.Text);
            pd.Visible = true;
            pd.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
        private void btnEditAdminProfile_Click(object sender, EventArgs e)
        {
            EditAdminProfile editAdminProfile = new EditAdminProfile(this.lblAdminId.Text);
            editAdminProfile.Visible = true;
            editAdminProfile.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            PaymentList paymentList = new PaymentList(this.lblAdminId.Text);
            paymentList.Visible = true;
            paymentList.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnAdminDetails_Click(object sender, EventArgs e)
        {
            FormAdminList fd = new FormAdminList(this.lblAdminId.Text);
            fd.Visible = true;
            fd.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
    }
}
