namespace eRezervacija.API.Helpers
{
	public class PagedList<T>
	{
		public List<T> DataItems { get; set; } = new List<T>();

		public int CurrentPage { get; }

		public int TotalPages { get; }

		public int PageSize { get; }

		public int TotalCount { get; }

		public bool HasPrevios => CurrentPage > 1;

		public bool HasNext => CurrentPage < TotalPages;
		private PagedList(List<T> items, int totalCount, int pageNumber, int pageSize)
		{
			TotalCount = totalCount;
			CurrentPage = pageNumber;
			PageSize = pageSize;
			TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
			this.DataItems.AddRange(items);
		}

		public static PagedList<T> Create(IQueryable<T> source, int pageNumber, int pageSize)
		{
			var totalCount = source.Count();
			var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
			return new PagedList<T>(items, totalCount, pageNumber, pageSize);
		}
	}
}
