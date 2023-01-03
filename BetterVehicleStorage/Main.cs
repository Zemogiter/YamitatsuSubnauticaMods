namespace BetterVehicleStorage
{
    using System.Reflection;
    using HarmonyLib;
    using Managers;
    using SMLHelper.V2.Handlers;
    using Utilities;
    using BepInEx;
    using System;

    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.ahk1221.smlhelper", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        #region[Declarations]
        private const string
            MODNAME = "BetterVehicleStorage",
            AUTHOR = "Yamaitatsu",
            GUID = "com.Yamaitatsu.BetterVehicleStorage",
            VERSION = "1.0.0.0";
        #endregion

        internal const string WorkBenchTab = "Storage";

        public void Awake()
        {
            Console.WriteLine("BetterVehicleStorage - Started patching v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(3));

            CraftTreeHandler.AddTabNode(
                CraftTree.Type.Workbench,
                WorkBenchTab,
                "Storage Modules",
                SpriteManager.Get(TechType.VehicleStorageModule));

            StorageModuleMgr.RegisterModules();

            CraftDataHandler.SetQuickSlotType(TechType.VehicleStorageModule, QuickSlotType.Instant);

            var harmony = new Harmony(GUID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Console.WriteLine("BetterVehicleStorage - Finished patching");
        }
    }
}