﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new NotImplementedException(); asdsad
        }

        public Command GetCommandById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
