namespace ModernWebStore.Domain.Entities
{
    public class Category
    {

        public Category(string title) //Limitar alguem a informar o que terá
        {
            this.Title = title;
        }
        public int Id { get; private set; }
        public string Title { get; private set; }

    }
}
