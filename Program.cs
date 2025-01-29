namespace payroll
{
    class EmployeePayeollTimeoff
    {
        public int noOfWeeks;
        public int salary;


        public void PayrollTimeoff(int salary)
        {
            if (salary == 150)
            {

                Console.WriteLine("level 1 employe ");
                Console.WriteLine("leave for 5 weeks");
            }
            else
            {
                Console.WriteLine("no leave");
            }
        }
    }
    class Employee
    {
        public string name;

        public void work(string work)
        {
            Console.WriteLine("Work: " + work);

        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            // create Employee object 
            Employee e1 = new Employee();
            EmployeePayeollTimeoff p1 = new EmployeePayeollTimeoff();
            Console.WriteLine("Employee 1");

            // set name of the Employee 
            e1.name = "Gloria";
            Console.WriteLine("Name: " + e1.name);

            //call method of the Employee
            e1.work("Coding");
            //call method of the Employee

            p1.PayrollTimeoff(150);
            Console.ReadLine();
        }
    }
}
