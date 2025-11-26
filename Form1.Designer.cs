namespace BattagliaNavale_Sacchiero
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_lunghezza = new System.Windows.Forms.ComboBox();
            this.cmb_direzione = new System.Windows.Forms.ComboBox();
            this.lbl_titoloTipoNave = new System.Windows.Forms.Label();
            this.lbl_direzione = new System.Windows.Forms.Label();
            this.dtg_battaglia = new System.Windows.Forms.DataGridView();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_tentativi = new System.Windows.Forms.Label();
            this.lbl_titoloPunteggio = new System.Windows.Forms.Label();
            this.lbl_naviRimanenti = new System.Windows.Forms.Label();
            this.lbl_naviRimanentiTitolo = new System.Windows.Forms.Label();
            this.lbl_naviAffondate = new System.Windows.Forms.Label();
            this.lbl_naviAffondateTitolo = new System.Windows.Forms.Label();
            this.pnl_secondaFase = new System.Windows.Forms.Panel();
            this.pnl_primaFase = new System.Windows.Forms.Panel();
            this.lst_Log = new System.Windows.Forms.ListBox();
            this.lbl_messaggioVittoria = new System.Windows.Forms.Label();
            this.pnl_secondaFase2 = new System.Windows.Forms.Panel();
            this.lst_log2 = new System.Windows.Forms.ListBox();
            this.lbl_titoloTentativi2 = new System.Windows.Forms.Label();
            this.lbl_naviRimanenti2 = new System.Windows.Forms.Label();
            this.lbl_tentativi2 = new System.Windows.Forms.Label();
            this.lbl_titoloNaviRimanenti2 = new System.Windows.Forms.Label();
            this.lbl_titolonaviAffondate2 = new System.Windows.Forms.Label();
            this.lbl_naviAffondate2 = new System.Windows.Forms.Label();
            this.dtg_campo2 = new System.Windows.Forms.DataGridView();
            this.lbl_vittoria2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_battaglia)).BeginInit();
            this.pnl_secondaFase.SuspendLayout();
            this.pnl_primaFase.SuspendLayout();
            this.pnl_secondaFase2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_campo2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_lunghezza
            // 
            this.cmb_lunghezza.FormattingEnabled = true;
            this.cmb_lunghezza.Location = new System.Drawing.Point(6, 27);
            this.cmb_lunghezza.Name = "cmb_lunghezza";
            this.cmb_lunghezza.Size = new System.Drawing.Size(121, 21);
            this.cmb_lunghezza.TabIndex = 1;
            // 
            // cmb_direzione
            // 
            this.cmb_direzione.FormattingEnabled = true;
            this.cmb_direzione.Location = new System.Drawing.Point(6, 85);
            this.cmb_direzione.Name = "cmb_direzione";
            this.cmb_direzione.Size = new System.Drawing.Size(121, 21);
            this.cmb_direzione.TabIndex = 2;
            // 
            // lbl_titoloTipoNave
            // 
            this.lbl_titoloTipoNave.AutoSize = true;
            this.lbl_titoloTipoNave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloTipoNave.Location = new System.Drawing.Point(2, 0);
            this.lbl_titoloTipoNave.Name = "lbl_titoloTipoNave";
            this.lbl_titoloTipoNave.Size = new System.Drawing.Size(225, 24);
            this.lbl_titoloTipoNave.TabIndex = 3;
            this.lbl_titoloTipoNave.Text = "scegliere lunghezza nave";
            // 
            // lbl_direzione
            // 
            this.lbl_direzione.AutoSize = true;
            this.lbl_direzione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direzione.Location = new System.Drawing.Point(2, 58);
            this.lbl_direzione.Name = "lbl_direzione";
            this.lbl_direzione.Size = new System.Drawing.Size(189, 24);
            this.lbl_direzione.TabIndex = 4;
            this.lbl_direzione.Text = "scegliere la direzione";
            // 
            // dtg_battaglia
            // 
            this.dtg_battaglia.AllowUserToAddRows = false;
            this.dtg_battaglia.AllowUserToDeleteRows = false;
            this.dtg_battaglia.AllowUserToResizeColumns = false;
            this.dtg_battaglia.AllowUserToResizeRows = false;
            this.dtg_battaglia.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtg_battaglia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_battaglia.Location = new System.Drawing.Point(12, 54);
            this.dtg_battaglia.MultiSelect = false;
            this.dtg_battaglia.Name = "dtg_battaglia";
            this.dtg_battaglia.Size = new System.Drawing.Size(405, 375);
            this.dtg_battaglia.TabIndex = 5;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(250, 10);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(301, 25);
            this.lbl_titolo.TabIndex = 6;
            this.lbl_titolo.Text = "Gioca a Battaglia Navale !!!";
            // 
            // lbl_tentativi
            // 
            this.lbl_tentativi.AutoSize = true;
            this.lbl_tentativi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentativi.Location = new System.Drawing.Point(171, 0);
            this.lbl_tentativi.Name = "lbl_tentativi";
            this.lbl_tentativi.Size = new System.Drawing.Size(24, 25);
            this.lbl_tentativi.TabIndex = 8;
            this.lbl_tentativi.Text = "0";
            // 
            // lbl_titoloPunteggio
            // 
            this.lbl_titoloPunteggio.AutoSize = true;
            this.lbl_titoloPunteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloPunteggio.Location = new System.Drawing.Point(67, 0);
            this.lbl_titoloPunteggio.Name = "lbl_titoloPunteggio";
            this.lbl_titoloPunteggio.Size = new System.Drawing.Size(100, 25);
            this.lbl_titoloPunteggio.TabIndex = 7;
            this.lbl_titoloPunteggio.Text = "Tentativi:";
            // 
            // lbl_naviRimanenti
            // 
            this.lbl_naviRimanenti.AutoSize = true;
            this.lbl_naviRimanenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviRimanenti.Location = new System.Drawing.Point(170, 74);
            this.lbl_naviRimanenti.Name = "lbl_naviRimanenti";
            this.lbl_naviRimanenti.Size = new System.Drawing.Size(24, 25);
            this.lbl_naviRimanenti.TabIndex = 15;
            this.lbl_naviRimanenti.Text = "6";
            // 
            // lbl_naviRimanentiTitolo
            // 
            this.lbl_naviRimanentiTitolo.AutoSize = true;
            this.lbl_naviRimanentiTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviRimanentiTitolo.Location = new System.Drawing.Point(10, 74);
            this.lbl_naviRimanentiTitolo.Name = "lbl_naviRimanentiTitolo";
            this.lbl_naviRimanentiTitolo.Size = new System.Drawing.Size(155, 25);
            this.lbl_naviRimanentiTitolo.TabIndex = 14;
            this.lbl_naviRimanentiTitolo.Text = "Navi rimanenti:";
            // 
            // lbl_naviAffondate
            // 
            this.lbl_naviAffondate.AutoSize = true;
            this.lbl_naviAffondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviAffondate.Location = new System.Drawing.Point(170, 34);
            this.lbl_naviAffondate.Name = "lbl_naviAffondate";
            this.lbl_naviAffondate.Size = new System.Drawing.Size(24, 25);
            this.lbl_naviAffondate.TabIndex = 13;
            this.lbl_naviAffondate.Text = "0";
            // 
            // lbl_naviAffondateTitolo
            // 
            this.lbl_naviAffondateTitolo.AutoSize = true;
            this.lbl_naviAffondateTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviAffondateTitolo.Location = new System.Drawing.Point(10, 34);
            this.lbl_naviAffondateTitolo.Name = "lbl_naviAffondateTitolo";
            this.lbl_naviAffondateTitolo.Size = new System.Drawing.Size(157, 25);
            this.lbl_naviAffondateTitolo.TabIndex = 12;
            this.lbl_naviAffondateTitolo.Text = "Navi affondate:";
            // 
            // pnl_secondaFase
            // 
            this.pnl_secondaFase.Controls.Add(this.lst_Log);
            this.pnl_secondaFase.Controls.Add(this.lbl_titoloPunteggio);
            this.pnl_secondaFase.Controls.Add(this.lbl_naviRimanenti);
            this.pnl_secondaFase.Controls.Add(this.lbl_tentativi);
            this.pnl_secondaFase.Controls.Add(this.lbl_naviRimanentiTitolo);
            this.pnl_secondaFase.Controls.Add(this.lbl_naviAffondateTitolo);
            this.pnl_secondaFase.Controls.Add(this.lbl_naviAffondate);
            this.pnl_secondaFase.Location = new System.Drawing.Point(450, 54);
            this.pnl_secondaFase.Name = "pnl_secondaFase";
            this.pnl_secondaFase.Size = new System.Drawing.Size(263, 359);
            this.pnl_secondaFase.TabIndex = 16;
            // 
            // pnl_primaFase
            // 
            this.pnl_primaFase.Controls.Add(this.lbl_titoloTipoNave);
            this.pnl_primaFase.Controls.Add(this.cmb_lunghezza);
            this.pnl_primaFase.Controls.Add(this.cmb_direzione);
            this.pnl_primaFase.Controls.Add(this.lbl_direzione);
            this.pnl_primaFase.Location = new System.Drawing.Point(436, 38);
            this.pnl_primaFase.Name = "pnl_primaFase";
            this.pnl_primaFase.Size = new System.Drawing.Size(223, 130);
            this.pnl_primaFase.TabIndex = 17;
            // 
            // lst_Log
            // 
            this.lst_Log.FormattingEnabled = true;
            this.lst_Log.Location = new System.Drawing.Point(15, 154);
            this.lst_Log.Name = "lst_Log";
            this.lst_Log.Size = new System.Drawing.Size(233, 160);
            this.lst_Log.TabIndex = 18;
            // 
            // lbl_messaggioVittoria
            // 
            this.lbl_messaggioVittoria.AutoSize = true;
            this.lbl_messaggioVittoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messaggioVittoria.ForeColor = System.Drawing.Color.Red;
            this.lbl_messaggioVittoria.Location = new System.Drawing.Point(49, 10);
            this.lbl_messaggioVittoria.Name = "lbl_messaggioVittoria";
            this.lbl_messaggioVittoria.Size = new System.Drawing.Size(195, 31);
            this.lbl_messaggioVittoria.TabIndex = 18;
            this.lbl_messaggioVittoria.Text = "HAI VINTO !!!";
            // 
            // pnl_secondaFase2
            // 
            this.pnl_secondaFase2.Controls.Add(this.lst_log2);
            this.pnl_secondaFase2.Controls.Add(this.lbl_titoloTentativi2);
            this.pnl_secondaFase2.Controls.Add(this.lbl_naviRimanenti2);
            this.pnl_secondaFase2.Controls.Add(this.lbl_tentativi2);
            this.pnl_secondaFase2.Controls.Add(this.lbl_titoloNaviRimanenti2);
            this.pnl_secondaFase2.Controls.Add(this.lbl_titolonaviAffondate2);
            this.pnl_secondaFase2.Controls.Add(this.lbl_naviAffondate2);
            this.pnl_secondaFase2.Location = new System.Drawing.Point(450, 484);
            this.pnl_secondaFase2.Name = "pnl_secondaFase2";
            this.pnl_secondaFase2.Size = new System.Drawing.Size(263, 359);
            this.pnl_secondaFase2.TabIndex = 20;
            // 
            // lst_log2
            // 
            this.lst_log2.FormattingEnabled = true;
            this.lst_log2.Location = new System.Drawing.Point(15, 154);
            this.lst_log2.Name = "lst_log2";
            this.lst_log2.Size = new System.Drawing.Size(233, 160);
            this.lst_log2.TabIndex = 18;
            // 
            // lbl_titoloTentativi2
            // 
            this.lbl_titoloTentativi2.AutoSize = true;
            this.lbl_titoloTentativi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloTentativi2.Location = new System.Drawing.Point(67, 0);
            this.lbl_titoloTentativi2.Name = "lbl_titoloTentativi2";
            this.lbl_titoloTentativi2.Size = new System.Drawing.Size(100, 25);
            this.lbl_titoloTentativi2.TabIndex = 7;
            this.lbl_titoloTentativi2.Text = "Tentativi:";
            // 
            // lbl_naviRimanenti2
            // 
            this.lbl_naviRimanenti2.AutoSize = true;
            this.lbl_naviRimanenti2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviRimanenti2.Location = new System.Drawing.Point(170, 74);
            this.lbl_naviRimanenti2.Name = "lbl_naviRimanenti2";
            this.lbl_naviRimanenti2.Size = new System.Drawing.Size(24, 25);
            this.lbl_naviRimanenti2.TabIndex = 15;
            this.lbl_naviRimanenti2.Text = "6";
            // 
            // lbl_tentativi2
            // 
            this.lbl_tentativi2.AutoSize = true;
            this.lbl_tentativi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentativi2.Location = new System.Drawing.Point(171, 0);
            this.lbl_tentativi2.Name = "lbl_tentativi2";
            this.lbl_tentativi2.Size = new System.Drawing.Size(24, 25);
            this.lbl_tentativi2.TabIndex = 8;
            this.lbl_tentativi2.Text = "0";
            // 
            // lbl_titoloNaviRimanenti2
            // 
            this.lbl_titoloNaviRimanenti2.AutoSize = true;
            this.lbl_titoloNaviRimanenti2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloNaviRimanenti2.Location = new System.Drawing.Point(10, 74);
            this.lbl_titoloNaviRimanenti2.Name = "lbl_titoloNaviRimanenti2";
            this.lbl_titoloNaviRimanenti2.Size = new System.Drawing.Size(155, 25);
            this.lbl_titoloNaviRimanenti2.TabIndex = 14;
            this.lbl_titoloNaviRimanenti2.Text = "Navi rimanenti:";
            // 
            // lbl_titolonaviAffondate2
            // 
            this.lbl_titolonaviAffondate2.AutoSize = true;
            this.lbl_titolonaviAffondate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolonaviAffondate2.Location = new System.Drawing.Point(10, 34);
            this.lbl_titolonaviAffondate2.Name = "lbl_titolonaviAffondate2";
            this.lbl_titolonaviAffondate2.Size = new System.Drawing.Size(157, 25);
            this.lbl_titolonaviAffondate2.TabIndex = 12;
            this.lbl_titolonaviAffondate2.Text = "Navi affondate:";
            // 
            // lbl_naviAffondate2
            // 
            this.lbl_naviAffondate2.AutoSize = true;
            this.lbl_naviAffondate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naviAffondate2.Location = new System.Drawing.Point(170, 34);
            this.lbl_naviAffondate2.Name = "lbl_naviAffondate2";
            this.lbl_naviAffondate2.Size = new System.Drawing.Size(24, 25);
            this.lbl_naviAffondate2.TabIndex = 13;
            this.lbl_naviAffondate2.Text = "0";
            // 
            // dtg_campo2
            // 
            this.dtg_campo2.AllowUserToAddRows = false;
            this.dtg_campo2.AllowUserToDeleteRows = false;
            this.dtg_campo2.AllowUserToResizeColumns = false;
            this.dtg_campo2.AllowUserToResizeRows = false;
            this.dtg_campo2.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtg_campo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_campo2.Location = new System.Drawing.Point(12, 484);
            this.dtg_campo2.MultiSelect = false;
            this.dtg_campo2.Name = "dtg_campo2";
            this.dtg_campo2.Size = new System.Drawing.Size(405, 375);
            this.dtg_campo2.TabIndex = 19;
            this.dtg_campo2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_campo2_CellContentClick);
            // 
            // lbl_vittoria2
            // 
            this.lbl_vittoria2.AutoSize = true;
            this.lbl_vittoria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vittoria2.ForeColor = System.Drawing.Color.Red;
            this.lbl_vittoria2.Location = new System.Drawing.Point(49, 450);
            this.lbl_vittoria2.Name = "lbl_vittoria2";
            this.lbl_vittoria2.Size = new System.Drawing.Size(195, 31);
            this.lbl_vittoria2.TabIndex = 21;
            this.lbl_vittoria2.Text = "HAI VINTO !!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 871);
            this.Controls.Add(this.lbl_vittoria2);
            this.Controls.Add(this.pnl_secondaFase2);
            this.Controls.Add(this.dtg_campo2);
            this.Controls.Add(this.lbl_messaggioVittoria);
            this.Controls.Add(this.pnl_primaFase);
            this.Controls.Add(this.pnl_secondaFase);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.dtg_battaglia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_battaglia)).EndInit();
            this.pnl_secondaFase.ResumeLayout(false);
            this.pnl_secondaFase.PerformLayout();
            this.pnl_primaFase.ResumeLayout(false);
            this.pnl_primaFase.PerformLayout();
            this.pnl_secondaFase2.ResumeLayout(false);
            this.pnl_secondaFase2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_campo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_lunghezza;
        private System.Windows.Forms.ComboBox cmb_direzione;
        private System.Windows.Forms.Label lbl_titoloTipoNave;
        private System.Windows.Forms.Label lbl_direzione;
        private System.Windows.Forms.DataGridView dtg_battaglia;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_tentativi;
        private System.Windows.Forms.Label lbl_titoloPunteggio;
        private System.Windows.Forms.Label lbl_naviRimanenti;
        private System.Windows.Forms.Label lbl_naviRimanentiTitolo;
        private System.Windows.Forms.Label lbl_naviAffondate;
        private System.Windows.Forms.Label lbl_naviAffondateTitolo;
        private System.Windows.Forms.Panel pnl_secondaFase;
        private System.Windows.Forms.Panel pnl_primaFase;
        private System.Windows.Forms.ListBox lst_Log;
        private System.Windows.Forms.Label lbl_messaggioVittoria;
        private System.Windows.Forms.Panel pnl_secondaFase2;
        private System.Windows.Forms.ListBox lst_log2;
        private System.Windows.Forms.Label lbl_titoloTentativi2;
        private System.Windows.Forms.Label lbl_naviRimanenti2;
        private System.Windows.Forms.Label lbl_tentativi2;
        private System.Windows.Forms.Label lbl_titoloNaviRimanenti2;
        private System.Windows.Forms.Label lbl_titolonaviAffondate2;
        private System.Windows.Forms.Label lbl_naviAffondate2;
        private System.Windows.Forms.DataGridView dtg_campo2;
        private System.Windows.Forms.Label lbl_vittoria2;
    }
}

