namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>(GetCustomers());

            var query = customers.Where(n => n.City == "Dublin");

            foreach (var customer in query)
            {
                Console.WriteLine(customer.Name);
            }
        }
        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);  
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);
            
            return customers;
        }

        public class Customer
        {
            public string Name { get; set; }
            public string City { get; set; }
        }
    }
}
