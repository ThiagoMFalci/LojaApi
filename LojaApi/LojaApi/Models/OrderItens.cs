namespace LojaApi.Models
{
    public class OrderItens
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
