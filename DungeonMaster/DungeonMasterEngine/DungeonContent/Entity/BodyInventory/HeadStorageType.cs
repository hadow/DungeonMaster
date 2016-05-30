using DungeonMasterEngine.DungeonContent.Entity.BodyInventory.@base;

namespace DungeonMasterEngine.DungeonContent.Entity.BodyInventory
{
    internal class HeadStorageType : IStorageType
    {
        public int Size { get; } = 1;

        public static HeadStorageType Instance { get; } = new HeadStorageType();

        private HeadStorageType() { }
    }
}