using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examination.Domain.SeedWork;
using MongoDB.Bson.Serialization.Attributes;

namespace Examination.Domain.AggregateModels.CategoryAggregate
{
    public class Category : Entity
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("urlPath")]
        public string UrlPath { get; set; }
    }
}