using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2FinalProject
{
    public partial class StaffDetails : Form
    {
        private DataAccess Da { get; set; }
        public StaffDetails()
        {
            InitializeComponent();
        }
        public StaffDetails(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
            this.lblAdminId.Text = id;
        }
        private void PopulateGridView(string sql = "select S_Id,S_Name,S_Gender,S_Mobile,S_Address,S_JoiningDate,S_Salary,S_Email from StaffInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvStaffDetails.AutoGenerateColumns = false;
            this.dgvStaffDetails.DataSource = ds.Tables[0];
        }
       
        private void AutoIdGenerate()
        {
            var query = "select max(S_Id) from StaffInfo;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "S-" + (++temp).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = @"select * from StaffInfo where S_Id like '%" + this.txtAutoSearch.Text + @"%' or  
                      S_Name like '%" + this.txtAutoSearch.Text + @"%';"; 
            this.PopulateGridView(sql);
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtGender.Text) || string.IsNullOrEmpty(this.txtMobile.Text) ||
                string.IsNullOrEmpty(this.txtAddress.Text) || string.IsNullOrEmpty(this.txtJoiningDate.Text) ||
                string.IsNullOrEmpty(this.txtSalary.Text) || string.IsNullOrEmpty(this.txtEmail.Text))
            { return false; }
            else{ return true; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvStaffDetails.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvStaffDetails.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvStaffDetails.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " +name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                { return; }

                var sql = "delete from StaffInfo where S_Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtName.Clear();
            this.txtGender.Clear();
            this.txtMobile.Clear();
            this.txtAddress.Clear();
            this.txtJoiningDate.Clear();
            this.txtSalary.Clear();
            this.txtEmail.Clear();
            this.txtAutoSearch.Text = "";
            this.dgvStaffDetails.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from StaffInfo where S_Id ='" + this.txtUserId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update StaffInfo
                                set S_Name = '" + this.txtName.Text + @"',
                                S_Gender = '" + this.txtGender.Text + @"',
                                S_Mobile = '" + this.txtMobile.Text + @"',
                                S_Address = '" + this.txtAddress.Text + @"',
                                S_JoinningDate = '" + this.txtJoiningDate.Text + @"',
                                S_Salary = " + this.txtSalary.Text + @",
                                S_Email = '" + this.txtEmail.Text + @"'
                                where S_Id = '" + this.txtUserId.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    var sql = "insert into StaffInfo values('" + this.txtUserId.Text + "', '" + this.txtName.Text + "', '" + this.txtGender.Text + "', '" + this.txtMobile.Text + "', '" + this.txtAddress.Text + "', '" + this.txtJoiningDate.Text + "', " + this.txtSalary.Text + ",'" + this.txtEmail.Text + "','00000' );";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added");
                    else
                        MessageBox.Show("Data hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc) {MessageBox.Show("An error has occured: " + exc.Message);}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.lblAdminId.Text);
            admin.Visible = true;
            admin.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void StaffDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void dgvStaffDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Id"].Value.ToString();
            this.txtName.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Name"].Value.ToString();
            this.txtGender.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Gender"].Value.ToString();
            this.txtMobile.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Mobile"].Value.ToString();
            this.txtAddress.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Address"].Value.ToString();
            this.txtJoiningDate.Text = this.dgvStaffDetails.CurrentRow.Cells["S_JoiningDate"].Value.ToString();
            this.txtSalary.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Salary"].Value.ToString();
            this.txtEmail.Text = this.dgvStaffDetails.CurrentRow.Cells["S_Email"].Value.ToString();
        }
    }
}
