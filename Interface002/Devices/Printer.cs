using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface002.Devices
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessoDoc(string documento)//IMPLEMENTAÇÃO DO DEVICE
        {
            Console.WriteLine("Printer Processo: " + documento);
        }
        public void Print(string documento) //IMPLEMENTAÇÃO INTERFACE IPRINTER
        {
            Console.WriteLine("Printer print " + documento); }
    }
}
