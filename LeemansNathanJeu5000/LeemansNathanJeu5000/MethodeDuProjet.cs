using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeemansNathanJeu5000
{
    public struct MethodeDuProjet
    {
        public void LancerDes(int[,] tableauDe, Random rnd, int[,] Joueur1, int[,] Joueur2)
        {
            for (int i = 0; i < tableauDe.GetLength(1); i++)
            {
                Joueur1[0,i] = rnd.Next(1, 7);
                Joueur2[0,i] = rnd.Next(1,7);
                tableauDe[0, i] = Joueur1[0,i];
                tableauDe[1, i] = Joueur2[0,i];
            }
        }
        public void AfficherTableau(int[,] tableauDe, bool J1ouJ2)
        {
            if (J1ouJ2 == true)
            {
                for (int j = 0; j < tableauDe.GetLength(1); j++)
                {
                    Console.Write(tableauDe[0, j]);
                }    
            }
            else
            {
                for (int j = 0; j < tableauDe.GetLength(1); j++)
                {
                    Console.Write(tableauDe[1, j]);
                }
            }        
            Console.WriteLine();
        }
        public void Points(ref int NbrePointJ1, ref int NbrePointJ2, int[,] Joueur1, int[,] Joueur2, int[,] tableauDe)
        {            
            if (Joueur1[0, 0] == 5 && Joueur1[0, 1] == 5 && Joueur1[0, 2] == 5 && Joueur1[0, 3] == 5 && Joueur1[0, 4] == 5)
            {
                NbrePointJ1 = NbrePointJ1 + 5000;
            }
            if (Joueur2[0, 0] == 5 && Joueur2[0, 1] == 5 && Joueur2[0, 2] == 5 && Joueur2[0, 3] == 5 && Joueur2[0, 4] == 5)
            {
                NbrePointJ2 = NbrePointJ2 + 5000;
            }
            if (Joueur1[0, 0] == 5 || Joueur1[0, 1] == 5 || Joueur1[0, 2] == 5 || Joueur1[0, 3] == 5 || Joueur1[0, 4] == 5)
            {
                NbrePointJ1 = NbrePointJ1 + 50;
            }
            if (Joueur2[0, 0] == 5 || Joueur2[0, 1] == 5 || Joueur2[0, 2] == 5 || Joueur2[0, 3] == 5 || Joueur2[0, 4] == 5)
            {
                NbrePointJ2 = NbrePointJ2 + 50;
            }
            if (Joueur1[0, 0] == 1 || Joueur1[0, 1] == 1 || Joueur1[0, 2] == 1 || Joueur1[0, 3] == 1 || Joueur1[0, 4] == 1)
            {
                NbrePointJ1 = NbrePointJ1 + 100;
            }
            if (Joueur2[0, 0] == 1 || Joueur2[0, 1] == 1 || Joueur2[0, 2] == 1 || Joueur2[0, 3] == 1 || Joueur2[0, 4] == 1)
            {
                NbrePointJ2 = NbrePointJ2 + 100;
            }
            if (Joueur2[0, 0] != 6 && Joueur2[0, 1] != 6 && Joueur2[0, 2] != 6 && Joueur2[0, 3] != 6 && Joueur2[0, 4] != 6)
            {
                if (Joueur2[0,0] != Joueur2[0,1] && Joueur2[0, 0] != Joueur2[0, 2] && Joueur2[0, 0] != Joueur2[0, 3] && Joueur2[0, 0] != Joueur2[0, 4] && Joueur2[0, 1] != Joueur2[0, 2] && Joueur2[0, 1] != Joueur2[0, 3] && Joueur2[0, 1] != Joueur2[0, 4] && Joueur2[0, 2] != Joueur2[0, 3] && Joueur2[0, 2] != Joueur2[0, 4] && Joueur2[0, 3] != Joueur2[0, 4])
                {
                    NbrePointJ2 = NbrePointJ2 + 1000;
                }
            }
            if (Joueur1[0, 0] != 6 && Joueur1[0, 1] != 6 && Joueur1[0, 2] != 6 && Joueur1[0, 3] != 6 && Joueur1[0, 4] != 6)
            {
                if (Joueur1[0, 0] != Joueur1[0, 1] && Joueur1[0, 0] != Joueur1[0, 2] && Joueur1[0, 0] != Joueur1[0, 3] && Joueur1[0, 0] != Joueur1[0, 4] && Joueur1[0, 1] != Joueur1[0, 2] && Joueur1[0, 1] != Joueur1[0, 3] && Joueur1[0, 1] != Joueur1[0, 4] && Joueur1[0, 2] != Joueur1[0, 3] && Joueur1[0, 2] != Joueur1[0, 4] && Joueur1[0, 3] != Joueur1[0, 4])
                {
                    NbrePointJ1 = NbrePointJ1 + 1000;
                }
            }
            if (Joueur2[0, 0] != 1 && Joueur2[0, 1] != 1 && Joueur2[0, 2] != 1 && Joueur2[0, 3] != 1 && Joueur2[0, 4] != 1)
            {
                if (Joueur2[0, 0] != Joueur2[0, 1] && Joueur2[0, 0] != Joueur2[0, 2] && Joueur2[0, 0] != Joueur2[0, 3] && Joueur2[0, 0] != Joueur2[0, 4] && Joueur2[0, 1] != Joueur2[0, 2] && Joueur2[0, 1] != Joueur2[0, 3] && Joueur2[0, 1] != Joueur2[0, 4] && Joueur2[0, 2] != Joueur2[0, 3] && Joueur2[0, 2] != Joueur2[0, 4] && Joueur2[0, 3] != Joueur2[0, 4])
                {
                    NbrePointJ2 = NbrePointJ2 + 1000;
                }
            }
            if (Joueur1[0, 0] != 1 && Joueur1[0, 1] != 1 && Joueur1[0, 2] != 1 && Joueur1[0, 3] != 1 && Joueur1[0, 4] != 1)
            {
                if (Joueur1[0, 0] != Joueur1[0, 1] && Joueur1[0, 0] != Joueur1[0, 2] && Joueur1[0, 0] != Joueur1[0, 3] && Joueur1[0, 0] != Joueur1[0, 4] && Joueur1[0, 1] != Joueur1[0, 2] && Joueur1[0, 1] != Joueur1[0, 3] && Joueur1[0, 1] != Joueur1[0, 4] && Joueur1[0, 2] != Joueur1[0, 3] && Joueur1[0, 2] != Joueur1[0, 4] && Joueur1[0, 3] != Joueur1[0, 4])
                {
                    NbrePointJ1 = NbrePointJ1 + 1000;
                }
            }
            if (Joueur1[0,0] == Joueur1[0,1] && Joueur1[0,2] == Joueur1[0,1] || Joueur1[0, 2] == Joueur1[0, 3] && Joueur1[0, 3] == Joueur1[0, 4] || Joueur1[0, 1] == Joueur1[0, 2] && Joueur1[0, 2] == Joueur1[0, 3])
            {
                NbrePointJ1 = NbrePointJ1 + 400;
            }
            if (Joueur2[0, 0] == Joueur2[0, 1] && Joueur2[0, 2] == Joueur2[0, 1] || Joueur2[0, 2] == Joueur2[0, 3] && Joueur2[0, 3] == Joueur2[0, 4] || Joueur2[0, 1] == Joueur2[0, 2] && Joueur2[0, 2] == Joueur2[0, 3])
            {
                NbrePointJ2 = NbrePointJ2 + 400;
            }
            if (Joueur1[0,0] == 1 && Joueur1[0,1] == 1 && Joueur1[0, 2] == 1 || Joueur1[0, 2] == 1 && Joueur1[0, 3] == 1 && Joueur1[0, 4] == 1 || Joueur1[0, 1] == 1 && Joueur1[0, 2] == 1 && Joueur1[0, 3] == 1)
            {
                NbrePointJ1 = NbrePointJ1 + 600;
            }
            if (Joueur2[0, 0] == 1 && Joueur2[0, 1] == 1 && Joueur2[0, 2] == 1 || Joueur2[0, 2] == 1 && Joueur2[0, 3] == 1 && Joueur2[0, 4] == 1 || Joueur2[0, 1] == 1 && Joueur2[0, 2] == 1 && Joueur2[0, 3] == 1)
            {
                NbrePointJ2 = NbrePointJ2 + 600;
            }
        }
    }
}