using System;
using System.Reflection.Metadata.Ecma335;

namespace ComparisonOperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Affiche un message demandant à l'utilisateur de saisir une valeur
            Console.WriteLine("Saisissez une valeur");

            // Lit la valeur saisie par l'utilisateur, la convertit en entier et la stocke dans la variable 'num'
            int num = Convert.ToInt32(Console.ReadLine());

            // Appelle la méthode locale 'GetAfficher' pour afficher si le nombre est pair ou impair
            GetAfficher(num);

            // Définition de la méthode locale 'GetAfficher'
            void GetAfficher(int num)
            {
                // Affiche le résultat en utilisant la méthode 'GetParite' pour déterminer si 'num' est pair ou impair
                Console.WriteLine($"ce nombre est {GetParite(num)}");
            };

            // Définition de la méthode locale 'GetParite' qui retourne "pair" ou "impair" en fonction de la valeur de 'num'
            string GetParite(int num)
            {
                // Si le reste de la division de 'num' par 2 est 0, alors le nombre est pair
                if (num % 2 == 0)
                {
                    return "pair";
                }
                // Sinon, le nombre est impair
                else
                {
                    return "impair";
                }
            }



        }

    }
}