using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
