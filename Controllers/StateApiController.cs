using Core_APIsWithJenkinsPipeline.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_APIsWithJenkinsPipeline.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StateApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/state")]
        public List<State> GetStates() {
            List<State> lst = new List<State>();
            lst.Add(new State { StateId = 1,StateName="Maharashtra"});
            lst.Add(new State { StateId = 2, StateName = "Goa" });
            lst.Add(new State { StateId = 3, StateName = "Panjab" });
            lst.Add(new State { StateId = 4, StateName = "Gujrat" });
            lst.Add(new State { StateId = 5, StateName = "Kerala" });
            lst.Add(new State { StateId = 6, StateName = "Hariyana" });
            lst.Add(new State { StateId = 7, StateName = "Assam" });
            lst.Add(new State { StateId = 8, StateName = "Bihar" });
            return lst;

        }
    }
}
