using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1
{
    internal class Person
    {
        protected string name;
        protected int age;


        public string Name {  get { return name; }}
        public int Age { get { return age; } }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string GetPersonData()
        {
            return $"Nombre: {name} - Edad: {age}";
        }

    }
}
