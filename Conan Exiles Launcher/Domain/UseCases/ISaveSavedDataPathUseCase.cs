namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface ISaveSavedDataPathUseCase
    {
        public Task Save(string savedDataPath);
    }
}
