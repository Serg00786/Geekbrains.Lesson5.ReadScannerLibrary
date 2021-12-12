using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;


namespace ReadScannerLibrary
{
    public class StrategySaveToJson : IStrategy
    {

        public bool DoAlgorithm(DataModel data)
        {
            var dataModelJson = new DataModelJson
            {
                ID = Encoding.ASCII.GetString(data.ID),
                CPULoad = Encoding.ASCII.GetString(data.CPULoad),
                MemoryLoad = Encoding.ASCII.GetString(data.MemoryLoad)
            };
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(dataModelJson);
            if (File.Exists("JsonLog.txt")){
                File.AppendAllText("JsonLog.txt", jsonString);
            }
            else
            {
                File.WriteAllText("JsonLog.txt", jsonString);
            }
            
            return true;
        }
    }
}

