using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales2
{
    public class Donnees
    {
        public static List<Stagiaire> ListePositions = new List<Stagiaire>() {
                new Stagiaire(0,0), new Stagiaire(0,1),
                new Stagiaire(1,0), new Stagiaire(1,1),new Stagiaire(1,2),new Stagiaire(1,3),
                new Stagiaire(2,0),new Stagiaire(2,1),new Stagiaire(2,2),new Stagiaire(2,3)
            };

        public static StagiaireRoom DTARoom = new StagiaireRoom() { new Stagiaire(0,0,"Gabriel"), new Stagiaire(0,1,"Gregory"),
                new Stagiaire(1,0,"Armel"), new Stagiaire(1,1,"Antoine"),new Stagiaire(1,2,"Thomas"),new Stagiaire(1,3,"Cyril"),
                new Stagiaire(2,0,"Kévin"),new Stagiaire(2,1,"Jeremy"),new Stagiaire(2,2,"Julien"),new Stagiaire(2,3,"Elian") };

        public static StagiaireRoom DTAtempRoom = DTARoom;
        
    }
}
