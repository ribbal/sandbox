using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
	public static class Utilities
	{
		public static DateTime ParseDate(string dateTimeString)
		{
			DateTime dateTime;

			var formats = new[] { "yyyyMMdd hh:mm:ss", "yyyyMMdd", "yyyy/MM/dd hh:mm:ss", "yyyy/MM/dd", "yyyy-MM-dd hh:mm:ss", "yyyy-MM-dd" };

			if (DateTime.TryParseExact(dateTimeString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
			{
				return dateTime;
			}
			else
			{
				throw new FormatException(string.Format("Unrecognised DateTime format: {0}", dateTimeString));
			}
		}
	}
}
