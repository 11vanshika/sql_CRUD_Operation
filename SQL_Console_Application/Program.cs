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
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.;Initial Catalog=Employee;Integrated Security=True";

            
            try
            {
               sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection Established Successfully");
                // Create path in CRUD operation 

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

                //---------------------- Display Command-----------------------------//

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
                dataReader.Close();
                //------------------- Update Command------------------------------//
                int u_id;
                int u_age;
                double u_number;
                Console.WriteLine("Enter the user id that you would to update");
                u_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the age of user to update");
                u_age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the phone number of user to update");
                u_number = double.Parse(Console.ReadLine());

                string updateQuery = "UPDATE Employee_Details SET EmployeeAge = "+ u_age + " , EmployeeNumber ="+ u_number+"  WHERE EmployeeId = "+u_id +"";
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);  
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("Update Successfully");



                //----------------------- Delete command--------------------------//
                int user_id;
                Console.WriteLine("Enter the user id that you would to Delete");
                user_id = int.Parse(Console.ReadLine());
                string deleteQuery = "delete from Employee_Details where EmployeeId = "+user_id +"";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Delete Successfully");




                sqlConnection.Close();





            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
