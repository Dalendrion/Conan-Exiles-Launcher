using Conan_Exiles_Launcher.Domain.Ports;

namespace Conan_Exiles_Launcher.Domain.Exceptions
{
    public class InvalidPathException : Exception
    {
        public InvalidPathException(string message, Exception cause) : base(message, cause)
        {
            
        }
    }
}
