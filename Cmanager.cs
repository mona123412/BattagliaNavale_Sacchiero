using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaNavale_Sacchiero
{
    public abstract class Cmanager
    {

        public static bool ContolloCellaDisponibile(int x, int y, int[,] campo)
        {
            // controlo fuori campo
            if (x > 9 || y > 9 || x < 0 || y < 0)
            {
                return false; // fuori dal campo di gioco
            }

            // controllo cella occupata
            if (campo[x, y] != 0)
            {
                return false; // cella occupata
            }

            return true;
        }

        public static bool ControllaCelleAttorno(int x, int y, int[,] campo)
        {
            // array delle coordinate attorno alla cella (8 direzioni)
            int[,] offset = {
                {-1, -1}, {-1, 0}, {-1, 1},
                { 0, -1},          { 0, 1},
                { 1, -1}, { 1, 0}, { 1, 1}
            };

            for (int i = 0; i < 8; i++)
            {
                int nx = x + offset[i, 0];
                int ny = y + offset[i, 1];

                // se dentro il campo, controlla se è occupata
                if (nx >= 0 && nx < 10 && ny >= 0 && ny < 10)
                {
                    if (campo[nx, ny] != 0)
                        return false; // c'è una nave attorno
                }
            }

            return ContolloCellaDisponibile(x, y, campo); // nessuna nave attorno
        }
    }
}
