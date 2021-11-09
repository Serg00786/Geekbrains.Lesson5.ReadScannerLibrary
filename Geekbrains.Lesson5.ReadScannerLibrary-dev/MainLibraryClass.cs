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

    public class MainLibraryClass
    {
        public MainLibraryClass()
        {


        }
        public void GetData (dataModelDTO dataModel)
        {
            Contract.Requires(dataModel.ID !=null);
            Contract.Requires(dataModel.CPULoad != null);
            Contract.Requires(dataModel.MemoryLoad != null);
            Contract.EnsuresOnThrow<InvalidDataException>(Contract.OldValue(dataModel.ID) != null);

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
