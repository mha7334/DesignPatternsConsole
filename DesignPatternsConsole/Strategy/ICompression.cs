using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Strategy
{
    public interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);

    }
}
