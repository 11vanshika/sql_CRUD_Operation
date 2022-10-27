using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Console_Application
{
    public class Delete : main
    {
        public void delete()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                int user_id;
                Console.WriteLine("Enter the user id that you would to Delete");
                user_id = int.Parse(Console.ReadLine());
                string deleteQuery = "delete from Employee_Details where EmployeeId = " + user_id + "";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Delete Successfully");
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
