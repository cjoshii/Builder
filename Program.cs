// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,! Welcome to the Computer Store!");

IComputerBuilder builder = new ComputerBuilder();
ComputerBuilderDirector director = new ComputerBuilderDirector(builder);

IComputer gamingPC = director.BuildGamingPC();
IComputer miningPC = director.BuildMiningPC();
IComputer developmentPC = director.BuildDevelopmentPC();
IComputer customPC = director.BuildCustomPC("Intel i9", "64GB", "Nvidia RTX 3090", "2TB SSD");

Console.WriteLine("Gaming PC:");
gamingPC.Display();

Console.WriteLine("Mining PC:");
miningPC.Display();

Console.WriteLine("Development PC:");
developmentPC.Display();

Console.WriteLine("Custom PC:");
customPC.Display();
