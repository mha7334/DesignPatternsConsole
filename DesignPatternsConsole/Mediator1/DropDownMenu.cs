using System;

namespace DesignPatternsConsole.Mediator1
{
    public class DropDownMenu : Colleague
    {
        public DropDownMenu(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleEvent(string @event)
        {
            Console.WriteLine("Handle DropDown Event" + @event);
        }

        public void TriggerDropDownChanged(string args)
        {
            this.Mediator.Send("Event - " + args, this);
        }
    }
}