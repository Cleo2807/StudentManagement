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
    public partial class UPDATEFORM : Form
    {
        private int SelectedStudentID;
        public UPDATEFORM()
        {
            InitializeComponent();
        }

        public UPDATEFORM(int sID)
        {
            InitializeComponent();
            SelectedStudentID = sID;
            DataLoad();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = Student; Integrated Security = True; uid = Root; password = root");
        private void DataLoad()
        {
            SqlCommand cmd = new SqlCommand("select * FROM [Studentdb] WHERE Id =" + SelectedStudentID, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbSID.Text = reader["Id"].ToString();
                tbSN.Text = reader["StudentName"].ToString();
                tbFN.Text = reader["FatherName"].ToString();
                tbMN.Text = reader["MotherName"].ToString();
                tbCL.Text = reader["Class"].ToString();
                tbCty.Text = reader["City"].ToString();
            }
            con.Close();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Studentdb SET StudentName = @SN,FatherName = @FN, MotherName = @MN, Class = @CL, City = @Cty WHERE Id = @Id ", con);
            cmd.Parameters.AddWithValue("@Id", tbSID.Text.ToString());
            cmd.Parameters.AddWithValue("@SN", tbSN.Text.ToString());
            cmd.Parameters.AddWithValue("@FN", tbFN.Text.ToString());
            cmd.Parameters.AddWithValue("@MN", tbMN.Text.ToString());
            cmd.Parameters.AddWithValue("@CL", tbCL.Text.ToString());
            cmd.Parameters.AddWithValue("@Cty", tbCty.Text.ToString());
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Studentdb WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", tbSID.Text.ToString());
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted successfully");
            con.Close();
        }
    }
}