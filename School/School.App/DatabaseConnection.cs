using System;
using School.Logic;
using System.Data.SqlClient;
namespace School.App {
    class DatabaseConnection {
        string connectionString="./../../ConnectionString";
        private string conString;

        public DatabaseConnection(){
            Console.WriteLine("Database Connection");
            this.conString = connectionString;
            using SqlConnection connection = new SqlConnection(this.conString);
        }

        //methods

        //establish connection
        public void getConnection(){
            try{
                connection.Open();
            }catch(Exception e){
                Console.WriteLine($"Database Connection Error!!! {e.Message}");
            }
        }

        //close connection
    }
}