using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
    public class Order
    {
        public Order(IList<OrderItem> orderItems, int userId)
        {

            this.Date = DateTime.Now;
            this.OrderItems = orderItems;
            this.UserId = userId;

        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; } //Icollection é um tipo de lista, só que mais "leve".
        public int UserId { get; private set; }
        public User User { get; private set; }

        public void AddItem(OrderItem item)
        {
            if (item == null)
                throw new Exception("Invalid Item!");

            if (item.Price <= 0)
                throw new Exception("Invalid Price");

            if (item.Quantity <= 0)
                throw new Exception("Invalid Quantity");
        }
    }
}
