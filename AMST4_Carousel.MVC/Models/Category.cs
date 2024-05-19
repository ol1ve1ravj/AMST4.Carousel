﻿using Microsoft.VisualBasic;

namespace AMST4_Carousel.MVC.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual List<Product> Products { get; set; }
    }
}
