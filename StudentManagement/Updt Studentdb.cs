using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
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
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=&quot;|DataDirectory|\student db.mdf&quot; Integrated Security = True ;UriId = Root;password = root");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET MotherName=' " + tbMN.Text + " ' WHERE StudentName = '" + tbSN.Text + " ' ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            con.Close();


        }
    }
}

