using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlSample
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection, mySqlConnection2;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        BindingSource bindingSource;
        public int increment = 0;
        public int maxRows;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
               "SERVER=localhost;" +
               "DATABASE=beksultan;" +
               "UID=root;" +
               "PASSWORD=;");
            mySqlConnection.Open();

            string query = "SELECT * FROM books LIMIT 3 OFFSET " + increment;
            Setup(query, mySqlConnection);
            GetMaxNumberOfRows();

        }
        private void GetMaxNumberOfRows()
        {

            string query2 = "SELECT COUNT(*) FROM books";
            mySqlConnection2 = new MySqlConnection(
                   "SERVER=localhost;" +
                   "DATABASE=beksultan;" +
                   "UID=root;" +
                   "PASSWORD=;");
            mySqlConnection2.Open();
            MySqlCommand command = new MySqlCommand(query2, mySqlConnection2);
            maxRows = int.Parse(command.ExecuteScalar().ToString());
            mySqlConnection2.Close();
        }
        private void Setup(string query, MySqlConnection mySqlConnection)
        {
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySqlDataAdapter.Update(dataTable);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM books ORDER BY Date";
            Setup(query, mySqlConnection);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string query = "SELECT * FROM books WHERE Name LIKE" + " '%" + s + "'";

            Setup(query, mySqlConnection);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string query = "SELECT * FROM books WHERE Name LIKE" + " '%" + s + "'";

            Setup(query, mySqlConnection);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (increment < maxRows - 2)
            {
                increment += 3;
                string query = "SELECT * FROM books LIMIT 3 OFFSET " + increment;
                Setup(query, mySqlConnection);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string query = "SELECT* FROM books ORDER BY DateofCreation desc";
            //Setup(query, mySqlConnection);
            if (increment >= 3)
            {
                increment -= 3;
                string query = "SELECT * FROM books LIMIT 3 OFFSET " + increment;
                Setup(query, mySqlConnection);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT* FROM books ORDER BY Date DESC";
            Setup(query, mySqlConnection);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT* FROM books ORDER BY Date ASC";
            Setup(query, mySqlConnection);
        }

    }
}