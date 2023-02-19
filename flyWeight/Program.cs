using Flyweight;
// See https://aka.ms/new-console-template for more information
Console.Title = "FlyWeight";

var someCharecters = "ababa";

var charObjFactory = new charFactory();

var charObjects = charObjFactory.GetChar(someCharecters[0]);
charObjects.Draw("Times Roman", 11);

charObjects = charObjFactory.GetChar(someCharecters[1]);
charObjects.Draw("Times New Roman", 12);

charObjects = charObjFactory.GetChar(someCharecters[2]);
charObjects.Draw("Calibri", 13);

charObjects = charObjFactory.GetChar(someCharecters[3]);
charObjects.Draw("Monosript", 14);

var paragraph = charObjFactory.CreatePara(new List<Ichar>() {charObjects}, 4);
paragraph.Draw("Comic Sans", 18);




