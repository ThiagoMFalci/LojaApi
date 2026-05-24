using System.Data;

namespace LojaApi.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        public int Price { get; set; }
        public int Quantity { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    }
}
