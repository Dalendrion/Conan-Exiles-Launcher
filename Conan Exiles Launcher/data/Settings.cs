using System;
using System.Collections.Generic;
using System.Text;

namespace Conan_Exiles_Launcher.data
{
    internal class Settings
    {
        private string _steamPath = "C:\\Users\\avermaas\\Desktop\\SteamLibrary\\";
        private string _gamePath = "steamapps\\common\\Conan Exiles\\ConanSandbox\\";
        private string _modPath = "Mods\\modlist.txt";
        private string _workshopContent = "steamapps\\workshop\\content\\440900\\";

        public String ModlistPath
        {
            get
            {
                return _steamPath + _gamePath + _modPath;
            }
        }

        public string WorkshopPath
        {
            get
            {
                return _steamPath + _workshopContent;
            }
        }
    }
}
