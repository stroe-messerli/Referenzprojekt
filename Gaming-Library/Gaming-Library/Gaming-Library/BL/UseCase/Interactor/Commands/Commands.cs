using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.BL.UseCase.InputPort.Requests;

namespace Gaming_Library.BL.UseCase.Interactor.Commands
{
    public class Commands : ICommands
    {
        private readonly Dictionary<int, ICommand> _commands;

        public static ICommands Create()
        {
            return new Commands();
        }

        private Commands()
        {

        }
        public void Add(ICommand command)
        {
            _commands.Add(command.GetId(), command);
        }

        public ICommand GetCommand(IRequest request)
        {
            ICommand command;
            _commands.TryGetValue(request.GetType().GetHashCode(), out command);
            return command;
        }
    }
}
