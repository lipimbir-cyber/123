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
    public partial class zadachi : Form
    {
        public zadachi()
        {
            InitializeComponent();
            query = _query;
            loadtable();
            loadcombobox();
        }
        string query;
        const string _query = "Select zadachi.ID_zadachi, otdel.nazvanie_otdela as 'Название отдела', zadachi.zadachi as 'Задача' " +
            "From zadachi, otdel " +
            "Where zadachi.ID_otdel = otdel.ID_otdel ";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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
        }
        void comboboxselectedindexchanged(object sender, EventArgs e)
        {
            query = _query;
            foreach (Control cb in panel1.Controls)
            {
                if (cb is ComboBox)
                    if ((cb as ComboBox).SelectedIndex != -1) query += $@" and zadachi.{cb.Tag}={(cb as ComboBox).SelectedValue}";
            }
            loadtable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_zadachi ez = new edit_zadachi();
            ez.ShowDialog();
            loadtable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                edit_zadachi ez = new edit_zadachi(id);
                ez.ShowDialog();
                loadtable();
            }
            catch (InvalidCastException)
            {
                button1_Click(null, null);
            }
            catch (ArgumentOutOfRangeException)
            { }
        }
    }
}