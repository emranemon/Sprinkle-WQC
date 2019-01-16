using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sprinkle.Database;

namespace Sprinkle
{
    public partial class OutputLog : Form
    {
        SQLiteDB db = new SQLiteDB();
        public OutputLog()
        {
            InitializeComponent();
        }

        private void OutputLog_Load(object sender, EventArgs e)
        {
            string query = "SELECT date(DateTime) as Date, time(DateTime) as Time," +
                "Temperature, PH, EC, Turbidity, Label FROM OutputLog";
            View(query);

        }

        public void View(string query)
        {
            db.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, db.myConnection);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "OutputLog");
            LogDataGridView.DataSource = ds.Tables[0];
            db.CloseConnection();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT date(DateTime) as Date, time(DateTime) as Time," +
                "Temperature, PH, EC, Turbidity, Label FROM OutputLog WHERE date(DateTime) = '" +
                searchDateTimePicker.Text+"';";
            View(query);
        }

        private void allLogs_Click(object sender, EventArgs e)
        {
            string query = "SELECT date(DateTime) as Date, time(DateTime) as Time," +
                "Temperature, PH, EC, Turbidity, Label FROM OutputLog";
            View(query);
        }
    }
}
