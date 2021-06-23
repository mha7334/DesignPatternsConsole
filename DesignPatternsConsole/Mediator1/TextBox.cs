using System;

namespace DesignPatternsConsole.Mediator1
{
    public class TextBox : Colleague
    {
        public TextBox(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleEvent(string @event)
        {
            Console.WriteLine("Handle TextBox Event" + @event);
        }

        public void TriggerTextChanged(string args)
        {
            this.Mediator.Send("Event - " + args, this);
        }
    }
}