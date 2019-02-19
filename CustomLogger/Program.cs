[assembly:log4net.Config.XmlConfigurator(Watch =true)]
namespace CustomLogger
{
    public class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();/*log4net.LogManager.GetLogger
 (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);*/
        static void Main(string[] args)
        {
            System.Console.WriteLine("Writing log...");
            log.Error("This is my error message");
            System.Console.ReadLine();
        }
    }
}
