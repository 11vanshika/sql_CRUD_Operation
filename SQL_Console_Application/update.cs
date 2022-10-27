using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Console_Application
{
    public class update:main
    {
       
        public void Update()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                int u_id;
                int u_age;
                double u_number;
                Console.WriteLine("Enter the user id that you would to update");
                u_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the age of user to update");
                u_age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the phone number of user to update");
                u_number = double.Parse(Console.ReadLine());

                string updateQuery = "UPDATE Employee_Details SET EmployeeAge = " + u_age + " , EmployeeNumber =" + u_number + "  WHERE EmployeeId = " + u_id + "";
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("Update Successfully");
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
