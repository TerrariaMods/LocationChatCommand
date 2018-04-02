using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TrenycsChatCommands
{
    class LocationChatCommand : Terraria.ModLoader.ModCommand
    {
        public override CommandType Type
        {
            get { return CommandType.Chat; }
        }

        public override string Command
        {
            get { return "spawnloc"; }
        }

        public override string Usage
        {
            get { return "/loc"; }
        }

        public override string Description
        {
            get { return "Displays the x, y coordinates of your current location"; }
        }

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            caller.Reply(
                String.Format(
                    @"Your current spawn location is: {0}, {1}",
                        caller.Player.SpawnX, caller.Player.SpawnY
                )
            );
        }
    }
}
