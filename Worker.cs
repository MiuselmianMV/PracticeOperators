using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOperators
{
    public class Worker:Object
    {
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }

        public int Salary { get; set; }



        public Worker(string fullName, string birthDate, string contactNumber, string email, string position, string description, int salary)
        {
            FullName = fullName;
            BirthDate = birthDate;
            ContactNumber = contactNumber;
            Email = email;
            Position = position;
            Description = description;
            Salary = salary;
        }

        public void Show()
        {
            Console.WriteLine("FullName: {0}", FullName);
            Console.WriteLine("BirthDate: {0}", BirthDate);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Contact number: {0}", ContactNumber);
            Console.WriteLine("Position: {0}", Position);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Salary: {0}", Salary);
        }

        public static Worker operator + (Worker frst, int number)
        {
            frst.Salary += number;
            return frst;
        }

        public static Worker operator - (Worker frst, int number)
        {
            frst.Salary -= number;
            return frst;
        }

        public static bool operator == (Worker frst, Worker scnd)
        {
            if (frst.Salary == scnd.Salary)
                return true;

            return false;
        }

        public static bool operator != (Worker frst, Worker scnd)
        {
            if (frst.Salary != scnd.Salary)
                return true;

            return false;
        }

        public static bool operator > (Worker frst, Worker scnd)
        {
            if (frst.Salary > scnd.Salary)
                return true;

            return false;
        }

        public static bool operator < (Worker frst, Worker scnd)
        {
            if (frst.Salary < scnd.Salary)
                return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Worker other)
            {
                return this.Salary == other.Salary;
            }
            return false;


        }


    }
}
