using System;

namespace Template
{

    public abstract class MailServer{
        private Guid _id;

        public MailServer(Guid id){
            _id = id;
        }
        public void serveMail(){
            //step 1 can be orridden
            connectToServer();
            //Step 2 Has to be overriden
            authtenticate();
            //Step 3 use as it is.
            parseMail(_id);
        }

        public virtual void connectToServer(){
            Console.WriteLine($"Connecting to generic Server...");
        }
        public abstract void authtenticate();

        public string parseMail(Guid id){
            Console.WriteLine($"Parsing mail body for : {id}");
            return id.ToString();
        }
    }

    public class ExchangeServer : MailServer
    {

        public ExchangeServer():base(new Guid()){

        }
        public override void authtenticate()
        {
            Console.WriteLine($"Authenticating to a Exchange Server...");
        }
    }
}