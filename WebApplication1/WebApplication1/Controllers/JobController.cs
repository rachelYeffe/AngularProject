using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        static List<Job> Jobs = new List<Job>() {
            new Job
            {
                Field = Field.QA,
                Requirements = "כישורי בדיקות אוטומטיות",
                ScopeOfHours = 40,
                Area = "Tel Aviv",
                Hybrid = false
            },
            new Job
            {
                Field = Field.Server,
                Requirements = "ניסיון בפיתוח בסביבת שרת",
                ScopeOfHours = 45,
                Area = "Haifa",
                Hybrid = true
            },
            new Job
            {
                Field = Field.Client,
                Requirements = "יכולת עבודה עם ממשקי משתמש",
                ScopeOfHours = 35,
                Area = "Jerusalem",
                Hybrid = false
            }
        };

        [HttpGet("GetAllJobs")]
        public ActionResult<IEnumerable<Job>> GetAllJobs()
        {
            return Ok(Jobs);
        }

        [HttpPost("AddJob")]
        public ActionResult AddJob([FromBody] Job newJob)
        {
            Jobs.Add(newJob);
            return Ok();
        }
    }
}
