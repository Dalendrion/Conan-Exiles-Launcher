using Conan_Exiles_Launcher.Controllers.Dto;
using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Controllers.Mappers
{
    public static class ImportResultMapper
    {
        public static ImportResult FromDto(ImportResulDto dto)
        {
            return new ImportResult(
                ServerDataMapper.FromDto(dto.Server),
                dto.Mods.Select(mod => ModDataMapper.FromDto(mod)).ToList()
            );
        }
    }
}
