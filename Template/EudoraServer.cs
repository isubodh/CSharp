namespace Template {
    public class EudoraServer : MailServer
    {
        public EudoraServer():base(new Guid()){

        }
        public override void authtenticate()
        {
            Console.WriteLine($"Authenticating to a Eudora Server...");
        }

        public override void connectToServer()
        {
            Console.WriteLine($"Setting up Eudora specific params...");
            base.connectToServer();
        }
    }
}