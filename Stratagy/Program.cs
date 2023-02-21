using Stratagy;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Behaviour Stratagy!";

        var o1 = new Orders(1, 100);
        o1.print(new printJson());

        o1 = new Orders(2, 200);
        o1.print(new printXML());

        o1 = new Orders(3, 300);
        o1.print(new printTXT());
    }
}