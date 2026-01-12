using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class Books : BaseModel
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<BookImages> BookImages { get; set; }
    }
}
