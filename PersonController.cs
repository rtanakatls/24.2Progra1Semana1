using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _24._2Progra1Semana1
{
    internal class PersonController
    {
        protected string name;
        protected int age;

        public virtual Person GetNewPerson()
        {
            EnterName();
            EnterAge();
            return new Person(name, age);
        }

        protected void EnterName()
        {
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
        }

        protected void EnterAge()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tu edad es {age} años");
                if (age < 0)
                {
                    Console.WriteLine("Aún no has nacido");
                }
                else if (age > 150)
                {
                    Console.WriteLine("Ya estás muerto");
                }
                else if (age < 18)
                {
                    continueFlag = false;
                    Console.WriteLine("No puedes tomar alcohol");
                }
                else
                {
                    continueFlag = false;
                    Console.WriteLine("Puedes tomar todo el alcohol que quieras");
                }
            }
        }
    }
}
