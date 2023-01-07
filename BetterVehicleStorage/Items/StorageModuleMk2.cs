namespace BetterVehicleStorage.Items
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using SMLHelper.V2.Crafting;
    using SMLHelper.V2.Utility;
    using static Atlas;

    public class StorageModuleMk2 : StorageModule
    {
        public StorageModuleMk2()
            : base("StorageModuleMk2", "Storage Module Mk2", "An improved storage module with 32 slots.")
        {
            StorageWidth = 8;
            StorageHeight = 4;
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(TechType.VehicleStorageModule, 1),
                    new Ingredient(TechType.WiringKit, 1),
                    new Ingredient(TechType.Lithium, 3),
                    new Ingredient(TechType.AramidFibers, 1)
                }
            };
        }

        protected override Sprite GetItemSprite()
        {
            Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "StorageModuleMk2.png"));
            return sprite;
        }
    }
}