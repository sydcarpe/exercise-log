using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection("server=localhost;uid=root;pwd=Tuna!Fish99;database=workoutLog");
            conn.Open();
            string query = "SELECT * FROM User WHERE id = 1;"; // hard coded for now, will be changed later, but just for testing :)

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

            //creating new datatable
            DataTable datatable = new DataTable();

            adapter.Fill(datatable); //filling datatable

            //displaying in message box
            string message = "";

            //runs through each line and prints them as a string (hence the ToString())
            foreach (DataRow row in datatable.Rows)
            {
                message += row["first_name"].ToString() + " ";
            }
            //displaying the final message
            MessageBox.Show(message);

        }
    }
}
