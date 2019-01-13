using Share.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Handlers
{
    public interface ICommandHandlerManyWithFilter<T, F>
    {
        CommandResult Handle(List<T> commands, F filterComplex);
    }
}
