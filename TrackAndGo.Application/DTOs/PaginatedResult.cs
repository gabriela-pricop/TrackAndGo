namespace TrackAndGo.Application.DTOs
{
    public class PaginatedResult<T>
    {
        public PaginatedResult(int totalCount, int page, int pageSize, List<T> items)
        {
            TotalCount = totalCount;
            PageNumber = page;
            PageSize = pageSize;
            Items = items;
        }

        public int TotalCount { get; set; }
        public int PageNumber {  get; set; }
        public int PageSize { get; set; }
        public List<T> Items { get; set; } = [];
    }
}
