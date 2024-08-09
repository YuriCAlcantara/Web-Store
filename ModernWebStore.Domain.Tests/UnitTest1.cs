using ModernWebStore.Domain.Entities;

namespace ModernWebStore.Domain.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var category = new Category("Motherboard");
            var product = new Product("Processador", "Intel I7", 1200, 5, 1);

            var order = new Order(new List<OrderItem>(), 1);
            order.AddItem(null);



            //Salvar categoria

            Assert.AreNotEqual(0, order.OrderItems);
        }
    }
}