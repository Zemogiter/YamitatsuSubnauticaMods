namespace BetterVehicleStorage.Items
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using SMLHelper.V2.Crafting;
    using SMLHelper.V2.Utility;
    using static Atlas;

    public class StorageModuleMk3 : StorageModule
    {
        private readonly TechType StorageModuleMk2TechType;
        public StorageModuleMk3(TechType storageModuleMk2TechType)
            : base(
                "StorageModuleMk3",
                "Storage Module Mk3",
                "An improved storage module with 48 slots.")
        {
            StorageWidth = 8;
            StorageHeight = 6;
            StorageModuleMk2TechType = storageModuleMk2TechType;
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(StorageModuleMk2TechType, 1),
                    new Ingredient(TechType.WiringKit, 1),
                    new Ingredient(TechType.AluminumOxide, 3),
                    new Ingredient(TechType.AramidFibers, 1)
                }
            };
        }
        protected override Sprite GetItemSprite()
        {
            //Sprite sprite = SpriteManager.Get(TechType.techType); // Or
            Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "StorageModuleMk3.png"));
            return sprite;
        }
    }
}