using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataLibrary.Controller
{
    public interface IDataConnection
    {
        /// <summary>
        /// Initializes a connection to the connection type.
        /// </summary>
        void InitializeConnection();

        /// <summary>
        /// Inserts record type T into the table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="record"></param>
        void InsertRecord<T>(string table, T record);
    }
}
