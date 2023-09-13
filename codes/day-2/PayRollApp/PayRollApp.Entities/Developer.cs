using System;

namespace PayRollApp.Entities
{
    public sealed class Developer : Employee
    {
        public double IncentivePayment { get; set; }

        public Developer()
        {
        }
        public Developer(int id, string name, double basiPayment, double daPayment, double hraPayment, double incentivePayment) : base(id, name, basiPayment, daPayment, hraPayment)
        {
            IncentivePayment = incentivePayment;
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalSalary += IncentivePayment;
        }
        //public sealed override string ToString()
        public override string ToString()
        {
            return $"{base.ToString()}, {IncentivePayment}";
        }
    }
}
