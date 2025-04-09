using AuctionsApp.Models;

namespace AuctionsApp.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
    }
}
