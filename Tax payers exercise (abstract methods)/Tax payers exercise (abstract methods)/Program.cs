using System;
using System.Globalization;
using System.Collections.Generic;
using Tax_payers_exercise__abstract_methods_.Entities;

List < TaxPayer > taxPayers = new List<TaxPayer>();


Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char ic = char.Parse(Console.ReadLine());
    if ( ic == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income: ");
        double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
    }
    else if (ic == 'c')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income: ");
        double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Number of employees: ");
        int employess = int.Parse(Console.ReadLine());
        taxPayers.Add(new Company(name, annualIncome, employess));
    }
}


Console.WriteLine();
Console.WriteLine("TAXES PAID: ");

foreach(TaxPayer taxPayer in taxPayers)
{
    Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.TotalTax().ToString("F2", CultureInfo.InvariantCulture));
}