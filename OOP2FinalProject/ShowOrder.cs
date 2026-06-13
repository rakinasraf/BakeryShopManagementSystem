using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP2FinalProject
{
    public partial class ShowOrder : Form
    {
        private DataAccess Da { get; set; }
        public ShowOrder()
        {
            InitializeComponent();
        }
        public ShowOrder(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.lblStaffId.Text = id;
        }
        private void PopulateGridView(string sql = "select * from OrderDetails;")
        {
            try 
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvProductList.AutoGenerateColumns = false;
                this.dgvProductList.DataSource = ds.Tables[0];
                var dt = this.Da.ExecuteQueryTable(sql);
                int i = 0;
                var j = 0;
                while (i < dt.Rows.Count)
                {
                    j += Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());
                    i++;
                }
                this.txtGrandTotal.Text = j.ToString();
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from OrderDetails;";
                var dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Confirm Order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    Payment payment = new Payment(this.lblStaffId.Text, this.txtGrandTotal.Text);
                    payment.Visible = true;
                    payment.Location = new Point(this.Location.X, this.Location.Y);
                    this.Hide();
                }
                else { MessageBox.Show("Please purchase any product before go to payment"); }
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        private void btnPrevioustoProductList_Click(object sender, EventArgs e)
        {
            FormProductList formProductList = new FormProductList(this.lblStaffId.Text);
            formProductList.Visible = true;
            formProductList.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
        private void ShowOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                var name = this.dgvProductList.CurrentRow.Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                { return; }
                var sql = "delete from OrderDetails where Product_Name = '" + name + "';";
                var count = this.Da.ExecuteDMLQuery(sql);
                this.PopulateGridView();
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }
    }
}
