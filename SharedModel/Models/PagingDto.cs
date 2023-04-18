namespace SharedModel.Models
{
    public class PagingDto
    {
    }
    public class PagingRequestDto
    {
        public string? SearchTerm { get; set; }
        public string? ColumnName { get; set; }
        const int maxPageSize = 100;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 5;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

    }

    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public MetaData MetaData { get; set; }
    }
    public class MetaData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public bool HasLastPage => CurrentPage != TotalPages;
        public bool HasFirstPage => CurrentPage > 1;
    }
}
