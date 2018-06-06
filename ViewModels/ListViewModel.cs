namespace ViewModels
{
    public class ListViewModel
    {
        public int PageSize { get; set; } = 10;
        public int PageIndex { get; set; } = 1;
        public string Sort { get; set; } = null;
        public string Filter { get; set; } = null;
    }
}