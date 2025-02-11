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
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class Add_Student_Form : Form
    {
        public Add_Student_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSName.Clear();
            txtSenum.Clear();
            txtSsem.Clear();
            txtSdp.Clear();
            txtScon.Clear();
            txtSemail.Clear();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (txtSName.Text != "" && txtSenum.Text != "" && txtSsem.Text != "" && txtSdp.Text != "" && txtScon.Text != "" && txtSemail.Text != "")
            {
                String sname = txtSName.Text;
                String senum = txtSenum.Text;
                String ssem = txtSsem.Text;
                String sdep = txtSdp.Text;
                String scon = txtScon.Text;
                String smail = txtSemail.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "insert into NewStudent (stdname,stdenroll,stddep,stdsem,stdcon,stdemail) values ('" + sname + "','" + senum + "','" + sdep + "','" + ssem + "'," + scon + ",'" + smail + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSName.Clear();
                txtSenum.Clear();
                txtSsem.Clear();
                txtSdp.Clear();
                txtScon.Clear();
                txtSemail.Clear();
            }
            else
            {
                MessageBox.Show("Empty field are not allowed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
    }
}
