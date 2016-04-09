﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonMasterEngine.DungeonContent.Tiles;
using DungeonMasterEngine.GameConsoleContent.Base;
using Microsoft.Xna.Framework;

namespace DungeonMasterEngine.GameConsoleContent
{
    public class TeleportCommand : Interpreter
    {
        public override async Task Run()
        {
            Point targetLocation;
            if (Parameters.Length == 2 && int.TryParse(Parameters[0], out targetLocation.X) && int.TryParse(Parameters[1], out targetLocation.Y))
            {
                var theron = ConsoleContext.AppContext.Theron;
                int currentLevel = theron.Location.LevelIndex;
                var level = ConsoleContext.AppContext.ActiveLevels.First(x => x.LevelIndex == currentLevel);//Level has to be there 
                Tile targetTile = null;
                level.TilesPositions.TryGetValue(targetLocation, out targetTile);

                if (targetTile != null && targetTile.IsAccessible)
                {
                    theron.Location = targetTile;
                }
                else
                {
                    Output.WriteLine("Invalid target location.");
                }
            }
            else
            {
                Output.WriteLine("Invalid parameters");
            }
        }
    }
}