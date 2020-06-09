using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection dbConn;

        String ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\Users\jessi\OneDrive\Documents\StudentsDB.accdb;" +
            "Persist Security Info=False";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(ConnectionString);
                dbConn.Open();

                MessageBox.Show("Connection open Successfully");

                dbConn.Close();
            }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            String sql;
            sql = "select * From StudentsData;";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader rd = dbCmd.ExcecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);

            dbConn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
            {
        dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql ="";

            sql = "insert into StudentsData (StudentID, StudentName, CourseCode, TeacherName) values (11, 'Eric Forman', 'IS375', 'Red Forman')";

            command = new OleDbCommand(sql, dbConn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExcecuteNonQuery();

            MessageBox.Show("Added successfully");

            command.Dipose();
            dbConn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
            {
        dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "delete from StudentsData where StudentName= 'Eric Forman'";

            command = new OleDbCommand(sql, dbConn);
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.Connection.ExcecuteNonQuery();

            MessageBox.Show("Deleted successfully");

            command.Dispose();
            dbConn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
            {
        dbConn - new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "Update StudentsData set StudentName= 'Michael Kelso' where StudentID=4";

            command = new OleDbCommand(sql, dbConn);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExcecuteNonQuery();

            MessageBox.Show("Record updated successfully");

            command.Dispose();
            dbConn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
            {
        dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            String sql;
            sql = "Select * From StudentData where StudentName= 'Bill Mosby';";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader rd = dbCmd.ExcecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);

            dbConn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
