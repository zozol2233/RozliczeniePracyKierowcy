namespace RozliczenieApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Wyniklbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Liczbabox = new System.Windows.Forms.TextBox();
            this.Opisbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajkurs = new System.Windows.Forms.Button();
            this.lstKursy = new System.Windows.Forms.ListBox();
            this.txtKwota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data kursu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba kursów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis kursów";
            // 
            // Wyniklbl
            // 
            this.Wyniklbl.AutoSize = true;
            this.Wyniklbl.Location = new System.Drawing.Point(438, 351);
            this.Wyniklbl.Name = "Wyniklbl";
            this.Wyniklbl.Size = new System.Drawing.Size(0, 16);
            this.Wyniklbl.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Liczbabox
            // 
            this.Liczbabox.Location = new System.Drawing.Point(426, 101);
            this.Liczbabox.Name = "Liczbabox";
            this.Liczbabox.Size = new System.Drawing.Size(100, 22);
            this.Liczbabox.TabIndex = 5;
            // 
            // Opisbox
            // 
            this.Opisbox.Location = new System.Drawing.Point(701, 101);
            this.Opisbox.Name = "Opisbox";
            this.Opisbox.Size = new System.Drawing.Size(100, 22);
            this.Opisbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDodajkurs
            // 
            this.btnDodajkurs.Location = new System.Drawing.Point(391, 273);
            this.btnDodajkurs.Name = "btnDodajkurs";
            this.btnDodajkurs.Size = new System.Drawing.Size(155, 34);
            this.btnDodajkurs.TabIndex = 8;
            this.btnDodajkurs.Text = "Dodaj kurs";
            this.btnDodajkurs.UseVisualStyleBackColor = true;
            this.btnDodajkurs.Click += new System.EventHandler(this.btnDodajkurs_Click);
            // 
            // lstKursy
            // 
            this.lstKursy.FormattingEnabled = true;
            this.lstKursy.ItemHeight = 16;
            this.lstKursy.Location = new System.Drawing.Point(569, 158);
            this.lstKursy.Name = "lstKursy";
            this.lstKursy.Size = new System.Drawing.Size(377, 324);
            this.lstKursy.TabIndex = 9;
            this.lstKursy.SelectedIndexChanged += new System.EventHandler(this.lstKursy_SelectedIndexChanged);
            // 
            // txtKwota
            // 
            this.txtKwota.Location = new System.Drawing.Point(75, 335);
            this.txtKwota.Name = "txtKwota";
            this.txtKwota.Size = new System.Drawing.Size(100, 22);
            this.txtKwota.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kwota";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(945, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKwota);
            this.Controls.Add(this.lstKursy);
            this.Controls.Add(this.btnDodajkurs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Opisbox);
            this.Controls.Add(this.Liczbabox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Wyniklbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Wyniklbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Liczbabox;
        private System.Windows.Forms.TextBox Opisbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodajkurs;
        private System.Windows.Forms.ListBox lstKursy;
        private System.Windows.Forms.TextBox txtKwota;
        private System.Windows.Forms.Label label4;
    }
}

