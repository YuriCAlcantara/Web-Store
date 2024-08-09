namespace ModernWebStore.Domain.Entities
{
    public class Product
    {
        public Product(string title, string description, decimal price, int quantityOn, int categoryId)
        {
            Title = title;
            Description = description;
            Price = price;
            QuantityOn = quantityOn;
            CategoryId = categoryId;
            
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOn { get; private set; }
        public int CategoryId { get; private set; } //Referência o Id da minha classe Category
        public Category Category { get; private set; } 
    }
}
