using System;
using System.Collections.Generic;
using System.Text;

namespace Conan_Exiles_Launcher.Core.Adapters.GameSettings
{
    public class ServerData
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public string Password { get; set; }
        public string UID { get; set; }
        public Boolean BattleEye { get; set; }

        public override string ToString()
        {
            return $"Name: {Name},"
                + $" IPAddress: {IPAddress},"
                + $" Port: {Port},"
                + $" Password: {Password},"
                + $" UID: {UID},"
                + $" BattleEye: {BattleEye}";
        }
    }
}
