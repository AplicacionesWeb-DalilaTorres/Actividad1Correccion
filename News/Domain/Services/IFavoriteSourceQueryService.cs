using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Model.Queries;

namespace CatchUpPlatform.News.Domain.Services
{
    public interface IFavoriteSourceQueryService
    {
        Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
        Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
    }
}
