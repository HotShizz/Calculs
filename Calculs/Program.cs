using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        private static int GetUserResponse(bool gameChoice)
        {
            bool isInt = false;
            int response = 0;
            while (!isInt)
            {
                try
                {
                    response = int.Parse(Console.ReadLine());
                    isInt = true;
                }
                catch
                {
                    if (gameChoice)
                    {
                        Console.WriteLine("Erreur de Saisie. Merci de choissir un element dans la liste : ");
                        GetChoice();
                    }
                    else
                    {
                        Console.WriteLine("Erreur de Saisie. Merci de saisir un nombre Entier");
                    }
                }
            }
            return response;
        }

        private static int[] DoMath(int GameType)
        {
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
        private static int GetChoice()
        {
            Console.WriteLine("Addition ....................... 1");
            Console.WriteLine("Multiplication ................. 2");
            Console.WriteLine("Quitter ........................ 0");
            Console.Write("Choix :                          ");
            return 0;
        }
        static void Main(string[] args)
        {
            
            // variables
            int[] solution= new int[3]; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix=4; // saisie du choix de l'utilsiateur
            int counter = 0;
            // boucle sur le menu
            while (choix != 0)
            {
                choix = 4;// affiche le menu et saisi le choix
                while (choix > 2 || choix < 0)
                {
                    if (counter > 0)
                    {
                        Console.WriteLine("Erreur de Saisie. Merci de choissir un element dans la liste : ");
                    }
                    GetChoice();
                    choix = GetUserResponse(true);
                    counter++;
                }
                counter = 0;
                // traitement des choix
                if (choix == 1)
                {
                    solution = DoMath(1);
                    // saisie de la réponse
                    Console.Write(solution[0] +" + " + solution[1] + " = ");
                        reponse = GetUserResponse(false);
                        // comparaison avec la bonne réponse
                        if (reponse == solution [2])
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + solution[0] + " + " + solution[1] + " = " + solution[2]);
                        }
                    }
                    else if (choix==2)
                    {
                    solution = DoMath(2);
                    // saisie de la réponse
                    Console.Write(solution[0] + " X " + solution[1] + " = ");
                    reponse = GetUserResponse(false);
                    // comparaison avec la bonne réponse
                    if (reponse == solution[2])
                    {
                        Console.WriteLine("Bravo !");
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + solution[0] + " X " + solution[1] + " = " + solution[2]);
                    }
                    choix = 4;
               }
            }
        }
    }
}
