using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog= StudentManagement;Integrated Security=True";

            cnn = new SqlConnection(connectionString);
            int id = Convert.ToInt16(tbStudentID.Text);
            var SName = tbStudentName.Text;
            var FName = tbFatherName.Text;
            var MName = tbMothersName.Text;
            var C = tbClass.Text;
            var City = tbCity.Text;

        }
    }
}
