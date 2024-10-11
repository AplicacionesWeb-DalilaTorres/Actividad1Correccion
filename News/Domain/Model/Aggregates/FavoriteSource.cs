namespace CatchUpPlatform.News.Domain.Model.Aggregates
{
    /// FavoriteSource Aggregate
    /// <summary>
    /// This class represents the FavoriteSource aggregate. It is used to store the favorite sources of a user.
    /// </summary>
    public class FavoriteSource
    {
        // Unique identifier for the favorite font
        public int Id { get; private set; }
        // API Key for the news source
        public string NewsApiKey { get; private set; }
        // Source identifier (source ID)
        public string SourceId { get; private set; }

        // Empty constructor to allow the creation of an empty instance
        public FavoriteSource()
        {
            this.NewsApiKey = string.Empty;
            this.SourceId = string.Empty;
        }

        // Constructor that initializes the properties of a favorite font
        public FavoriteSource(int id, string newsApiKey, string sourceId)
        {
            Id = id;
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }

        // Method to update the favorite font (can be expanded as needed)
        public void UpdateSource(string newsApiKey, string sourceId)
        {
            NewsApiKey = newsApiKey;
            SourceId = sourceId;
        }

    }
}
