namespace RozliczenieApp
{
    partial class SalaryForm
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
            this.btnDodajkurs = new System.Windows.Forms.Button();
            this.Kursy = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data kursu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba kursów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 244);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Liczbabox
            // 
            this.Liczbabox.Location = new System.Drawing.Point(119, 182);
            this.Liczbabox.Name = "Liczbabox";
            this.Liczbabox.Size = new System.Drawing.Size(100, 22);
            this.Liczbabox.TabIndex = 5;
            // 
            // Opisbox
            // 
            this.Opisbox.Location = new System.Drawing.Point(119, 241);
            this.Opisbox.Name = "Opisbox";
            this.Opisbox.Size = new System.Drawing.Size(100, 22);
            this.Opisbox.TabIndex = 6;
            // 
            // btnDodajkurs
            // 
            this.btnDodajkurs.Location = new System.Drawing.Point(266, 333);
            this.btnDodajkurs.Name = "btnDodajkurs";
            this.btnDodajkurs.Size = new System.Drawing.Size(155, 34);
            this.btnDodajkurs.TabIndex = 8;
            this.btnDodajkurs.Text = "Dodaj kurs";
            this.btnDodajkurs.UseVisualStyleBackColor = true;
            this.btnDodajkurs.Click += new System.EventHandler(this.btnDodajkurs_Click);
            // 
            // Kursy
            // 
            this.Kursy.FormattingEnabled = true;
            this.Kursy.ItemHeight = 16;
            this.Kursy.Location = new System.Drawing.Point(564, 78);
            this.Kursy.Name = "Kursy";
            this.Kursy.Size = new System.Drawing.Size(382, 404);
            this.Kursy.TabIndex = 9;
            this.Kursy.SelectedIndexChanged += new System.EventHandler(this.lstKursy_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 16);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "imie i naziwsko";
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(476, 31);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(36, 16);
            this.lblLicensePlate.TabIndex = 13;
            this.lblLicensePlate.Text = "nr rej";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(771, 31);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(74, 16);
            this.lblCarBrand.TabIndex = 14;
            this.lblCarBrand.Text = "marka sam";
            // 
            // SalaryForm
            // 
            this.ClientSize = new System.Drawing.Size(945, 481);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Kursy);
            this.Controls.Add(this.btnDodajkurs);
            this.Controls.Add(this.Opisbox);
            this.Controls.Add(this.Liczbabox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Wyniklbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryForm";
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
        private System.Windows.Forms.Button btnDodajkurs;
        private System.Windows.Forms.ListBox Kursy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblCarBrand;
    }
}

