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

namespace Library_Management_System
{
    public partial class Book_Return_Form : Form
    {
        public Book_Return_Form()
        {
            InitializeComponent();
        }

        private void txtEnrollNumber_MouseHover(object sender, EventArgs e)
        {
            txtEnrollNumber.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from IssueBooks where std_enroll = '" + txtEnrollNumber.Text + "' and book_return_date IS NULL";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridViewTable.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalied Enroll Number or No book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTable.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridViewTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridViewTable.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridViewTable.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtIssuedDate.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "update IssueBooks set book_return_date = '" +dateTimePickerReturnDate.Text + "' where std_enroll = '" + txtEnrollNumber.Text + "' and id = " + rowid + " ";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Return Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBookName.Clear();
            txtIssuedDate.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtIssuedDate.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Cancel?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
