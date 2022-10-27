using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Console_Application
{
    public class main
    {
        SqlConnection sqlConnection;
        private string connectionString = @"Data Source=.;Initial Catalog=Company_Hr;Integrated Security=True";
        //--------------------- Update for Employee -------------------------------------//
        public void UpdateForEmployee(int id, string EmployeeName, double EmployeeNumber, int EmployeeAge, int departmentid, int salaryid)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC updateData " + id + ",'" + EmployeeName + "'," + EmployeeNumber + "," + EmployeeAge + "," + departmentid + "," + salaryid + ";";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
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

        //--------------------------- Delete  for employee-----------------------------------//
        public void DeleteForEmployee(int id)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC deleteData " + id + ";";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
                Console.WriteLine("Delete Successfully");

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
        //------------------------------- Diaplay data  for Employee table------------------------------//
        public void DisplayForEmployee()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "select * from Employee_Deteails_View ;";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
                SqlDataReader dataReaders = EXECCommand.ExecuteReader();
                while (dataReaders.Read())
                {
                    Console.WriteLine("EmployeeId: " + dataReaders.GetValue(0).ToString());
                    Console.WriteLine("EmployeeName: " + dataReaders.GetValue(1).ToString());
                    Console.WriteLine("EmployeeAge: " + dataReaders.GetValue(2).ToString());
                    Console.WriteLine("EmployeeNumber: " + dataReaders.GetValue(3).ToString());
                    Console.WriteLine("DepartmentName: " + dataReaders.GetValue(4).ToString());
                    Console.WriteLine("Salary: " + dataReaders.GetValue(5).ToString());


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
        //----------------------------- Insert for Employee -------------------------------//

        public void Insert(string EmployeeName, double EmployeeNumber, int EmployeeAge, int departmentid, int salaryid)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC InsertData '" + EmployeeName + "'," + EmployeeNumber + "," + EmployeeAge + "," + departmentid + "," + salaryid + ";";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
                Console.WriteLine("Insert Successfully");

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


        //------------------------- Insert for Department -----------------------------------------//
        public void SP_InsertForDepartment(string departmentname)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC InsertData '" + departmentname + "';";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
                Console.WriteLine("Insert Successfully");

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

        //------------------------------- Update Department Table ----------------------------------------------//
        public void SP_UpdateForDepartment(int id, string departmentname)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC updateData " + id + ",'" + departmentname + "';";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
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

        //--------------------------- Insert Salary in Salary table ------------------------------------------------//

        public void SP_InsertForSalary(double salary)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC InsertData " + salary + ";";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
                Console.WriteLine("Insert Successfully");

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

        //------------------------------- Update salary Table ----------------------------------------------//
        public void SP_UpdateForSalary(int id, double salary)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string execCommand = "EXEC updateData " + id + "," + salary + ";";
                SqlCommand EXECCommand = new SqlCommand(execCommand, sqlConnection);
                EXECCommand.ExecuteNonQuery();
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
