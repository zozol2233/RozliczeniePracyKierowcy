namespace RozliczenieApp
{
    partial class SalaryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblZalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Wyniklbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Liczbabox = new System.Windows.Forms.TextBox();
            this.Opisbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstKursy = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblZalogowany
            this.lblZalogowany.AutoSize = true;
            this.lblZalogowany.Location = new System.Drawing.Point(20, 20);
            this.lblZalogowany.Name = "lblZalogowany";
            this.lblZalogowany.Size = new System.Drawing.Size(150, 16);
            this.lblZalogowany.TabIndex = 0;
            this.lblZalogowany.Text = "Zalogowany: brak danych";

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data kursu";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba kursów";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis kursów";

            // Wyniklbl
            this.Wyniklbl.AutoSize = true;
            this.Wyniklbl.Location = new System.Drawing.Point(438, 351);
            this.Wyniklbl.Name = "Wyniklbl";
            this.Wyniklbl.Size = new System.Drawing.Size(0, 16);
            this.Wyniklbl.TabIndex = 4;

            // dateTimePicker1
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;

            // Liczbabox
            this.Liczbabox.Location = new System.Drawing.Point(426, 101);
            this.Liczbabox.Name = "Liczbabox";
            this.Liczbabox.Size = new System.Drawing.Size(100, 22);
            this.Liczbabox.TabIndex = 6;

            // Opisbox
            this.Opisbox.Location = new System.Drawing.Point(701, 101);
            this.Opisbox.Name = "Opisbox";
            this.Opisbox.Size = new System.Drawing.Size(100, 22);
            this.Opisbox.TabIndex = 7;

            // button1
            this.button1.Location = new System.Drawing.Point(426, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);

            // lstKursy
            this.lstKursy.FormattingEnabled = true;
            this.lstKursy.ItemHeight = 16;
            this.lstKursy.Location = new System.Drawing.Point(569, 158);
            this.lstKursy.Name = "lstKursy";
            this.lstKursy.Size = new System.Drawing.Size(377, 324);
            this.lstKursy.TabIndex = 9;

            // SalaryForm
            this.ClientSize = new System.Drawing.Size(945, 481);
            this.Controls.Add(this.lblZalogowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wyniklbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Liczbabox);
            this.Controls.Add(this.Opisbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstKursy);
            this.Name = "SalaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblZalogowany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Wyniklbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Liczbabox;
        private System.Windows.Forms.TextBox Opisbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstKursy;
    }
}



