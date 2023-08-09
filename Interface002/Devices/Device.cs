using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface002.Devices
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessoDoc(string documento);


    }
}
