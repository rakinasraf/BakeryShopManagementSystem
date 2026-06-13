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
    public partial class Staff : Form
    {
        private DataAccess Da { get; set; }
        public Staff()
        {
            InitializeComponent();
        }
        public Staff(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            var ds = this.Da.ExecuteQuery("select * from StaffInfo where S_Id = '" + id + "'");
            
            this.lblStaffId.Text = ds.Tables[0].Rows[0][0].ToString();
            this.lblstaffName.Text += ds.Tables[0].Rows[0][1].ToString();
            this.lblName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.lblStaffGender.Text += ds.Tables[0].Rows[0][2].ToString();
            this.lblStaffMobile.Text += ds.Tables[0].Rows[0][3].ToString();
            this.lblStaffAddress.Text += ds.Tables[0].Rows[0][4].ToString();
            this.lblStaffJoiningDate.Text += ds.Tables[0].Rows[0][5].ToString();
            this.lblStaffSalary.Text += ds.Tables[0].Rows[0][6].ToString();
            this.lblStaffEmail.Text += ds.Tables[0].Rows[0][7].ToString();
            this.lblStaffPassword.Text += ds.Tables[0].Rows[0][8].ToString();
        }

        private void btnEditStaffprofile_Click(object sender, EventArgs e)
        {
            EditStaffProfile editStaffProfile = new EditStaffProfile(this.lblStaffId.Text);
            editStaffProfile.Visible = true;
            editStaffProfile.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            FormProductList formProductList = new FormProductList(this.lblStaffId.Text);
            formProductList.Visible = true;
            formProductList.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            login.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
