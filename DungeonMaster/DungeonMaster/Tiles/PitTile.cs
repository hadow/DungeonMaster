﻿namespace DungeonMasterParser.Tiles
{
    public class PitTile : Tile
    {
        //Bit 0:
        //     '0' Normal
        //     '1' Imaginary
        public bool IsImaginary { get; set; }

        // Bit 1: Unused
        
        // Bit 2:
        //     '0' Visible
        //     '1' Invisible
        public bool IsVisible { get; set; }
        
        // Bit 3:
        //     '0' Closed
        //     '1' Open
        public bool IsOpen { get; set; }

        public override T GetTile<T>(ITileCreator<T> t)
        {
            return t.GetTile(this);
        }
    }
}