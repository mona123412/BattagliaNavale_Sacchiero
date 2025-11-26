using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavale_Sacchiero
{

    /*
     Battaglia Navale

Scrivi un programma di battaglia navale che si svolga su una matrice di 10x10 celle e che preveda per ciascuna parte l'utilizzo della seguente flotta:
1 nave da 4 celle
2 navi da 3 celle
2 navi da 2 celle
1 nave da 1 cella.

Questa applicazione form prevede una fase di posizionamento delle navi e poi di gioco vero e proprio. Nella prima fase andiamo a fare la modalità “giocatore singolo” dove uno di voi inserisce le navi e la seconda dove l’altro prova a trovarle. Oltre alle celle del campo sul form deve esserci anche presente: un contatore per le mosse, uno per le navi non affondate e un log per registrare le informazioni. 

Individuate le classi opportune per gestire l’esercizio.

Per gestire la partita vera e propria andiamo a utilizzare gli eventi e i delegati. Quindi quando si preme una casella della griglia verrà eseguito un evento che fa due funzioni diverse in base sia presente o meno la nave:
Se c’è la nave verrà scritto in un log: “Colpito in posizione (x,y)”
Altrimenti verrà scritto “Acqua !!”





Modifiche:

1. Sarebbe bello che oltre a scrivere sul log venissero anche riprodotti dei suoni adatti alla situazione. (Esempio: colpo di cannone per il colpito e suono di sasso nell'acqua negli altri casi)

2. Si potrebbe anche fare la modalità gioca contro un amico. In cui vengono fatte le due fasi di posizionamento e poi sono presenti, nella fase di gioco, due campi in cui, in modo alterno, i giocatori si sfidano a trovare le navi.

3. Si potrebbe ipotizzare una modalità contro il computer che, randomicamente, sceglie le caselle finché non colpisce una casella di una nave a quel punto inizia a colpire le caselle adiacenti. (Da gestire con un evento diverso che fa partire una funzione di “Puntamento”)



     */

    public class Cnave
    {
        public (int x, int y) posIniziale { get; private set; }
        public int direzione { get; private set; } // 0 = su, 1 = giu, 2 = destra, 3 = sinistra, -1 = nessuna (1 cella)
        public int lunghezza { get; private set; }
        int numCelleColpite = 0;
        public int isAffondata; // 0 = no, 1 = si
        public int campoID; // ID del campo a cui appartiene la nave

        public static event EventHandler affondato_EventHandler;

        public Cnave((int x, int y) posIniziale, int direzione, int lunghezza, int campoID)
        {
            this.posIniziale = posIniziale;
            this.direzione = direzione;
            this.lunghezza = lunghezza;
            this.campoID = campoID;


            isAffondata = 0;

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
                        isAffondata = 1;
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
