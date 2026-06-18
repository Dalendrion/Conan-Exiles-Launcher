using System.Net;

namespace Conan_Exiles_Launcher.Controllers.Dto
{
    public class ImportResultDto
    {
        public Guid? Guid { get; set; }
        public ServerDataDto Server { get; set; }
        public List<ModDataDto> Mods { get; set; }
        
        public ImportResultDto(ServerDataDto server, List<ModDataDto> mods)
        {
            Server = server;
            Mods = mods;
        }
        
        public string ServerName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Server.Name))
                {
                    return IPAddress;
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
                if (string.IsNullOrWhiteSpace(Server.IPAddress) || string.IsNullOrWhiteSpace(Server.Port))
                {
                    return $"{Server.IPAddress}{Server.Port}";
                }
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

        public override bool Equals(object? other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other is ImportResultDto that)
            {
                return this.Guid == that.Guid;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Guid.GetHashCode();
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
