using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Pan" },
                new Command {Id = 1, HowTo = "Boil a Potato", Line = "Boil Water", Platform = "Pan"},
                new Command {Id = 2, HowTo = "Boil a Crab", Line = "Boil Water", Platform = "Pan" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Pan"};
        }
    }
}
