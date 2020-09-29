using InsiteTeamTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsiteTeamTask.Repositories
{
    public interface IDataRepository
    {
        List<Attendance> GetAttendanceListFor(int gameNumber, int seasonNumber);
        List<Attendance> GetAttendanceListFor(string productCode);
        List<Game> GetGames();
        List<Product> GetProducts();
        List<Event> GetEvents();
        List<Season> GetSeasons(int eventId);
    }
}
