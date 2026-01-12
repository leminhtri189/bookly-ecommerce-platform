using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class BookImages : BaseModel
    {
        public string ImageUrl { get; set; }
        public Guid BookId { get; set; }
        public virtual Books Book { get; set; }
    }
}
