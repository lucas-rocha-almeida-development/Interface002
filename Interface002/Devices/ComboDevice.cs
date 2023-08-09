using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface002.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string documento)
        {
            Console.WriteLine("ComboDevice print " + documento);
        }

        public override void ProcessoDoc(string documento)
        {
            Console.WriteLine("ComboDevice Processamento " + documento);        }

        public string Scan()
        {
            return "ComboDevice Scan Resultado";     }
    }
}
