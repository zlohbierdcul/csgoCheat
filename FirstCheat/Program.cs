using System;
using System.Threading;

namespace FirstCheat
{
    internal class Program
    {

        static void Main(string[] args)
        {
            VAMemory vaMemory = new VAMemory("minecraft");

            var client = vaMemory.GetModuleBaseAddress("client.dll");
            var engine = vaMemory.GetModuleBaseAddress("engine.dll");

        }


    }


}