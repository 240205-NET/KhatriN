using System;
using System.Text;
namespace Chinook.EF
{
    class Program {
        public static void Main(string[] args){
            Console.WriteLine("Chinook Starting..");
            var repo = new Repository();
            Console.WriteLine(repo.ListAllCustomers());
            bool loop = true;
            while(loop){
                Console.WriteLine(@"Select an action:
                1: List All Customers
                2: Add A Customer
                0: Exit
                ");
                string select = Console.ReadLine();
                switch(select){
                    case "1":
                        Console.WriteLine(repo.ListAllCustomers());
                        break;
                    case "2":
                        repo.AddNewCustomer();
                        break;
                    default:
                    loop=false;
                        break;
                }
            }
            // using (var context = new ChinookContext());
            // {
            //     foreach(var customer in context.Customers){
            //         Console.WriteLine(customer.FirstName);
            //     }
            // }
        }
    }

    class Repository
    {
        //fields
        private readonly ChinookContext  _context = new ChinookContext();
        //constructor
        public Repository()
        {
        }

        //methods
        public string ListAllCustomers(){
            var sb = new StringBuilder();
            foreach(var customers in _context.Customers){
                sb.AppendLine($"{customers.CustomerId}: {customers.FirstName}");
            }
            return sb.ToString();
        }

        public void AddNewCustomer(){
            var newCustomer = new Customer{
                CustomerId = 99,
                FirstName = "Richard",
                LastName = "Hawkins",
                Email = "RH@no.com"
            };
            _context.Add(newCustomer);
            _context.SaveChanges();

        }

        public void RemoveCustomer(){
            var customer = (Customer)_context.Customers.Where(c => c.CustomerId == 99).First();
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
