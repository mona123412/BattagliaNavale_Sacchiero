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

        public event EventHandler<EventoScelta> scelta_EventHandler;

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
            EventoScelta scelta = new EventoScelta(cmb_scelta.SelectedIndex);
            scelta_EventHandler.Invoke(this, scelta); // lancia l'evento con la scelta fatta

            this.Close(); // chiude la finestra di scelta
        }
    }

    public class EventoScelta : EventArgs
    {
        public int SceltaFatta { get; set; }
        public EventoScelta(int scelta)
        {
            SceltaFatta = scelta;
        }
    }
}
