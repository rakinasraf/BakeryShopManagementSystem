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
    public partial class FormMemberList : Form
    {
        public FormMemberList()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-6I8C99IJ\\SQLEXPRESS;Initial Catalog=UserInfo;Integrated Security=True");
            sqlcon.Open();
            //string sql = "select * from UserInfo";
            //SqlCommand sqlcom = new SqlCommand("select * from UserInfo", sqlcon);
            string sql = "select * from StaffInfo";

            //SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvMemberList.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

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

                var query = "select * from Movie where Id ='" + this.txtID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Movie
                                set Title = '" + this.txtTitle.Text + @"',
                                IMDB = " + this.txtIMDB.Text + @",
                                Income = " + this.txtIncome.Text + @",
                                ReleaseDate = '" + this.dtpReleaseDate.Text + @"',
                                Genre = '" + this.cmbGenre.Text + @"'
                                where Id = '" + this.txtID.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    //insert
                    var sql = "insert into Movie values('" + this.txtID.Text + "', '" + this.txtTitle.Text + "', " + this.txtIMDB.Text + ", " + this.txtIncome.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "');";
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
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPrice.Text) || string.IsNullOrEmpty(this.txt.Text) ||
                string.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            else
                return true;
        }
    }
}
