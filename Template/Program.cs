// See https://aka.ms/new-console-template for more information
using Template;

Console.Title = "Builder : Template";

var eudMail = new EudoraServer();
eudMail.serveMail();

var excMail = new ExchangeServer();
excMail.serveMail();