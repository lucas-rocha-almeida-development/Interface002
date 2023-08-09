using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface002.Devices;

namespace Interface002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };//objeto do tipo printer
            p.ProcessoDoc(" Minha Carta ");//metodo
            p.Print("Minha Carta ");//metodo

            Scanner s = new Scanner() { SerialNumber = 2003 };//objeto do tipo scanner
            s.ProcessoDoc("Meu Email :");//metodo
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { 
            
            SerialNumber = 3921};
            c.ProcessoDoc("Minha Informação");
            c.Print("Minha Informação");//imprime
            Console.WriteLine(c.Scan());//escaneia

        }
    }
}
