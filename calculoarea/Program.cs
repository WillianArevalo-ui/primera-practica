using System;
class Program
{
    static void Main()
        {
            Console.Write("Ingrese el ancho del rectangulo:");
            double ancho = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el alto del rectangulo:");
            double alto = Convert.ToDouble(Console.ReadLine());
            double area = Calculararea(ancho, alto);
            double perimetro = Calcularperimetro(ancho, alto); 
            Console.WriteLine($"El area del rectangulo es: {area}");
            Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");


        }
        static double Calculararea(double ancho, double alto)
        {
            return ancho * alto;
        }
        static double Calcularperimetro(double ancho, double alto)
        {
            return 2 * (ancho + alto);
        }
     static void CalcularCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine($"Área: {area:F2}, Circunferencia: {perimetro:F2}");
    }

}
