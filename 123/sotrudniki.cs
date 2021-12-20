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
    public partial class sotrudniki : Form
    {
        public sotrudniki()
        {
            InitializeComponent();
            query = _query;
            loadtable();
            loadcombobox();
        }
        string query;
        const string _query = "select sotrudniki.ID_sotrudnik, otdel.nazvanie_otdela as 'Название отдела', doljnost.doljnost as 'Должность', sotrudniki.FIO AS 'ФИО', " +
            "sotrudniki.domashniy_telefon as 'Домашний телефон', sotrudniki.mobilniy_telefon as 'Мобильный телефон', sotrudniki.rabochiy_telefon as 'Рабочий телефон', " +
            "sotrudniki.razmer_zp 'Размер з/п', sotrudniki.forma_zp as 'Форма з/п' " +
            "from sotrudniki, otdel, doljnost " +
            "where sotrudniki.ID_otdel = otdel.ID_otdel and sotrudniki.ID_doljnost = doljnost.ID_doljnost ";
        private void loadtable()
        {
            MySqlConnection con = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da = new MySqlDataAdapter
                (query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            edit_sotrudniki es = new edit_sotrudniki();
            es.ShowDialog();
            loadtable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                edit_sotrudniki es = new edit_sotrudniki(id);
                es.ShowDialog();
                loadtable();
            }
            catch (InvalidCastException)
            {
                button1_Click(null, null);
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            doljnost.SelectedIndex = -1;
            otdel.SelectedIndex = -1;
            panel1.Visible = checkBox1.Checked;
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
            otdel.SelectedIndex = -1;
            otdel.SelectedIndexChanged += new EventHandler(comboboxselectedindexchanged);
            MySqlConnection con1 = new MySqlConnection
           ("Server=127.0.0.1;Database=sladkov_ilya;charset=utf8;Uid=root;Pwd=;SslMode=none");
            MySqlDataAdapter da1 = new MySqlDataAdapter
                ("Select * from otdel", con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            doljnost.DataSource = dt1;
            doljnost.DisplayMember = "doljnost";
            doljnost.ValueMember = "ID_doljnost";
            doljnost.SelectedIndex = -1;
            doljnost.SelectedIndexChanged += new EventHandler(comboboxselectedindexchanged);
        }
        void comboboxselectedindexchanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and sotrudniki.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            loadtable();
        }
    }
}
