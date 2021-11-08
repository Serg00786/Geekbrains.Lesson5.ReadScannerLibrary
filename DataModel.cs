using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadScannerLibrary
{
    public class DataModel
    {
        public byte[] ID { get; set; }
        public byte[] CPULoad { get; set; }
        public byte[] MemoryLoad { get; set; } 
    }
}
