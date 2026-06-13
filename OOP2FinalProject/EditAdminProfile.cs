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
    public partial class EditAdminProfile : Form
    {
        private DataAccess Da { get; set; }
        public EditAdminProfile()
        {
            InitializeComponent();
        }
        public EditAdminProfile(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            var ds = this.Da.ExecuteQuery("select * from AdminInfo where A_Id = '" + id + "'");
            this.lblAdminId.Text = id;
            this.txtEditAdminName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtEditAdmingender.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtEditAdminMobileno.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtEditAdminAddress.Text = ds.Tables[0].Rows[0][4].ToString();
            this.txtEditAdminEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            this.txtEditAdminPassword.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnEditAdminSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = @"update AdminInfo
                           set A_Name = '" + this.txtEditAdminName.Text + @"',
                           A_Gender = '" + this.txtEditAdmingender.Text + @"',
                           A_Mobile = '" + this.txtEditAdminMobileno.Text + @"',
                           A_Address = '" + this.txtEditAdminAddress.Text + @"',
                           A_Email = '" + this.txtEditAdminEmail.Text + @"',
                           A_Password = '" + this.txtEditAdminPassword.Text + @"'
                           where A_Id = '" + this.lblAdminId.Text + "'; ";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data has been updated");
                    Admin admin = new Admin(this.lblAdminId.Text);
                    admin.Visible = true;
                    admin.Location = new Point(this.Location.X, this.Location.Y);
                    this.Hide();
                }
                else { MessageBox.Show("Data hasn't been updated"); }
                
            }
            catch (Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }
        private void EditAdminProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
