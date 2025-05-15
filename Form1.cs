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
            public static string connStr = "Server = 95.183.12.18; Port = 3306; Database=selimBD; user=selimBD; password=123";
        }
        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void createJournal_Click(object sender, EventArgs e)
        {

        }

        private void showTable_Click(object sender, EventArgs e)
        {
            secondPage.secondPage transfer = new secondPage.secondPage();
            transfer.Show();
        }

        private void staticBtn_Click(object sender, EventArgs e)
        {
            staticPage.statisticPage transfer = new staticPage.statisticPage();
            transfer.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
