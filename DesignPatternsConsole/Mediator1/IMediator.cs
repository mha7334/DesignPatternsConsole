using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatternsConsole.Mediator1
{
    public interface IMediator
    {
        void Send(string @event, Colleague colleague);
    }
}
