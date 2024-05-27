using Microsoft.VisualBasic;

namespace AMST4_Carousel.MVC.Models
{
    /// <summary>
    /// <Author>Andrey Bertoletti</Author>
    /// </summary>
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual List<Product> Products { get; set; }
    }
}
