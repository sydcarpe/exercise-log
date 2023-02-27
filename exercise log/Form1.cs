using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_log
{
    public partial class Form1 : Form
    {
        const string ConnectionString = "server=localhost;uid=root;pwd=Tuna!Fish99;database=workoutLog";
        public Form1()
        {
            InitializeComponent();
            PopulateMuscleGroup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConnectionString);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopulateMuscleGroup()
        {
            var conn = new MySqlConnection(ConnectionString);

            string showMuscleGroups = "SELECT muscle_name FROM muscle_groups;";

            //creating Sql command object to execute query
            var cmd = conn.CreateCommand();
            cmd.CommandText = showMuscleGroups;
            conn.Open();

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //retrieving the muscle group name from SqlDataReader
                string muscleGroupName = reader.GetString(0);

                muscleGroups.Items.Add(muscleGroupName);
            }
            reader.Close();
            conn.Close();
        }


        //checkbox list 
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
