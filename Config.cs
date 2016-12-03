using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;

namespace LimitedItemCommand
{
    public class Config : IRocketPluginConfiguration 
    {
        public int SpawningLimit;

        public void LoadDefaults()
        {
            SpawningLimit = 30;
        }
    }
}
