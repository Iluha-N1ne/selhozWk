using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace selhozWk.secondPage
{
    public partial class secondPage : Form
    {
        public secondPage()
        {
            InitializeComponent();
        }
        /*
  * Microsoft Windows [Version 10.0.22631.4602]
  * (c) TO "Олегохолдинг" (TO "Olegoholding"). All rights secure.
  * License to use GNU-4.0
  * Use, and have fun
  */
        private class sqlTables
        {
            public static string rabochie = $@"SELECT rabochie.id AS Номер, familiya AS Фамилия, imya AS Имя, doljnost AS Должность, telefon AS Телефон FROM rabochie";
            public static string rasteniye = $@"SELECT rasteniye.id AS Номер, nazvaniye AS Название, vid AS Вид, srokRosta AS СрокиРоста, urojainost AS Урожайность FROM rasteniye";
            public static string ugodiya = $@"SELECT ugodiya.id AS Номер, nazvaniye AS Название, ploshad AS Площадь, tipPocvi AS ТипПочвы, raspolojeniye AS Расположение FROM ugodiya";
            public static string journal = $@"SELECT journal.id AS Номер, rabochie.familiya AS Фамилия, rabochie.imya AS Имя, rasteniye.nazvaniye AS НазваниеРастения, ugodiya.Nazvaniye AS НазваниеУгодия, dataPoseva AS ДатаПосева, ploshadZaseva AS ПлощадьЗасева FROM journal";
            public static string joinJournal = "LEFT JOIN rasteniye ON id_rasteniya = rasteniye.id LEFT JOIN ugodiya ON id_ugodiya = ugodiya.id LEFT JOIN rabochie ON id_rabotnika = rabochie.id";
            public static string engNames;
        }

        private void secondPage_Load(object sender, EventArgs e)
        {

        }
        #region loadData
        private void tableSlct_SelectedIndexChanged(object sender, EventArgs e)
        {
            engNames.TryGetValue(tableSlct.Text, out sqlTables.engNames);
            tables.TryGetValue(sqlTables.engNames, out string query);
            dataLoad(query);
            //MessageBox.Show(sqlTables.engNames);
        }
        private void dataLoad(string query)
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
        #endregion
        #region addData
        private void changeBtn_Click(object sender, EventArgs e)
        {
            var tables = new Dictionary<string, string>
            {
                {"rabochie",$@"{sqlTables.rabochie}"},
                {"rasteniye",$@"{sqlTables.rasteniye}"},
                {"journal",$@"{sqlTables.journal} {sqlTables.joinJournal}"},
                {"ugodiya",$@"{sqlTables.ugodiya}"}
            };
            tables.TryGetValue(sqlTables.engNames, out string query);

            var dataSet = new DataSet();
            var table = (DataTable)dataGrid.DataSource;

            table.TableName = sqlTables.engNames;
            dataSet.Tables.Add(table);

            //foreach (DataColumn column in table.Columns) { MessageBox.Show(column.ColumnName); }

            try
            {
                using (var conn = new MySqlConnection(mainPage.mainClass.connStr))
                {
                    var adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand(query, conn);
                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.Update(dataSet, sqlTables.engNames);
                }
                dataSet.Reset();
                dataLoad(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        #region deleteData
        private void dltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["Номер"].Value.ToString());
                using (MySqlConnection connection = new MySqlConnection(mainPage.mainClass.connStr))
                {
                    string query = $"DELETE FROM {sqlTables.engNames} WHERE id = {ID}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        dataLoad(query);
                    }
                    catch (Exception ex)
                    {
                        dataLoad(query);
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        #endregion
        #region searchData
        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tablesSearch = new Dictionary<string, string>
        {
                {"rabochie",$@"{sqlTables.rabochie} WHERE familiya LIKE '{srcEdit.Text}%'"},
                {"rasteniye",$@"{sqlTables.rasteniye} WHERE nazvaniye LIKE '{srcEdit.Text}%'"},
                {"journal",$@"{sqlTables.journal} {sqlTables.joinJournal} WHERE dataPoseva LIKE '{srcEdit.Text}%'"},
                {"ugodiya",$@"{sqlTables.ugodiya} WHERE nazvaniye LIKE '{srcEdit.Text}%'"}
        };
        tablesSearch.TryGetValue(sqlTables.engNames, out string query);
            dataLoad(query);
        }
        #endregion 
        #region Dictionary
        Dictionary<string, string> engNames = new Dictionary<string, string>
        {
                {"Рабочие",$@"rabochie"},
                {"Растения",$@"rasteniye"},
                {"Журнал",$@"journal"},
                {"Угодия",$@"ugodiya"}
        };        

        Dictionary<string, string> tables = new Dictionary<string, string>
        {
                {"rabochie",$@"{sqlTables.rabochie}"},
                {"rasteniye",$@"{sqlTables.rasteniye}"},
                {"journal",$@"{sqlTables.journal} {sqlTables.joinJournal}"},
                {"ugodiya",$@"{sqlTables.ugodiya}"}
        };
        #endregion
    }
#warning TO "Olehgoholding"
}
