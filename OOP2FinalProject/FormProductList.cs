using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2FinalProject
{
    public partial class FormProductList : Form
    {
        private DataAccess Da { get; set; }
        public FormProductList()
        {
            InitializeComponent();
        }
        public FormProductList(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.lblStaffId.Text = id;
        }
        private void PopulateGridView(string sql = "select * from ProductInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProductDetails.AutoGenerateColumns = false;
            this.dgvProductDetails.DataSource = ds.Tables[0];
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductDetails.SelectedRows.Count < 1 || string.IsNullOrEmpty(this.nudQuantity.Text))
                {
                    MessageBox.Show("Please select a product first to add to cart.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                int price = (Convert.ToInt32(this.nudQuantity.Text)) * (Convert.ToInt32(this.dgvProductDetails.CurrentRow.Cells[2].Value));
                
                var sql = "insert into OrderDetails values('" + (this.dgvProductDetails.CurrentRow.Cells[1].Value.ToString()) + "'," + this.nudQuantity.Text + ", " + price + ");";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1) { MessageBox.Show("Added to cart"); }
                else { MessageBox.Show("An error has occured"); }
            }
            catch (Exception exc){MessageBox.Show("An error has occured: " + exc.Message);}
        }

        private void txtAutoSearch_TextChanged_1(object sender, EventArgs e)
        {
            var sql = @"select * from ProductInfo where P_Id like '%" + this.txtAutoSearch.Text + @"%' or  
                      P_Name like '%" + this.txtAutoSearch.Text + @"%';";
            this.PopulateGridView(sql);
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            ShowOrder showOrder = new ShowOrder(this.lblStaffId.Text);
            showOrder.Visible = true;
            showOrder.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

        private void btnBacktoStaff_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = new Staff(this.lblStaffId.Text);
                staff.Visible = true;
                staff.Location = new Point(this.Location.X, this.Location.Y);
                this.Hide();
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        private void FormProductList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
