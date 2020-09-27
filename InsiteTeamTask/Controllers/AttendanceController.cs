using System.Collections.Generic;
using InsiteTeamTask.Models;
using InsiteTeamTask.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InsiteTeamTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IDataRepository dataRepository;

        public AttendanceController(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
        // GET api/values
        [Route("{gameNumber:int}/{seasonNumber:int}")]
        [HttpGet]
        public ActionResult<IEnumerable<Attendance>> Get(int gameNumber, int seasonNumber)
        {
            var attendance = dataRepository.GetAttendanceListFor(gameNumber, seasonNumber);

            return Ok(attendance);
        }

        [Route("{productCode}")]
        [HttpGet]
        public ActionResult<IEnumerable<Attendance>> Get(string productCode)
        {
            var attendance = dataRepository.GetAttendanceListFor(productCode);

            return Ok(attendance);
        }
    }
}
