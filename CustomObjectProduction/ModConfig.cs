﻿
using StardewModdingAPI;

namespace CustomObjectProduction
{
    public class ModConfig
    {
        public bool EnableMod { get; set; } = true;

        public SButton ToggleModKey { get; set; } = SButton.Pause;
    }
}
