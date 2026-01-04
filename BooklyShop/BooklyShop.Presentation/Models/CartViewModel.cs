namespace BooklyShop.Presentation.Models
{
    public class CartViewModel
    {
        public IReadOnlyList<CartLineViewModel> Lines { get; set; } = Array.Empty<CartLineViewModel>();
        public decimal Total => Lines.Sum(x => x.LineTotal);
    }
}
