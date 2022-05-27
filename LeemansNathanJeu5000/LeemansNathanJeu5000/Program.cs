using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeemansNathanJeu5000
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Joueur1 = new int[1,5];
            int[,] Joueur2 = new int[1,5];
            int[,] tableauDe = new int[2, 5];
            Random rnd = new Random();
            int NbrePointJ1 = 0;
            int NbrePointJ2 = 0;
            bool J1ouJ2;
            string relancer = "oui";

            MethodeDuProjet MesOutils = new MethodeDuProjet();

            Console.WriteLine("-----------");
            Console.WriteLine("Jeu du 5000");
            Console.WriteLine("-----------\n");

            while (NbrePointJ1 < 5000 && NbrePointJ2 < 5000)
            {
                while (relancer == "oui")
                {
                    MesOutils.LancerDes(tableauDe, rnd, Joueur1, Joueur2);
                    Console.WriteLine("Le premier joueur lance ses dés");
                    J1ouJ2 = true;
                    MesOutils.AfficherTableau(tableauDe, J1ouJ2);
                    Console.WriteLine("Voulez-vous relancer(autoriser une fois)");
                    relancer = Console.ReadLine();
                }
                relancer = "oui";
                Console.WriteLine("Le deuxième joueur lance ses dés");
                J1ouJ2 = false;
                MesOutils.AfficherTableau(tableauDe, J1ouJ2);
                
                MesOutils.Points(ref NbrePointJ1, ref NbrePointJ2, Joueur1, Joueur2, tableauDe);
                
                Console.WriteLine($"\nScore Joueur 1: \n  {NbrePointJ1}");
                Console.WriteLine($"Score Joueur 2: \n  {NbrePointJ2}");
                Console.ReadLine();
                Console.Clear();
            }
            if (NbrePointJ1 >= 5000)
            {
                Console.WriteLine("Le jeu est fini, félicitation au joueur N°1");
            }
            if (NbrePointJ2 >= 5000)
            {
                Console.WriteLine("Le jeu est fini, félicitation au joueur N°2");
            }
            Console.ReadLine();
        }
    }
}