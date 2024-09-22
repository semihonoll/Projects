using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Entity_AdoNet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SqlDataReader
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=False;";
            //conn.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT FirstName, LastName, Title FROM Employees";
            //cmd.Connection = conn;

            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine($"Adı: {dr["FirstName"]} Soyadı: {dr["LastName"]}");
            //}

            //conn.Close();
            //dr.Close();
            #endregion

            #region SqlDataAdapter
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=False;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT FirstName, LastName, Title FROM Employees";
            cmd.Connection = conn;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine($"Adı: {ds.Tables[0].Rows[i]["FirstName"]}");
            }
            #endregion

            conn.Close();

            Console.ReadLine();
        }
    }
}
