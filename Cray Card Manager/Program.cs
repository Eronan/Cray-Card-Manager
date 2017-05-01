using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cray_Card_Manager
{
    static class Program
    {
        public static string sqliteDBFile = @".\vgCards.db";
        public static string[] tables = new string[2] { "Main", "Custom" };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataSet allCards = new DataSet();

            foreach (string str in tables)
            {
                using (SQLiteConnection cnn = new SQLiteConnection("datasource=" + sqliteDBFile))
                {
                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand("select * from " + str, cnn);
                        cnn.Open();

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        adapter.Fill(allCards, str);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        if (cnn != null) cnn.Close();
                    }
                }

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(allCards));
        }
    }
}
