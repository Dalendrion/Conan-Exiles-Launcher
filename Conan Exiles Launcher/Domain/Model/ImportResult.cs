namespace Conan_Exiles_Launcher.Domain.Model
{
    public class ImportResult
    {
        public Guid? Guid { get; set; }
        public ServerData Server { get; set; }
        public List<ModData> Mods { get; set; }
        
        public ImportResult(ServerData server, List<ModData> mods)
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
