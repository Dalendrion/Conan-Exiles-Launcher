namespace Conan_Exiles_Launcher.Controllers.Dto
{
    public class ImportResulDto
    {
        public ServerDataDto Server { get; set; }
        public List<ModDataDto> Mods { get; set; }
        
        public ImportResulDto(ServerDataDto server, List<ModDataDto> mods)
        {
            Server = server;
            Mods = mods;
        }

        public override string ToString()
        {
            return $@"{{
    LastServer: {Server},
    ModData: [
        {string.Join(",\n        ", Mods)}
    ]
}}";
        }
    }
}
