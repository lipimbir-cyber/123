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
    public partial class edit_proekt : Form
    {
        public edit_proekt()
        {
            InitializeComponent();
            loadcombobox();
        }
        int id;
        public edit_proekt(int _id)
        {
            InitializeComponent();
            loadcombobox();
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
                ("Select * from proekt Where ID_proekt = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            zadachi.SelectedValue = dt.Rows[0][1];
            nazvanie_proekta.Text = dt.Rows[0][2].ToString();
            data_nachala.Text = dt.Rows[0][3].ToString();
            data_okonchaniya.Text = dt.Rows[0][4].ToString();
            razmer_finansirovania.Text = dt.Rows[0][5].ToString();
            tip_finansirovania.Text = dt.Rows[0][6].ToString();
        }
        private void loadcombobox()
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ("Select * from zadachi", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            zadachi.DataSource = dt;
            zadachi.DisplayMember = "zadachi";
            zadachi.ValueMember = "ID_zadachi";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
          ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Insert into proekt (`ID_zadachi`, `nazvanie_proekta`, `data_nachala`, `data_okonchaniya`, `razmer_finansirovania`, `tip_finansirovania` )
                VALUES ('{zadachi.SelectedValue}',
                '{nazvanie_proekta.Text}',
                '{data_nachala.Text}',
                '{data_okonchaniya.Text}',
                '{razmer_finansirovania.Text}',
                '{tip_finansirovania.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Update proekt Set
                ID_zadachi='{zadachi.SelectedValue}',
                nazvanie_proekta='{nazvanie_proekta.Text}',
                data_nachala='{data_nachala.Text}',
                data_okonchaniya='{data_okonchaniya.Text}',
                razmer_finansirovania='{razmer_finansirovania.Text}',
                tip_finansirovania='{tip_finansirovania.Text}'
                Where ID_zadachi={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Delete from proekt Where ID_proekt = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
