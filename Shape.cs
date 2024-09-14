using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Figures
{
    internal abstract class Shape
    {
        protected string name;

        public abstract float GetArea();

        public virtual string GetData()
        {
            return name;
        }

    }
}
