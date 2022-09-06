using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class SMSFORM : Form
    {


        public SMSFORM()
        {
            InitializeComponent();
            Dataload();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Student; Integrated Security = True; uid = Root; password = root");
        private void Dataload()
        {

            SqlCommand cmd = new SqlCommand("select * from [Student].[dbo].[Studentdb]", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            GridStudentData.DataSource = dt;




        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ADDFORM form = new ADDFORM();
            form.ShowDialog();
            Dataload();
        }
        private void buttonUPDATEDelete_Click(object sender, EventArgs e)
        {

            int Student = (int)GridStudentData.SelectedRows[0].Cells[0].Value;
            UPDATEFORM form = new UPDATEFORM(Student);
            form.ShowDialog();
            Dataload();
        }
    }
}
