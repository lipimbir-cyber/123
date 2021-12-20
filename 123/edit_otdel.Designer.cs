namespace _123
{
    partial class edit_otdel
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
            this.nazvanie_otdela = new System.Windows.Forms.TextBox();
            this.komnata = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.razmer_finansirovania = new System.Windows.Forms.TextBox();
            this.chislo_sotrudnikov = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazvanie_otdela
            // 
            this.nazvanie_otdela.Location = new System.Drawing.Point(13, 13);
            this.nazvanie_otdela.Name = "nazvanie_otdela";
            this.nazvanie_otdela.Size = new System.Drawing.Size(151, 23);
            this.nazvanie_otdela.TabIndex = 0;
            // 
            // komnata
            // 
            this.komnata.Location = new System.Drawing.Point(13, 42);
            this.komnata.Name = "komnata";
            this.komnata.Size = new System.Drawing.Size(151, 23);
            this.komnata.TabIndex = 0;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(12, 71);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(151, 23);
            this.telefon.TabIndex = 0;
            // 
            // razmer_finansirovania
            // 
            this.razmer_finansirovania.Location = new System.Drawing.Point(12, 100);
            this.razmer_finansirovania.Name = "razmer_finansirovania";
            this.razmer_finansirovania.Size = new System.Drawing.Size(151, 23);
            this.razmer_finansirovania.TabIndex = 0;
            // 
            // chislo_sotrudnikov
            // 
            this.chislo_sotrudnikov.Location = new System.Drawing.Point(12, 129);
            this.chislo_sotrudnikov.Name = "chislo_sotrudnikov";
            this.chislo_sotrudnikov.Size = new System.Drawing.Size(151, 23);
            this.chislo_sotrudnikov.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // edit_otdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 218);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chislo_sotrudnikov);
            this.Controls.Add(this.razmer_finansirovania);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.komnata);
            this.Controls.Add(this.nazvanie_otdela);
            this.Name = "edit_otdel";
            this.Text = "edit_otdel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazvanie_otdela;
        private System.Windows.Forms.TextBox komnata;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox razmer_finansirovania;
        private System.Windows.Forms.TextBox chislo_sotrudnikov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}