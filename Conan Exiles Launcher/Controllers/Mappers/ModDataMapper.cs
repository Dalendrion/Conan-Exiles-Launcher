using Conan_Exiles_Launcher.Controllers.Dto;
using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Controllers.Mappers
{
    public static class ModDataMapper
    {
        public static ModData FromDto(ModDataDto dto)
        {
            return new ModData
            {
                FileName = dto.FileName,
                ID = dto.ID
            };
        }

        public static ModDataDto ToDto(ModData model)
        {
            return new ModDataDto
            {
                FileName = model.FileName,
                ID = model.ID
            };
        }
    }
}
