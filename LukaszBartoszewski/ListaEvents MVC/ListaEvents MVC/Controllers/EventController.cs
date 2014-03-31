using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IApplication;
using TxtRepo;

namespace ListaEvents_MVC.Controllers
{
    public class EventController : ApiController
    {
        // GET api/event
        public IEnumerable<Event> Get()
        {
            GetEventsFromIApplication getThem = new GetEventsFromIApplication();
            return getThem.Events();
        }

        // GET api/event/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/event
        public void Post([FromBody]string value)
        {
        }

        // PUT api/event/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/event/5
        public void Delete(int id)
        {
        }
    }
}
