using CatchUpPlatform.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.News.Domain.Services
{
    public interface IFavoriteSourceCommandService
    {
        Task CreateFavoriteSource(FavoriteSource favoriteSource);
        Task UpdateFavoriteSource(FavoriteSource favoriteSource);
        Task DeleteFavoriteSource(int id);
    }
}
