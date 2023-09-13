using System;

namespace PayRollApp.Entities
{
    public class Employee
    {
        //automatic properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicPayment { get; set; }
        public double DaPayment { get; set; }
        public double HraPayment { get; set; }
        public double TotalSalary { get; protected set; }

        public Employee()
        {

        }

        public Employee(int id, string name, double basiPayment, double daPayment, double hraPayment)
        {
            Id = id;
            Name = name;
            BasicPayment = basiPayment;
            DaPayment = daPayment;
            HraPayment = hraPayment;
        }
        public virtual void CalculateSalary()
        {
            TotalSalary = BasicPayment + DaPayment + HraPayment;
        }

        public override string ToString()
        {
            return $"{Name}, {Id}, {TotalSalary}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Employee)
            {
                Employee employee = (Employee)obj;
                if (employee.Id != this.Id)
                    return false;

                return true;
            }
            else
                return false;
        }
    }
}
