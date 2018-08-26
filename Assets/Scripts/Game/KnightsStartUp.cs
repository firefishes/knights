using ShipDock.Framework.Applications;
using ShipDock.Framework.Cores.Notices;
using ShipDock.Framework.ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class KnightsStartUp : GameStartUpComponent
    {
        protected override void GameInited()
        {
            base.GameInited();

            //Notice dataNotice = Pooling<Notice>.From();
            //dataNotice
        }
    }

}