namespace WebAPI.Web.Logging
{
    public class LogClass:ILogClass
    {
        public void LogMethod(string message,string type)
        {
            if (type == "error")
            {
                Console.WriteLine("Error "+message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
