using System;
using System.Collections.Generic;
using MongoDB.Driver;
using StudentManagement.Business.Entity;
using StudentManagement.Reporting;

namespace StudentManagement.DataAccess.Repository
{
    public class MongoDbReportRepository : IReportRepository
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _db;

        public MongoDbReportRepository(MongoClient client)
        {
            _client = client;
            _db = _client.GetDatabase("StudentReport");
        }

        public void Insert(StudentReport studentReport)
        {
            var studentCollection = _db.GetCollection<StudentReport>("StudentReport");

            studentCollection.InsertOne(studentReport);
        }

        public IList<StudentReport> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}