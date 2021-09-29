using MongoDB.Driver;

namespace PersonalDataLibary
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        //private IMongoCollection collection;
        public MongoCRUD(string database)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:pass-word@mflix.akddw.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            db = client.GetDatabase("mflix");
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

         public void LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

        }



    }
}
