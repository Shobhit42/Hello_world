using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hello_world
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Salary { get; set;}
    }

    public static class DataManager{
        public static List<Employees> GetData() {
            return new List<Employees>
            {
                new Employees {Id = 1 , Name = "John" , Gender = "Male" , Age = 20 , Salary = 10000},
                new Employees {Id = 2 , Name = "Jenifer" , Gender = "Female" , Age = 21 , Salary = 20000},
                new Employees {Id = 3 , Name = "Josef" , Gender = "Male", Age = 22, Salary = 20000},
                new Employees {Id = 4 , Name = "Jack" , Gender = "Male", Age = 23, Salary = 15000},
                new Employees {Id = 5 , Name = "John" , Gender = "Male" , Age = 22, Salary = 20000},
                new Employees {Id = 6 , Name = "Jenifer" , Gender = "Female" , Age = 25, Salary = 10000},
                new Employees {Id = 7 , Name = "Jimmy" , Gender = "Male", Age = 28, Salary = 30000},
                new Employees {Id = 8 , Name = "Amy" , Gender = "Female", Age = 25, Salary = 10000}
            };
        }
    }
    public class Customer
    {
        public int Id;
        public string Name;
        // public List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

    }

    public abstract class ParentClass
        
    {
        public ParentClass(int x)
        {
            Console.WriteLine("inside constructor of parent class");
        }
        public abstract void ParentClassMethod();
    }

    //public class Order : ParentClass
    //{
    //    override public void ParentClassMethod()
    //    {
    //        Console.WriteLine("Called");
            
    //    }
    //}
    
    internal class Program
    {

        static void Main(string[] args)
        {
            ParentClass p = new ParentClass();
            p.ParentClassMethod();
            Order o = new Order();
            o.ParentClassMethod();
            Console.WriteLine("Called");
            Console.ReadLine();


            //List<Employees> list = DataManager.GetData();

            // Select and Distinct
            //IEnumerable<string> name = list.Select(e => e.Name).Distinct();
            //foreach(string n in name)
            //{
            //    Console.WriteLine(n);
            //}


            // OrderBy and ThenBy
            //list = list.OrderBy(e => e.Salary).ThenBy(e=> e.Age).ToList();
            //foreach (Employees emp in list) {
            //    Console.WriteLine(emp.Name + " " + emp.Salary);
            //}


            // Where Clause for filtering
            //list = list.Where(e => e.Age >= 25 && e.Salary>20000).OrderBy(e => e.Age).ToList();
            //foreach (Employees emp in list) {
            //    Console.WriteLine(emp.Name + " " + emp.Age);
            //}


            // First or Last
            //Employees emp = list.FirstOrDefault(e => e.Name == "John");
            //Console.WriteLine(emp.Name + " " + emp.Age);


            // Single - Single hee milna chahiye , not more than 1 and less than 1
            // Employees emp = list.Single(e => e.Name == "hf");


            // Take and Property - to fetch 2 element from top or middle and skip for skipping the element
            // list = list.Take(5).ToList();

            // Aggregating properties
            //Console.WriteLine(list.Any(e => e.Age>20)); // True
            //Console.WriteLine(list.All(e => e.Age>30)); // False
            //Console.WriteLine(list.Count(e => e.Name == "John"));
            //Console.WriteLine(list.Sum(e => e.Salary));
            //Console.WriteLine(list.Where(e => e.Age>25).Average(e => e.Salary));
            //Console.WriteLine(list.Max(e => e.Salary));

            // MinBY - Returns the emp whos salary is minimum


            // Console.ReadLine();
            //var customer = new Customer(1);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());
            //Console.WriteLine(customer.Orders.Count);
            //Console.ReadLine();

            //string s = "abc";
            //s = s + 'a';
            //Console.WriteLine(s);
            //Console.ReadLine();

            //object obj1 = "sample1";
            //string s1 = obj1.ToString();


            //string s2 = "sample2";
            //object obj2 = s2;

            //int x = 100;
            //string s = Convert.ToString(x);

            //long l1 = 10000000000000;
            //int x1 = Convert.ToInt32(l1);
            //Console.WriteLine(x1);
            //Console.ReadLine();
            //int y1 = (int)(l1);

            //int x2 = 1000;
            //long l2 = x2;


            practiceRefOut();

        }

        private static void practiceRefOut()
        {
            int input = 10;
            refOut(ref input);
            Console.WriteLine(input);
            Console.ReadLine();
        }

        private static void refOut(ref int v)
        {
            v = v + 10;
        }

        static void sample(out int x)
        {
            x = 1;
        }
    }
}
