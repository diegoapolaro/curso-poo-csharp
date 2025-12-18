namespace Tax_payers_exercise__abstract_methods_.Entities
{
    abstract internal class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double annualIncome) 
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TotalTax();
    }
}
