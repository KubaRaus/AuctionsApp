using AuctionsApp.Models;

namespace AuctionsApp.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
