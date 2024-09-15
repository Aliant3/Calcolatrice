using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione2.Calcolatrice
{
    internal class Calcolatrice
    {


        public static double Somma(double x, double y)
        {
            return x + y;
        }

        public static double Sottrazione(double x, double y)
        {
            return x - y;
        }

        public static double Moltiplicazione(double x, double y)
        {
            return x * y;
        }

        public static double CalcolaPotenza(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static double CalcolaRadice(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Divisione(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Non puoi dividere per 0");
            }

            return x / y;
        }


        static void Main(string[] args)
        {
            int[] elenco = { };

            bool insAbi = true;
            

            while (insAbi)
            {
                double num1 = 0;
                double num2 = 0;
                Console.WriteLine("Inserisci due numeri");


                while (num1 == 0 && num2 == 0)
                {
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();

                    try
                    {
                        num1 = Convert.ToDouble(input1);
                        num2 = Convert.ToDouble(input2);

                    }
                    catch
                    {
                        Console.WriteLine("ERRORE: Digita due numeri per continuare");
                        input1 = Console.ReadLine();
                        input2 = Console.ReadLine();
                    }


                    Console.WriteLine("Digita A per eseguire una somma, B per eseguire una sottrazione, C per eseguire una moltiplicazione, D per la divisione, E per la potenza, F per la radice e Q per uscire dal programma");

                    string? inputUtente = Console.ReadLine();


                    switch (inputUtente.ToUpper())
                    {
                        case "A":
                            Console.WriteLine("Il risultato è: " + Somma(num1, num2));
                            break;
                        case "B":
                            Console.WriteLine("Il risultato è: " + Sottrazione(num1, num2));
                            break;
                        case "C":
                            Console.WriteLine("Il risultato è: " + Moltiplicazione(num1, num2));
                            break;
                        case "D":
                            Console.WriteLine("Il risultato è: " + Divisione(num1, num2));
                            break;
                        case "E":
                            Console.WriteLine("Il risultato è: " + CalcolaPotenza(num1, num2));
                            break;
                        case "F":
                            Console.WriteLine("Il risultato è " + CalcolaRadice(num1));
                            break;
                        case "Q":
                            insAbi = !insAbi;
                            break;
                        default:
                            Console.WriteLine("Parametro non trovato");
                            break;

                    }
                }



            }
        }


    }
}
    