using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insert insertQuery = new Insert();
            //insertQuery.insertdata();

            //update updateQuery = new update();
            //updateQuery.Update();

            //Delete deleteQuery = new Delete();
            //deleteQuery.delete();

            Select selectQuery = new Select();
            selectQuery.display();
        }
    }
}
