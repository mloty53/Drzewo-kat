using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
	class Program
	{
		static void Main(string[] Args)
		{
			if (Args.Length < 1)
			{
				Console.Error.WriteLine("Error: no input path given.");
				return;
			}

			if (Directory.Exists(Args[0]) == false)
			{
				Console.Error.WriteLine("Error: path incorrect.");
				return;
			}

			DiskDirectory dd = new DiskDirectory(new DirectoryInfo(Args[0]));
			dd.Print();
		}
	}
}
