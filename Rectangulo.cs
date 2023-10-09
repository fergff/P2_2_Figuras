using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_Figuras
{
    internal class Rectangulo : Figura
    {
        private double Base { get; set; }
        private double Altura { get; set; }

        public override double GetArea()
        {
            return Base * Altura;
        }


        public Rectangulo(Color color, double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override string ToString()
        {
            double area = GetArea();
            return $"FIGURA RECTANGULO:\nAlto : {Altura}\nAncho : {Base}\nColor : {_color}\nArea : {area}";
        }

    }
}
