using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P2_2_Figuras
{
    internal class TrianguloEquilatero:Figura
    {
        private double Lado { get; set; }


        public override double GetArea()
        {
            return (Math.Sqrt(3)/4) * (Lado* Lado);
        }

        public TrianguloEquilatero(Color color, double lado)
        {
            Lado = lado;
        }

        public override string ToString()
        {
            double area = GetArea();
            return $"FIGURA TRIÁNGULO EQUILÁTERO\nLado : {Lado}\nColor : {_color}\nArea : {area}";
        }
    }
}
