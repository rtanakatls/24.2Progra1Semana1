using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Game
{
    internal abstract class Item
    {
        protected string name;

        public string Name { get { return name; } }

        public Item(string name)
        {
            this.name = name;
        }
    }
}
