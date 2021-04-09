using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
