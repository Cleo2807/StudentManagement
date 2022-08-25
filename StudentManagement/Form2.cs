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

namespace StudentManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(tbStudentID.Text);
            var SName = tbStudentName.Text;
            var FName = tbFatherName.Text;
            var MName = tbMothersName.Text;
            var C = tbClass.Text;
            var City = tbCity.Text;

            using (SqlConnection conn = new SqlConnection())
                try
                {
                    string MyConnection = conn.ConnectionString;    
                    conn.Open();
                    string Query = string.Format("Insert into Student where Id = {0}, StudentName = {1}, FatherName = {2}, MotherName = {3}, Class = {4}, City = {5}" + id, SName, FName, MName, C, City);


                }
               catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              finally
              {
                    conn.Close();
              }

            
        }
              
        
    }
}
