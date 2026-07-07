namespace Conan_Exiles_Launcher.Domain.Exceptions
{
    internal class ServerDoesNotExistException : ArgumentException
    {
        public ServerDoesNotExistException(Guid guid) : base($"ImportResult with guid {guid} does not exist.")
        {
        }
    }
}
