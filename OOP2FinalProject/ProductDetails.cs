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
    public partial class ProductDetails : Form
    {
        private DataAccess Da { get; set; }
        public ProductDetails()
        {
            InitializeComponent();
        }
        public ProductDetails(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
            this.lblAdminId.Text = id;
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = @"select * from ProductInfo where P_Id like '%" + this.txtAutoSearch.Text + @"%' or  
                        P_Name like '%" + this.txtAutoSearch.Text + @"%';";
            this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql = "select * from ProductInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProductDetails.AutoGenerateColumns = false;
            this.dgvProductDetails.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate()
        {
            try 
            {
                var query = "select max(P_Id) from ProductInfo;";
                var dt = this.Da.ExecuteQueryTable(query);
                var oldId = dt.Rows[0][0].ToString();
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);
                var newId = "P-" + (++temp).ToString("d3");
                this.txtProductId.Text = newId;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvProductDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductId.Text = this.dgvProductDetails.CurrentRow.Cells["P_Id"].Value.ToString();
            this.txtName.Text = this.dgvProductDetails.CurrentRow.Cells["P_Name"].Value.ToString();
            this.txtPrice.Text = this.dgvProductDetails.CurrentRow.Cells["P_Price"].Value.ToString();
            this.txtQuantity.Text = this.dgvProductDetails.CurrentRow.Cells["P_Quantity"].Value.ToString();
            this.txtMakingDate.Text = this.dgvProductDetails.CurrentRow.Cells["P_MakingDate"].Value.ToString();
            this.txtExpiryDate.Text = this.dgvProductDetails.CurrentRow.Cells["P_ExpiryDate"].Value.ToString();
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPrice.Text) || string.IsNullOrEmpty(this.txtQuantity.Text) ||
                string.IsNullOrEmpty(this.txtMakingDate.Text) || string.IsNullOrEmpty(this.txtExpiryDate.Text))
            { return false; }
            else { return true; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductDetails.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvProductDetails.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                { return; }

                var sql = "delete from ProductInfo where P_Id = '" + id + "';";
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
            this.txtProductId.Clear();
            this.txtName.Clear();
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.txtMakingDate.Clear();
            this.txtExpiryDate.Clear();
            this.txtAutoSearch.Text = "";
            this.dgvProductDetails.ClearSelection();
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

                var query = "select * from ProductInfo where P_Id ='" + this.txtProductId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update StaffInfo
                                set p_Name = '" + this.txtName.Text + @"',
                                P_Price = " + this.txtPrice.Text + @",
                                P_Quantity = '" + this.txtQuantity.Text + @"',
                                P_MakingDate = '" + this.txtMakingDate.Text + @"',
                                P_ExpiryDate = '" + this.txtExpiryDate.Text + @"'
                                where P_Id = '" + this.txtProductId.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    var sql = "insert into ProductInfo values('" + this.txtProductId.Text + "', '" + this.txtName.Text + "', " + this.txtPrice.Text + ", '" + this.txtQuantity.Text + "', '" + this.txtMakingDate.Text + "', '" + this.txtExpiryDate.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added");
                    else
                        MessageBox.Show("Data hasn't been added");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnBackpdltoad_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.lblAdminId.Text);
            admin.Visible = true;
            admin.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void ProductDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
