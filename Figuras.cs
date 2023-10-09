using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

public abstract class Figura
{
    protected Color _color { get; set; }
    public abstract double GetArea();


    public override string ToString()
    {
        
        return $"Color: {_color}";
    }

}