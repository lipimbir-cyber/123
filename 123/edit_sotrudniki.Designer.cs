
namespace _123
{
    partial class edit_sotrudniki
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
            this.doljnost = new System.Windows.Forms.ComboBox();
            this.otdel = new System.Windows.Forms.ComboBox();
            this.razmer_zp = new System.Windows.Forms.TextBox();
            this.mobilniy_telefon = new System.Windows.Forms.TextBox();
            this.forma_zp = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.domashniy_telefon = new System.Windows.Forms.TextBox();
            this.rabochiy_telefon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doljnost
            // 
            this.doljnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doljnost.FormattingEnabled = true;
            this.doljnost.Location = new System.Drawing.Point(12, 56);
            this.doljnost.Name = "doljnost";
            this.doljnost.Size = new System.Drawing.Size(167, 23);
            this.doljnost.TabIndex = 0;
            // 
            // otdel
            // 
            this.otdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.otdel.FormattingEnabled = true;
            this.otdel.Location = new System.Drawing.Point(12, 12);
            this.otdel.Name = "otdel";
            this.otdel.Size = new System.Drawing.Size(167, 23);
            this.otdel.TabIndex = 1;
            // 
            // razmer_zp
            // 
            this.razmer_zp.Location = new System.Drawing.Point(12, 227);
            this.razmer_zp.Name = "razmer_zp";
            this.razmer_zp.Size = new System.Drawing.Size(100, 23);
            this.razmer_zp.TabIndex = 2;
            // 
            // mobilniy_telefon
            // 
            this.mobilniy_telefon.Location = new System.Drawing.Point(12, 169);
            this.mobilniy_telefon.Name = "mobilniy_telefon";
            this.mobilniy_telefon.Size = new System.Drawing.Size(100, 23);
            this.mobilniy_telefon.TabIndex = 3;
            // 
            // forma_zp
            // 
            this.forma_zp.Location = new System.Drawing.Point(12, 256);
            this.forma_zp.Name = "forma_zp";
            this.forma_zp.Size = new System.Drawing.Size(100, 23);
            this.forma_zp.TabIndex = 4;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(12, 111);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(100, 23);
            this.FIO.TabIndex = 5;
            // 
            // domashniy_telefon
            // 
            this.domashniy_telefon.Location = new System.Drawing.Point(12, 140);
            this.domashniy_telefon.Name = "domashniy_telefon";
            this.domashniy_telefon.Size = new System.Drawing.Size(100, 23);
            this.domashniy_telefon.TabIndex = 6;
            // 
            // rabochiy_telefon
            // 
            this.rabochiy_telefon.Location = new System.Drawing.Point(12, 198);
            this.rabochiy_telefon.Name = "rabochiy_telefon";
            this.rabochiy_telefon.Size = new System.Drawing.Size(100, 23);
            this.rabochiy_telefon.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // edit_sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 355);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rabochiy_telefon);
            this.Controls.Add(this.domashniy_telefon);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.forma_zp);
            this.Controls.Add(this.mobilniy_telefon);
            this.Controls.Add(this.razmer_zp);
            this.Controls.Add(this.otdel);
            this.Controls.Add(this.doljnost);
            this.Name = "edit_sotrudniki";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doljnost;
        private System.Windows.Forms.ComboBox otdel;
        private System.Windows.Forms.TextBox razmer_zp;
        private System.Windows.Forms.TextBox mobilniy_telefon;
        private System.Windows.Forms.TextBox forma_zp;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox domashniy_telefon;
        private System.Windows.Forms.TextBox rabochiy_telefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}