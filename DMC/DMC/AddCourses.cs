using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMC
{
    public partial class AddCourses : Form
    {

        CourseResult courseObj = new CourseResult();
        public AddCourses()
        {


            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string id = CourseIDBox.Text;
            string name = CourseTitleBox.Text;
            int marks = Convert.ToInt32(MarksBox.Text);
            int crd = Convert.ToInt32(CreditHoursBox.Text);
            int sem = Convert.ToInt32(SemesterBox.Text);
            if (!courseObj.isCourseIDValid(id))
            {
                MessageBox.Show("Invalid Course ID 😊");
                return;
            }
            else if (!courseObj.isCourseTitleValid(name))
            {
                MessageBox.Show("Invalid Course Title 😊");
                return;
            }
            else if (!courseObj.isCreditHoursValid(crd))
            {
                MessageBox.Show("Invalid Credit Hours 😊");
                return;
            }
            else if (!courseObj.isMarksValid(marks))
            {
                MessageBox.Show("Invalid Marks 😊");
                return;
            }
            else if (!courseObj.isSemesterValid(sem))
            {
                MessageBox.Show("Invalid Semester 😊");
                return;
            }

            AddStudents.CourseID = id;
            AddStudents.CourseName = name;
            AddStudents.MarksOfCourse = marks;
            AddStudents.CrdHRS = crd;
            AddStudents.SemNum = sem;
            this.Close();
        }
    }
}
