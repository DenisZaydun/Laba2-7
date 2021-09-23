using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лб2__7
{
    class Employee
    {
        private string _name, _surname, _position;
        private int _lengthOfWork;
        private double _salary = 8000, _tax;

        public Employee(string surname, string name)
        {
            _surname = surname;
            _name = name;

            if (_name == "Денис" && _surname == "Зайдун")
            {
                _lengthOfWork = 20;
                _position = "Project Manager";
            }
        }

        public void Salary()
        {
            if (_lengthOfWork < 3)
            {
                _salary = _salary * 1.2;
            }
            else if(_lengthOfWork > 3 && _lengthOfWork < 5)
            {
                _salary = _salary * 1.5;
            }
            else if (_lengthOfWork > 5 && _lengthOfWork < 10)
            {
                _salary = _salary * 2;
            }
            else if (_lengthOfWork > 10 && _lengthOfWork <= 20)
            {
                _salary = _salary * 3;
            }

            if (_position == "Project Manager")
            {
                _salary = _salary * 1.8;
            }
            else if (_position == "Team Leader")
            {
                _salary = _salary * 1.9;
            }
            else if (_position == "System(s) Administrator")
            {
                _salary = _salary * 1.2;
            }
            else if (_position == "Network Administrator")
            {
                _salary = _salary * 1.1;
            }
            else if (_position == "Software Developer")
            {
                _salary = _salary * 1.5;
            }
            else
            {
                _salary = _salary * 1;
            }

            _tax =(18 + 1.5)/100 * _salary;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Прізвище: {_surname}");
            Console.WriteLine($"Ім'я: {_name}");
            Console.WriteLine($"Посада: {_position}");
            Console.WriteLine($"Зарплатня: {_salary}$");
            Console.WriteLine($"Податковий збір: {_tax}$");
        }
    }
}
