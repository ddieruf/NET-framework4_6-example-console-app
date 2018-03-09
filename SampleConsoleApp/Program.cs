using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
	class Program
	{
		private static log4net.ILog _logger;
		static void Main(string[] args)
		{
			Console.WriteLine("Hi there.");

			_logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
			_logger.Info("Hi there again!");
		}
	}
}
