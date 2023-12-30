using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*
     string connectionString = @"server=DESKTOP-HD4I80E\SQLEXPRESS;Database=Northwind;user=bahtiyar_sonmez;password=12333hd;trusted_Connection=true;TrustServerCertifiate=true";

*/


namespace Proj06_MvcWivcWithSql.Dal
{
    public static class Db
    {
        private static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection()
        {
            string connectionString = @"server=DESKTOP-HD4I80E\SQLEXPRESS;Database=Northwind;user=sa password=1234;trusted_Connection=true;TrustServerCertificate=true";
            return new SqlConnection(connectionString);
        }
        public static void OpenCn(){
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                Console.WriteLine("Baglantı başarıyla kuruldu...")
            }
            catch (Exception.e)
            {
                Console.WriteLine(e.Message);
            }        
        }
        public static void CloseCn(){
            try
            {
                if (Connection.State==ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception.e)
       
            {
                Console.WriteLine(e.Message);
            }
        }
    }   
}