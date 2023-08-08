using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examination.Domain.SeedWork;
using Examination.Dtos.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace Examination.Domain.AggregateModels.ExamResultAggregate
{
    public class QuestionResult : Entity
    {
        public QuestionResult() { }
        public QuestionResult(string id, string content, QuestionType questionType, Level level,
            List<AnswerResult> answers, string explain, bool? result)
        {
            Id = id;
            Content = content;
            QuestionType = questionType;
            Level = level;
            Explain = explain;
            Result = result;
            Answers = answers;
        }
        [BsonElement("content")]
        public string Content { get; set; }
        [BsonElement("questionType")]
        public QuestionType QuestionType { get; set; }
        [BsonElement("level")]
        public Level Level { get; set; }
        [BsonElement("explain")]
        public string Explain { get; set; }
        [BsonElement("answers")]
        public List<AnswerResult> Answers { set; get; }
        [BsonElement("result")]
        public bool? Result { get; set; }
    }
}