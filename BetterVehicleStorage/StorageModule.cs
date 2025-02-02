﻿namespace BetterVehicleStorage
{
    using SMLHelper.V2.Assets;
    using SMLHelper.V2.Handlers;
    using System.Collections;
    using UnityEngine;

    public abstract class StorageModule : Craftable
    {
        public int StorageWidth;
        public int StorageHeight;
        protected StorageModule(string classId, string friendlyName, string description)
            : base(classId, friendlyName, description)
        {
            base.OnFinishedPatching += () =>
            {
                CraftDataHandler.SetEquipmentType(this.TechType, EquipmentType.VehicleModule);
                CraftDataHandler.SetQuickSlotType(this.TechType, QuickSlotType.Instant);
            };
        }

        public sealed override TechGroup GroupForPDA => TechGroup.VehicleUpgrades;

        public sealed override TechCategory CategoryForPDA => TechCategory.VehicleUpgrades;

        public sealed override TechType RequiredForUnlock => TechType.Workbench;

        public sealed override CraftTree.Type FabricatorType => CraftTree.Type.Workbench;

        public sealed override string AssetsFolder => "BetterVehicleStorage/Assets";

        public override IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.VehicleStorageModule);
            yield return task;
            GameObject origibalPrefab = task.GetResult();
            GameObject resultPrefab = Object.Instantiate(origibalPrefab);
            gameObject.Set(resultPrefab);
        }
    }
}