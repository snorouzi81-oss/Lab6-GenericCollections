

namespace Lab6_GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Johan", "Male", 45000);
            Employee employee2 = new Employee(2, "Tobias", "Male", 40000);
            Employee employee3 = new Employee(3, "Alex", "Male", 25000);
            Employee employee4 = new Employee(4, "Lena", "Female", 35000);
            Employee employee5 = new Employee(5, "Ulrika", "Female", 30000);
            Employee employee = new Employee();

            Console.WriteLine("--------------Del 1 – Stack-------------");
            Stack<Employee> StackEmployee = new Stack<Employee>();
            StackEmployee.Push(employee1);
            StackEmployee.Push(employee2);
            StackEmployee.Push(employee3);
            StackEmployee.Push(employee4);
            StackEmployee.Push(employee5);

            Console.WriteLine("-------------Skriv ut alla objekt i stacken:------------");
            foreach (var e in StackEmployee)
            {
                Console.WriteLine($"***{StackEmployee.Count} objekt finns kvar i stacken.***");
                Console.WriteLine($"{e.Id}, {e.Name}, {e.Gender},{e.Salary}");

            }

            Console.WriteLine("------------Hämta alla objekt med Pop-metoden--------------");

            while (StackEmployee.Count > 0)
            {
                employee = StackEmployee.Pop();

                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender}, {employee.Salary}");
                Console.WriteLine($"*****{StackEmployee.Count} objekt finns kvar i stacken.*****");
            }


            StackEmployee.Push(employee1);
            StackEmployee.Push(employee2);
            StackEmployee.Push(employee3);
            StackEmployee.Push(employee4);
            StackEmployee.Push(employee5);

            Console.WriteLine("-----Hämta två objekt med Peek()-metoden.----");
            Console.WriteLine($"***{StackEmployee.Count} objekt finns kvar i stacken.***");
            employee = StackEmployee.Peek();
            Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender},{employee.Salary}");
            Console.WriteLine($"***{StackEmployee.Count} objekt finns kvar i stacken.***");
            employee = StackEmployee.Peek();
            Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender},{employee.Salary}");

            Console.WriteLine("----Kolla om objekt nummer 3 finns i stacken eller inte.-----");
            if (StackEmployee.Contains(employee3))
            {
                Console.WriteLine($"Objekt nummer 3 finns i stacken. ");
            }
            else
            {
                Console.WriteLine("Objekt nummer 3 finns inte i stacken.");
            }


            Console.WriteLine("-------------Del 2 – List-----------");
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(employee1);
            listEmployees.Add(employee2);
            listEmployees.Add(employee3);
            listEmployees.Add(employee4);
            listEmployees.Add(employee5);

            if (listEmployees.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine("----------hitta och skriva ut det första objektet i listan som har Gender = \"Male\"----------");
            Employee? findEmployee = listEmployees.Find(e => e.Gender == "Male");

            if (findEmployee != null)
            {
                Console.WriteLine($"{findEmployee.Id}, {findEmployee.Name}, {findEmployee.Gender},{findEmployee.Salary}");
            }

            Console.WriteLine("----------hitta och skriva ut alla objekt i listan som har Gender = Male ---------");
            List<Employee> findAllEmployee = listEmployees.FindAll(e => e.Gender == "Male");
            foreach (Employee e in findAllEmployee)
            {
                Console.WriteLine($"{e.Id}, {e.Name}, {e.Gender}, {e.Salary}");
            }
        }
    }
}
