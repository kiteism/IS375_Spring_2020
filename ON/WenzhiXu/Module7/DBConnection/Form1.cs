using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public static SQLiteConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection("Data Source=StudentData.sqlite");
                conn.Open();
                MessageBox.Show("Connection open Successfully!");
            } 
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=StudentData.sqlite");
            conn.Open();

            String sql = "select * from student";
            SQLiteCommand sqlreader = new SQLiteCommand(sql, conn);

            using (SQLiteDataReader read = sqlreader.ExecuteReader())
            {
                while (read.Read())
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = read.GetInt32(0);
                    dataGridView1.Rows[index].Cells[1].Value = read.GetString(1);
                    dataGridView1.Rows[index].Cells[2].Value = read.GetString(2);
                    dataGridView1.Rows[index].Cells[3].Value = read.GetString(3);

                }
            }

            conn.Close();
        }
    }
}
