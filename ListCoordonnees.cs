using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales2
{
    public class ListCoordonnees : List<int[]> 
    {

        List<int[]> listcoordonnees { get; set; }

        public ListCoordonnees()
        {
            listcoordonnees = new List<int[]>();
        }

        new public bool Contains(int[] item)
        {
            foreach( int[] coordonnees in listcoordonnees)
            {

                if ( item.LongLength == coordonnees.LongLength) 
                {
                    int Taille = (int) item.LongLength, indice=0;
                    
                    while((item.ElementAt(indice) == coordonnees.ElementAt(indice)) && (indice < Taille) )
                    {
                        indice += 1;
                    }

                    Console.Write(item.ElementAt(indice).ToString() + coordonnees.ElementAt(indice).ToString());

                    if (indice == Taille) { return true; }
                    
                }

                else
                {
                    return false;
                }

            }

            return false;

        }


    }
}
