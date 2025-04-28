using SAP.SharedContext;

namespace SAP.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Url = url;
            Title = title;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}