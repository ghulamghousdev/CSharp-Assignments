using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        // Data members
        private string StudentName;
        private string RegNumber;
        private string Degree;
        CourseResult[] Courses = new CourseResult[50];

        private int coursesCount = 0;


        //Function which will add course.
        public void SetCourses()
        {
            CourseResult c2 = new CourseResult("Programming Fundamentals", "CS311", 3, 55, 1);
            CourseResult c3 = new CourseResult("Intro to Computing", "CS312", 3, 62, 1);
            CourseResult c4 = new CourseResult("Datastructures", "CS313", 3, 72, 2);
            CourseResult c5 = new CourseResult("Intro to Assembly", "CS314", 3, 49, 2);
            CourseResult c6 = new CourseResult("Technical Writing", "CS315", 3, 77, 3);
            CourseResult c7 = new CourseResult("Communication Skills", "CS316", 3, 68, 3);
            this.Courses[this.coursesCount] = c2;
            this.coursesCount++;
            this.Courses[this.coursesCount] = c3;
            this.coursesCount++;
            this.Courses[this.coursesCount] = c4;
            this.coursesCount++;
            this.Courses[this.coursesCount] = c5;
            this.coursesCount++;
            this.Courses[this.coursesCount] = c6;
            this.coursesCount++;
            this.Courses[this.coursesCount] = c7;
            this.coursesCount++;

            //Asking user if user want to add more courses
            Console.Write("Enter 1 to add course or 0 to exit: ");
            int b = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            if (b == 0)
                flag = false;
            //If user wanted to add more courses then this block will execute
            while (flag)
            {
                CourseResult c1 = new CourseResult();
                c1.input();
                this.Courses[this.coursesCount] = c1;
                this.coursesCount++; //Keeping track of how many courses are added for a student
                Console.Write("Enter 1 to add another course or 0 to exit: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                    break;
            }
        }

        //Default constructor
        public Student() { }


        //Function to set Name
        public void SetStudentName()
        {
            bool flag = false;
            while (flag == false)
            {
                flag = true;
                this.StudentName = Console.ReadLine(); //taking input from user
                if (isValidName(this.StudentName) == false) //Validating the name of student
                {
                    Console.WriteLine("Name is in invalid format.");
                    flag = false;
                    Console.Write("Enter Name: ");
                }
            }
        }


        //Function to set reg number
        public void SetRegNumber()
        {
            bool flag = false;
            while (flag == false)
            {
                flag = true;
                this.RegNumber = Console.ReadLine(); //taking input from user
                if (isValidRegNumber(this.RegNumber) == false) //Validating the reg number of student
                {
                    Console.WriteLine("Reg Number is in invalid format.");
                    flag = false;
                    Console.Write("Enter Reg Number: ");
                }
            }
        }


        //Function to set reg degree
        public void SetDegree()
        {
            bool flag = false;
            while(flag == false)
            {
                flag = true;
                this.Degree = Convert.ToString(Console.ReadLine());
                if (isDegreeNameValid(this.Degree) == false) //This block validates the degree name
                {
                    Console.WriteLine("Degree name is invalid");
                    flag = false;
                    Console.Write("Enter Degree Name: ");
                }
            }
        }

        //Function to get Student Name
        public string GetStudentName()
        {
            return this.StudentName;
        }

        //Function to get Degree
        public string GetDegree()
        {
            return this.Degree;
        }

        //Function to Get Reg Number
        public string GetRegNumber()
        {
            return this.RegNumber;
        }

        //Function to get semester GPA
        public double GetSemesterGPA(int a)
        {
            double GradePoints = 0;
            int crd = 0;
            for (int i = 0; i < this.coursesCount; i++)
            {
                if (this.Courses[i].GetSemester() == a) //Checking the sem 
                {
                    GradePoints = GradePoints + (Courses[i].GetGradePoints() * Courses[i].GetCreditHours());
                    crd = crd + Courses[i].GetCreditHours();
                }
            }
            return (GradePoints / (Convert.ToDouble(crd)));
        }

        //Function to get CGPA of a student
        public double GetCGPA()
        {
            int CreditHours = 0;
            double GradePoints = 0;
            for(int i = 0; i < this.coursesCount; i++)
            {
                GradePoints = GradePoints + (this.Courses[i].GetGradePoints() * this.Courses[i].GetCreditHours()); //storing total grade points
                CreditHours = CreditHours + this.Courses[i].GetCreditHours(); //storing total credit hours
            }
            return (GradePoints / (Convert.ToDouble(CreditHours)));
        }

        //Function to return total number of Semsters
        public int GetSemesters()
        {
            int sem = 0;
            for(int i = 0; i < this.coursesCount; i++)
            {
                if(this.Courses[i].GetSemester() > sem)
                {
                    sem = this.Courses[i].GetSemester();
                }
            }
            return sem;
        }

        //Function to get credit hours of a semester
        public int GetSemesterCreditHours(int sem)
        {
            int creditHours = 0;
            for (int i = 0; i < this.coursesCount; i++)
            {
                if (this.Courses[i].GetSemester() == sem)
                {
                    creditHours = this.Courses[i].GetCreditHours();
                }
            }
            return creditHours;
        }

        //Function to get Session of the Student
        public string GetSession()
        {
            return (""+this.RegNumber[0]+ this.RegNumber[1]+ this.RegNumber[2]+ this.RegNumber[3]);
        }

        //Function to get Discipline of the Student
        public string GetDiscipline()
        {
            return ("" + this.RegNumber[5] + this.RegNumber[6]);
        }

        //Function to take input from user
        public void input()
        {
            Console.Write("\n\n\n**********Enter Student Details**********\n\n\nEnter Student Name: ");
            this.SetStudentName();
            Console.Write("Enter Reg Number: ");
            this.SetRegNumber();
            Console.Write("Degree: ");
            this.SetDegree();
            this.SetCourses();
        }

        //Printing the student details
        public void Output()
        {
            int semCount = 1;
            bool flag = true;
            Console.Write("\n\n\n\t\t\t**********DMC**********\n\n");
            Console.WriteLine("\nName: " + this.GetStudentName() + "\tDegree: " + this.GetDegree() + " " + this.GetDiscipline() + "\nRegistration Number:" + this.GetRegNumber() + "\nDegree" + this.GetSession());
            while (semCount > 0 && semCount < 9)
            {
                for (int i = 0; i < this.coursesCount; i++)
                {
                    if (this.Courses[i].GetSemester() == semCount)
                    {
                        if (flag == true)
                        {
                            Console.WriteLine("\nSemester " + Convert.ToString(semCount) + ":");
                            Console.WriteLine("".PadRight(5)+"ID".PadRight(14)+"Course Name".PadRight(30) + "CH".PadRight(5) +"Marks".PadRight(10) + "Grade".PadRight(5));
                            flag = false;
                        }
                        Console.WriteLine("".PadRight(5)+Courses[i].Output());
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("".PadRight(60)+"SGPA: " + this.GetSemesterGPA(semCount));
                    flag = true;
                }
                semCount++;
            }
            Console.WriteLine("".PadRight(60)+"CGPA: " + this.GetCGPA());
        }

        //Functions for validations

        //Functions for validation of degree
        public bool isDegreeNameValid(string degreeName)
        {
            if(degreeName == "MS" || degreeName == "BE" || degreeName == "BS")
            {
                return true;
            }
            return false;
        }

        //Functions for validation of student name
        public bool isValidName(string name)
        {
            bool isValid = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (ifalpha(name[i]) || name[i] == ' ')
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    return isValid;
                }
            }

            return isValid;
        }


        //Function to validate reg number
        public bool isValidRegNumber(string reg)
        {
            if (reg.Length == 9) //If roll number is of one digit
            {
                if (isDigit(reg[0]) 
                    && isDigit(reg[1]) 
                    && isDigit(reg[2]) 
                    && isDigit(reg[3]) 
                    && isDigit(reg[8]) 
                    && ifAlphaUpper(reg[5]) 
                    && ifAlphaUpper(reg[6]) 
                    && reg[4] == '-' 
                    && reg[7] == '-')
                {
                    return true;
                }
            }
            else if (reg.Length == 10) //If roll number is of two digit
            {
                if (isDigit(reg[0]) 
                    && isDigit(reg[1]) 
                    && isDigit(reg[2]) 
                    && isDigit(reg[3]) 
                    && isDigit(reg[8]) 
                    && isDigit(reg[9]) 
                    && ifAlphaUpper(reg[5]) 
                    && ifAlphaUpper(reg[6]) 
                    && reg[4] == '-' 
                    && reg[7] == '-')
                {
                    return true;
                }
            }
            else if (reg.Length == 11) //If roll number is of three digit
            {
                if (isDigit(reg[0]) 
                    && isDigit(reg[1]) 
                    && isDigit(reg[2]) 
                    && isDigit(reg[3]) 
                    && isDigit(reg[8]) 
                    && isDigit(reg[9]) 
                    && isDigit(reg[10]) 
                    && ifAlphaUpper(reg[5]) 
                    && ifAlphaUpper(reg[6]) 
                    && reg[4] == '-' 
                    && reg[7] == '-')
                {
                    return true;
                }
            }

            return false;
        }

        //Function to check  alphabets.
        public bool ifalpha(char a)
        {
            bool isValid = false;
            if ((a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z'))
            {
                isValid = true;
            }
            return isValid;
        }

        //Function to check Upper case alphabets.
        public bool ifAlphaUpper(char a)
        {
            bool isValid = false;
            if ((a >= 'A' && a <= 'Z'))
            {
                isValid = true;
            }
            return isValid;
        }

        //Function to check digits.
        public bool isDigit(char b)
        {
            bool isValid = false;
            if (b >= '0' && b <= '9')
            {
                isValid = true;
            }
            return isValid;
        }


    }
}
