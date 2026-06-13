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
    public partial class FormAdminList : Form
    {
        private DataAccess Da { get; set; }

        public FormAdminList()
        {
            InitializeComponent();
        }

        public FormAdminList(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
            this.lblAdminId.Text = id;
        }

        private void PopulateGridView(string sql = "select A_Id,A_Name,A_Gender,A_Mobile,A_Address,A_Email from AdminInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAdminList.AutoGenerateColumns = false;
            this.dgvAdminList.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        { 
            try 
            {
                var query = "select max(A_Id) from AdminInfo;";
                var dt = this.Da.ExecuteQueryTable(query);
                var oldId = dt.Rows[0][0].ToString();
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);
                var newId = "A-" + (++temp).ToString("d3");
                this.txtUserId.Text = newId;
            }
            catch(Exception exc) 
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = @"select * from AdminInfo where A_Id like '%" + this.txtAutoSearch.Text + @"%' or  
                      A_Name like '%" + this.txtAutoSearch.Text + @"%';";
            this.PopulateGridView(sql);
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtGender.Text) || string.IsNullOrEmpty(this.txtMobile.Text) ||
                string.IsNullOrEmpty(this.txtAddress.Text) || string.IsNullOrEmpty(this.txtEmail.Text))
            { return false; }
            else { return true; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.lblAdminId.Text);
            admin.Visible = true;
            admin.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnAdminInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from AdminInfo where A_Id ='" + this.txtUserId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update AdminInfo
                                set A_Name = '" + this.txtName.Text + @"',
                                A_Gender = '" + this.txtGender.Text + @"',
                                A_Mobile = '" + this.txtMobile.Text + @"',
                                A_Address = '" + this.txtAddress.Text + @"',
                                A_Email = '" + this.txtEmail.Text + @"'
                                where A_Id = '" + this.txtUserId.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    var sql = "insert into AdminInfo values('" + this.txtUserId.Text + "', '" + this.txtName.Text + "', '" + this.txtGender.Text + "', '" + this.txtMobile.Text + "', '" + this.txtAddress.Text + "', '" + this.txtEmail.Text + "','00000' );";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added");
                    else
                        MessageBox.Show("Data hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdminList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvAdminList.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvAdminList.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                { return; }

                var sql = "delete from AdminInfo where A_Id = '" + id + "';";
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
            this.txtEmail.Clear();
            this.txtAutoSearch.Text = "";
            this.dgvAdminList.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void FormAdminList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void dgvAdminList_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvAdminList.CurrentRow.Cells["A_Id"].Value.ToString();
            this.txtName.Text = this.dgvAdminList.CurrentRow.Cells["A_Name"].Value.ToString();
            this.txtGender.Text = this.dgvAdminList.CurrentRow.Cells["A_Gender"].Value.ToString();
            this.txtMobile.Text = this.dgvAdminList.CurrentRow.Cells["A_Mobile"].Value.ToString();
            this.txtAddress.Text = this.dgvAdminList.CurrentRow.Cells["A_Address"].Value.ToString();
            this.txtEmail.Text = this.dgvAdminList.CurrentRow.Cells["A_Email"].Value.ToString();
        }
    }
}
