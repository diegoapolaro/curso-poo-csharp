namespace Tax_payers_exercise__abstract_methods_.Entities
{
    internal class Company : TaxPayer
    {
        public int Employess { get; set; }

        public Company() { }

        public Company(string name, double annualIncome, int employess) : base(name, annualIncome)
        {
            Employess = employess;
        }



        public override double TotalTax()
        {
            if (Employess > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
