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
    public partial class EditStaffProfile : Form
    {
        private DataAccess Da { get; set; }
        public EditStaffProfile()
        {
            InitializeComponent();
        }
        public EditStaffProfile(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            var ds = this.Da.ExecuteQuery("select * from StaffInfo where S_Id = '" + id + "'");
            this.lblStaffId.Text = id;
            this.txtEditStaffName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtEditStaffgender.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtEditStaffMobileno.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtEditStaffAddress.Text = ds.Tables[0].Rows[0][4].ToString();
            this.txtEditStaffEmail.Text = ds.Tables[0].Rows[0][7].ToString();
            this.txtEditStaffPassword.Text = ds.Tables[0].Rows[0][8].ToString();
        }

        private void btnEditStaffSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = @"update StaffInfo
                           set S_Name = '" + this.txtEditStaffName.Text + @"',
                           S_Gender = '" + this.txtEditStaffgender.Text + @"',
                           S_Mobile = '" + this.txtEditStaffMobileno.Text + @"',
                           S_Address = '" + this.txtEditStaffAddress.Text + @"',
                           S_Email = '" + this.txtEditStaffEmail.Text + @"',
                           S_Password = '" + this.txtEditStaffPassword.Text + @"'
                           where S_Id = '" + this.lblStaffId.Text + "'; ";
                 var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1) 
                { 
                    MessageBox.Show("Data has been updated");
                    Staff staff = new Staff(this.lblStaffId.Text);
                    staff.Visible = true;
                    staff.Location = new Point(this.Location.X, this.Location.Y);
                    this.Hide();
                }
                else { MessageBox.Show("Data hasn't been updated"); }
            }
            catch(Exception exc) { MessageBox.Show("An error has occured: " + exc.Message); }
        }

        private void EditStaffProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
