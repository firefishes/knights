using System;
using ShipDock.Framework;
using ShipDock.Framework.Applications;
using ShipDock.Framework.Applications.RPG;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Components;
using ShipDock.Framework.Loaders;
using UnityEngine;

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
            loader.OnLoaded += ResLoaded;
            loader.StartLoad();
        }

        private void ResLoaded(SimpleLoader obj)
        {
            IOCManager.AddContainersReady(OnIOCReady);
            IOCManager.Add(new ComunicationsIOC());
            IOCManager.Add(new GameContainer());
        }

        private void OnIOCReady()
        {
            Debug.Log("Game start up");

            App.SendNotice(RPGConsts.MAIN_ROLE_PREFAB_LOADED);
        }
    }

}