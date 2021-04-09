namespace DesignPatternsConsole.Interpreter
{
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }
}