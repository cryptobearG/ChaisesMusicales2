using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales2
{

    class Program
    {
        static void Main(string[] args)
        {
            StagiaireRoom NewDTARoom = new StagiaireRoom(10);

            foreach (Stagiaire stagiaire in Donnees.DTAtempRoom)
            {
                while (Donnees.DTAtempRoom.Contains(stagiaire))
                {

                    Stagiaire Position = StaticChaises.RandomPosition(stagiaire, Donnees.ListePositions);

                    if (stagiaire.IsValidStagiaire())
                    {
                        int position = StaticChaises.PositionInsertion(stagiaire);
                        NewDTARoom[position] = stagiaire;

                        if ((NewDTARoom.Gauche(stagiaire) != Donnees.DTARoom.Gauche(stagiaire)) && (NewDTARoom.Droite(stagiaire) != Donnees.DTARoom.Droite(stagiaire)))
                        {
                            //Donnees.ListePositions.RemoveAt(StaticChaises.PositionDonner(Donnees.ListePositions, Position));
                            Donnees.ListePositions.Remove(Position);
                            //Donnees.DTAtempRoom.Remove(stagiaire);
                            break;


                        }

                        else
                        {
                            NewDTARoom.Remove(stagiaire);
                        }



                    }
                }

            }

            foreach (Stagiaire stagiaire in NewDTARoom) { stagiaire.Affiche(); }
            Console.ReadKey();
        }
    }
}

            
        

        
    
