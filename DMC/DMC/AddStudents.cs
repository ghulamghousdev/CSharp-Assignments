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
    public partial class AddStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=Student;Integrated Security=True");
        public static string CourseName = "";
        public static string CourseID = "";
        public static int MarksOfCourse = 0;
        public static int CrdHRS = 0;
        public static int SemNum = 0;

        Student StudentObj = new Student();

        public AddStudents()
        {
            InitializeComponent();
        }

        public void SaveData()
        {
            StudentObj.StudentName = NameBox.Text;
            StudentObj.RegNumber = IDBox.Text;
            StudentObj.Degree = DegreeBox.Text;

            DialogResult NewForm;
            NewForm = new AddCourses().ShowDialog();
        }

        public void ViewData()
        {
            if(CourseID!="")
                StudentObj.SetCourses(CourseID, CourseName, CrdHRS, MarksOfCourse, SemNum);
            
            viewGrid.Rows.Clear();
            for (int i = 0; i < StudentObj.coursesCount; i++)
            {
                string id = StudentObj.Courses[i].GetCourseID();
                string name = StudentObj.Courses[i].GetCourseTitle();
                string crd = Convert.ToString(StudentObj.Courses[i].GetCreditHours());
                string marks = Convert.ToString(StudentObj.Courses[i].GetMarks());
                string sem = Convert.ToString(StudentObj.Courses[i].GetSemester());

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(viewGrid);
                dataPush.Cells[0].Value = id;
                dataPush.Cells[1].Value = name;
                dataPush.Cells[2].Value = marks;
                dataPush.Cells[3].Value = crd;
                dataPush.Cells[4].Value = sem;
                viewGrid.Rows.Add(dataPush);
            }

            CourseID = "";
            CourseName = "";
            CrdHRS = 0;
            MarksOfCourse = 0;
            SemNum = 0;
        }

        public void SaveStudent()
        {
            if (!StudentObj.isValidName(StudentObj.StudentName))
            {
                MessageBox.Show("Invalid Student Name 😊");
                return;
            }
            else if (!StudentObj.isValidRegNumber(StudentObj.RegNumber))
            {
                MessageBox.Show("Invalid Student Registration Number 😊");
                return;
            }
            else if (!StudentObj.isDegreeNameValid(StudentObj.Degree))
            {
                MessageBox.Show("Invalid Student Degree Name Invalid 😊");
                return;
            }

            con.Open();
            string firstQuery = "INSERT INTO STUDENT(StudentName, RegNumber, Degree) values(@name, @id, @crft)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@name", StudentObj.StudentName);
            cmd.Parameters.AddWithValue("@id", StudentObj.RegNumber);
            cmd.Parameters.AddWithValue("@crft", StudentObj.Degree);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SaveCourses()
        {
            for (int i = 0; i < StudentObj.coursesCount; i++)
            {
                con.Open();
                string firstQuery = "INSERT INTO Courses(RegNumber, CourseID, CourseTitle, CreditHours, Marks, Semester) values(@id, @courseID,@name, @crd, @mark, @sem)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@name", StudentObj.Courses[i].GetCourseTitle());
                cmd.Parameters.AddWithValue("@id", StudentObj.RegNumber);
                cmd.Parameters.AddWithValue("@crd", StudentObj.Courses[i].GetCreditHours());
                cmd.Parameters.AddWithValue("@mark", StudentObj.Courses[i].GetMarks());
                cmd.Parameters.AddWithValue("@sem", StudentObj.Courses[i].GetSemester());
                cmd.Parameters.AddWithValue("@courseID", StudentObj.Courses[i].GetCourseID());
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void AddCoursesButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewData();
        }
    }
}
