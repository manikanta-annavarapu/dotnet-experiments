// See https://aka.ms/new-console-template for more information
using VirtualOverrideAndNewPolymorphism;

Console.WriteLine("Initail State");

var initialState = new InitialState();

initialState.Run();

Separator();
Console.WriteLine("Warning State");

var warningState = new WarningState();
warningState.Run();

Separator();
Console.WriteLine("Clear Warning State");

var clearWarningState = new ClearWarningState();
clearWarningState.Run();

Separator();
Console.WriteLine("Override State");

var overrideState = new OverrideState();
overrideState.Run();






static void Separator()
{
    Console.WriteLine("******************************************************************************************");
}
