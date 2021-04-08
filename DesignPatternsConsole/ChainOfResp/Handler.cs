using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.ChainOfResp
{
    public abstract class Handler
    {
        public Handler rsHandler;
        public void nextHandler(Handler rsHandler)
        {
            this.rsHandler = rsHandler;
        }
        public abstract void dispatchRs(long requestedAmount);
    }
}
