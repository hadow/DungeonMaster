using System.Collections.Generic;
using DungeonMasterEngine.DungeonContent.Entity.Attacks;
using DungeonMasterEngine.DungeonContent.Entity.BodyInventory.@base;
using DungeonMasterEngine.DungeonContent.Items.GrabableItems.Initializers;

namespace DungeonMasterEngine.DungeonContent.Items.GrabableItems.Factories
{
    public class ClothItemFactory : GrabableItemFactoryBase
    {
        public ClothItemFactory(string name, float weight, IEnumerable<IAttackFactory> attackCombo, IEnumerable<IStorageType> carryLocation) : base(name, weight, attackCombo, carryLocation) {}

        public Cloth Create<TItemInitiator>(TItemInitiator initiator) where TItemInitiator : IClothInitializer
        {
            return new Cloth(initiator, this);
        }
    }
}