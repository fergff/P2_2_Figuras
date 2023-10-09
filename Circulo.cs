using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal class Circulo : Figura
{

    private double radio { get; set; }

    public override double GetArea()
    {
        return 3.14 * (radio * radio);
    }

    public Circulo(Color color,double radio)
    {
        this.radio = radio;
    }

    public override string ToString()
    {
        double area = GetArea();
        return $"FIGURA CÍRCULO:\nRadio: {radio} \nColor: {_color} \nArea : {area}";
    }

}