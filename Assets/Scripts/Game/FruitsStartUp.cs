﻿using System;
using ShipDock.Framework;
using ShipDock.Framework.Applications;
using ShipDock.Framework.Applications.RPG;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Components;
using ShipDock.Framework.Loaders;
using UnityEngine;
using ShipDock.Framework.Managers;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.AppointerIOC.Attributes;
using ShipDock.Framework.Finess.ECS.Components;

namespace FF.Game
{
    public class FruitsStartUp : GameStartUpComponent
    {
        protected override void GameInited()
        {
            base.GameInited();

            SimpleLoader loader = new SimpleLoader() { IsAutoRelease = true };
            loader.AddLoad(GameLoadType.LOAD_TYPE_MANIFEST, CoreConsts.AB_MANIFEST);
            loader.AddLoad(GameLoadType.LOAD_TYPE_AB, RPGConsts.AB_MAIN_ENTITAS);
            loader.AddLoad(GameLoadType.LOAD_TYPE_AB, Consts.AB_MAIN_ROLES);
            loader.OnLoaded += ResLoaded;
            loader.StartLoad();
        }

        private void ResLoaded(SimpleLoader obj)
        {
            AssetBundlesManager manager = AssetBundlesManager.Instance;
            manager.AddSystemPrefab<RolePolicyerComponent>("RolePolicyerEntity", "RolePolicyerEntity", true, RPGConsts.AB_MAIN_ENTITAS, "RolePolicyerEntity");
            manager.AddSystemPrefab<EntitasComponent>("EntitasEmpty", "EntitasItem", true, RPGConsts.AB_MAIN_ENTITAS, "EntitasItem");

            IOCManager.AddContainersReady(OnContainersReady);
            IOCManager.Add(new ComunicationsIOC());
            IOCManager.Add(new GameContainer());
        }

        private void OnContainersReady()
        {
            Debug.Log("Game start up");

            GameObject prefabRaw = AssetBundlesManager.Instance.GetAsset(Consts.AB_MAIN_ROLES, "Role");
            GameObjectPoolManager.Instance.FromPool(Consts.POOL_MAIN_ROLE, ref prefabRaw);

            prefabRaw = AssetBundlesManager.Instance.GetAsset(Consts.AB_MAIN_ROLES, "RoleEnemy");
            GameObjectPoolManager.Instance.FromPool(Consts.POOL_ENEMY_ROLE_1, ref prefabRaw);
        }
    }

}