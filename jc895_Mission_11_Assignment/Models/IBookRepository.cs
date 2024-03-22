namespace jc895_Mission_11_Assignment.Models
{
        public interface IBookRepository
        {
            public IQueryable<Book> Books { get; }
        }
    }
