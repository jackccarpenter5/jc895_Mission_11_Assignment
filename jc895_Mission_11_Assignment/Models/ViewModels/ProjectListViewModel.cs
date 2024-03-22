namespace jc895_Mission_11_Assignment.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
