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
    public partial class ManageStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=Student;Integrated Security=True");

        public ManageStudents()
        {
            InitializeComponent();
        }

        private void viewStudents()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from STUDENT", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            SqlCommand cmd1 = new SqlCommand("Select * from Courses", con);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);

            viewGrid.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int coursesCount = 0;
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string degree = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    string id1 = ds.Tables[0].Rows[j].ItemArray[0].ToString();
                    if (id1 == id)
                        coursesCount++;
                }
                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(viewGrid);
                dataPush.Cells[0].Value = id;
                dataPush.Cells[1].Value = name;
                dataPush.Cells[2].Value = degree;
                dataPush.Cells[2].Value = coursesCount;
                viewGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        private void ManageStudentsButton_Click(object sender, EventArgs e)
        {
            new AddStudents().Show();
            this.Hide();
        }
    }
}
