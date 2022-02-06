namespace TaskProducts.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return $"{Id}. {Category.Name}-{Name}:{Price}";
        }
    }
}
