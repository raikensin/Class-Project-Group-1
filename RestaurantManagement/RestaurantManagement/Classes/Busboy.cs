using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Busboy : Employee
    {
        public Busboy(int employID, string empFirstName, string empLastName, int empHour, int empWage) : base(employID, empFirstName, empLastName, empHour, empWage, "Busboy")
        {
        }


    
        //private string tableStatus;

        public string TableStatus { get; set; }

        public void ChangeTableStatus()
        {
            if (EmployeeID == 2)
            {
                ChangeTableStatus();
            }
        }

        public static void tableClean(int num)
        {
            //update the status of the tables.
            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateitem = connection.CreateCommand())
            {
                updateitem.CommandText = "update dbo.Seating set TableStatus = 'occupied'  where TableID =" + num + ";";
                var tableParam = new SqlParameter("TableStatus", SqlDbType.VarChar) { Value = "clean" };
                updateitem.Parameters.Add(tableParam);
                updateitem.ExecuteNonQuery();
            }
        }
        public static void tableOccupied(int num)
        {
            //update the status of the tables.
            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateitem = connection.CreateCommand())
            {
                updateitem.CommandText = "update dbo.Seating set TableStatus = 'occupied'  where TableID =" + num + ";";
                var tableParam = new SqlParameter("TableStatus", SqlDbType.VarChar) { Value = "clean" };
                updateitem.Parameters.Add(tableParam);
                updateitem.ExecuteNonQuery();
            }
        }
            public static void tableDirty(int num)
        {
            //update the status of the tables.
            SqlConnection connection = new SqlConnection();
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateitem = connection.CreateCommand())
            {
                updateitem.CommandText = "update dbo.Seating set TableStatus = 'occupied'  where TableID =" + num + ";";
                var tableParam = new SqlParameter("TableStatus", SqlDbType.VarChar) { Value = "clean" };
                updateitem.Parameters.Add(tableParam);
                updateitem.ExecuteNonQuery();
            }
        }
    }
    }
