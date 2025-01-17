namespace RozliczenieApp
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.introlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(348, 277);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(119, 51);
            this.btnCreateAcc.TabIndex = 2;
            this.btnCreateAcc.Text = "Załóż konto!";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // introlabel
            // 
            this.introlabel.AutoSize = true;
            this.introlabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.introlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.introlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introlabel.ForeColor = System.Drawing.Color.Black;
            this.introlabel.Location = new System.Drawing.Point(75, 0);
            this.introlabel.Name = "introlabel";
            this.introlabel.Size = new System.Drawing.Size(663, 100);
            this.introlabel.TabIndex = 3;
            this.introlabel.Text = "Witaj w RozliczenieApp!\r\nAplikacja służy do zarządzania kursami, monitorowania\r\nd" +
    "anych kierowców oraz obliczania dziennych i miesięcznych wypłat.\r\n\r\n";
            this.introlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.introlabel);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Label introlabel;
    }
}