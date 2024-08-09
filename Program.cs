using System;

namespace TestIBM
{
    class Program
    {
        static void Main(string[] args)
        {
            // mon programme factoriel en mode algo
            // je déclare mes variables
            double nb;
            double resultat = 1;
           
            Console.Write("veuillez saisir un nombre pour avoir son factorielle : ");
            nb =Convert.ToInt64(Console.ReadLine());

            for (double i = 1; i <= nb; i++)
            {
                resultat *= i;
            }

            if (nb < 0)
            {
                Console.WriteLine("Erreur de saisie le factoriel est pour des entiers positifs donc veuillez entrer un nombre positif");
            }
            else
            Console.WriteLine($"le factoriel de {nb}! est  {resultat}");
          
            // return resultat;






            //cette fois ici j'adapte mon programme en mode fonction récursive (qui s'appelle elle mêmme) 





            // int result = 1;
            // int nombre;
            // Console.WriteLine("Veuillez saisir un nombre: ");
            // nombre = Convert.ToInt32(Console.ReadLine());
            ////result = CalculFact(nombre);
            // Console.WriteLine(result);

        }
        
        //static int CalculFact(int n)
        //{
        //    int res = 1;
        //    if (n >= 1)
        //    {
        //        res = n * CalculFact(n - 1);

        //        //for (int i = 1; i <= n; i++)
        //        //{
        //        //    res *= i;
        //        //}

        //    }
        //    return res;
        }
        
    }

