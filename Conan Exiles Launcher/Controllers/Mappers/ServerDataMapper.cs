using Conan_Exiles_Launcher.Controllers.Dto;
using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Controllers.Mappers
{
    public static class ServerDataMapper
    {
        public static ServerData FromDto(ServerDataDto dto)
        {
            return new ServerData
            {
                Name = dto.Name,
                IPAddress = dto.IPAddress,
                Port = dto.Port,
                BattleEye = dto.BattleEye
            };
        }

        public static ServerDataDto ToDto(ServerData model)
        {
            return new ServerDataDto
            {
                Name = model.Name,
                IPAddress = model.IPAddress,
                Port = model.Port,
                BattleEye = model.BattleEye
            };
        }
    }
}
