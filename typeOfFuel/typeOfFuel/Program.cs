using System;

using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int codigo = 0, alcool = 0, gasolina = 0, gasolio = 0;

            Console.WriteLine("Insira os códigos abaixo: ");

            while (codigo != 4)
            {
                if (codigo == 1)
                {

                    alcool = alcool + 1;

                }
                else if (codigo == 2)
                {

                    gasolina = gasolina + 1;

                }
                else if (codigo == 3)
                {

                    gasolio = gasolio + 1;

                }

                codigo = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("ALCOOL: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + gasolio);

        }
    }
}
