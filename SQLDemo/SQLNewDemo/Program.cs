using System;
using System.Data.SqlClient;

namespace SQLDemo
{
    class Program{

        public static void Main(string[] args){
            Console.WriteLine("SQL Demo Running....");
            
            string connectionString = "./../../ConnectionString";
            
            using SqlConnection connection = new SqlConnection(connectionString);
            try{
                connection.Open();
                string cmdText = " SELECT CustomerId, FirstName, LastName, Address, City, State From [dbo].[Customer] WHERE Country='Brazil'; ";
                SqlCommand cmd= new SqlCommand(cmdText, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Reader Executed...");
                List<Customer> customers = new List<Customer>();
                while(reader.Read()){
                    int? id = reader.GetInt32(0);
                    string? firstName = reader.GetString(1);
                    string? lastName = reader.GetString(2);
                    string? address = reader.GetString(3);
                    string? state = reader.GetString(4);
                    string? city = reader.GetString(5);
                    names.Add(firstName);
                    Customer cus = new Customer(id,firstName,lastName,address,state,city);
                    customers.Add(cus);
                //Console.WriteLine(firstName);
                }
            
                connection.Close();
                foreach(Customer c in customers){
                    c.introduction();
                }
              
                Customer newCustomer = new Customer(999,"dummy name", "Bufford", "Revature", "1 Nowhere Lane", "NewYork","NY","USA", 0123, "(123)-456 7890", "(098) 333 3333", "Jema@noemail.com", 1);
                connection.Open();

                // string cmdText1 = $"INSERT INTO Customer (CustomerId, FirstName, LastName, Company, Address, City, State, Country, Postalcode, Phone, Fax, Email, SupportRepId) VALUES({newCustomer.id}, '{newCustomer.firstName}', '{newCustomer.lastName}', '{newCustomer.company}','{newCustomer.address}', '{newCustomer.city}','{newCustomer.state}','{newCustomer.country}',{newCustomer.postal}, '{newCustomer.phone}','{ newCustomer.fax}', '{newCustomer.email}', {newCustomer.repId});";
                
                
                string cmdText1 = "INSERT INTO Customer (CustomerId, FirstName, LastName, Company, Address, City, State, Country, Postalcode, Phone, Fax, Email, SupportRepId) VALUES(@ID, '@fName', '@lName', '@company','@address', '@city','@state','@country',@postal, '@phone','@fax', '@email', @repId);";

                using SqlCommand cmd1 = new SqlCommand(cmdText1,connection);
                cmd1.Parameters.AddValue("@ID", newCustomer.id);
                cmd1.Parameters.AddValue("@fName", newCustomer.firstName);
                cmd1.Parameters.AddValue("@lName", newCustomer.lastName);
                cmd1.Parameters.AddValue("@company", newCustomer.company);
                cmd1.Parameters.AddValue("@address", newCustomer.address);
                cmd1.Parameters.AddValue("@city", newCustomer.city);
                cmd1.Parameters.AddValue("@state", newCustomer.state);
                cmd1.Parameters.AddValue("@country", newCustomer.country);
                cmd1.Parameters.AddValue("@postal", newCustomer.postal);
                cmd1.Parameters.AddValue("@phone", newCustomer.phone);
                cmd1.Parameters.AddValue("@fax", newCustomer.fax);
                cmd1.Parameters.AddValue("@email", newCustomer.email);
                cmd1.Parameters.AddValue("@repId", newCustomer.repId);


            }catch(Exception e){
                Console.WriteLine(e.Message());
                connection.Close();
            }
            
            Console.WriteLine("SQL Demo Ending....");
        }
    }

    public class Customer{
        //fields
        public int? id {get; set;}
        public string? firstName {get; set;}
        public string? lastName {get; set;}
        public string? company {get; set;}
        public string? address {get; set;}
        public string? city {get; set;}
        public string? state {get; set;}
        public string? country {get; set;}
        public int? postal {get; set;}
        public string? phone {get; set;}
        public string? fax {get; set;}
        public string? email {get; set;}
        public int repId {get; set;}

        //constructor
        public Customer(int? id, string? firstName, string? lastName, 
        string? address, string? city, string? state){
            this.id=id;
            this.firstName=firstName;
            this.lastName=lastName;
            this.address=address;
            this.city=city;
            this.state=state;
        }
        public Customer(int? id, string? firstName, string? lastName, string? company,
        string? address, string? city, string? state, string? country,
        int? postal, string? phone, string? fax, string? email, int? repId){
            this.id=id;
            this.firstName=firstName;
            this.lastName=lastName;
            this.company=company;
            this.address=address;
            this.city=city;
            this.state=state;
            this.country=country;
            this.postal=postal;
            this.phone=phone;
            this.fax=fax;
            this.email=email;
            this.repId=repId;
        }
        //methods

        public void introduction(){
            Console.WriteLine($"ID: {this.id}\n FirstName: {this.firstName}\n LastName: {this.lastName}");
        }
    }
}