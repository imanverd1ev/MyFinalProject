﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CCS
{
	public class FileLogger : ILogger
	{
		public void Log(string message)
		{
            Console.WriteLine("Dosyaya loglandi");
        }

		public void Log()
		{
			throw new NotImplementedException();
		}
	}
}
