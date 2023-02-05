
namespace Decorator {

    public interface IMailService {
        
        bool SendMail(string message);
    }

    public class EMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Sending {nameof(EMailService)} to Customer : {message}");
            return true;
        }
    }

    public class PrintMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Sending {nameof(PrintMailService)} to Customer: {message}");
            return true;
        }
    }
}