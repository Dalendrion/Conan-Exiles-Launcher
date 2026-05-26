namespace Conan_Exiles_Launcher.Data
{
    internal class Settings
    {
        private string _steamPath = "C:\\Users\\avermaas\\Desktop\\SteamLibrary\\";
        private string _savedData = "C:\\Users\\avermaas\\Desktop\\Conan Exiles\\conan_exiles_launcher_data.json";
        private string _gamePath = "steamapps\\common\\Conan Exiles\\ConanSandbox\\";
        private string _gameIni = "Saved\\Game.ini";
        private string _modlistPath = "Mods\\modlist.txt";
        private string _serverModlistPath = "servermodlist.txt";
        private string _workshopContent = "steamapps\\workshop\\content\\440900\\";
        private string _sandboxExecutable = "Binaries\\Win64\\ConanSandbox-Win64-Shipping.exe";
        private string _sandboxBattleEyeExecutable = "Binaries\\Win64\\ConanSandbox_BE.exe";

        public static Settings Instance {
            get
            {
                if (field == null)
                {
                    field = new Settings();
                }
                return field;
            }
        }

        public string SteamPath
        {
            get
            {
                return _steamPath;
            }
            set
            {
                _steamPath = value;
            }
        }

        public string SavedDataPath
        {
            get
            {
                return _savedData;
            }
            set
            {
                _savedData = value;
            }
        }

        public string ModlistPath
        {
            get
            {
                return _steamPath + _gamePath + _modlistPath;
            }
        }

        public string ServerModlistPath
        {
            get
            {
                return _steamPath + _gamePath + _serverModlistPath;
            }
        }

        public string SandboxExecutablePath
        {
            get
            {
                return _steamPath + _gamePath + _sandboxExecutable;
            }
        }

        public string BattleEyeExecutablePath
        {
            get
            {
                return _steamPath + _gamePath + _sandboxBattleEyeExecutable;
            }
        }

        public string WorkshopContentPath
        {
            get
            {
                return _steamPath + _workshopContent;
            }
        }

        public string GameIniPath
        {
            get
            {
                return _steamPath + _gamePath + _gameIni;
            }
        }
    }
}
