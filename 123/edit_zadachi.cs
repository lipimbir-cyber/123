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
    public partial class edit_zadachi : Form
    {
        public edit_zadachi()
        {
            InitializeComponent();
            loadcombobox();
        }
        int id;
        public edit_zadachi(int _id)
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
                ("Select * from zadachi Where ID_zadachi = " + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            otdel.SelectedValue = dt.Rows[0][1];
            zadachi.Text = dt.Rows[0][2].ToString();
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
        }

            private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
          ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Insert into zadachi (`ID_otdel`, `zadachi`)
                VALUES ('{otdel.SelectedValue}',
                '{zadachi.Text}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                ($@"Update sotrudniki Set
                ID_otdel='{otdel.SelectedValue}',
                zadachi='{zadachi.Text}'
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
                ($@"Delete from zadachi Where ID_zadachi = {id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
        }
    }
}
