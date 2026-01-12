using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public virtual ICollection<Books>? Books { get; set; }
    }
}
