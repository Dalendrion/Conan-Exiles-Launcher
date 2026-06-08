namespace Conan_Exiles_Launcher.Controllers.Dto
{
    public class ServerDataDto
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public Boolean BattleEye { get; set; }

        public static bool HasSameIpAddress(ServerDataDto a, ServerDataDto b)
        {
            if (a == null) return false;
            if (b == null) return false;
            return string.Equals(a.IPAddress, b.IPAddress, StringComparison.OrdinalIgnoreCase)
                && string.Equals(a.Port, b.Port, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{{ Name: \"{Name}\","
                + $" IPAddress: \"{IPAddress}\","
                + $" Port: \"{Port}\","
                + $" BattleEye: \"{BattleEye}\" }}";
        }
    }
}
