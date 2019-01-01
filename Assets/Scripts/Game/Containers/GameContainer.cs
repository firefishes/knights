using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Containers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FF.Game
{
    public class GameContainer : ContainerIOC
    {

        public GameContainer()
        {
            IOCManager.Add(new ComponentsContainer());
            IOCManager.Add(new MainRoleContainer());
            IOCManager.Add(new RolePolicyerContainer());
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Finish()
        {
            base.Finish();
        }
    }

}