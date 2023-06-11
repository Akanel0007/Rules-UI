using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NelRulesUI
{
    public class NelRulesConfig : IRocketPluginConfiguration
    {
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public string Message3 { get; set; }
        public string Message4 { get; set; }
        public string Message5 { get; set; }
        public string Message6 { get; set; }
        public string Message7 { get; set; }
        public string ButtonText { get; set; }
        public string DiscordNel { get; set; }
        public string BaslikNel { get; set; }
        public string ReddedText { get; set; }
        public string NelRulesPermission { get; set; }


        public void LoadDefaults()
        {
            BaslikNel = "ServerName";
            Message1 = "Nel Plugins Rules";
            Message2 = "Rule 1";
            Message3 = "Rule 2";
            Message4 = "Rule 3";
            Message5 = "Rule 4";
            Message6 = "Rule 5";
            Message7 = "Instagram taner.yumukk / Discord Support Server https://discord.gg/2D9VNwcQEB";
            DiscordNel = ".gg/codegeassroleplay";
            ButtonText = "Accept";
            ReddedText = "Refuse";
            NelRulesPermission = "Nel.Rules";
        }
    }
}
