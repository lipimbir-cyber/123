using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _123
{
    public partial class edit_otdel : Form
    {
        public edit_otdel()
        {
            InitializeComponent();
        }
        int id;
        public edit_otdel(int _id)
        {
            InitializeComponent();
            id = _id;
            loadstring();
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }
        public void loadstring()
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from otdel Where ID_otdel = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nazvanie_otdela.Text = dt.Rows[0][1].ToString();
            komnata.Text = dt.Rows[0][2].ToString();
            telefon.Text = dt.Rows[0][3].ToString();
            razmer_finansirovania.Text = dt.Rows[0][4].ToString();
            chislo_sotrudnikov.Text = dt.Rows[0][5].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
          ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Insert into otdel (`nazvanie_otdela`, `komnata`, `telefon`, `razmer_finansirovania`, `chislo_sotrudnikov`)
                VALUES ('{nazvanie_otdela.Text}',
                '{komnata.Text}',
                '{telefon.Text}',
                '{razmer_finansirovania.Text}',
                '{chislo_sotrudnikov.Text}',)", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Update otdel Set
                nazvanie_otdela='{nazvanie_otdela.Text}',
                komnata='{komnata.Text}',
                telefon='{telefon.Text}',
                razmer_finansirovania='{razmer_finansirovania.Text}',
                chislo_sotrudnikov='{chislo_sotrudnikov.Text}'
                Where ID_otdel={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete from otdel Where ID_otdel = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
