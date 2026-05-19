using System;
using System.Collections.Generic;
using System.Text;

namespace Conan_Exiles_Launcher.Core.Adapters.Files
{
    internal interface FileLineProcessor
    {
        public void ProcessLine(string line);
    }
}
