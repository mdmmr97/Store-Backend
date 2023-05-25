using Store_Backend.Application;

namespace Store_Backend.Infraestructure.Rest
{
    public class PagedResponse<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public PagedList<T>? Data { get; set;}
    }
}