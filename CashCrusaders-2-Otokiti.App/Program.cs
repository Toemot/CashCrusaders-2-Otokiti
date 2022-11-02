// See https://aka.ms/new-console-template for more information

using CashCrusaders_2_Otokiti.App;
using CashCrusaders_2_Otokiti.DataAccess.Data;

Console.WriteLine("Hello, Cash Crusaders!");

var items = new DataProvider();

while (true)
{
    Console.WriteLine("Please enter an employee name to search for all employees that reports to them, 'help' to list all employees or 'quit' to exit the application. ");
    Console.WriteLine();
    var line = Console.ReadLine();
    if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    var allItems = items.LoadEmployees();

    ICommandHandler commandHandler = string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
        ? new HelpCommandHandler(allItems)
        : new CommandHandler(allItems, line);

    commandHandler.HandleCommand();
}