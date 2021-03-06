﻿using System.Collections.Generic;
using System.Linq;

namespace ShellMe.CommandLine.CommandHandling
{
    public class CommandMatcher
    {
        public string CommandName { get; set; }

        public CommandMatcher(IEnumerable<string> arguments)
        {
            CommandName = arguments == null || !arguments.Any() ? string.Empty : arguments.First().ToLower().Trim();
        }
    }
}
