//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Collections;
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void Main(string[] args)
    {   
        
        Rectangulo rectangulo01 = new Rectangulo(Color.FromArgb(255, 50, 20, 34),3,3.9);
        Circulo circulo01 = new Circulo(Color.FromArgb(255,0,20,35),4);
        Circulo circulo02 = new Circulo(Color.FromArgb(255, 230, 20, 30), 2);
        TrianguloEquilatero triangulo01 = new TrianguloEquilatero(Color.FromArgb(255, 230, 20, 30), 3);

        ArrayList figuras = new ArrayList();
        figuras.Add(rectangulo01);
        figuras.Add(circulo01);
        figuras.Add(circulo02);
        figuras.Add(triangulo01);

        //imprimo figuras
        foreach (var i in figuras)
        {
            Console.WriteLine(i);
        }
        //cambiamos el color
        foreach (var i in figuras)
        {
            i.Equals(Color.FromArgb(245, 40, 145, 200));
        }
        //cumar todas las Areas
        double suma = 0;
        foreach (var i in figuras)
        {
             suma += i.GetArea();
        }
        Console.WriteLine(suma);
        

    }

}
