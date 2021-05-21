using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson.Serialization.Attributes;

namespace events.Models
{
    [BsonIgnoreExtraElements]
    public class Eventdetail
    {
        public string Tittle { get; set; }

        public string Location { get; set; }

        public string Price { get; set; }

        public string Date { get; set; }

        public string About { get; set; }

        public string Learn { get; set; }

        public string Imagename { get; set; }

        [NotMapped]
        public string Imagesrc { get; set; }

        [NotMapped]
        public IFormFile Imagefile { get; set; }

        public Eventdetail()
        {
        }
    }
}
