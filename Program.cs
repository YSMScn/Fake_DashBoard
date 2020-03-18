using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fake_Dashboard
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseQuery.ConnectingDatabase();//PROBABLY NEED TO CHANGE WITH CLOSE METHOD FOR EACH METHOD IN DATABASEQUERY.CS
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBorad());
            

        }
    }
}
