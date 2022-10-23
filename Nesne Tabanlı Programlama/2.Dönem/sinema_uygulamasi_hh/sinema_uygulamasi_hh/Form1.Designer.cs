
namespace sinema_uygulamasi_hh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hizliveofkeli = new System.Windows.Forms.PictureBox();
            this.whoamı = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hizliveofkeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoamı)).BeginInit();
            this.SuspendLayout();
            // 
            // hizliveofkeli
            // 
            this.hizliveofkeli.Image = ((System.Drawing.Image)(resources.GetObject("hizliveofkeli.Image")));
            this.hizliveofkeli.Location = new System.Drawing.Point(46, 47);
            this.hizliveofkeli.Name = "hizliveofkeli";
            this.hizliveofkeli.Size = new System.Drawing.Size(214, 266);
            this.hizliveofkeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hizliveofkeli.TabIndex = 0;
            this.hizliveofkeli.TabStop = false;
            this.hizliveofkeli.Click += new System.EventHandler(this._filmsec);
            // 
            // whoamı
            // 
            this.whoamı.Image = ((System.Drawing.Image)(resources.GetObject("whoamı.Image")));
            this.whoamı.Location = new System.Drawing.Point(430, 47);
            this.whoamı.Name = "whoamı";
            this.whoamı.Size = new System.Drawing.Size(214, 266);
            this.whoamı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whoamı.TabIndex = 1;
            this.whoamı.TabStop = false;
            this.whoamı.Click += new System.EventHandler(this._filmsec);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "HRP SİNEMA SALONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(205, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Seçmek İçin Lütfen Gireceğiniz Filme Tıklayın";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(695, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whoamı);
            this.Controls.Add(this.hizliveofkeli);
            this.Name = "Form1";
            this.Text = "HRP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hizliveofkeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoamı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hizliveofkeli;
        private System.Windows.Forms.PictureBox whoamı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

