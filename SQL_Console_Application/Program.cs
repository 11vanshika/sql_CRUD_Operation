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
            main MainQuery = new main();
            //MainQuery.UpdateForEmployee(1,"vanshika",6789345609,22,4,5);
            //MainQuery.DeleteForEmployee(8);
            ///MainQuery.Insert("xyz", 897389736, 23, 4, 1);
            MainQuery.DisplayForEmployee();

            // MainQuery.SP_InsertForDepartment("hr");//DepartmetName
            //MainQuery.SP_UpdateForDepartment(1,selles);//DepartmentId , DepartmentName
            //MainQuery.SP_InsertForSalary(675546);//salary 
            //MainQuery.SP_UpdateForSalary(2,8658644);//salaryId , salary
        }
    }
}
