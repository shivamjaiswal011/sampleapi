using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using events.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;

namespace events.Controllers
{
    [EnableCors("AnotherPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IMongoCollection<Eventdetail> Collection;

        private readonly IMongoCollection<Footer> Col;

        public EventsController(IMongoClient client)
        {
            var database = client.GetDatabase("events");
            Collection = database.GetCollection<Eventdetail>("Event");
            Col = database.GetCollection<Footer>("Footer");
        }

        [HttpGet]
        public object Get()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(Collection.Find(new BsonDocument()).ToList());
        }

        [Route("footer")]
        [HttpGet]
        public object Getfooter()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(Col.Find(new BsonDocument()).ToList());
        }








    }
}
