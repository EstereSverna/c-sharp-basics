namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {  
            var employee = new Employee("Chris", "Anderson", "adress - 1", 232, "Doctor");
            employee.Display();
            var student = new Student("Ernest", "Adamson", "adress - 2", 234, 3.4);
            student.Display();
        }
    }
}