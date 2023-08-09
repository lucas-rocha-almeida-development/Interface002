using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface002.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessoDoc(string documento) //IMPLEMENTAÇÃO DO DEVICE
        {
            Console.WriteLine("Processo de escaneamento: " + documento);
        }
        public string Scan() { return "Resultado do Scanner"; }//IMPLEMENTAÇÃO INTERFACE ISCANNER

    }
}
