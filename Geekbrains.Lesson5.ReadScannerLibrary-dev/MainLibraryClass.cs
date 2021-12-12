using ReadScannerLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadScannerLibrary
{ 
    public interface IMainLibraryClass
    {
        void GetData(dataModelDTO dataModel);
        void ProcessData(DataModel data);
    }

    public class MainLibraryClass : IMainLibraryClass
    {
        public MainLibraryClass()
        {
            

        }
        public void GetData (dataModelDTO dataModel)
        { 
            DataModel data = new DataModel();
            data.ID = dataModel.ID;
            data.CPULoad = dataModel.CPULoad;
            data.MemoryLoad = dataModel.MemoryLoad;
            this.ProcessData(data);
        }

        public void ProcessData(DataModel data)
        {
            var context = new Context();
            context.SetStrategy(new StrategySaveToJson());
            context.RealizeBusinessLogic(data);

            context.SetStrategy(new StrategySaveToXML());
            context.RealizeBusinessLogic(data);
        }

    }
}
