using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthGuard
{
	public static class Config
	{
		public static double MainFormOpacity
		{
			get
			{
				string val = System.Configuration.ConfigurationManager.AppSettings["MainFormOpacity"];
				return int.Parse(val) / 100.0;
			}
		}
	}
}
