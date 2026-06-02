namespace Conan_Exiles_Launcher.Domain.Model
{
    public class ImportResult
    {
        public ServerData Server { get; set; }
        public List<ModData> Mods { get; set; }
        public string ServerName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Server.Name))
                {
                    return $"{Server.IPAddress}:{Server.Port}";
                }
                else
                {
                    return Server.Name;
                }
            }
        }
        public string IPAddress
        {
            get
            {
                return $"{Server.IPAddress}:{Server.Port}";
            }
            set
            {
                string[] parts = value.Split(':');
                if (parts.Length == 2)
                {
                    Server.IPAddress = parts[0];
                    Server.Port = parts[1];
                }
            }
        }

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
