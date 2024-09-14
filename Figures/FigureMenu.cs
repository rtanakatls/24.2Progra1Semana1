using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Figures
{
    internal class FigureMenu
    {
        List<Shape> shapes= new List<Shape>();
        public void Execute()
        {
            shapes.Add(new Triangle(10,20));

            foreach (Shape s in shapes)
            {
                Console.WriteLine($"Nombre: {s.GetData()} , área: {s.GetArea()}");
            }
        }
    }
}
