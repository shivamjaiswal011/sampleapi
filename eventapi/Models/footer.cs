using System;
using MongoDB.Bson.Serialization.Attributes;

namespace events.Models
{
    [BsonIgnoreExtraElements]
    public class Footer
    {

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Email { get; set; }

        public Footer()
        {
        }
    }
}
