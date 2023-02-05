using Decorator;

Console.WriteLine("Hello, World!");

var em = new EMailService();
em.SendMail("Spam only");

var pm = new PrintMailService();
pm.SendMail("Thank you");

var lem = new LoggedMailService(em);
lem.SendMail("Spam all");

var vpm = new VerifiledMailService(pm);
vpm.SendMail(" Thanks");