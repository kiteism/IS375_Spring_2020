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

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=StudentData.sqlite");
            conn.Open();

            var cmd = new SQLiteCommand(conn);
            cmd.CommandText = "Insert into Student(StudentName, CourseCode, TeacherName) Values('Eric Forman', 'IS375', 'Red Forman')";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Added successfully.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=StudentData.sqlite");
            conn.Open();

            var cmd = new SQLiteCommand(conn);
            cmd.CommandText = "Delete from Student Where StudentName='Eric Forman'";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Delete successfully.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=StudentData.sqlite");
            conn.Open();

            var cmd = new SQLiteCommand(conn);
            cmd.CommandText = "Update Student Set StudentName='Michael Kelso' Where StudentId=4";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record updated successfully.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=StudentData.sqlite");
            conn.Open();

            String sql = "select * from student where StudentName='Bill Mosby'";
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
