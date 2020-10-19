//2018-CS-31
//Ghulam Ghous
//Section A

using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        string studentName;
        string regNumber;
        DateTime dateOfBirth;
        string CNIC;
        string[] hobbies = new string[10];
        double CGPA;
        int size;

        //Default Constructor
        public Student()
        {
            this.studentName = "Ghous";
            this.regNumber="2018-CS-31";
            this.dateOfBirth = DateTime.Parse("8 oct 2000");
            this.CNIC = "3650172093493";
            this.CGPA = 3.204;
            this.size = 2;
            this.hobbies[0] = Convert.ToString("Movies");
            this.hobbies[1] = Convert.ToString("Cricket");
        }

        //Parameterized Constructor
        public Student(string Name, string regNumber)
        {
            this.studentName = Name;
            this.regNumber = regNumber;
        }


        //Function to set Name
        public void setName()
        {
            bool flag = false;
            while (flag == false)
            {
                this.studentName = Console.ReadLine();
                if (isValidName(this.studentName) == false)
                {
                    Console.WriteLine("Name is in invalid format.");
                    flag = false;
                    Console.Write("Enter Name: ");
                }
                else
                {

                    flag = true;
                }

            }
        }

        //Function to set reg number
        public void setRegNumber() 
        {
            bool flag = false;
            while (flag == false)
            {
                this.regNumber = Console.ReadLine();
                if (isValidRegNumber(this.regNumber) == false)
                {
                    Console.WriteLine("Reg Number is in invalid format.");
                    flag = false;
                    Console.Write("Enter Reg Number: ");
                }
                else
                {
                    flag = true;
                }
            }
        }

        //Function to set cnic
        public void setCNIC()
        {
             bool flag = false;
            while (flag == false)
            {
                this.CNIC = Console.ReadLine();
                if (this.CNIC.Length != 13)
                {
                    Console.WriteLine("Invalid format of CNIC");
                    flag = false;
                    Console.Write("Enter CNIC: ");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
        }


        //Function to set cgpa
        public void setCGPA()
        {
            bool flag = false;
            while (flag == false)
            {
                this.CGPA = Convert.ToDouble(Console.ReadLine());
                if (this.CGPA < 0 || this.CGPA > 4)
                {
                    Console.WriteLine("Invalid format of CGPA");
                    flag = false;
                    Console.Write("Enter CGPA: ");
                }
                else
                {
                    flag = true;
                }
            }
        }


        //Function to set set hobbies
        public void setHobbies()
        {
            Console.WriteLine("Enter number of hobbies?");
            this.size = Convert.ToInt32(Console.ReadLine());
 
            for (int i = 0; i < this.size; i++)
            {
                Console.Write("Enter a Hobby: ");
                this.hobbies[i] = Convert.ToString(Console.ReadLine());
            }

        }

        //Function to set date of birth
        public void setDate()
        {
           bool flag = false;
            while (flag==false) {
                this.dateOfBirth = DateTime.Parse(Console.ReadLine());
                if (this.dateOfBirth.Year < 1991 || this.dateOfBirth.Year >= 2005)
                {
                    Console.WriteLine("Invalid Date");
                    flag = false;
                    Console.Write("Enter Date of Birth in format 12 feb 2012: ");


                }
                else
                {
                    flag = true;
                }
            }
        }

        //Function to get name
        public string getName()
        {
            return studentName;
        }

        //Function to get reg number
        public string getRegNumber()
        {
            return regNumber;
        }

        //Function to get cnic
        public string getCNIC()
        {
            return CNIC;
        }

        //Function to get hobbies
        public string[] getHobbies()
        {
            return hobbies;
        }

        //Function to get cgpa
        public double getCGPA()
        {
            return CGPA;
        }

        //Function to get date of birth
        public DateTime GetDate()
        {
            return this.dateOfBirth;
        }


        //Function to take input from user
        public void input()
        {
            Console.Write("\n\n\n**********Taking Input from User**********\n\n\nEnter Name: ");
            this.setName();
            Console.Write("Enter Registration Number: ");
            this.setRegNumber();
            Console.Write("Enter Date of Birth in format 12 feb 2012: ");
            this.setDate();
            Console.Write("Enter CNIC: ");
            this.setCNIC();
            Console.Write("Enter CGPA: ");
            this.setCGPA();
            this.setHobbies();
        }

        //Function to output all the attributes
        public void Output()
        {
            Console.WriteLine("\n\n\n**********OUTPUT**********\n\n\n");
            Console.WriteLine("Name: " + this.getName() + " Contains " + Convert.ToString(this.NumberOfWordsInName()) + " words");
            Console.WriteLine("Registration Number: " + regNumber);
            Console.WriteLine("CGPA: " + Convert.ToString(this.getCGPA()) + " " + this.GetStatus());
            Console.Write("DateOfBirth: ");
            this.printDate();
            this.GetAge();
            Console.WriteLine("CNIC: " + this.getCNIC());
            Console.WriteLine("Gender: " + this.GetGender());
            Console.Write("Hobbies: ");
            this.printHobbies();
        }

        //Function to get status of student
        public string GetStatus()
        {

            if (this.CGPA < 2.0)
            {
                return "Suspended";
            }
            else if (this.CGPA >= 2.0 || this.CGPA < 2.5)
            {
                return "Below average";
            }
            else if (this.CGPA >= 2.5 || this.CGPA < 3.3)
            {
                return "Average";
            }
            else if (this.CGPA >= 3.3 || this.CGPA < 3.5)
            {
                return "Below Good";
            }
            else if (this.CGPA >= 3.5)
            {
                return "Excellent";
            }
            return null;
        }


        //Function to get total words in the name
        public int NumberOfWordsInName()
        {
            int i = 0;
            int words = 1;
            
            //Loop to the end of string
            while(i <= this.studentName.Length - 1)
            {
                if (this.studentName[i] == ' ' || this.studentName[i] == '\n' || this.studentName[i] == '\t')
                {
                    words++;
                }
                i++;
            }

            return words;
        }


        //Function to get total age
        public void GetAge()
        {
            DateTime todayDate = DateTime.Today;
            int currentDate = todayDate.Day;
            int currentMonth = todayDate.Month;
            int currentYear = todayDate.Year;
            int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(this.dateOfBirth.Day > currentDate)
            {
                currentMonth = currentMonth - 1;
                currentDate = currentDate + daysInMonths[this.dateOfBirth.Month - 1];
            }

            if (this.dateOfBirth.Month > currentMonth)
            {
                currentYear = currentYear - 1;
                currentMonth = currentMonth + 12;

            }

            int totalDays = currentDate - this.dateOfBirth.Day;
            int totalMonth = currentMonth - this.dateOfBirth.Month;
            int totalYears = currentYear - this.dateOfBirth.Year;
            Console.WriteLine("(Age is " + totalYears + " years " + totalMonth + " months and " + totalDays + " days)");
        }


        //Function to get gender of Student
        public string GetGender()
        {
            string lastChar = this.CNIC.Substring(this.CNIC.Length - 1);
            int lastDigit = Convert.ToInt32(lastChar);
            if((lastDigit % 2) == 0)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }


        //Functions for validations
        public bool isValidName(string name)
        {
            bool isValid = false;
            for(int i=0; i<name.Length; i++)
            {
                if(ifalpha(name[i]) || name[i] ==' ')
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
            if (reg.Length == 9)
            {
                if ( isDigit(reg[0]) && isDigit(reg[1]) && isDigit(reg[2]) && isDigit(reg[3]) && isDigit(reg[8])  && ifAlphaUpper(reg[5]) && ifAlphaUpper(reg[6]) && reg[4] == '-' && reg[7] == '-')
                {
                    return true;
                }
            }
            else if(reg.Length == 10)
            {
                if (isDigit(reg[0]) && isDigit(reg[1]) && isDigit(reg[2]) && isDigit(reg[3]) && isDigit(reg[8]) && isDigit(reg[9])  && ifAlphaUpper(reg[5]) && ifAlphaUpper(reg[6]) && reg[4] == '-' && reg[7] == '-')
                {
                    return true;
                }
            }
            else if (reg.Length == 11)
            {
                if (isDigit(reg[0]) && isDigit(reg[1]) && isDigit(reg[2]) && isDigit(reg[3]) && isDigit(reg[8]) && isDigit(reg[9]) && isDigit(reg[10]) && ifAlphaUpper(reg[5]) && ifAlphaUpper(reg[6]) && reg[4] == '-' && reg[7] == '-')
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
            if ((a >= 'A' && a <= 'Z') || (a>= 'a' && a<= 'z'))
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


        //Print Functions


        //Function to print attributes initilized by parameterized constructor 
        public void printParameterizedConstructor()
        {
            Console.WriteLine("\n\n\n****Attributes Initilized by Parameterized Costructor****\n\n");
            Console.WriteLine("Name: " + this.getName());
            Console.WriteLine("Reg Number: " + this.getRegNumber());
        }

        //Function to Print date of birth
        public void printDate()
        {
            string[] months = new string[12] { "January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine(months[this.dateOfBirth.Month] + " " + this.dateOfBirth.Day + ", " + this.dateOfBirth.Year);
        }

        //Function to print values set in default constructor
        public void printDefaultConstructor()
        {
            Console.WriteLine("\n\n\n****Attributes Initilized by Default Costructor****\n\n\n");
            Console.WriteLine("Name: " + this.getName());
            Console.WriteLine("Reg Number: " + this.getRegNumber());
            Console.Write("DateOfBirth: ");
            this.printDate();
            Console.WriteLine("CNIC: " + this.getCNIC());
            Console.WriteLine("CGPA: " + Convert.ToString(this.getCGPA()));
            Console.Write("Hobbies: ");
            this.printHobbies();
        }

        //Function to print hobbies
        public void printHobbies()
        {

            for (int i = 0; i < this.size; i++)
            {
                Console.Write(this.hobbies[i]);
                if (i < this.size - 1)
                {
                    Console.Write(", ");
                }
            }
        }

        //Destructor
        ~Student()
        {
            Console.WriteLine("Destructor was called");
        }
    }
}
