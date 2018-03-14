using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;

namespace SampleConsoleApp
{
	class Program
	{
		private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		static void Main(string[] args){
			_logger.Info("Hi there.");
			_logger.Warn("Waiting forever...");
			Console.ReadLine();
		}
	}
}
