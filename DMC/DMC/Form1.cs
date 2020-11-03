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

namespace DMC
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=Student;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            studentCount();
        }

        private void ManageStudentButton_Click(object sender, EventArgs e)
        {
            new ManageStudents().Show();
            this.Hide();
        }

        private void studentCount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from STUDENT", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int BSCount = 0;
            int BECount = 0;
            int MSCount = 0;
            int StudentCount = 0;

            

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string degree = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                if (degree == "BS")
                    BSCount++;
                if (degree == "BE")
                    BECount++;
                if (degree == "MS")
                    MSCount++;
                StudentCount++;
            }
            con.Close();
            BS.Text = "BS Student: " + Convert.ToString(BSCount);
            BE.Text = "BE Student: " + Convert.ToString(BECount);
            MS.Text = "MS Student: " + Convert.ToString(MSCount);
            Student.Text = Convert.ToString(StudentCount) + " have been added";
        }

    }
}
