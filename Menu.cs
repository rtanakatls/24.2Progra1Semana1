using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1
{
    internal class Menu
    {
        PersonController personController;
        StudentController studentController;
        Person[] peopleArray;

        public Menu()
        {
            peopleArray = new Person[0];
            personController = new PersonController();
            studentController=new StudentController();
        }

        private void AddSlotToArray()
        {
            Person[] tempArray=new Person[peopleArray.Length + 1];
            for (int i = 0; i < peopleArray.Length; i++)
            {
                tempArray[i] = peopleArray[i];
            }
            peopleArray = tempArray;
        }


        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag=true;
            while (continueFlag)
            {
                int option;
                Console.WriteLine("1. Añadir persona");
                Console.WriteLine("2. Mostrar todas las personas");
                Console.WriteLine("3. Añadir estudiante");
                Console.WriteLine("0. Salir");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        AddPerson();
                        break;
                    case 2:
                        ShowAllPeople();
                        break;
                    case 3:
                        AddStudent();
                        break;
                    case 0:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }


        private void AddPerson()
        {
            AddSlotToArray();
            peopleArray[peopleArray.Length - 1] = personController.GetNewPerson();
        }

        private void AddStudent()
        {
            AddSlotToArray();
            peopleArray[peopleArray.Length - 1] = studentController.GetNewPerson();
        }

        private void ShowAllPeople()
        {
            foreach(Person person in peopleArray)
            {
                Console.WriteLine(person.GetPersonData());
            }
        }

    }
}
