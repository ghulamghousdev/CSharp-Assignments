using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Section
    {
        Student[] Students = new Student[50];
        private int StudentsCount = 0;
        private int SuspendedStudents = 0;
        
        public void AddStudents(Student obj)
        {
            this.Students[StudentsCount] = obj;
            this.StudentsCount++;
        }

        public Student[] ListOfAllStudents()
        {
            return this.Students;
        }

        public Student[] ListOfSuspendedStudents()
        {
            Student[] SuspendedStudents = new Student[50];
            for(int i = 0; i < this.StudentsCount; i++)
            {
                if( this.Students[i].GetCGPA() < 2.0)
                {
                    SuspendedStudents[this.SuspendedStudents] = this.Students[i];
                }
            }

            return SuspendedStudents;
        }



    }
}
