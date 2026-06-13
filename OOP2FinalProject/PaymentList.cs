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
    public partial class PaymentList : Form
    {
        private DataAccess Da { get; set; }
        public PaymentList()
        {
            InitializeComponent();
        }
        public PaymentList(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.lblAdminId.Text = id;
        }
        private void PopulateGridView(string sql = "select * from PaymentList;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvPaymentList.AutoGenerateColumns = false;
            this.dgvPaymentList.DataSource = ds.Tables[0];
        }

        private void btnbackpltoad_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.lblAdminId.Text);
            admin.Visible = true;
            admin.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
        private void PaymentList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
