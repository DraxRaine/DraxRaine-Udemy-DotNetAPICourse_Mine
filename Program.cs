using System;
using Dapper;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommand = "Select getdate()";

            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

            // Console.WriteLine(rightNow);

            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 943.87m,
                VideoCard = "RTX 2060"
            };

            string sql = @"INSERT INTO TutorialAppSchema.Computer(
                Motherboard,
                HasWifi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            ) values (
                '" + myComputer.Motherboard
                + "','" + myComputer.HasWifi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate
                + "','" + myComputer.Price
                + "','" + myComputer.VideoCard
            +"')";

            // Console.WriteLine(sql);

            int result = dbConnection.Execute(sql);

            // Console.WriteLine(result);

            string sqlSelect = @"SELECT 
                Computer.Motherboard,
                Computer.HasWifi,
                Computer.HasLTE,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.VideoCard
                FROM TutorialAppSchema.Computer";

            IEnumerable<Computer> computers = dbConnection.Query<Computer>(sqlSelect);

            Console.WriteLine("'Motherboard','HasWifi','HasLTE','ReleaseDate','Price','VideoCard'");
            
            foreach(Computer singleComputer in computers){
            
                Console.WriteLine("'" + myComputer.Motherboard
                + "','" + myComputer.HasWifi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate
                + "','" + myComputer.Price
                + "','" + myComputer.VideoCard
            +"'");
            }

            // Console.WriteLine(myComputer.Motherboard);
            // Console.WriteLine(myComputer.HasWifi);
            // Console.WriteLine(myComputer.VideoCard);
            // Console.WriteLine(myComputer.ReleaseDate);





        }

    }
}