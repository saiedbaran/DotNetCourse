using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace dotnetcourse
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;Trusted_Connection=True;TrustServerCertificate=True;";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            DateTime now = dbConnection.QuerySingle<DateTime>("SELECT GETDATE()");
            System.Console.WriteLine(now);

            // Models.Computer computer = new Models.Computer()
            // {
            //     Motherboard = "ASUS",
            //     HasWifi = true,
            //     HasLTE = false,
            //     ReleaseDate = DateTime.Today,
            //     Price = 1000.99m,
            //     VideoCard = "RTX 3090"
            // };
        }
    }
}