using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMC
{
    class CourseResult
    {//Data Members
        private string CourseID;
        private string CourseTitle;
        private int CreditHours;
        private int Marks;
        private int Semester;

        //Default constructor
        public CourseResult()
        {
            this.CourseID = "";
            this.CourseTitle = "";
            this.Marks = 0;
            this.CreditHours = 1;
            this.Semester = 1;
        }

        //Parameterized constructor
        public CourseResult(string id, string name, int crd, int marks, int sem)
        {
            this.CourseTitle = name;
            this.CourseID = id;
            this.Marks = marks;
            this.Semester = sem;
            this.CreditHours = crd;
        }


        //Function to set Course ID
        public void SetCourseID()
        {
            while (true)
            {
                this.CourseID = Convert.ToString(Console.ReadLine());
                if (isCourseIDValid(this.CourseID))
                {
                    break;
                }
                Console.WriteLine("CourseID is invalid");
                Console.Write("Enter CourseID: ");
            }
        }

        //Function to set semester
        public void SetSemester()
        {
            while (true)
            {
                this.Semester = Convert.ToInt32(Console.ReadLine());
                if (isSemesterValid(this.Semester))
                {
                    break;
                }
                Console.WriteLine("Semester is invalid");
                Console.Write("Enter Semester: ");
            }
        }


        //Function to set credit hours
        public void SetCreditHours()
        {
            while (true)
            {
                this.CreditHours = Convert.ToInt32(Console.ReadLine());
                if (isCreditHoursValid(this.CreditHours))
                {
                    break;
                }
                Console.WriteLine("Credit Hours are invalid");
                Console.Write("Enter Credit Hours: ");
            }
        }

        //Function to set marks
        public void SetMarks()
        {
            while (true)
            {
                this.Marks = Convert.ToInt32(Console.ReadLine());
                if (isMarksValid(this.Marks))
                {
                    break;
                }
                Console.WriteLine("Marks are invalid");
                Console.Write("Enter Marks: ");
            }
        }

        //Function to set name of Course 
        public void SetCourseTitle()
        {
            while (true)
            {
                this.CourseTitle = Convert.ToString(Console.ReadLine());
                if (isCourseTitleValid(this.CourseTitle))
                {
                    break;
                }
                Console.WriteLine("CourseTitle is invalid");
                Console.Write("Enter Course Title: ");
            }
        }

        //Function to get Course Title
        public string GetCourseTitle()
        {
            return this.CourseTitle;
        }

        //Function to get Course Title
        public string GetCourseID()
        {
            return this.CourseID;
        }

        //Function to get Course ID
        public int GetMarks()
        {
            return this.Marks;
        }

        //Function to get Credit hours
        public int GetCreditHours()
        {
            return this.CreditHours;
        }

        //Function to get Semester
        public int GetSemester()
        {
            return this.Semester;
        }

        //Function to take input
        public void input()
        {
            Console.Write("\nEnter Course Title: ");
            this.SetCourseTitle();
            Console.Write("Enter Course ID: ");
            this.SetCourseID();
            Console.Write("Enter Credit Hours: ");
            this.SetCreditHours();
            Console.Write("Enter Semester: ");
            this.SetSemester();
            Console.Write("Enter Marks: ");
            this.SetMarks();
        }

        //Function to return all the attributes
        public string Output()
        {
            return (this.GetCourseID().PadRight(14) + this.GetCourseTitle().PadRight(30) + Convert.ToString(this.GetCreditHours()).PadRight(5) + Convert.ToString(this.GetMarks()).PadRight(10) + this.GetGrade().PadRight(10));
        }

        //Function to Validate course title
        public bool isCourseTitleValid(string name)
        {
            bool isValid = false;
            if (name.Length >= 10 && name.Length <= 35)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (isAlphabet(name[i]) || name[i] == ' ')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        return isValid;
                    }
                }
            }
            else
            {
                return false;
            }

            return isValid;
        }


        //Function to get grade
        public string GetGrade()
        {
            if (this.Marks < 40)
                return "F";
            else if (this.Marks >= 40 && this.Marks < 50)
                return "D";
            else if (this.Marks >= 50 && this.Marks < 55)
                return "C";
            else if (this.Marks >= 55 && this.Marks < 60)
                return "C+";
            else if (this.Marks >= 60 && this.Marks < 65)
                return "B-";
            else if (this.Marks >= 65 && this.Marks < 70)
                return "B+";
            else if (this.Marks >= 70 && this.Marks < 80)
                return "A-";
            else if (this.Marks >= 80)
                return "A";
            return "";
        }

        //Function to grade points
        public double GetGradePoints()
        {
            string Grade = this.GetGrade();
            if (Grade == "F")
                return 0;
            else if (Grade == "D")
                return 1.0;
            else if (Grade == "C")
                return 2.3;
            else if (Grade == "C+")
                return 2.7;
            else if (Grade == "B-")
                return 3.0;
            else if (Grade == "B+")
                return 3.3;
            else if (Grade == "A-")
                return 3.7;
            else if (Grade == "A")
                return 4.0;
            return 0;
        }


        //Function to Validate Marks
        public bool isMarksValid(int marks)
        {
            if (marks >= 0 && marks <= 100)
            {
                return true;
            }
            return false;
        }

        //Function to Validate Credit Hours
        public bool isCreditHoursValid(int crd)
        {
            if (crd >= 1 && crd <= 3)
            {
                return true;
            }
            return false;
        }

        //Function to Validate course id
        public bool isCourseIDValid(string CourseID)
        {
            if (CourseID.Length >= 2 && CourseID.Length <= 8 && CourseID[CourseID.Length - 1] == 'L') //If course is of lab
            {
                if (isDigit(CourseID[CourseID.Length - 2])
                   && isDigit(CourseID[CourseID.Length - 3])
                   && isDigit(CourseID[CourseID.Length - 4])
                   )
                {
                    for (int i = 0; i < CourseID.Length - 4; i++)
                    {
                        if (isAlphabetUpperCase(CourseID[i]) == false)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            else if (CourseID.Length >= 2 && CourseID.Length <= 8) //If course if theory
            {
                if (isDigit(CourseID[CourseID.Length - 1])
                    && isDigit(CourseID[CourseID.Length - 2])
                    && isDigit(CourseID[CourseID.Length - 3])
                    )
                {
                    for (int i = 0; i < CourseID.Length - 3; i++)
                    {
                        if (isAlphabetUpperCase(CourseID[i]) == false)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }



        //Function to Validate Semester
        public bool isSemesterValid(int sem)
        {
            if (sem >= 1 && sem <= 8)
            {
                return true;
            }
            return false;
        }

        //Function to Validate Alphabet
        public bool isAlphabet(char a)
        {
            if ((a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z'))
            {
                return true;
            }
            return false;
        }

        //Function to Validate digit
        public bool isDigit(int digit)
        {
            if (digit >= '0' && digit <= '9')
            {
                return true;
            }
            return false;
        }

        //Function to Validate Upper case alphabet
        public bool isAlphabetUpperCase(char a)
        {
            if ((a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z'))
            {
                return true;
            }
            return false;
        }

        //Copy constructor
        public CourseResult(CourseResult src)
        {
            CourseID = src.CourseID;
            CourseTitle = src.CourseTitle;
            Marks = src.Marks;
            CreditHours = src.CreditHours;
            Semester = src.Semester;
        }
    }
}
