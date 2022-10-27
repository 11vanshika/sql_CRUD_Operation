using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Console_Application
{
    public class Select : main
    { 
        public void display()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string displayQuery = "select * from Employee_details";
                SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
                SqlDataReader dataReader = displayCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("EmployeeId: " + dataReader.GetValue(0).ToString());
                    Console.WriteLine("EmployeeName: " + dataReader.GetValue(1).ToString());
                    Console.WriteLine("EmployeeAge: " + dataReader.GetValue(2).ToString());
                    Console.WriteLine("EmployeeNumber: " + dataReader.GetValue(3).ToString());

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }   
    
    }
}
