using PersonalDataLibrary.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataLibrary.Connectors {
    class TextConnector: IDataConnection {
        public void InitializeConnection () {
            //make sure text file exists
            //Open Text file    
        }

        public void InsertRecord<T> (string table, T record) {
            //write to text file    
        }

        public void InsertRecord<T> (string table, T record, T record2) {
            //write to text file    
        }
    }
}
