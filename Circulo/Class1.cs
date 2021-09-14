using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
class program
{
    static double Pi = 3.14;
    static void Main(string[]args)
    {
        //Instanciando a classe calculadora
        Calculadora calc = new Calculadora();

        //Decretando as variavéis  que o código está pedindo
;       Console.WriteLine("Entre com valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = calc.Circunferencia(raio);
        double volume = calc.Volume(raio);

        //Input do usuário 
        Console.WriteLine("Circuferência:" + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor do Pi:" + Pi.ToString("F2", CultureInfo.InvariantCulture));

    }
}
