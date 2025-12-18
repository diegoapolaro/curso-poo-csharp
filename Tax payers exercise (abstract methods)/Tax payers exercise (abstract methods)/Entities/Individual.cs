using System.Reflection.Metadata.Ecma335;

namespace Tax_payers_exercise__abstract_methods_.Entities
{
    internal class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome) {HealthExpenditures = healthExpenditures;}

        public override double TotalTax()
        {
         if (AnnualIncome < 20000.00) 
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
