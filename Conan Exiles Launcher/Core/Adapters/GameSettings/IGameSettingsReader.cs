using System;
using System.Collections.Generic;
using System.Text;

namespace Conan_Exiles_Launcher.Core.Adapters.GameSettings
{
    internal interface IGameSettingsReader
    {
        GameSettingsData ReadGameSettings();
    }
}
