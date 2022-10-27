using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Console_Application
{
    public class Insert:main
    {
        public void insertdata()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Enter your Name");
                string useranme = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number");
                double number = Convert.ToDouble(Console.ReadLine());


                string insertQuery = "INSERT INTO Employee_details(EmployeeName,EmployeeAge,EmployeeNumber) VALUES('" + useranme + "'," + age + "," + number + ")";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Data Insert Successfully");
            }catch(Exception e)
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
