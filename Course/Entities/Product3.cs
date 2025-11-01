

namespace Course.Entities
{
    class Product3
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product3(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //vou considerar que pra ser igual o nome e price precisa ser igual
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Product3))
            {
                return false;
            }
            Product3 other = obj as Product3;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
