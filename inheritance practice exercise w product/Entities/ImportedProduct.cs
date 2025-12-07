using System.Globalization;

namespace inheritance_practice_exercise_w_product.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        { 
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag() + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
