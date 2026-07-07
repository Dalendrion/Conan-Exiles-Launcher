namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface IDeleteDataUseCase
    {
        public Task DeleteDataAsync(Guid guid);
    }
}
