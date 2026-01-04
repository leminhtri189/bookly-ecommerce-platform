using BooklyShop.Presentation.Models;

namespace BooklyShop.Presentation.Infrastructure
{
    public static class SampleBookCatalog
    {
        private static readonly List<BookViewModel> Books = new()
        {
            new BookViewModel
            {
                Id = 1,
                Title = "Clean Code",
                Author = "Robert C. Martin",
                Category = "Software",
                Price = 18.90m,
                Description = "A handbook of agile software craftsmanship."
            },
            new BookViewModel
            {
                Id = 2,
                Title = "The Pragmatic Programmer",
                Author = "Andrew Hunt & David Thomas",
                Category = "Software",
                Price = 21.50m,
                Description = "Journey to mastery with practical advice for developers."
            },
            new BookViewModel
            {
                Id = 3,
                Title = "Deep Work",
                Author = "Cal Newport",
                Category = "Productivity",
                Price = 13.75m,
                Description = "Rules for focused success in a distracted world."
            },
            new BookViewModel
            {
                Id = 4,
                Title = "Atomic Habits",
                Author = "James Clear",
                Category = "Self-Help",
                Price = 12.40m,
                Description = "An easy & proven way to build good habits and break bad ones."
            }
        };

        public static IReadOnlyList<BookViewModel> GetAll() => Books;

        public static BookViewModel? GetById(int id) => Books.FirstOrDefault(x => x.Id == id);
    }
}
