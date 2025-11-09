namespace PrimaryConstructors.Models
{
    public class Product(int id, string name, string description, decimal price)
    {
        public int Id { get; } = id;

        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
        public decimal Price { get; private set; } = price;
        public DateTime CreatedAt { get; } = DateTime.UtcNow;


        // Methods that use primary constructor parameters
        public void Update(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public bool IsExpensive() => price > 1000;
    }
}
