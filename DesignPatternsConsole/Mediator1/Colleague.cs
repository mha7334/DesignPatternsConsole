namespace DesignPatternsConsole.Mediator1
{
    public abstract class Colleague
    {
        protected readonly IMediator Mediator;

        protected Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void HandleEvent(string @event);
       
    }
}