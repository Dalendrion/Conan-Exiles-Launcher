using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.In
{
    public interface ILaunchGameUseCase
    {
        public void LaunchGame(ServerData serverData);
    }
}
