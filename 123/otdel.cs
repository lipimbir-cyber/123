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
    public partial class otdel : Form
    {
        public otdel()
        {
            InitializeComponent();
            query = _query;
            loadtable();
        }
        string query;
        const string _query = "Select ID_otdel, nazvanie_otdela as 'Название отдела', komnata as 'Комната', telefon as 'Телефон', " +
            "razmer_finansirovania as 'Размер финансирования', chislo_sotrudnikov as 'Число сотрудников' " +
            "From otdel " +
            "Where ID_otdel = ID_otdel ";
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
            edit_otdel eo = new edit_otdel();
            eo.ShowDialog();
            loadtable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                edit_otdel eo = new edit_otdel(id);
                eo.ShowDialog();
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
