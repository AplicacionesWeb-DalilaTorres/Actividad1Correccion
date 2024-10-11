using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Queries;
using CatchUpPlatform.News.Domain.Services;

namespace CatchUpPlatform.News.Application.Internal
{
    public class FavoriteSourceQueryService : IFavoriteSourceQueryService
    {
        public Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
        {
            // Logic for getting the favorite font by Id
            throw new NotImplementedException();
        }

        public Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
        {
            // Logic for getting the favorite font by NewsApiKey and SourceId
            throw new NotImplementedException();
        }
    }
}



