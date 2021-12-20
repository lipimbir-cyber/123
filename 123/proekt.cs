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
    public partial class proekt : Form
    {
        public proekt()
        {
            InitializeComponent();
            query = _query;
            loadtable();
            loadcombobox();
        }
        string query;
        const string _query = "Select proekt.ID_proekt, zadachi.zadachi as 'Задачи', proekt.nazvanie_proekta as 'Название проекта', proekt.data_nachala as 'Дата начала', " +
            "proekt.data_okonchaniya as 'Дата окончания', proekt.razmer_finansirovania as 'Размер финансирования', proekt.tip_finansirovania as 'Тип финансирования' " +
            "From proekt, zadachi " +
            "Where proekt.ID_zadachi = zadachi.ID_zadachi ";
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
            zadachi.SelectedIndex = -1;
            zadachi.SelectedIndexChanged += new EventHandler(comboboxselectedindexchanged);
        }
        void comboboxselectedindexchanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and proekt.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            loadtable();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                edit_proekt ep = new edit_proekt(id);
                ep.ShowDialog();
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
            zadachi.SelectedIndex = -1;
            panel1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_proekt ep = new edit_proekt();
            ep.ShowDialog();
            loadtable();
        }
    }
}
