namespace Decorator {

    public abstract class MailServiceDecoratorBase : IMailService
    {
        public readonly IMailService _mailService;

        public MailServiceDecoratorBase(IMailService mailService){
            _mailService = mailService;
        }
        public virtual bool SendMail(string message)
        {
            return _mailService.SendMail(message);
        }
    }

    public class LoggedMailService : MailServiceDecoratorBase {
        
        public LoggedMailService(IMailService mailService): base(mailService){
        } 

        public override bool SendMail(string message){
            Console.WriteLine($"Logging : {message}");
            return base.SendMail(message);
        }
    }

    public class VerifiledMailService : MailServiceDecoratorBase {
        
        public VerifiledMailService(IMailService mailService): base(mailService){
        } 

        public override bool SendMail(string message){
            Console.WriteLine($"Verifyling : {message}");
            return base.SendMail(message);
        }
    }
    
}