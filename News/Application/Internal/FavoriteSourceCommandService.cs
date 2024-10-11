using Catchup_Platform.News.Domain.Model.Commands;
using CatchUpPlatform.News.Domain.Model.Aggregates;
using CatchUpPlatform.News.Domain.Services;

namespace CatchUpPlatform.News.Application.Internal
{
    public class FavoriteSourceCommandService : IFavoriteSourceCommandService
    {
        private readonly List<FavoriteSource> _dataStore = new();

        public Task CreateFavoriteSource(CreateFavoriteSourceCommand command)
        {
            var newFavoriteSource = new FavoriteSource(new Random().Next(), command.NewsApiKey, command.SourceId);
            _dataStore.Add(newFavoriteSource);
            return Task.CompletedTask;
        }

        public Task UpdateFavoriteSource(UpdateFavoriteSourceCommand command)
        {
            var favoriteSource = _dataStore.FirstOrDefault(fs => fs.Id == command.Id);
            if (favoriteSource == null)
            {
                throw new Exception("Favorite source not found");
            }
            favoriteSource.UpdateSource(command.NewsApiKey, command.SourceId);
            return Task.CompletedTask;
        }

        public Task DeleteFavoriteSource(DeleteFavoriteSourceCommand command)
        {
            var favoriteSource = _dataStore.FirstOrDefault(fs => fs.Id == command.Id);
            if (favoriteSource == null)
            {
                throw new Exception("Favorite source not found");
            }
            _dataStore.Remove(favoriteSource);
            return Task.CompletedTask;
        }
    }

}




