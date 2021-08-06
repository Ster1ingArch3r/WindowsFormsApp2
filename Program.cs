using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SQLiteConnection conn;
            conn = CreateConnection();
            CreateTable(conn);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=characters.db;Version=3;Compress=True;");
            try
            {
                conn.Open();

            }
            catch (Exception conn_ex)
            {
                MessageBox.Show(Convert.ToString(conn_ex));
            }
            return conn;
        }
        static void CreateTable(SQLiteConnection conn)
        {
            try
            {
                SQLiteCommand cmd;
                string createTable = "CREATE TABLE IF NOT EXISTS saved_characters4(ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "NAME VARCHAR(30) NOT NULL, RACE VARCHAR(30) NOT NULL, STRENGTH INT, DEXTERITY INT, " +
                    "CONSTITUTION INT, INTELLIGENCE INT, WISDOM INT, CHARISMA INT, LEVEL INT, EXPERIENCE INT, EXPERIENCENEXT, SPEND);";
                cmd = conn.CreateCommand();
                cmd.CommandText = createTable;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(SQLiteException SQLEx)
            {
                MessageBox.Show(Convert.ToString(SQLEx));
            }
        }
    }
}
