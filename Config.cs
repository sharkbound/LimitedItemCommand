using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;

namespace LimitedItemCommand
{
    public class Config : IRocketPluginConfiguration 
    {
        public string placeHolder;

        public void LoadDefaults()
        {
            placeHolder = "placeholder";
        }
    }
}
