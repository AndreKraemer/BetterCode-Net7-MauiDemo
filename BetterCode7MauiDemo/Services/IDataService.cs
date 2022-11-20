using BetterCode7MauiDemo.Models;
namespace BetterCode7MauiDemo.Services;

public interface IDataService
{
    Task<Session> GetSessionAsync(int id);
    Task<IEnumerable<Session>> GetSessionsAsync();
    Task<Speaker> GetSpeakerAsync(int id);
    Task<IEnumerable<Speaker>> GetSpeakersAsync();
}
