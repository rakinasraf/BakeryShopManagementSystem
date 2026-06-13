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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(string id)
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-6I8C99IJ\\SQLEXPRESS;Initial Catalog=UserInfo;Integrated Security=True");
            sqlcon.Open();
            string sql = "select * from UserInfo where Id = '" + id +"'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            this.lblUserId.Text += ds.Tables[0].Rows[0][0].ToString();
            this.lblUserName.Text += ds.Tables[0].Rows[0][1].ToString();
            this.lblUserPosition.Text += ds.Tables[0].Rows[0][2].ToString();
            this.lblUserMobile.Text += ds.Tables[0].Rows[0][3].ToString();
            this.lblUserPassword.Text += ds.Tables[0].Rows[0][4].ToString();
        }

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            FormProductList fpl = new FormProductList();
            fpl.Visible = true;
        }

        private void btnAdminList_Click(object sender, EventArgs e)
        {
            FormAdminList fal = new FormAdminList();
            fal.Visible = true;
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            FormMemberList fml = new FormMemberList();
            fml.Visible = true;
        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
