
using System.Collections.Generic;

namespace command.Pattern {

public class Program
{
    public static int x = 0;
    public static int y = 0;
    private static void Main(string[] args)
    {
        var cmdList = new List<ICommand>();

        Console.WriteLine("Please press arrow keys and then Enter");
      
        while (true){
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow) cmdList.Add(new upCommand());
            else if (key == ConsoleKey.DownArrow) cmdList.Add(new downCommand());
            else if (key == ConsoleKey.LeftArrow) cmdList.Add(new leftCommand());
            else if (key == ConsoleKey.RightArrow) cmdList.Add(new rightCommand());
            else if (key == ConsoleKey.Enter){
                cmdList.ForEach(obj => obj.invokeCommand());
                Console.WriteLine($"\n {x}, {y}");
                cmdList.Clear();
                Program.x = 0;
                Program.y =0;
            }
        } 
        
    }
}

public interface ICommand  {
    public void invokeCommand();
}

    class upCommand : ICommand
    {
        public void invokeCommand()
        {
            Console.Write("Up.");
            Program.y += 1;
        }
    }

    class downCommand : ICommand
    {
        public void invokeCommand()
        {
            Console.Write("Down.");
            Program.y -= 1;
        }
    }
    class leftCommand : ICommand
    {
        public void invokeCommand()
        {
            Console.Write("Left.");
            Program.x -= 1;
        }
    }
    class rightCommand : ICommand
    {
        public void invokeCommand()
        {
            Console.Write("Right.");
            Program.x += 1;
        }
    }

}

