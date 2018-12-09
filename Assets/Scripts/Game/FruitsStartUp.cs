using ShipDock.Framework.Applications;
using ShipDock.Framework.Applications.RPG;
using ShipDock.Framework.AppointerIOC.IOC;
using UnityEngine;

namespace FF.Game
{
    public class FruitsStartUp : GameStartUpComponent
    {
        protected override void GameInited()
        {
            base.GameInited();

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