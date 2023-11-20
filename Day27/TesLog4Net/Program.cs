namespace TesLog4Net;

namespace TesLog4Net  
{
	class Tes 
	{
	private static readonly ILog logger = LogManager.GetLogger(typeof(Tes))
	static void Main(string[] args)
	{
		XmlConfigurator.Configure(new InfoFile("leslog4Net.config"));
		logger.Debug("ini adalah pesan debug");
		logger.Info("ini adalah pesan info");
		logger.Warn("ini adalah pesan warning");
		logger.Error("ini adalah pesan eror");
		logger.Fatal("ini adalah pesan fatal");
		Game
	}
}
class GameRunner 
{
	private static readonly ILog logger = LogManager.GetLogger(typeof(GameRunner));
	public static void Message(string args)
	{
		logger.Info(args);
		
	}
	
} 

}
