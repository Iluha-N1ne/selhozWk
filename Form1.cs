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

namespace selhozWk
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }
/*
 * Microsoft Windows [Version 10.0.22631.4602]
 * (c) TO "Олегохолдинг" (TO "Olegoholding"). All rights secure.
 * License to use GNU-4.0
 * Use, and have fun
 */
        public class mainClass
        {
            public static string connStr = "Server = 95.183.12.18; Port = 3306; Database=selhozWk; user=selhozUser; password=123";
            public static string familiya_rabochego;
            public static string nazvaniye_ugodiya;
            public static string nazvaniye_rasteniye;

            public static int id_rabochego;
            public static int id_rasteniya;
            public static int id_ugodiya;
        }
        private void mainPage_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void createJournal_Click(object sender, EventArgs e)
        {
            panel1.Show();
            loadData();
        }
        

        private void showTable_Click(object sender, EventArgs e)
        {
            secondPage.secondPage transfer = new secondPage.secondPage();
            transfer.Show();
        }
        private void loadData()
        {
            using (MySqlConnection conn = new MySqlConnection(mainClass.connStr))
            {
                try
                {
                    conn.Open();

                    string posQuery = "SELECT DISTINCT familiya FROM rabochie;";
                    using (MySqlCommand Command = new MySqlCommand(posQuery, conn))
                    using (MySqlDataReader Reader = Command.ExecuteReader())
                    {
                        rabochiyCm.Items.Clear();
                        while (Reader.Read())
                        {
                            rabochiyCm.Items.Add(Reader["familiya"].ToString());
                        }
                    }

                    conn.Close();
                    conn.Open();

                    string posiQuery = "SELECT DISTINCT nazvaniye FROM rasteniye;";
                    using (MySqlCommand driversCommand = new MySqlCommand(posiQuery, conn))
                    using (MySqlDataReader driversReader = driversCommand.ExecuteReader())
                    {
                        rasteniyeCm.Items.Clear();
                        while (driversReader.Read())
                        {
                            rasteniyeCm.Items.Add(driversReader["nazvaniye"].ToString());
                        }
                    }

                    conn.Close();

                    conn.Open();

                    string positionQuery = "SELECT DISTINCT nazvaniye FROM ugodiya;";
                    using (MySqlCommand driversCommand = new MySqlCommand(positionQuery, conn))
                    using (MySqlDataReader driversReader = driversCommand.ExecuteReader())
                    {
                        ugodiyeCm.Items.Clear();
                        while (driversReader.Read())
                        {
                            ugodiyeCm.Items.Add(driversReader["nazvaniye"].ToString());
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {

            string query = @"INSERT INTO journal (ploshadZaseva, dataPoseva, id_rabotnika, id_ugodiya, id_rasteniya) VALUES(@ploshadZaseva, @dataPoseva, @id_rabotnika, @id_rasteniya, @id_ugodiya)";
            using (MySqlConnection conn = new MySqlConnection(mainClass.connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MessageBox.Show($"Рабочий {mainClass.id_rabochego}, растение {mainClass.id_rasteniya}, угодие {mainClass.id_ugodiya}");
                    cmd.Parameters.AddWithValue("@ploshadZaseva", zasevEdit.Text);
                    cmd.Parameters.AddWithValue("@dataPoseva", datePicker.Text);
                    cmd.Parameters.AddWithValue("@id_rabotnika", mainClass.id_rabochego);
                    cmd.Parameters.AddWithValue("@id_rasteniya",  mainClass.id_ugodiya);
                    cmd.Parameters.AddWithValue("@id_ugodiya", mainClass.id_rasteniya);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void rabochiyCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(mainClass.connStr))
            {
                    conn.Open();

                    string posQuery = $"SELECT DISTINCT id FROM rabochie WHERE familiya LIKE '{rabochiyCm.Text}%';";
                    using (MySqlCommand Command = new MySqlCommand(posQuery, conn))
                    using (MySqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            mainClass.id_rabochego = Reader.GetInt32("id");
                        }
                    }
            }
        }

        private void rasteniyeCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(mainClass.connStr))
            {
                conn.Open();

                string posQuery = $"SELECT DISTINCT id FROM rasteniye WHERE nazvaniye LIKE '{rasteniyeCm.Text}%';";
                using (MySqlCommand Command = new MySqlCommand(posQuery, conn))
                using (MySqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        mainClass.id_rasteniya = Reader.GetInt32("id");
                    }
                }
            }
        }

        private void ugodiyeCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(mainClass.connStr))
            {
                conn.Open();

                string posQuery = $"SELECT DISTINCT id FROM ugodiya WHERE nazvaniye LIKE '{ugodiyeCm.Text}%';";
                using (MySqlCommand Command = new MySqlCommand(posQuery, conn))
                using (MySqlDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        mainClass.id_ugodiya = Reader.GetInt32("id");
                    }
                }
            }
        }
    }
}
