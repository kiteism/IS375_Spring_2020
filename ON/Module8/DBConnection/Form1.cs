using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection dbConn;

        String ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + 
                "Data Source=C:/Users/Peyto/source/repos/PeytonBodhi/IS375_Spring_2020/ON/Module7/StudentsDB.accdb;" +
                "Persist Security Info=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            String sql;
            sql = "select * From StudentsData;";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader rd = dbCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);

            dbConn.Close();
            dataGridView1.DataSource = dt;
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "insert into StudentsData (StudentID, StudentName, CourseCode, TeacherName) values (11, 'Eric Forman', 'IS375', 'Red Forman')";
            
            command = new OleDbCommand(sql, dbConn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Added successfully");

            command.Dispose();
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
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Deleted successfully");

            command.Dispose();
            dbConn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();

            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String sql = "";

            sql = "Update StudentsData set StudentName= 'Michael Kelso' where StudentID=4";

            command = new OleDbCommand(sql, dbConn);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Record updated successfully");

            command.Dispose();
            dbConn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbConn = new OleDbConnection(ConnectionString);
            dbConn.Open();
            String sql;
            sql = "select * From StudentsData where StudentName='Bill Mosby';";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader rd = dbCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);

            dbConn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
