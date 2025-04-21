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
            public static int id_rabochego;
            public static int id_ugodiya;
            public static int id_rasteniye;
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

                    string posQuery = "SELECT DISTINCT id, familiya FROM rabochie;";
                    using (MySqlCommand Command = new MySqlCommand(posQuery, conn))
                    using (MySqlDataReader Reader = Command.ExecuteReader())
                    {
                        rabochiyCm.Items.Clear();
                        while (Reader.Read())
                        {
                            rabochiyCm.Items.Add(Reader["familiya"].ToString());
                            mainClass.id_rabochego = Convert.ToInt32(Reader["id"]);
                        }
                    }

                    conn.Close();
                    conn.Open();

                    string posiQuery = "SELECT DISTINCT id, nazvaniye FROM rasteniye;";
                    using (MySqlCommand driversCommand = new MySqlCommand(posiQuery, conn))
                    using (MySqlDataReader driversReader = driversCommand.ExecuteReader())
                    {
                        rasteniyeCm.Items.Clear();
                        while (driversReader.Read())
                        {
                            rasteniyeCm.Items.Add(driversReader["nazvaniye"].ToString());
                            mainClass.id_rasteniye = Convert.ToInt32(driversReader["id"]);
                        }
                    }

                    conn.Close();

                    conn.Open();

                    string positionQuery = "SELECT DISTINCT id, nazvaniye FROM ugodiya;";
                    using (MySqlCommand driversCommand = new MySqlCommand(positionQuery, conn))
                    using (MySqlDataReader driversReader = driversCommand.ExecuteReader())
                    {
                        ugodiyeCm.Items.Clear();
                        while (driversReader.Read())
                        {
                            ugodiyeCm.Items.Add(driversReader["nazvaniye"].ToString());
                            mainClass.id_ugodiya = Convert.ToInt32(driversReader["id"]);
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
            string query = @"INSERT INTO journal (ploshadZaseva, dataPoseva, id_rabotnika, id_ugodiya, id_rasteniya) VALUES(@User_id, @imya, @prodType_id, @Production_id, @Cost)";
            using (MySqlConnection conn = new MySqlConnection(mainClass.connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Пример работы с параметрами
                    cmd.Parameters.AddWithValue("@User_id", zasevEdit.Text);
                    cmd.Parameters.AddWithValue("@imya", datePicker.Text);
                    cmd.Parameters.AddWithValue("@Production_id", mainClass.id_ugodiya);
                    cmd.Parameters.AddWithValue("@prodType_id", mainClass.id_rabochego);
                    cmd.Parameters.AddWithValue("@Cost", mainClass.id_rasteniye);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
