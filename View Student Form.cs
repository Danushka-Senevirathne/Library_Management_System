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
    public partial class View_Student_Form_Load : Form
    {
        public View_Student_Form_Load()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_Student_Form_Load_Load(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                StudentGridView.DataSource = ds.Tables[0];
            }
        }
        int stdID;
        Int64 rowid;
        private void StudentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                stdID = int.Parse(StudentGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewStudent where stdid =" + stdID + "";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepart.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCon.Text = ds.Tables[0].Rows[0][5].ToString();
            txtMail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {

            if (txtSearchStudent.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewStudent where stdname LIKE  '" + txtSearchStudent.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                StudentGridView.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                StudentGridView.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchStudent.Clear();
            // recall the data from database
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            StudentGridView.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated.Conferm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String sname = txtName.Text;
                String senroll = txtEnroll.Text;
                String sdep = txtDepart.Text;
                String ssem = txtSem.Text;
                Int64 scon = Int64.Parse(txtCon.Text);
                String smail = txtMail.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "update NewStudent set stdname = '" + sname + "', stdenroll='" + senroll + "', stddep='" + sdep + "', stdsem='" + ssem + "', stdcon=" + scon + ", stdemail= '" + smail + "' where stdid =" + rowid + " ";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.Conferm?", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "delete from NewStudent where stdid=" + rowid + " ";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                txtName.Clear();
                txtEnroll.Clear();
                txtDepart.Clear();
                txtSem.Clear();
                txtCon.Clear();
                txtMail.Clear();
            }
        }
    }
}
