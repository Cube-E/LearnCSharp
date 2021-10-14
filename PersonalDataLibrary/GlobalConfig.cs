using PersonalDataLibary;
using PersonalDataLibrary.Connectors;
using PersonalDataLibrary.Controller;
using PersonalDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; set; }

        /// <summary>
        /// Creates connections and adds them to the connections list.
        /// </summary>
        /// <param name="isMongo"></param>
        /// <param name="isTextFiles"></param>
        public static void InitializeConnections(bool isMongo, bool isTextFiles) {
            if (isMongo) {
                MongoConnector mongo = new MongoConnector();
                connections.Add(mongo);
            }

            if (isTextFiles) {
                TextConnector text = new TextConnector ();
                connections.Add (text);
            }
        }

        public static void InsertRecords () {
            PrivacyDataModel privateData = new PrivacyDataModel ();
            foreach(IDataConnection connection in connections) {
                connection.InsertRecord<PrivacyDataModel> ("PrivateData", privateData);
            }
        }
    }
}
