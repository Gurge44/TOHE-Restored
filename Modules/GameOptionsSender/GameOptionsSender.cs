using System;
using System.Linq;
using System.Collections.Generic;
using InnerNet;
using AmongUs.GameOptions;

namespace TownOfHost.Modules
{
    public abstract class GameOptionsSender
    {
        public static GameOptionsSender CurrentSender
        {
            get => _currentSender;
            set
            {
                if (value != null)
                    _currentSender = value;
            }
        }
        private static GameOptionsSender _currentSender;
    }
}