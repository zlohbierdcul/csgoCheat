using System;
using System.Threading;

namespace FirstCheat
{
    internal class Program
	{
		public VAMemory vaMemory = new VAMemory("csgo");
		static void Main(string[] args)
		{

			StartCheatThread();
			Console.ReadKey();

		}



        public static nint StartInjection()
		{
			VAMemory vaMemory = new VAMemory("csgo");

			var client = (nint)0;
			var engine = (nint)0;

			try
			{
				client = vaMemory.GetModuleBaseAddress("client.dll");
				engine = vaMemory.GetModuleBaseAddress("engine.dll");
			}
			catch { }

			return client;
		}

		public static void StartCheatThread()
		{
			Thread cheatThread = new Thread(new ThreadStart(CheatLoop));
			cheatThread.Start();
		}

		public static void CheatLoop()
		{

		

			int i = 0;
			while (true)
			{
				// do cheaty stuff
				Console.WriteLine(i++);
				if (i > 10) return;
			}
		}
	}
}