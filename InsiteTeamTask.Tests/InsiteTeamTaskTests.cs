using InsiteTeamTask.MockData;
using InsiteTeamTask.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace InsiteTeamTask.Tests
{
    [TestClass]
    public class InsiteTeamTaskTests
    {
        
        [TestMethod]
        public void GetAttendaceListByGameSeason()
        {
            // Arrange
            var mockDataService = new MockDataService();
            var repo = new DataRepository();
            var games = mockDataService.Games();
            var seasons = mockDataService.Seasons();

 
            // Act
            var attendanceList = repo.GetAttendanceListFor(games.First().Id,seasons.First().Id);

            // Assert
            Assert.IsNotNull(attendanceList);
        }

        [TestMethod]
        public void GetAttendaceListByProductcode()
        {
            // Arrange
           
            var repo = new DataRepository();
            string ProductCode = "IT93";
            // Act
            var attendanceList = repo.GetAttendanceListFor(ProductCode);

            // Assert
            Assert.IsNotNull(attendanceList);
        }
        [TestMethod]
        public void GetAttendaceListByProductcodeshouldBeZero()
        {
            // Arrange

            var repo = new DataRepository();
            string productCode = "IT18";
            // Act
            var attendanceList = repo.GetAttendanceListFor(productCode);

            // Assert
            Assert.AreEqual(0,attendanceList.Count);
        }
        [TestMethod]
        public void GetAttendaceListByProductcodeshouldBeMore()
        {
            // Arrange

            var repo = new DataRepository();
            string productCode = "CH5490";
            // Act
            var attendanceList = repo.GetAttendanceListFor(productCode);

            // Assert
            Assert.AreEqual(12, attendanceList.Count);
        }
        [TestMethod]
        public void GetAttendaceListByGameSeasonshouldBeZero()
        {
            // Arrange

            var repo = new DataRepository();
            int GameId = 4;
            int SeasonId = 20;
            // Act
            var attendanceList = repo.GetAttendanceListFor(GameId,SeasonId);

            // Assert
            Assert.AreEqual(0, attendanceList.Count);
        }
        [TestMethod]
        public void GetAttendaceListByGameSeasonshouldBeMore()
        {
            // Arrange

            var repo = new DataRepository();
            int GameId = 12;
            int SeasonId = 16;
            // Act
            var attendanceList = repo.GetAttendanceListFor(GameId, SeasonId);

            // Assert
            Assert.AreEqual(1, attendanceList.Count);
        }
    }
}
