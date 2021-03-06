﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.Core.Plugins;
using Rocket.Core.Commands;
using Rocket.Unturned;

namespace LimitedItemCommand
{
    public class Plugin : RocketPlugin<Config>
    {
        public static Plugin Instance;
        protected override void Load()
        {
            Instance = this;
            Log("LimitedItemCommand Has Loaded!");
            Log("Current spawning limit: " + U.Settings.Instance.MaxSpawnAmount.ToString());
        }

        protected override void Unload()
        {
            Log("LimitedItemCommand Has Loaded!");
        }

        public override Rocket.API.Collections.TranslationList DefaultTranslations
        {
            get
            {
                return new Rocket.API.Collections.TranslationList
                {
                    {"giving_console", "Giving '{0}' {1}x of {2} ({3})"},
                    {"giving_failed", "Failed to find a item matching id or name '{0}'"}
                };
            }
        }

        public static void Log(string msg)
        {
            Rocket.Core.Logging.Logger.Log(msg);
        }
    }
}
