using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ChaisesMusicales2
{
    public class StagiaireRoom : Collection<Stagiaire>, IEnumerable<Stagiaire>
    {
        public List<Stagiaire> StagiaireSalle;

        public StagiaireRoom()
        {
            List<Stagiaire> StagiaireSalle = new List<Stagiaire>();

        }

        public StagiaireRoom(int NbStagiaires)
        {
            StagiaireSalle = new List<Stagiaire>();

            while (NbStagiaires > 0)
            {
                Console.Write("\n"+NbStagiaires);
                this.Add(new Stagiaire());
                NbStagiaires--;
            }
        }

        new public int Count
        {
            get
            {
                int Val = 0;

                try
                {
                    Val = StagiaireSalle.Count();

                }

                catch (System.ArgumentNullException)
                {
                    Val = 0;
                }

                return Val;





                ;
            }
        }

        public bool AuBout(Stagiaire StagiaireCourant)
        {
            return (StagiaireCourant == this.Last());
        }

        public bool AuDebut(Stagiaire StagiaireCourant)
        {
            return (StagiaireCourant == this.First());
        }

        public Stagiaire Gauche(Stagiaire LeStagiaire)
        {
            Stagiaire StagiaireReturn = new Stagiaire();

            if (!(this.AuDebut(LeStagiaire)))
            {
               StagiaireReturn = this.ElementAt(this.IndexOf(LeStagiaire) - 1);
                            }      
            return StagiaireReturn;
        }

        public Stagiaire Droite(Stagiaire LeStagiaire)
        {
            Stagiaire StagiaireReturn = new Stagiaire();

            if (!(this.AuBout(LeStagiaire)))
            {
                StagiaireReturn = this.ElementAt(this.IndexOf(LeStagiaire) + 1);
            }
            return StagiaireReturn;
        }


        //new public bool Contains(Stagiaire LeStagiaire)
        //{
        //    foreach (Stagiaire stagiaire in this)
        //    {
        //        if (
        //            (stagiaire.Nom == LeStagiaire.Nom) &&
        //            (stagiaire.Ligne == LeStagiaire.Ligne) &&
        //            (stagiaire.Colonne == LeStagiaire.Colonne) &&
        //            (stagiaire.NewLigne == LeStagiaire.NewLigne) &&
        //            (stagiaire.NewColonne == LeStagiaire.NewColonne)
        //            )
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        }

    }

