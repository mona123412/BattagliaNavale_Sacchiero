using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavale_Sacchiero
{
    public class Cnave
    {
        public (int x, int y) posIniziale { get; private set; }
        public int direzione { get; private set; } // 0 = su, 1 = giu, 2 = destra, 3 = sinistra, -1 = nessuna (1 cella)
        public int lunghezza { get; private set; }
        int numCelleColpite = 0;
        public int campoID; // ID del campo a cui appartiene la nave

        public static event EventHandler affondato_EventHandler;

        public Cnave((int x, int y) posIniziale, int direzione, int lunghezza, int campoID)
        {
            this.posIniziale = posIniziale;
            this.direzione = direzione;
            this.lunghezza = lunghezza;
            this.campoID = campoID;

            Form1.colpito_EventHandler += ColpitoEnvento;
        }

        public void ColpitoEnvento(object sender, EventColpitoArg e)
        {
            if(campoID == e.idCampo) // Controllo se l'evento riguarda il campo di questa nave
            {
                int x = e.x;
                int y = e.y;

                // Controllo se la nave è stata colpita
                if (ContrlloQuestaNave(x, y))
                {
                    // Aggiungo la cella colpita alla lista
                    numCelleColpite++;
                    // Controllo se la nave è affondata
                    if (numCelleColpite == lunghezza)
                    {
                        Form1.colpito_EventHandler -= ColpitoEnvento;
                        affondato_EventHandler?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }

        private bool ContrlloQuestaNave(int x, int y)
        {
            int dx = direzione == 0 || direzione == 1 ? 0 : direzione == 2 ? 1 : -1;
            int dy = direzione == 2 || direzione == 3 ? 0 : direzione == 1 ? 1 : -1;

            for (int i = 0; i < lunghezza; i++)
            {
                if (x == posIniziale.x + (dx*i) && y == posIniziale.y+(dy*i))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
