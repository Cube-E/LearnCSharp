using PersonalDataLibary;
using PersonalDataLibrary.Controller;
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
        public static void InitializeConnections(bool isMongo, bool isTextFiles)
        {
            if (isMongo)
            {
                MongoConnector mongo = new MongoConnector();
                connections.Add(mongo);
            }

            if (isTextFiles)
            {
                // TODO - Create text connection
            }
            
        }
    }
}
