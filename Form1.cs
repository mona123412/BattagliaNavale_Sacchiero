using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BattagliaNavale_Sacchiero.Form1;

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
    public partial class Form1 : Form
    {
        public static event EventHandler<EventColpitoArg> colpito_EventHandler;

        Random rand = new Random(Environment.TickCount);

        public delegate bool OperzaioneSuCelle(int xIn, int yIn);

        public List<int> mosseEffettuate = new List<int>(); // di base è 0, nella fase di gioco va incrementato ad ogni mossa effettuata
        public List<int> naviNonAffondate = new List<int>(); // di base è 0, nella fase di posizionamento va incrementato ad ogni nave posizionata e nella fase di gioco va decrementato ad ogni nave affondata
        public int faseDiGioco; // 0 = posizionamento, 1 = gioco, -1 = partita finita

        // rappresenta il campo di gioco, 0 = acqua, 1 = nave, -1 = colpito
        public List<int[,]> campo = new List<int[,]>(); // lista dei campi avversari (per modalità 1v1 2 campi o vs computer)

        public int modalita;

        public int campoAttivo = 0; // 0 = primo campo, 1 = secondo campo (se presente)

        public List<int[]> naviRimaste = new List<int[]>(); // navi rimaste da posizionare: 1 nave da 4 celle, 2 navi da 3 celle, 2 navi da 2 celle, 1 nave da 1 cella

        List<List<Cnave>> navi = new List<List<Cnave>>();
        public Form1()
        {
            InitializeComponent();

            dtg_battaglia.CellContentClick += dtg_battaglia_CellContentClick;
            dtg_campo2.CellContentClick += dtg_campo2_CellContentClick;

            Inizio();
        }

        public void Inizio()
        {
            PrendeScelta();

            Crea1CampoDiGioco(dtg_battaglia);

            PreparaComboBox();

            pnl_primaFase.Visible = true;
            pnl_secondaFase.Visible = false;

            lbl_messaggioVittoria.Visible = false;
            lbl_vittoria2.Visible = false;

            // da dimensioni iniziali al form (800; 490)
            this.Size = new Size(800, 490);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool Libero(int xIn, int yIn)
        {
            if (campo[campoAttivo][xIn, yIn] != 0)
            {
                return false; // occupato
            }
            return true; // libero
        }

        public bool Colpisci(int xIn, int yIn)
        {

            if (campo[campoAttivo][xIn, yIn] == 1)
            {
                EffettuaMossa(xIn, yIn, dtg_battaglia, lst_Log, lbl_tentativi, lbl_naviAffondate, lbl_naviRimanenti);
                return true; // trovato
            }
            return false; // non trovato
        }


        public void PrendeScelta()
        {
            Fscelta finestra = new Fscelta();
            if(finestra.ShowDialog() == DialogResult.OK)
            {
                finestra_scelta(finestra.SceltaFatta);
            }
            else
            {
                MessageBox.Show("Nessuna modalità selezionata, il programma verrà chiuso.");
                this.Close();
            }
        }

        private void finestra_scelta(int SceltaFatta)
        {
            modalita = SceltaFatta; ;
            // gestisce la scelta fatta nella finestra di scelta modalità
            switch (modalita)
            {
                case 0: // 1v1 - 1 campo
                    campoAttivo = 0;

                    aggiunge();

                    break;
                case 1: // 1v1 - 2 campi
                    campoAttivo = 0;
                    aggiunge();
                    aggiunge();
                    break;
                case 2: // vs Computer
                    campoAttivo = 0;

                    aggiunge();
                    break;
                default:
                    MessageBox.Show("Scelta modalità non valida!");
                    this.Close();
                    break;
            }
        }

        public void aggiunge()
        {
            mosseEffettuate.Add(0);

            naviNonAffondate.Add(0);

            naviRimaste.Add(new int[] { 1, 2, 2, 1 }); // 1 nave da 4 celle, 2 navi da 3 celle, 2 navi da 2 celle, 1 nave da 1 cella

            campo.Add(new int[10, 10]); // aggiunge un campo avversario vuoto

            navi.Add(new List<Cnave>()); // aggiunge la lista delle navi del primo giocatore
        }

        private void dtg_battaglia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            int colonna = e.ColumnIndex;


            if (faseDiGioco == 0)
            {
                PosizionaNave(colonna, riga);
            }
            else if (faseDiGioco == 1 && campoAttivo == 0)
            {
                EffettuaMossa(colonna, riga, dtg_battaglia, lst_Log, lbl_tentativi, lbl_naviAffondate, lbl_naviRimanenti);
                if (modalita == 1) // se è 1v1 - 2 campi
                {
                    campoAttivo = 1; // passa al secondo campo
                }
            }
        }

        public void Crea1CampoDiGioco(DataGridView dtg_battagliaIn)
        {
            // pulisce il dtg
            dtg_battagliaIn.Columns.Clear();
            dtg_battagliaIn.Rows.Clear();

            // creazione colonne
            for (int i = 0; i < 10; i++)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = $"{(char)(i + 65)}"; // scrive le lettere dell'asse x
                btnColumn.Width = 35;
                btnColumn.FlatStyle = FlatStyle.Flat; // per un bottone più personalizzabile

                btnColumn.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

                dtg_battagliaIn.Columns.Add(btnColumn);
            }

            // creazione righe
            for (int i = 0; i < 10; i++)
            {
                dtg_battagliaIn.Rows.Add();
                dtg_battagliaIn.Rows[i].Height = 35;

                // da ad ogni cella il colore e il tag 0 che indica l'acqua
                for (int j = 0; j < 10; j++)
                {
                    dtg_battagliaIn.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                }
            }

            dtg_battagliaIn.RowHeadersWidth = 50; // permette di vedere i numeri della prima colonna

            // non permette all'utente di uscire dagli schemi
            dtg_battagliaIn.AllowUserToAddRows = false;
            dtg_battagliaIn.AllowUserToResizeColumns = false;
            dtg_battagliaIn.AllowUserToResizeRows = false;

            // permette di selezionare solo una cella alla volta
            dtg_battagliaIn.MultiSelect = false;

            // permette di selezionare solo la cella e non la riga o la colonna intera
            dtg_battagliaIn.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        public void PreparaComboBox()
        {

            // aggiunge gli elementi alla cmb_lunghezza (4 celle, 3 celle, 2 celle, 1 cella)
            cmb_lunghezza.Items.Add("1 cella");
            cmb_lunghezza.Items.Add("2 celle");
            cmb_lunghezza.Items.Add("3 celle");
            cmb_lunghezza.Items.Add("4 celle");
           

            cmb_lunghezza.SelectedIndex = 0; // seleziona il primo elemento di default

            // aggiunge gli elementi alla cmb_direzione (su, giu, destra, sinistra)

            cmb_direzione.Items.Add("su");
            cmb_direzione.Items.Add("giu");
            cmb_direzione.Items.Add("destra");
            cmb_direzione.Items.Add("sinistra");

            cmb_direzione.SelectedIndex = 0; // seleziona il primo elemento di default

            // non permette di scrivere nella combobox
            cmb_lunghezza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_direzione.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void PosizionaNave(int x, int y)
        {

            // da fare
            if (naviRimaste[campoAttivo][cmb_lunghezza.SelectedIndex] <= 0)
            {
                MessageBox.Show("Non ci sono più navi di questa lunghezza da posizionare!");
                return;
            }
            int lunghezzaNave = cmb_lunghezza.SelectedIndex + 1; // lunghezza nave in celle (1,2,3,4)
            int direzione;
            if (lunghezzaNave == 1)
            {
                direzione = -1;
            }
            else
            {
                direzione = cmb_direzione.SelectedIndex; // 0 = su, 1 = giu, 2 = destra, 3 = sinistra
            }

            int dx = direzione == 0 || direzione == 1 ? 0 : direzione == 2 ? 1 : -1;
            int dy = direzione == 2 || direzione == 3 ? 0 : direzione == 1 ? 1 : -1;

            for (int i = 0; i < lunghezzaNave; i++)
            {
                if (!(PerOgniCellaAttorno(x + (dx * i), y + (dy * i), Libero) && ContolloCellaDisponibile(x + (dx * i), y + (dy * i))))
                {
                    MessageBox.Show("Cella non disponibile per posizionamento nave!");
                    return; // esce dalla funzione se una delle celle non è disponibile
                }
            }

            for (int i = 0; i< lunghezzaNave; i++)
            {
                campo[campoAttivo][x + (dx * i), y + (dy * i)] = 1;

                // da un colore alla cella in modo che si capisca che la nave è stata aggiunta
                dtg_battaglia.Rows[y + (dy * i)].Cells[x + (dx * i)].Style.BackColor = Color.Gray;
                dtg_battaglia.Rows[y + (dy * i)].Cells[x + (dx * i)].Style.SelectionBackColor = Color.Gray;
            }

            Cnave nave= new Cnave((x, y), direzione, lunghezzaNave, campoAttivo);
            navi[campoAttivo].Add(nave);


            naviRimaste[campoAttivo][lunghezzaNave-1]--; // decrementa il numero di navi rimaste da posizionare di quella lunghezza


            naviNonAffondate[campoAttivo]++;

            if(naviNonAffondate[campoAttivo] == 6)
            {
                Crea1CampoDiGioco(dtg_battaglia);

                if(modalita == 1 && campoAttivo == 0) // se è 1v1 - 2 campi
                {
                    campoAttivo = 1; // passa al secondo campo
                } else {
                    faseDiGioco = 1;

                    if (modalita == 1) // se è 1v1 - 2 campi
                    {
                        this.Size = new Size(800, 910); // ridimensiona il form per far vedere il secondo campo

                        Crea1CampoDiGioco(dtg_campo2); // crea il secondo campo di gioco
                    }

                    pnl_primaFase.Visible = false;
                    pnl_secondaFase.Visible = true;

                    Cnave.affondato_EventHandler += Nave_affondata_EventHandler;

                    if(modalita == 2) // se è vs computer
                    {
                        // non permette più di fare mosse
                        faseDiGioco = -1;

                        MosseComputer();
                    }
                }
            }

        }

        private void Nave_affondata_EventHandler(object sender, EventArgs e)
        {
            int direzione = ((Cnave)sender).direzione;
            int lunghezza = ((Cnave)sender).lunghezza;

            int x = ((Cnave)sender).posIniziale.x;
            int y = ((Cnave)sender).posIniziale.y;

            int dx = direzione == 0 || direzione == 1 ? 0 : direzione == 2 ? 1 : -1;
            int dy = direzione == 2 || direzione == 3 ? 0 : direzione == 1 ? 1 : -1;

            DataGridView dtg_battagliaIn;
            ListBox log;
            if (campoAttivo == 0)
            {
                dtg_battagliaIn = dtg_battaglia;
                log = lst_Log;
            }
            else
            {
                dtg_battagliaIn = dtg_campo2;
                log = lst_log2;
            }


                for (int i = 0; i < lunghezza; i++)
            {
                dtg_battagliaIn.Rows[y + (dy * i)].Cells[x + (dx * i)].Value = "☠"; // mette un teschio sulla nave affondata
            }

            // scrive nel log che la nave è affondata
            log.Items.Add($"Nave di {lunghezza} celle affondata");

            naviNonAffondate[campoAttivo]--;
            if(naviNonAffondate[campoAttivo] <= 0)
            {
                if(campoAttivo == 0)
                {
                    lbl_messaggioVittoria.Visible = true;
                } else
                {
                    lbl_vittoria2.Visible = true;
                }
                // non permette più di fare mosse
                faseDiGioco = -1;

            }
        }

        public bool ContolloCellaDisponibile(int x, int y)
        {
            // controlo fuori campo
            if (x > 9 || y > 9 || x < 0 || y < 0)
            {
                return false; // fuori dal campo di gioco
            }

            // controllo cella occupata
            if (campo[campoAttivo][x,y] != 0)
            {
                return false; // cella occupata
            }

            return true;
        }

        public bool PerOgniCellaAttorno(int x, int y, OperzaioneSuCelle operazione)
        {
            int[,] offset =
            {
        {-1,-1}, {-1,0}, {-1,1},
        { 0,-1},         { 0,1},
        { 1,-1}, { 1,0}, { 1,1}
    };

            for (int i = 0; i < 8; i++)
            {
                int nx = x + offset[i, 0];
                int ny = y + offset[i, 1];

                if (nx >= 0 && nx < 10 && ny >= 0 && ny < 10)
                {
                    if (!operazione(nx, ny)) // se l'operazione ritorna false
                    {
                        return false; // smetti e ritorna false
                    }
                }
            }

            return true;
        }

        public void EffettuaMossa(int x, int y, DataGridView dtg_battagliaIn, ListBox log, Label tentativi, Label naviAff, Label naviRim)
        {

            if (campo[campoAttivo][x, y] == 1)
            {
                dtg_battagliaIn.Rows[y].Cells[x].Style.BackColor = Color.Red; // colpito
                // permette di vedere il colore rosso anche se il bottone è premuto
                dtg_battagliaIn.Rows[y].Cells[x].Style.SelectionBackColor = Color.Red;

                campo[campoAttivo][x, y] = -1; // segna la cella come colpita

                // scrive nel log "Colpito in posizione (x,y)"
                log.Items.Add($"Colpito in posizione ({(char)(x + 65)},{y + 1})");

                // lancia l'evento colpito
                colpito_EventHandler.Invoke(this, new EventColpitoArg(x, y, campoAttivo));

                mosseEffettuate[campoAttivo]++;

                if (modalita == 2) // se è vs computer
                {
                    PerOgniCellaAttorno(x, y, Colpisci);
                }
            }
            else if(campo[campoAttivo][x, y] == 0)
            {
                dtg_battagliaIn.Rows[y].Cells[x].Style.BackColor = Color.Blue; // acqua
                dtg_battagliaIn.Rows[y].Cells[x].Style.SelectionBackColor = Color.Blue;

                campo[campoAttivo][x, y] = -1; // segna la cella come colpita

                mosseEffettuate[campoAttivo]++;

                // scrive nel log "Acqua !!"
                log.Items.Add("Acqua!!");
            }

            tentativi.Text = $"{mosseEffettuate[campoAttivo]}";
            naviAff.Text = $"{6 - naviNonAffondate[campoAttivo]}";
            naviRim.Text = $"{naviNonAffondate[campoAttivo]}";
        }

        public async void MosseComputer() // funzione asincrona per permettere i ritardi tra una mossa e l'altra
        {

            while (naviNonAffondate[campoAttivo] > 0) // finché ci sono navi non affondate
            {
                int x = rand.Next(0, 10);
                int y = rand.Next(0, 10);
                if (campo[0][x, y] == -1)
                {
                    continue; // cella già colpita, ripeti il ciclo
                }
                EffettuaMossa(x, y, dtg_battaglia, lst_Log, lbl_tentativi, lbl_naviAffondate, lbl_naviRimanenti);

                await Task.Delay(500);
            }
        }

        private void dtg_campo2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            int colonna = e.ColumnIndex;

            if (faseDiGioco == 1 && campoAttivo == 1) // se è la fase di gioco e il campo attivo è il secondo
            {
                EffettuaMossa(colonna, riga, dtg_campo2, lst_log2, lbl_tentativi2, lbl_naviAffondate2, lbl_naviRimanenti2);
                campoAttivo = 0; // torna al primo campo
            }
        }
    }

    public class EventColpitoArg : EventArgs
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int idCampo { get; private set; }
        public EventColpitoArg(int x, int y, int idCampo)
        {
            this.x = x;
            this.y = y;
            this.idCampo = idCampo;
        }
    }
}
