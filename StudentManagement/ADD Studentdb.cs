using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Student; Integrated Security = True");


        private void AddButton_Click(object sender, EventArgs e)
        {
            
            con.Open();
         SqlCommand cmd = new SqlCommand("INSERT INTO Table (StudentName,FatherName,MotherName,Class,City) VALUES (@StudentName,@FatherName,@MotherName,@Class,@City)", con);
            cmd.Parameters.Add("@StudentName", tbStudentName.Text);
            cmd.Parameters.Add("@FatherName", tbFatherName.Text);
            cmd.Parameters.Add("@MotherName", tbStudentName.Text);
            cmd.Parameters.Add("@Class", tbClass.Text);
            cmd.Parameters.Add("@City", tbCity.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted successfully");
            con.Close();


        }

           

    }
}

