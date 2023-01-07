namespace BetterVehicleStorage.Items
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using SMLHelper.V2.Crafting;
    using SMLHelper.V2.Utility;
    using static Atlas;

    public class StorageModuleMk4 : StorageModule
    {
        private readonly TechType StorageModuleMk3TechType;
        public StorageModuleMk4(TechType storageModuleMk3TechType)
            : base(
                "StorageModuleMk4",
                "Storage Module Mk4",
                "An improved storage module with 64 extra slots.")
        {
            StorageWidth = 8;
            StorageHeight = 8;
            StorageModuleMk3TechType = storageModuleMk3TechType;
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(StorageModuleMk3TechType, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1),
                    new Ingredient(TechType.Nickel, 3),
                    new Ingredient(TechType.AramidFibers, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "StorageModuleMk4.png"));
            return sprite;
        }
    }
}