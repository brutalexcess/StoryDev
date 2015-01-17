using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryDev.API
{
    public class Plugin
    {
        public string Title;
        public string Description;
        public string Author;

        public string InitMethod;
        public string DeinitMethod;

        public string MenuText;
        public string MenuImage;

        public bool Enabled;
    }
}
