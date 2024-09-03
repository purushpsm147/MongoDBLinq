using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBLinq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var dbClient = new MongoClient("");

        //var dbList = dbClient.ListDatabases().ToList();
        //Console.WriteLine("The list of databases are : ");
        //foreach (var db in dbList)
        //{
        //    Console.WriteLine(db);
        //}

        var database = dbClient.GetDatabase("sample_training");
        var collection = database.GetCollection<BsonDocument>("grades");

        //var document = new BsonDocument
        //{
        //    { "student_id", 10000 },
        //    { "scores", new BsonArray
        //        {
        //        new BsonDocument{ {"type", "exam"}, {"score", 88.12334193287023 } },
        //        new BsonDocument{ {"type", "quiz"}, {"score", 74.92381029342834 } },
        //        new BsonDocument{ {"type", "homework"}, {"score", 89.97929384290324 } },
        //        new BsonDocument{ {"type", "homework"}, {"score", 82.12931030513218 } }
        //        }
        //    },
        //    { "class_id", 480}
        //};

        //collection.InsertOne(document);
        //await collection.InsertOneAsync(document);

        Console.WriteLine("\r\nTo Read documents in MongoDB, we use the Find() method");
        var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();
        Console.WriteLine(firstDocument.ToString());

        Console.WriteLine("\r\nWe can pass the filter into the Find() method to get the first document that matches the query");
        var filter = Builders<BsonDocument>.Filter.Eq("student_id", 10000);
        var studentDocument = collection.Find(filter).FirstOrDefault();
        Console.WriteLine(studentDocument.ToString());

        Console.WriteLine("\r\nReading All Documents in a Collection");
        //var allDocuments = collection.Find(new BsonDocument()).ToList();

        var highExamScoreFilter = Builders<BsonDocument>.Filter.ElemMatch<BsonValue>(
            "scores", new BsonDocument { { "type", "exam" }, 
                { "score", new BsonDocument { { "$gt", 90 } } } 
            });

        var highExamScores = collection.Find(highExamScoreFilter).ToList();

    }

}


