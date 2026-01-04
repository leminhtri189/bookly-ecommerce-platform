namespace BooklyShop.Presentation.Models
{
    public class CartLineViewModel
    {
        public BookViewModel Book { get; set; } = new();
        public int Quantity { get; set; }
        public decimal LineTotal => Book.Price * Quantity;
    }
}
