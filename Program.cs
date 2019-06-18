using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sandbox
{
	class Program
	{
	    static void Main(string[] args)
	    {
            Console.WriteLine("Thread Count: " + System.Diagnostics.Process.GetCurrentProcess().Threads.Count);


            var e = Enumerations.MyEnum.Option1;

	        var s = e.ToString();
	        //var d = Enums.GetDescription((Enumerations.MyEnum)e);
	        Console.WriteLine(s);


	        var date = Utilities.ParseDate("20161118 01:00:00");
	        date = Utilities.ParseDate("20161118");
	        date = Utilities.ParseDate("2016/11/18 01:00:00");
	        date = Utilities.ParseDate("2016/11/18");
	        date = Utilities.ParseDate("2016-11-18 01:00:00");
	        date = Utilities.ParseDate("2016-11-18");
	        date = Utilities.ParseDate("0001-01-01");

	        var eventDesc = Enumerations.EventCode.AbandonSession.ToString();
	        var eventCode = ((int) Enumerations.EventCode.AbandonSession).ToString();

	        Enumerations.MyEnum en = default(Enumerations.MyEnum);
	        var x = Enumerations.MyEnum.TryParse("option", true, out en);

	        var xx = (Enumerations.MyEnum) Enum.Parse(typeof (Enumerations.MyEnum), "Option2");

	        var i = 5;
	        Console.WriteLine(i.ToString("000"));

	        var pwd = StringCipher.Decrypt("l6ELOhZv88Ja95nHT3ZhEg==");
	        Console.WriteLine($"Decrypted Password: {pwd}");

	        string str = string.Empty;
	        var result = str.Split(new string[] {","}, StringSplitOptions.None);

            var obj = new Class();
	        var param = obj.GetParams();
	        var paramCount = param.Length;

	        Console.ReadKey();
	    }
	}
}
