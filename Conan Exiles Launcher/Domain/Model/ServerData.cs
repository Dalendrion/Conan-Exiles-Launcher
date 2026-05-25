namespace Conan_Exiles_Launcher.Domain.Model
{
    public class ServerData
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public Boolean BattleEye { get; set; }

        public override string ToString()
        {
            return $"{{ Name: \"{Name}\","
                + $" IPAddress: \"{IPAddress}\","
                + $" Port: \"{Port}\","
                + $" BattleEye: \"{BattleEye}\" }}";
        }
    }
}
