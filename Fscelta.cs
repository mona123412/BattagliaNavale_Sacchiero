using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavale_Sacchiero
{
    public partial class Fscelta : Form
    {

        public int SceltaFatta { get; protected set; }

        public Fscelta()
        {
            InitializeComponent();

            Inizio();
        }

        public void Inizio()
        {
            // mette nel combo box le 3 scelte di modalità: 1v1 1 campo, 1v1 2 campi, vs computer
            cmb_scelta.Items.Add("1v1 - 1 campo");
            cmb_scelta.Items.Add("1v1 - 2 campi");
            cmb_scelta.Items.Add("vs Computer");

            cmb_scelta.SelectedIndex = 0; // seleziona di default la prima opzione

            cmb_scelta.DropDownStyle = ComboBoxStyle.DropDownList; // impedisce di scrivere nel combo box
        }

        private void Fscelta_Load(object sender, EventArgs e)
        {

        }

        private void btn_scelta_Click(object sender, EventArgs e)
        {
            SceltaFatta = cmb_scelta.SelectedIndex; // salva la scelta fatta

            this.DialogResult = DialogResult.OK; // imposta il risultato della finestra di scelta come OK

            this.Close(); // chiude la finestra di scelta
        }

        // se l'utente chiude la finestra senza fare una scelta
        private void Fscelta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) // se non è stato impostato come OK
            {
                this.DialogResult = DialogResult.Cancel; // imposta il risultato come Cancel
            }
        }
    }
}
