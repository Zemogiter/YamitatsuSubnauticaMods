namespace BetterVehicleStorage.Items
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using SMLHelper.V2.Crafting;
    using SMLHelper.V2.Utility;
    using static Atlas;

    public class StorageModuleMk5 : StorageModule
    {
        private readonly TechType StorageModuleMk4TechType;
        public StorageModuleMk5(TechType storageModuleMk4TechType)
            : base(
                "StorageModuleMk5",
                "Storage Module Mk5",
                "An improved storage module with 80 slots.")
        {
            StorageWidth = 8;
            StorageHeight = 10;
            StorageModuleMk4TechType = storageModuleMk4TechType;
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(StorageModuleMk4TechType, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1),
                    new Ingredient(TechType.Kyanite, 3),
                    new Ingredient(TechType.AramidFibers, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            //Sprite sprite = SpriteManager.Get(TechType.techType); // Or
            Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "StorageModuleMk5.png"));
            return sprite;
        }
    }
}