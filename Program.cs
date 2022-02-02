using CommandConsole.CommandPattern;
using System;

namespace CommandConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver reciever = new Receiver();
            Command command = new ConcreteCommand(reciever);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
