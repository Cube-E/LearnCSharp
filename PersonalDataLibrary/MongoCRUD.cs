using MongoDB.Driver;

namespace PersonalDataLibary
{
    public class MongoCRUD
    {
        private IMongoDatabase db;
        private IMongoCollection<PersonalDataModel> collection;

        //private IMongoCollection collection;
        private MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);

        }
    }
}
