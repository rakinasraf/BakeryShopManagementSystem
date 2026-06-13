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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-6I8C99IJ\\SQLEXPRESS;Initial Catalog=UserInfo;Integrated Security=True");
            sqlcon.Open();
            //string sql = "select * from UserInfo";
            //SqlCommand sqlcom = new SqlCommand("select * from UserInfo", sqlcon);
            string sql1 = "select * from ProductInfo";
            string sql2 = "select Id , Price from ProductInfo ";

            //SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(sql2, sqlcon);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            sda1.Fill(ds1);
            sda2.Fill(ds2);
            this.dgvProductList.DataSource = ds1.Tables[0];
            this.dgvCart.DataSource = ds2.Tables[0];
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
