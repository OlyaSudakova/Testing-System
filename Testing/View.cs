using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            LoadData();



            /* DB2 db2 = new DB2();
             MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=teacher");
             mySql.Open();
             string dis = "SELECT * FROM teacher";
             MySqlCommand my = new MySqlCommand(dis, mySql); 
             List<string> data1 = new List<string>();
             MySqlDataReader reader1 = my.ExecuteReader();


             while (reader1.Read())
             {
                 string Value = reader1["dis"].ToString();
                 data1.Add(Value);
             }
             reader1.Close();
             mySql.Close();
             foreach (string s in data1)
                 dataGridView1.Rows.Add(s); */
        }
        private void LoadData()
        {
            BD3 bd = new BD3();
            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=test");
            mySqlConnection.Open();
            string query = "SELECT * FROM test";
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> data = new List<string>();


            while (reader.Read())
            {
                string Name = reader["name"].ToString();
                //string Dis = reader["disc"].ToString();
                data.Add(Name);
                //data.Add(Dis);
            }
            reader.Close();
            mySqlConnection.Close();
            foreach (string s in data)
                dataGridView1.Rows.Add(s);
          
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow2 form = new MainWindow2();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
