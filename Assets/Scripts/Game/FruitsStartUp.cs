using ShipDock.Framework.Applications;
using ShipDock.Framework.AppointerIOC.IOC;
using UnityEngine;

namespace Knights.Game
{
    public class FruitsStartUp : GameStartUpComponent
    {
        protected override void GameInited()
        {
            base.GameInited();

            IOCManager.AddContainersReady(OnIOCReady);
            IOCManager.Add(new ComunicationsIOC());
        }

        private void OnIOCReady()
        {
            Debug.Log("fsdfasd");
        }
    }

}