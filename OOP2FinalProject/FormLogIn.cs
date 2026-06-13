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
using Microsoft.SqlServer.Server;

namespace OOP2FinalProject
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            //this.txtPassword.Text = string.Empty;
            //this.txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUserId_Click(object sender, EventArgs e)
        {
            //this.txtUserId.Text = string.Empty;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-6I8C99IJ\\SQLEXPRESS;Initial Catalog=UserInfo;Integrated Security=True");
            sqlcon.Open();
            //string sql = "select * from UserInfo";
            //SqlCommand sqlcom = new SqlCommand("select * from UserInfo", sqlcon);
            string sql = "select * from UserInfo where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "'";

            //SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sql,sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                    if (ds.Tables[0].Rows[0][2].ToString() == "Admin")
                    {
                        FormAdmin fa = new FormAdmin(this.txtUserId.Text);
                        fa.Visible = true;
                    }
                    else
                    {
                        FormMember fm = new FormMember(this.txtUserId.Text);
                        fm.Show();
                    }
            }
            else
            {
                    MessageBox.Show("Invalid User");
            }
            sqlcon.Close();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
