using System;
using System.Collections.Generic;

namespace Command
{
    // abstract class for all commands
    public abstract class CommandClass
    {
        public abstract string command();
    }
    // a specific command
    public class CommandDog: CommandClass
    {
        public override string command()
        {
            return "new command for dog";
        }
    }

    // interface for acting a command
    public interface ICommand<T> where T:CommandClass
    {
        void act(T t);
    }
    // the dog can act commands
    public class Dog: ICommand<CommandDog>
    {
        public void act(CommandDog d)
        {
            Console.WriteLine(d.command());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.act(new CommandDog());
        }
    }

}
