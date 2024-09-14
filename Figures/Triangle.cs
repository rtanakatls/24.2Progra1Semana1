using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Figures
{
    internal class Triangle : Shape
    {
        protected float b;
        protected float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
            name = "Triángulo";
        }

        public override float GetArea()
        {
            return b * h / 2;
        }
    }
}
