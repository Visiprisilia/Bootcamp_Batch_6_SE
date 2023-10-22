﻿//HTTPRequest enum
class program
{
	public enum HTTPRequest
	{
		NotFound = 404,
		OK = 200,
		Forbidden = 403
	}
	static void Main()
	{
		WebAccess.ContinueAccess(HTTPRequest.Forbidden);
	}
	class WebAccess
	{
		public static void ContinueAccess(HTTPRequest status)
		{
			if (status == HTTPRequest.NotFound)
			{
				// ((int)status).Dump();
				Console.WriteLine((int)status);
			}
			else if (status == HTTPRequest.OK)
			{
				// ((int)status).Dump();
				Console.WriteLine((int)status);
			}
			else
			{
				// ((int)status).Dump();
				Console.WriteLine((int)status);
			}
		}
	}
}