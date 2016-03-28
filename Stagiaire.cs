using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales2
{
    public class Stagiaire 
    {
        public string Nom { get; set; }
        public int Ligne { get; set; }
        public int Colonne { get; set; }
        public int NewLigne { get; set; }
        public int NewColonne { get; set; }

        public Stagiaire()
        {
            Nom = "Inconnu";
            Ligne = 0;
            Colonne = 0;
        }

        public Stagiaire(int ligne, int colonne,string nom= "")
        {
            Nom = nom;
            Ligne = ligne;
            Colonne = colonne;
        }

        public void Affiche()
        {
            Console.Write("\n"+Nom + " " + "[" + Ligne + ","+ Colonne + "]"+ " " + "[" + NewLigne + "," + NewColonne + "]");
        }

        public bool IsValidStagiaire()
        {
          
            if ((Ligne ==0) && (Colonne > 1))
            {
                throw new Exception();
            }

            else if (Colonne > 3  || Ligne>3  )
            {
                throw new Exception();
            }
          
    

            return true;
        }

        }
    }

