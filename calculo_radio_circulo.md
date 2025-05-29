using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
        {
         while (true)
        {
            Console.WriteLine("\n Calcular radio de un circulo a partir del area");
        
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
        /*Se añade el calculo al radio*/
         /*case "3":
          CalcularRadioDesdeArea();
         break;*/
     static void CalcularCirculo()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine($"Área: {area:F2}, Circunferencia: {perimetro:F2}");
    }
/*Método para calcular el radio de un circulo a partir del area*/
static void CalcularRadioDesdeArea()
        {
            Console.Write("Ingrese el area del circulo:");
            if(!double.TryParse(Console.ReadLine(),
                out double area) ||<= 0)
            {
                Console.WriteLine("Area invalida.Intentar de nuevo");
                return;
            }
            /*Calcular el radio usando la formula inversa del are del circulo*/
            double radio = Match.sqrt(area / Match.PI);
            Console.WriteLine("El radio del circulo es: {radio:F2}");
        }


}
