using System;

namespace Лб2__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            Employee employee = new Employee("Зайдун", "Денис");
            employee.Salary();
            employee.GetInfo();

            Console.ReadKey();
        }
    }
}
