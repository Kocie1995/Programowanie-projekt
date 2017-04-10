namespace Projekt
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Poziomy = new System.Windows.Forms.ListBox();
            this.Start_butt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pomoc = new System.Windows.Forms.Button();
            this.Ranking = new System.Windows.Forms.Button();
            this.Exit_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poziom Trudnosci";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Poziomy
            // 
            this.Poziomy.FormattingEnabled = true;
            this.Poziomy.Items.AddRange(new object[] {
            "Latwy",
            "Sredni",
            "Trudny"});
            this.Poziomy.Location = new System.Drawing.Point(138, 73);
            this.Poziomy.Name = "Poziomy";
            this.Poziomy.Size = new System.Drawing.Size(46, 43);
            this.Poziomy.TabIndex = 3;
            this.Poziomy.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Start_butt
            // 
            this.Start_butt.Location = new System.Drawing.Point(31, 122);
            this.Start_butt.Name = "Start_butt";
            this.Start_butt.Size = new System.Drawing.Size(153, 23);
            this.Start_butt.TabIndex = 4;
            this.Start_butt.Text = "Start";
            this.Start_butt.UseVisualStyleBackColor = true;
            this.Start_butt.Click += new System.EventHandler(this.Start_butt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pomoc
            // 
            this.Pomoc.Location = new System.Drawing.Point(31, 151);
            this.Pomoc.Name = "Pomoc";
            this.Pomoc.Size = new System.Drawing.Size(153, 23);
            this.Pomoc.TabIndex = 6;
            this.Pomoc.Text = "Pomoc";
            this.Pomoc.UseVisualStyleBackColor = true;
            this.Pomoc.Click += new System.EventHandler(this.Pomoc_Click);
            // 
            // Ranking
            // 
            this.Ranking.Location = new System.Drawing.Point(31, 180);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(153, 23);
            this.Ranking.TabIndex = 7;
            this.Ranking.Text = "Ranking";
            this.Ranking.UseVisualStyleBackColor = true;
            this.Ranking.Click += new System.EventHandler(this.Ranking_Click);
            // 
            // Exit_butt
            // 
            this.Exit_butt.Location = new System.Drawing.Point(31, 210);
            this.Exit_butt.Name = "Exit_butt";
            this.Exit_butt.Size = new System.Drawing.Size(153, 23);
            this.Exit_butt.TabIndex = 8;
            this.Exit_butt.Text = "Exit";
            this.Exit_butt.UseVisualStyleBackColor = true;
            this.Exit_butt.Click += new System.EventHandler(this.Exit_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(231, 251);
            this.Controls.Add(this.Exit_butt);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.Pomoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start_butt);
            this.Controls.Add(this.Poziomy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Poziomy;
        private System.Windows.Forms.Button Start_butt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Pomoc;
        private System.Windows.Forms.Button Ranking;
        private System.Windows.Forms.Button Exit_butt;
    }
}

