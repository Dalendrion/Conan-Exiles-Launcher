using Conan_Exiles_Launcher.Domain.Exceptions;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class DeleteDataService : IDeleteDataUseCase
    {
        private readonly ISavedDataPort _savedDataPort;

        public DeleteDataService(ISavedDataPort savedDataPort)
        {
            _savedDataPort = savedDataPort;
        }

        /// <summary>
        /// Deletes the server data associated with the provided Guid. If the server does not exist, a <c>ServerDoesNotExistException</c> is thrown.
        /// </summary>
        /// <param name="guid">The Guid of the to be deleted server.</param>
        /// <returns></returns>
        /// <exception cref="ServerDoesNotExistException">The server to be deleted isn't present.</exception>
        public async Task DeleteDataAsync(Guid guid)
        {
            _savedDataPort.DeleteImportResult(guid);
        }
    }
}
