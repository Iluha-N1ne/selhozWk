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
            public static string tableName;
            public static string query;
        }

        private void secondPage_Load(object sender, EventArgs e)
        {

        }
        #region loadData
        private void tableSlct_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlTables.tableName = tableSlct.Text;
            sqlTables.query = $"SELECT * FROM {sqlTables.tableName}";
            dataLoad(sqlTables.query);
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

            var dataSet = new DataSet();
            var table = (DataTable)dataGrid.DataSource;
            table.TableName = sqlTables.tableName;
            dataSet.Tables.Add(table);

            //foreach (DataColumn column in table.Columns) { MessageBox.Show(column.ColumnName); }

            try
            {
                using (var conn = new MySqlConnection(mainPage.mainClass.connStr))
                {
                    var adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand(sqlTables.query, conn);
                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.Update(dataSet, sqlTables.tableName);
                }
                dataSet.Reset();
                dataLoad(sqlTables.query);
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
                int ID = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["id"].Value.ToString());
                using (MySqlConnection connection = new MySqlConnection(mainPage.mainClass.connStr))
                {
                    string query = $"DELETE FROM {sqlTables.tableName} WHERE id = {ID}";
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
                {"Товары",$@"{sqlTables.query} WHERE LIKE Назввание'{srcEdit.Text}%'"},
                {"Тип",$@"{sqlTables.query} WHERE id LIKE {srcEdit.Text}"},
                {"Поставщики",$@"{sqlTables.query} WHERE id LIKE {srcEdit.Text}"},
                {"журналПродаж",$@"{sqlTables.query} WHERE id_Поставщика LIKE '{srcEdit.Text}'"}
        };
        tablesSearch.TryGetValue(sqlTables.tableName, out string query);
            dataLoad(query);
        }
        #endregion 
    }
#warning TO "Olehgoholding"
}
