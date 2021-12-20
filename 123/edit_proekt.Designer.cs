namespace _123
{
    partial class edit_proekt
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
            this.zadachi = new System.Windows.Forms.ComboBox();
            this.nazvanie_proekta = new System.Windows.Forms.TextBox();
            this.data_nachala = new System.Windows.Forms.TextBox();
            this.data_okonchaniya = new System.Windows.Forms.TextBox();
            this.razmer_finansirovania = new System.Windows.Forms.TextBox();
            this.tip_finansirovania = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zadachi
            // 
            this.zadachi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zadachi.FormattingEnabled = true;
            this.zadachi.Location = new System.Drawing.Point(13, 13);
            this.zadachi.Name = "zadachi";
            this.zadachi.Size = new System.Drawing.Size(177, 23);
            this.zadachi.TabIndex = 0;
            // 
            // nazvanie_proekta
            // 
            this.nazvanie_proekta.Location = new System.Drawing.Point(13, 43);
            this.nazvanie_proekta.Name = "nazvanie_proekta";
            this.nazvanie_proekta.Size = new System.Drawing.Size(177, 23);
            this.nazvanie_proekta.TabIndex = 1;
            // 
            // data_nachala
            // 
            this.data_nachala.Location = new System.Drawing.Point(12, 72);
            this.data_nachala.Name = "data_nachala";
            this.data_nachala.Size = new System.Drawing.Size(177, 23);
            this.data_nachala.TabIndex = 1;
            // 
            // data_okonchaniya
            // 
            this.data_okonchaniya.Location = new System.Drawing.Point(12, 101);
            this.data_okonchaniya.Name = "data_okonchaniya";
            this.data_okonchaniya.Size = new System.Drawing.Size(177, 23);
            this.data_okonchaniya.TabIndex = 1;
            // 
            // razmer_finansirovania
            // 
            this.razmer_finansirovania.Location = new System.Drawing.Point(12, 130);
            this.razmer_finansirovania.Name = "razmer_finansirovania";
            this.razmer_finansirovania.Size = new System.Drawing.Size(177, 23);
            this.razmer_finansirovania.TabIndex = 1;
            // 
            // tip_finansirovania
            // 
            this.tip_finansirovania.Location = new System.Drawing.Point(13, 159);
            this.tip_finansirovania.Name = "tip_finansirovania";
            this.tip_finansirovania.Size = new System.Drawing.Size(177, 23);
            this.tip_finansirovania.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // edit_proekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 253);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tip_finansirovania);
            this.Controls.Add(this.razmer_finansirovania);
            this.Controls.Add(this.data_okonchaniya);
            this.Controls.Add(this.data_nachala);
            this.Controls.Add(this.nazvanie_proekta);
            this.Controls.Add(this.zadachi);
            this.Name = "edit_proekt";
            this.Text = "edit_proekt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox zadachi;
        private System.Windows.Forms.TextBox nazvanie_proekta;
        private System.Windows.Forms.TextBox data_nachala;
        private System.Windows.Forms.TextBox data_okonchaniya;
        private System.Windows.Forms.TextBox razmer_finansirovania;
        private System.Windows.Forms.TextBox tip_finansirovania;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}