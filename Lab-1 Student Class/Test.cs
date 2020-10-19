//2018-CS-31
//Ghulam Ghous
//Section A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Test
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.printDefaultConstructor();
            
            Student s = new Student("Ghulam Ghous", "2018-CS-31");
            s.printParameterizedConstructor();
            s.input();
            s.Output();

            Console.ReadLine();
;        }
    }
}
