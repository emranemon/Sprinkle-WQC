using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprinkle.Database
{
    class SQLiteDB
    {
        public SQLiteConnection myConnection;

        //ctor & tab twice to create constractor
        public SQLiteDB()
        {
            myConnection = new SQLiteConnection("Data Source = database.sqlite3");

            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                string query = "CREATE TABLE `OutputLog` (" +
                    "`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                    "`DateTime`	TEXT NOT NULL," +
                    "`Temperature`	NUMERIC NOT NULL," +
                    "`PH`	NUMERIC NOT NULL," +
                    "`EC`	NUMERIC NOT NULL," +
                    "`Turbidity`	NUMERIC NOT NULL," +
                    "`Label`	TEXT NOT NULL)";
                myConnection.Open();
                SQLiteCommand command = new SQLiteCommand(query, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Db file and table created");
            }
        }

        public void InsertLog (float Temp, float PH, float EC, float NTU, string result)
        {
            string query = "INSERT INTO OutputLog (DateTime, Temperature, PH, EC, Turbidity, Label)" +
                                "VALUES ( " +
                                "datetime('now', 'localtime'), " +
                                Temp.ToString() + ", " +
                                PH.ToString() + ", " +
                                EC.ToString() + ", " +
                                NTU.ToString() + ", " +
                                "'" + result+ "'" +
                                " );";

            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            myCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
