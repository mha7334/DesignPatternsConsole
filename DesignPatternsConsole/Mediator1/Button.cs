using System;

namespace DesignPatternsConsole.Mediator1
{
    public class Button : Colleague
    {
        public Button(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleEvent(string @event)
        {
            Console.WriteLine("Handle Button Event" + @event);
        }

        public void TriggerClick(string args)
        {
            this.Mediator.Send("Event - " + args, this);
        }
    }
}