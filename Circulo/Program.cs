using System;

namespace ConsoleApp1
{
    class Calculadora
    {
        //Variável do PI
        public double Pi = 3.14;

        //Método que retorna o valor da circuferência 
        
        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
   

    //Método que retorna o valor do volume

    public double Volume(double r)
    {
            return 4.0 / 3.0 * Pi * r * r * r;
    }

     
    }
}
