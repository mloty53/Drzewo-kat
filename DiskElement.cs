using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
	public abstract class DiskElement
	{
		protected FileSystemInfo file;

		protected internal abstract void Print(int depth);
		protected abstract string Format(int depth);

		public FileSystemInfo File
		{
			get
			{
				return file;
			}
		}

		public void Print()
		{
			Print(0);
		}
	}
}
