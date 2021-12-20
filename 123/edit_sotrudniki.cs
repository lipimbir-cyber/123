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
    public partial class edit_sotrudniki : Form
    {
        public edit_sotrudniki()
        {
            InitializeComponent();
            loadcombobox();
        }
        int id;
        public edit_sotrudniki(int _id)
        {
            InitializeComponent();
            loadcombobox();
            id = _id;
            loadstring();
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }
        private void loadcombobox()
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from otdel", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            otdel.DataSource = dt;
            otdel.DisplayMember = "nazvanie_otdela";
            otdel.ValueMember = "ID_otdel";

            MySqlConnection con1 = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("Select * from doljnost", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            doljnost.DataSource = dt1;
            doljnost.DisplayMember = "doljnost";
            doljnost.ValueMember = "ID_doljnost";
        }
        private void loadstring()
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from sotrudniki Where ID_sotrudnik = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            otdel.SelectedValue = dt.Rows[0][1];
            doljnost.SelectedValue = dt.Rows[0][2];
            FIO.Text = dt.Rows[0][3].ToString();
            domashniy_telefon.Text = dt.Rows[0][4].ToString();
            mobilniy_telefon.Text = dt.Rows[0][5].ToString();
            rabochiy_telefon.Text = dt.Rows[0][6].ToString();
            razmer_zp.Text = dt.Rows[0][7].ToString();
            forma_zp.Text = dt.Rows[0][8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Update sotrudniki Set
                ID_otdel='{otdel.SelectedValue}',
                ID_doljnost='{doljnost.SelectedValue}',
                FIO='{FIO.Text}',
                domashniy_telefon='{domashniy_telefon.Text}',
                mobilniy_telefon='{mobilniy_telefon.Text}',
                rabochiy_telefon='{rabochiy_telefon.Text}',
                razmer_zp='{razmer_zp.Text}',
                forma_zp='{forma_zp.Text}'
                Where ID_sotrudnik={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete from sotrudniki Where ID_sotrudnik = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
          ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Insert into sotrudniki (`ID_otdel`, `ID_doljnost`, `FIO`, `domashniy_telefon`, `mobilniy_telefon`, `rabochiy_telefon`, `razmer_zp`, `forma_zp`)
                VALUES ('{otdel.SelectedValue}',
                '{doljnost.SelectedValue}',
                '{FIO.Text}',
                '{domashniy_telefon.Text}',
                '{mobilniy_telefon.Text}',
                '{rabochiy_telefon.Text}',
                '{razmer_zp.Text}',
                '{forma_zp.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
