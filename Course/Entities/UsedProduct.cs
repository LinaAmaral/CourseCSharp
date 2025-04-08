

namespace Course.Entities
{
    class UsedProduct: Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedate):base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            return $"{Name} (usado) ${Price.ToString()} (Data de fabricação: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
