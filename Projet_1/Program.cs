using System;

namespace Projet_1
{
    class MainClass
    {
        private static double Convertion(string elem)
        {
            bool state = true;
            double value = 0;
            while (state)
            {
                try
                {
                    Console.WriteLine("Entrez " + elem);
                    value = Convert.ToDouble(Console.ReadLine());
                    state = false;
                }
                catch(Exception E)
                {
               }
            }
            return value;
        }
        public static void Main(string[] args)
        {
            double root1;
            double root2;
            double a = 0;
            double b = 0;
            double c = 0;
            
            Console.WriteLine("Recherche des racines de ax ^2 + bx + c");
                a = Convertion("A");
                b = Convertion("B");
                c = Convertion("C");
           
            //calcul du delta
            double delta = (Math.Pow(b, 2) - (4 * a * c));
            //verification des condition et calcul des racines
            if (delta < 0)
            {
                Console.WriteLine("No root");
            }
            else if (delta == 0)
            {
                root1 = (-b / (2 * a));
                Console.WriteLine(Convert.ToString(root1));
            }
            else if (delta > 0)
            {
                root1 = (-b + Math.Sqrt(delta) / (2 * a));
                root2 = (-b - Math.Sqrt(delta) / (2 * a));
                Console.WriteLine("root 1: " + Convert.ToString(root1));
                Console.WriteLine("root 2: " + Convert.ToString(root2));
            }
        }

    }

}
