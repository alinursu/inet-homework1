using System;

namespace Lab1
{
    public  class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }
        
        public string GetFullName() => FirstName + LastName;

        public bool IsActive() => (EndDate - StartDate).Ticks > 0;
        public virtual string Salutation() =>  "Hello employee";
    }
}