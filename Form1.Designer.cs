namespace WA_Estrazione
{
    partial class rdn2allievi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListaStudenti = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdn1allievo = new System.Windows.Forms.RadioButton();
            this.rdn2all = new System.Windows.Forms.RadioButton();
            this.rnd3allievi = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Esclusioneallievi = new System.Windows.Forms.CheckBox();
            this.CasualeD = new System.Windows.Forms.RadioButton();
            this.Casuale = new System.Windows.Forms.RadioButton();
            this.CasualeP = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaStudenti);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(358, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allievi da interrogare";
            // 
            // ListaStudenti
            // 
            this.ListaStudenti.FormattingEnabled = true;
            this.ListaStudenti.ItemHeight = 20;
            this.ListaStudenti.Location = new System.Drawing.Point(6, 23);
            this.ListaStudenti.Name = "ListaStudenti";
            this.ListaStudenti.Size = new System.Drawing.Size(462, 84);
            this.ListaStudenti.TabIndex = 0;
            this.ListaStudenti.SelectedIndexChanged += new System.EventHandler(this.ListaStudenti_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(364, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opzioni interrogazione";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdn1allievo);
            this.groupBox3.Controls.Add(this.rdn2all);
            this.groupBox3.Controls.Add(this.rnd3allievi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(40, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 102);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quanti allievi si vogliono interrogare?";
            // 
            // rdn1allievo
            // 
            this.rdn1allievo.AutoSize = true;
            this.rdn1allievo.Location = new System.Drawing.Point(36, 41);
            this.rdn1allievo.Name = "rdn1allievo";
            this.rdn1allievo.Size = new System.Drawing.Size(76, 20);
            this.rdn1allievo.TabIndex = 0;
            this.rdn1allievo.TabStop = true;
            this.rdn1allievo.Text = "1 allievo";
            this.rdn1allievo.UseVisualStyleBackColor = true;
            this.rdn1allievo.CheckedChanged += new System.EventHandler(this.rdn1allievo_CheckedChanged);
            // 
            // rdn2all
            // 
            this.rdn2all.AutoSize = true;
            this.rdn2all.Location = new System.Drawing.Point(154, 41);
            this.rdn2all.Name = "rdn2all";
            this.rdn2all.Size = new System.Drawing.Size(71, 20);
            this.rdn2all.TabIndex = 1;
            this.rdn2all.TabStop = true;
            this.rdn2all.Text = "2 allievi";
            this.rdn2all.UseVisualStyleBackColor = true;
            this.rdn2all.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rnd3allievi
            // 
            this.rnd3allievi.AutoSize = true;
            this.rnd3allievi.Location = new System.Drawing.Point(268, 41);
            this.rnd3allievi.Name = "rnd3allievi";
            this.rnd3allievi.Size = new System.Drawing.Size(71, 20);
            this.rnd3allievi.TabIndex = 2;
            this.rnd3allievi.TabStop = true;
            this.rnd3allievi.Text = "3 allievi";
            this.rnd3allievi.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Esclusioneallievi);
            this.groupBox4.Controls.Add(this.CasualeD);
            this.groupBox4.Controls.Add(this.Casuale);
            this.groupBox4.Controls.Add(this.CasualeP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(40, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 119);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metodo di estrazione";
            // 
            // Esclusioneallievi
            // 
            this.Esclusioneallievi.AutoSize = true;
            this.Esclusioneallievi.Location = new System.Drawing.Point(138, 82);
            this.Esclusioneallievi.Name = "Esclusioneallievi";
            this.Esclusioneallievi.Size = new System.Drawing.Size(193, 20);
            this.Esclusioneallievi.TabIndex = 2;
            this.Esclusioneallievi.Text = "Escludi allievi già interrogati";
            this.Esclusioneallievi.UseVisualStyleBackColor = true;
            this.Esclusioneallievi.CheckedChanged += new System.EventHandler(this.Esclusioneallievi_CheckedChanged);
            // 
            // CasualeD
            // 
            this.CasualeD.AutoSize = true;
            this.CasualeD.Location = new System.Drawing.Point(261, 42);
            this.CasualeD.Name = "CasualeD";
            this.CasualeD.Size = new System.Drawing.Size(120, 20);
            this.CasualeD.TabIndex = 5;
            this.CasualeD.TabStop = true;
            this.CasualeD.Text = "Casuale dispari";
            this.CasualeD.UseVisualStyleBackColor = true;
            // 
            // Casuale
            // 
            this.Casuale.AutoSize = true;
            this.Casuale.Location = new System.Drawing.Point(36, 42);
            this.Casuale.Name = "Casuale";
            this.Casuale.Size = new System.Drawing.Size(76, 20);
            this.Casuale.TabIndex = 3;
            this.Casuale.TabStop = true;
            this.Casuale.Text = "Casuale";
            this.Casuale.UseVisualStyleBackColor = true;
            // 
            // CasualeP
            // 
            this.CasualeP.AutoSize = true;
            this.CasualeP.Location = new System.Drawing.Point(138, 42);
            this.CasualeP.Name = "CasualeP";
            this.CasualeP.Size = new System.Drawing.Size(102, 20);
            this.CasualeP.TabIndex = 4;
            this.CasualeP.TabStop = true;
            this.CasualeP.Text = "Casuale pari";
            this.CasualeP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(417, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancella";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(658, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Estrai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdn2allievi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "rdn2allievi";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListaStudenti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CasualeD;
        private System.Windows.Forms.RadioButton CasualeP;
        private System.Windows.Forms.RadioButton Casuale;
        private System.Windows.Forms.RadioButton rnd3allievi;
        private System.Windows.Forms.RadioButton rdn2all;
        private System.Windows.Forms.RadioButton rdn1allievo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Esclusioneallievi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

