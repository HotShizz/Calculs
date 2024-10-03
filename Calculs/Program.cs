using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        private static int GetUserResponse()
        {
            int response = 0;
            do
            {
                try
                {
                    response = int.Parse(Console.ReadLine());
                    return response;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Erreur de Saisie. Merci de saisir un nombre Entier : ");
                }
            } while (true);
        }

        private static int[] DoMath(int GameType)
        {
            Console.Clear();
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int[] results = new int[3]; // mémorisation de nombres aléatoires
            results[0] = rand.Next(1, 10);
            results[1] = rand.Next(1, 10);

            if (GameType == 1)
            {
                results[2] = results[0] + results[1];
            }
            else
            {
                results[2] = results[0] * results[1];
            }
            return results;
        }
        private static char GetChoice()
        {
            char usersSelection;
            do
            {
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                usersSelection = char.ToUpper(Console.ReadKey().KeyChar);
                switch (usersSelection)
                {
                    case '0':
                    case '1':
                    case '2':
                        return usersSelection;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Erreur de saisie. Merci de choissir un élément dans la liste.");
                        Console.WriteLine();
                        break;
                }
            } while (true);
        }
        static void Main(string[] args)
        {
            
            // variables
            int[] solution= new int[3];
            int reponse;
            char choix='4';
            // boucle sur le menu
            while (choix != '0')
            {
                // traitement des choix
                if (choix == '1')
                {
                    solution = DoMath(1);
                    // saisie de la réponse
                    Console.Write(solution[0] + " + " + solution[1] + " = ");
                    reponse = GetUserResponse();
                    // comparaison avec la bonne réponse
                    if (reponse == solution[2])
                    {
                        Console.WriteLine("Bravo !");
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + solution[0] + " + " + solution[1] + " = " + solution[2]);
                    }
                }
                else if (choix == '2')
                {
                    solution = DoMath(2);
                    // saisie de la réponse
                    Console.Write(solution[0] + " X " + solution[1] + " = ");
                    reponse = GetUserResponse();
                    // comparaison avec la bonne réponse
                    if (reponse == solution[2])
                    {
                        Console.WriteLine("Bravo !");
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + solution[0] + " X " + solution[1] + " = " + solution[2]);
                    }
                }
                choix = GetChoice();
            }
        }
    }
}
