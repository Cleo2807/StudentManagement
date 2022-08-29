using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Student; Integrated Security = True");
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Table (StudentName,FatherName,MotherName,Class,City) VALUES (@StudentName,@FatherName,@MotherName,@Class,@City)", conn);
            cmd.Parameters.Add("@StudentName", tbStudentName.Text);
            cmd.Parameters.Add("@FatherName", tbFatherName.Text);
            cmd.Parameters.Add("@MotherName", tbStudentName.Text);
            cmd.Parameters.Add("@Class", tbClass.Text);
            cmd.Parameters.Add("@City", tbCity.Text);
            cmd.ExecuteNonQuery();



        }

           

    }
}

