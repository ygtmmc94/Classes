using Classes.Customers.Concretes;
using Classes.Students;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person insan = new Person(); //intialization, insan bir intance yani obje 
            insan.Run();
            CustomerService customerService = new CustomerService();
            customerService.Add();
            customerService.Uptade();
            customerService.Delete();
            CustomerService customerService1;
            //customerService1.Add();
            var productservice = new ProductService();
            productservice.Add();
            productservice.Uptade();
            productservice.Delete();
            //productservice.AddUptadeDelete();
            EmployeeService employeeService = new EmployeeService();
            //Classes.Students.Student student = new Classes.Students.Student();
            Student student = new Student();
            student.List();
            Customer customer = new Customer();
            customer.Name = "Yiğit";
            customer.Surname = "Mmc";
            customer.City = "Ankara";
            customer.Id = 1;
            customer.SetAge(25);
            Console.WriteLine("Id: " + customer.Id + "\nName: " + customer.Name + " " + customer.Surname + "\nAge: " + customer.GetAge()+ "\nCity: " + customer.City);

            Console.ReadLine();
        }
    }

    class Person
    {
        public void Run() // Behavlor yani davranış.
        {
            Console.WriteLine("Person is running...");
        }
    }

    class CustomerService
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Uptade()
        {
            Console.WriteLine("Uptaded");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class ProductService
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Uptade()
        {
            Console.WriteLine("Uptaded");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void AddUptadeDelete()
        {
            this.Add();
            this.Uptade();
            this.Delete();
        }
    }
}
