namespace YoutubeClient.Models
{
    public class YoutubeResponse
    {
        public Item[] items { get; set; }

        public class Item
        {
            public string id { get; set; }
            public Snippet snippet { get; set; }

            public class Snippet
            {
                public string title { get; set; }
                public string description { get; set; }
            }
        }
    }
}
