using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1
{
    internal class Student : Person
    {
        protected float grade;

        public Student(string name, int age, float grade) : base(name, age)
        {
            this.grade = grade;
        }

        public override string GetPersonData()
        {
            return base.GetPersonData() + $" - Nota: {grade}";
        }

    }
}
