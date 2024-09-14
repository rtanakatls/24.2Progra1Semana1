using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Game
{
    internal class Potion : Item, IPickable
    {
        public Potion(string name) : base(name)
        {
        }

        public void PickUp()
        {
            Console.WriteLine("Recogiste una poción");
        }
    }
}
