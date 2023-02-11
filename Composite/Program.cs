using Composite;
// See https://aka.ms/new-console-tmplate for more information
Console.WriteLine("Hello, World!");

var root = new DirectoryObj("base", 10);

root.Add(new FileObj("one.txt", 100));
root.Add(new DirectoryObj("d1", 10));
root.Add(new DirectoryObj("d2", 10));

Console.WriteLine($"root dir before : {root.Name} : {root.GetSize()}");

var l1 = new DirectoryObj("level2", 10);
l1.Add(new FileObj("one.txt", 100));
l1.Add(new DirectoryObj("d1", 10));
l1.Add(new DirectoryObj("d2", 10));

var l2 = new DirectoryObj("level3", 50);
l2.Add(new FileObj("one.txt", 100));
root.Add(l2);

Console.WriteLine($"root dir before : {l1.Name} : {l1.GetSize()}");

root.Add(l1);
Console.WriteLine($"root dir after : {root.Name} : {root.GetSize()}");




