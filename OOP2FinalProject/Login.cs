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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                { MessageBox.Show("Please fill all the empty fields"); }
                this.Da = new DataAccess();
                string k = this.txtUserId.Text;
                if (k[0] == 'A')
                {
                    var ds = this.Da.ExecuteQuery("select * from AdminInfo where A_Id = '" + this.txtUserId.Text + "' and A_Password = '" + this.txtPassword.Text + "'");
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        Admin admin = new Admin(this.txtUserId.Text);
                        admin.Visible = true;
                        admin.Location = new Point(this.Location.X, this.Location.Y);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Id or Password");
                    }
                }
                else
                {
                    var ds = this.Da.ExecuteQuery("select * from StaffInfo where S_Id = '" + this.txtUserId.Text + "' and S_Password = '" + this.txtPassword.Text + "'");
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        Staff staff = new Staff(this.txtUserId.Text);
                        staff.Visible = true;
                        staff.Location = new Point(this.Location.X, this.Location.Y);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Id or Password");
                    }
                }
            }
            catch(Exception exc) 
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
