namespace PayRollApp.Entities
{
    public class Hr : Employee
    {
        public double GratuityPayment { get; set; }
        public Hr() { }
        public Hr(int id, string name, double basiPayment, double daPayment, double hraPayment, double gratuityPayment) : base(id, name, basiPayment, daPayment, hraPayment)
        {
            GratuityPayment = gratuityPayment;
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalSalary += GratuityPayment;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {GratuityPayment}";
        }
    }
}
