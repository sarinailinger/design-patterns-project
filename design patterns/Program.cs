// See https://aka.ms/new-console-template for more information
using design_patterns;
using System.Diagnostics;
using File = design_patterns.File;

Console.WriteLine("Hello, World!");

Repository repository = new("MyRepo");
User user = new("SariN", 654787, 258741369, "sn0533129699@gmail.com");
User user2 = new("SariG", 984686, 246895712, "s0533151081@gmail.com");

repository.Users.Add(user);
repository.Users.Add(user2);

File file1 = new File("Program.cs", 45, repository);
File file2 = new File("Program.cs", 47, repository);
Folder folder1 = new Folder("my folder", 67, repository);
folder1.Add(file1);

try
{
    Console.WriteLine(folder1.State.AddFiles());
    //folder1.State.RequestAReview();
    //Console.WriteLine(folder1.State.Commit("First commit"));
    //folder1.State.RequestAReview();

}
catch (Exception ex)
{
    Debug.WriteLine("You can not perform this action");
}

folder1.CareTaker.GetHistory();
