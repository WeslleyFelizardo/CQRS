﻿using Share.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Handlers
{
    public interface ICommandHandlerSingle<T>
    {
        CommandResult Handle(T command);
    }
}
