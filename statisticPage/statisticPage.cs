using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selhozWk.staticPage
{
    public partial class statisticPage : Form
    {
        public statisticPage()
        {
            InitializeComponent();
        }

        private void statisticPage_Load(object sender, EventArgs e)
        {
            string query = "SELECT журналПродаж.id, Товары.Назввание AS Товар, Дата FROM журналПродаж " +
                "LEFT JOIN Товары ON Товары.id= id_Товара;";
            loadData(query);
            loadLblData();
        }
        List<string> nameTovari = new List<string>();
        List<int> namePostavshik = new List<int>();
        List<int> allCost = new List<int>();
        public void loadData(string query)
        {
            using (MySqlConnection conn = new MySqlConnection($"{mainPage.mainClass.connStr}"))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGrid.DataSource = dataTable;
                        dataGrid.AutoGenerateColumns = true;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        public void loadLblData()
        {
            using (MySqlConnection conn = new MySqlConnection($"{mainPage.mainClass.connStr}"))
            {
                try
                {
                    string query = "SELECT журналПродаж.id, Товары.Назввание AS Товар, Дата FROM журналПродаж " +
                    "LEFT JOIN Товары ON Товары.id= id_Товара;";
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                nameTovari.Add(reader["Товар"].ToString());
                                //MessageBox.Show($"{string.Concat(nameTovari)}");
                            }
                        }
                    }

                        string highPopular = nameTovari.GroupBy(x => x)
                                    .OrderByDescending(g => g.Count())
                                    .Select(g => g.Key)
                                    .FirstOrDefault();

                        string lowPopular = nameTovari.GroupBy(x => x)
                              .OrderBy(g => g.Count())
                              .Select(g => g.Key)
                              .FirstOrDefault();

                    highPopularTovar.Text = highPopular;
                    lowPopularTovar.Text = lowPopular;

                    int numberOfPostavshik = 0;

                    string _query = $"SELECT id_Поставщика FROM Товары where Назввание  LIKE '{highPopular}'";
                    using (MySqlCommand command = new MySqlCommand(_query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                numberOfPostavshik = ((int)reader["id_Поставщика"]);
                                //MessageBox.Show($"{string.Concat(nameTovari)}");
                            }
                        }
                    }

                    string __query = $"SELECT Имя FROM Поставщики where id LIKE {numberOfPostavshik}";
                    using (MySqlCommand command = new MySqlCommand(__query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                highPostavshik.Text = (reader["Имя"].ToString());
                                //MessageBox.Show($"{string.Concat(nameTovari)}");
                            }
                        }
                    }

                    string ___query = $"SELECT id_Товара, Товары.Цена FROM журналПродаж LEFT JOIN Товары ON id_Товара = Товары.id;";
                    using (MySqlCommand command = new MySqlCommand(___query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<int> coastList = new List<int>();
                            while (reader.Read())
                            {
                                coastList.Add((int)reader["Цена"]);
                                //MessageBox.Show($"{string.Concat(nameTovari)}");
                            }
                            int summ = coastList.Sum();
                            summaryGisheft.Text = summ.ToString();
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
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime firstDate = dateTimePicker1.Value;
            DateTime secondDate = dateTimePicker2.Value;

            string query = $@"SELECT журналПродаж.id, Товары.Назввание AS Товар, Дата FROM журналПродаж
                LEFT JOIN Товары ON Товары.id= id_Товара 
                WHERE Дата BETWEEN '{firstDate}' AND '{secondDate}';";
            loadData(query);
        }
    }
}
