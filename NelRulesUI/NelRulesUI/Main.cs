using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NelRulesUI
{
    public class Main : RocketPlugin<NelRulesConfig>
    {
        public static Main Instance;

        protected override void Load()
        {
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected += Events_OnPlayerDisconnected;
            EffectManager.onEffectButtonClicked += OnButtonClicked;
            Logger.Log("Akanel#0007");
            Logger.Log("Support Discord");
            Logger.Log("https://discord.gg/2D9VNwcQEB");
            Logger.Log("https://discord.gg/2D9VNwcQEB");
            Logger.Log("https://discord.gg/2D9VNwcQEB");
            Logger.Log("Contact Instagram @taner.yumukk Or Discord Akanel#0007");
            Logger.Log("Rules UI Loaded");
            Logger.Log("Akanel#0007");
        }

        private void Events_OnPlayerDisconnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            EffectManager.askEffectClearByID(7525, player.SteamPlayer().transportConnection);
        }

        private void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            EffectManager.sendUIEffect(7525, 7525, player.SteamPlayer().transportConnection, false);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuralbirText", Configuration.Instance.Message1);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuralikiText", Configuration.Instance.Message2);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuralucText", Configuration.Instance.Message3);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuraldortText", Configuration.Instance.Message4);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuralbesText", Configuration.Instance.Message5);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuralaltiText", Configuration.Instance.Message6);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "KuralyediText", Configuration.Instance.Message7);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "DiscordText", Configuration.Instance.DiscordNel);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "BaslikText", Configuration.Instance.BaslikNel);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "OnaylaText", Configuration.Instance.ButtonText);
            EffectManager.sendUIEffectText(7525, player.Player.channel.owner.transportConnection, true, "ReddedText", Configuration.Instance.ReddedText);

        }

        public void OnButtonClicked(Player caller, string buttonName)
        {
            var config = Configuration.Instance;
            UnturnedPlayer player = UnturnedPlayer.FromPlayer(caller);

            if (buttonName == "OnaylaButton")
            {
                EffectManager.askEffectClearByID(7525, player.SteamPlayer().transportConnection);
            }
            if (buttonName == "ReddedButton")
            {
                EffectManager.askEffectClearByID(7525, player.SteamPlayer().transportConnection);
                UnturnedPlayer unturnedplayer2 = UnturnedPlayer.FromCSteamID(player.CSteamID);
                unturnedplayer2.Kick("You were kicked from the server for not accepting the rules");
            }
        }

        protected override void Unload()
        {
            U.Events.OnPlayerDisconnected -= Events_OnPlayerDisconnected;
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
            EffectManager.onEffectButtonClicked -= OnButtonClicked;
        }
    }
}
