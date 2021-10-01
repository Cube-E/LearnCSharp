using MongoDB.Driver;
using PersonalDataLibrary.Controller;

namespace PersonalDataLibary
{
    public class MongoConnector : IDataConnection
    {
        private IMongoDatabase _db { get; set; }
        private const string url = "mongodb+srv://admin:pass-word@mflix.akddw.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
        private const string database = "mflix";
        public MongoConnector()
        {
            InitializeConnection();
        }

        public void InitializeConnection()
        {
            var settings = MongoClientSettings.FromConnectionString(url);
            var client = new MongoClient(settings);
            _db = client.GetDatabase(database); 
        }

        public void InsertRecord<T>(string table, T record)
        {
            //private IMongoCollection collection;
            //var collection = db.GetCollection<T>(table);
            //collection.InsertOne(record);
        }
    }
}
