using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales2
{
    public static class StaticChaises
    {
        public static Stagiaire RandomPosition(this Stagiaire LeStagiaire, List<Stagiaire> ListePositions)
        {
            Random Rnd = new Random(System.DateTime.Now.Millisecond);
            int indice = Rnd.Next(0, ListePositions.Count());

            Console.WriteLine("La valeur est " + indice);

            Stagiaire Position = ListePositions[indice];

            if (
                Position.Ligne == LeStagiaire.Ligne || Position.Colonne == LeStagiaire.Colonne)
            {
                RandomPosition(LeStagiaire, ListePositions);
            }

            else {

                try
                {
                    if (LeStagiaire.IsValidStagiaire())
                    {

                        LeStagiaire.NewLigne = Position.Ligne;
                        LeStagiaire.NewColonne = Position.NewColonne;

                    }

                    else {
                        RandomPosition(LeStagiaire, ListePositions);
                    }
                }



                catch (Exception)
                {
                    Console.Write("Problème entrainant une exception");
                    return new Stagiaire();
                }

                


            }

            return Position;
        }

        public static bool PositionListeDispo(List<Stagiaire> ListePosition, Stagiaire LeStagiaire)
        {
            foreach (Stagiaire position in ListePosition)
            {

                if ((position.Ligne == LeStagiaire.NewLigne) && (position.Colonne == LeStagiaire.NewColonne))
                {
                    return true;
                }

            }

            return false;
        }

        public static int PositionDonner(List<Stagiaire> ListePosition, Stagiaire LeStagiaire)
        {
            foreach (Stagiaire position in ListePosition)
            {

                if ((position.Ligne == LeStagiaire.Ligne) && (position.Colonne == LeStagiaire.Colonne))
                {
                    return ListePosition.IndexOf(position);
                }

            }

            return -1;
        }

        public static int PositionInsertion(this Stagiaire MonStagiaire)
        {
            if((MonStagiaire.NewLigne == 0) && (MonStagiaire.NewColonne == 0)) { return 0; }
            if ((MonStagiaire.NewLigne == 0) && (MonStagiaire.NewColonne == 1)) { return 1; }
            if ((MonStagiaire.NewLigne == 1) && (MonStagiaire.NewColonne == 0)) { return 2; }
            if ((MonStagiaire.NewLigne == 1) && (MonStagiaire.NewColonne == 1)) { return 3; }
            if ((MonStagiaire.NewLigne == 1) && (MonStagiaire.NewColonne == 2)) { return 4; }
            if ((MonStagiaire.NewLigne == 1) && (MonStagiaire.NewColonne == 3)) { return 5; }
            if ((MonStagiaire.NewLigne == 2) && (MonStagiaire.NewColonne == 0)) { return 6; }
            if ((MonStagiaire.NewLigne == 2) && (MonStagiaire.NewColonne == 1)) { return 7; }
            if ((MonStagiaire.NewLigne == 2) && (MonStagiaire.NewColonne == 2)) { return 8; }
            if ((MonStagiaire.NewLigne == 2) && (MonStagiaire.NewColonne == 3)) { return 9; }


            //throw new Exception();
            return 20;
        }


    }
}
