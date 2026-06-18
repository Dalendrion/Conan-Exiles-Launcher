using Conan_Exiles_Launcher.Controllers.Dto;
using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Controllers.Mappers
{
    public static class ImportResultMapper
    {
        public static ImportResult FromDto(ImportResultDto dto)
        {
            return new ImportResult(
                ServerDataMapper.FromDto(dto.Server),
                dto.Mods.Select(mod => ModDataMapper.FromDto(mod)).ToList()
            )
            { Guid = dto.Guid };
        }

        public static ImportResultDto ToDto(ImportResult importResult)
        {
            return new ImportResultDto(
                ServerDataMapper.ToDto(importResult.Server),
                importResult.Mods.Select(mod => ModDataMapper.ToDto(mod)).ToList()
            )
            { Guid = importResult.Guid };
        }
    }
}
