using System;

namespace Lab1
{
   public static class Program
    {
        static void Main()
        {
            Manager manager = new Manager
            {
                Id = new Guid(),
                FirstName = "John",
                LastName = "Doe",
                StartDate = new DateTime(2010, 5, 10),
                EndDate = new DateTime(2009, 5, 10),
                Salary = 2000
            };
            Architect architect  = new Architect
            {
                Id = new Guid(),
                FirstName = "John",
                LastName = "Doe",
                StartDate = new DateTime(2010, 5, 10),
                EndDate = new DateTime(2009, 5, 10),
                Salary = 1500
            };
            Console.WriteLine(manager.IsActive());
            Console.WriteLine(manager.Salutation());
            Console.WriteLine(architect.Salutation());
            string sentence = "This is a sentence meant to be use. As a test.";
            Console.WriteLine(sentence.CountWord());
        }
    }
}