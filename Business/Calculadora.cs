using System;

namespace Business
{
    public class Calculadora : ICalculadora
    {



        public double suma(int a, int b)
        {
            return a + b;
        }

        public double substrac(int a, int b) => a - b;

        public double multiply(int a, int b) => a * b;

        public double divide(int a, int b) => a / b;

    }
}
