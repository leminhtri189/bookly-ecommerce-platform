using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class Transaction : BaseModel
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
    }
}
