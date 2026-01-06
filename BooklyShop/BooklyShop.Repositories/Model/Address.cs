using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class Address : BaseModel
    {
        public string? Location { get; set; }
        public User? User { get; set; }
    }
}
