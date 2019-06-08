using CommicBookGallery.Models;

namespace CommicBookGallery.Data
{
    internal class ComicBook : CommicBook
    {
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}