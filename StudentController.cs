using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1
{
    internal class StudentController : PersonController
    {
        private float grade;

        public override Person GetNewPerson()
        {
            EnterName();
            EnterAge();
            EnterGrade();
            return new Student(name,age,grade);
        }

        protected void EnterGrade()
        {
            Console.WriteLine("Introduce tu nota");
            grade = float.Parse(Console.ReadLine());
            Console.WriteLine($"Tu nota es {grade}");
        }
    }
}
