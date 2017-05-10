using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RestaurantManagement
{
    public class Seating
    {

        private int tableID;
        private string availabilty;
        private int hoursOccupied;

        public int TableID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
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
                updateitem.CommandText = "update dbo.Seating set TableStatus = 'occupied'  where TableID =" +num +";";
                var tableParam = new SqlParameter("TableStatus", SqlDbType.VarChar) { Value = "occupied" };
                updateitem.Parameters.Add(tableParam);
                updateitem.ExecuteNonQuery();
            }
        }
        public string Availabilty
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int HoursOccupied
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}