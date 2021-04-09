namespace DesignPatternsConsole.Visitor
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}