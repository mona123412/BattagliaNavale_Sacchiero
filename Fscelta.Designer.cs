namespace BattagliaNavale_Sacchiero
{
    partial class Fscelta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fscelta));
            this.lbl_scelta = new System.Windows.Forms.Label();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.btn_scelta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_scelta
            // 
            this.lbl_scelta.AutoSize = true;
            this.lbl_scelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scelta.Location = new System.Drawing.Point(40, 42);
            this.lbl_scelta.Name = "lbl_scelta";
            this.lbl_scelta.Size = new System.Drawing.Size(194, 20);
            this.lbl_scelta.TabIndex = 0;
            this.lbl_scelta.Text = "scegliere modalità di gioco";
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(77, 86);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 1;
            // 
            // btn_scelta
            // 
            this.btn_scelta.Location = new System.Drawing.Point(104, 130);
            this.btn_scelta.Name = "btn_scelta";
            this.btn_scelta.Size = new System.Drawing.Size(75, 23);
            this.btn_scelta.TabIndex = 2;
            this.btn_scelta.Text = "invia";
            this.btn_scelta.UseVisualStyleBackColor = true;
            this.btn_scelta.Click += new System.EventHandler(this.btn_scelta_Click);
            // 
            // Fscelta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 165);
            this.Controls.Add(this.btn_scelta);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.lbl_scelta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fscelta";
            this.Text = "Battaglia Navale";
            this.Load += new System.EventHandler(this.Fscelta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_scelta;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.Button btn_scelta;
    }
}