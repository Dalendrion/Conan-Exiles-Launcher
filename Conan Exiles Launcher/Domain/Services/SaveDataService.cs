using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;
using System.Text.RegularExpressions;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class SaveDataService : ISaveDataUseCase
    {
        private readonly ISavedDataPort _savedDataPort;

        public SaveDataService(ISavedDataPort savedDataPort)
        {
            _savedDataPort = savedDataPort;
        }

        public async Task<ImportResult> SaveServer(ImportResult importResult)
        {
            if (!Regex.IsMatch(importResult.Server.IPAddress, @"^(((?!25?[6-9])[12]\d|[1-9])?\d\.?\b){4}$"))
            {
                throw new InvalidServerDataException($"Invalid IP address");
            }
            if (!Regex.IsMatch(importResult.Server.Port, @"^[1-9]\d{0,4}$"))
            {
                throw new InvalidServerDataException($"Invalid IP port");
            }

            _savedDataPort.SaveImportResult(importResult);
            return importResult;
        }
    }

    public class InvalidServerDataException : Exception
    {
        public InvalidServerDataException(string message) : base(message)
        {
        }
    }
}
