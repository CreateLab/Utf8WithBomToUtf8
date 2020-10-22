using System;
using System.IO;
using System.Text;

namespace UTFBomSolver
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = @"your/path";
			var initial = File.ReadAllText(path);
			using var ms = new MemoryStream();
			using var writer = new StreamWriter(ms, new UTF8Encoding(false));
			writer.Write(initial);
			writer.Flush();
			File.WriteAllBytes(path,ms.ToArray());

		}
	}
}
